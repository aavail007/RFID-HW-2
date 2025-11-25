using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        // 常數定義
        const byte STX = 0x02; // 封包起始符號，用於標記命令封包的開頭
        const byte CMD_READ = 0x15; // 讀取命令
        const byte CMD_WRITE = 0x16; // 寫入命令
        const UInt32 VENDOR_ID = 0xe6a; // 設定裝置 Vendor ID (對應 RD200_RD300_Tools_V0225_20160913.exe 應用程式中的 VID)
        const UInt32 PRODUCT_ID = 0x317; // 設定裝置 Product ID (對應 RD200_RD300_Tools_V0225_20160913.exe 應用程式中的 PID)
        const UInt32 READ_LENGTH = 64; // 讀取緩衝區長度
        const int DATA_OFFSET = 4; // 資料區起始位置 (跳過 STX、LEN、CMD、STATUS)
        const int DATA_SIZE = 16; // 成功時回傳的卡片區塊內容固定 16 Bytes
        const uint DEVICE_INDEX = 1; // 裝置索引
        const byte KEY_TYPE = 0x60; // Key A
        const string DEFAULT_PWD = "FFFFFFFFFFFF"; // 預設密碼
        const int DEPOSIT_AMOUNT = 500; // 每次自動儲值金額

        public Form1()
        {
            InitializeComponent();
        }

        MW_EasyPOD EasyPOD; // 讀卡機結構體
        UInt32 dwResult, Index;


        private void Form1_Load(object sender, EventArgs e)
        {
            initDateField();
            initPointField();
        }

        #region 初始化功能
        /// <summary>
        /// 初始化日期欄位
        /// </summary>
        private void initDateField()
        {
            txtDate.Text = DateTime.Now.ToShortDateString();
        }

        /// <summary>
        /// 初始化限制點數欄位只能輸入數字
        /// </summary>
        private void initPointField()
        {
            txtPoint.KeyPress += OnlyNumber;
            txtQueryPoint.KeyPress += OnlyNumber;
            txtAddPoint.KeyPress += OnlyNumber;
            txtConsumePoint.KeyPress += OnlyNumber;
        }
        #endregion

        #region 按鈕事件處理
        /// <summary>
        /// 製作卡片
        /// </summary>
        private void btnMakeCard_Click(object sender, EventArgs e)
        {
            byte keyType = KEY_TYPE;
            byte[] key = StringToByteArray(DEFAULT_PWD);

            // 會員編號
            if (!WriteBlock(keyType, key, 1, 4, EncodeStringTo16Bytes(txtMemberId.Text)))
                return;

            // 姓名
            if (!WriteBlock(keyType, key, 1, 5, EncodeStringTo16Bytes(txtName.Text)))
                return;

            // 申請日期
            if (!WriteBlock(keyType, key, 1, 6, EncodeStringTo16Bytes(txtDate.Text)))
                return;

            // 點數
            int point = int.Parse(txtPoint.Text);
            if (!WriteValueBlock(2, 8, point, keyType, key))
                return;

            ClearIssueUI();
            lblIssueStatus.Text = "寫入完成";
        }

        /// <summary>
        /// 讀取卡片
        /// </summary>
        private void btnReadCard_Click(object sender, EventArgs e)
        {
            byte keyType = KEY_TYPE;
            byte[] key = StringToByteArray(DEFAULT_PWD);

            // 讀取會員編號：Sector 1, Block 4
            string memberId = ReadBlock(keyType, key, 1, 4);
            if (memberId == null) return;
            txtQueryMemberId.Text = memberId;

            // 讀取姓名：Sector 1, Block 5
            string name = ReadBlock(keyType, key, 1, 5);
            if (name == null) return;
            txtQueryName.Text = name;

            // 讀取申請日期：Sector 1, Block 6
            string date = ReadBlock(keyType, key, 1, 6);
            if (date == null) return;
            txtQueryDate.Text = date;

            // 讀取 Value Block：Sector 2, Block 8
            int? point = ReadValueBlock(keyType, key, 2, 8);
            if (point == null) return;
            txtQueryPoint.Text = point.ToString();

            // 顯示讀取成功
            lblQueryStatus.Text = "讀取完成";
        }

        private void btnClearCard_Click(object sender, EventArgs e)
        {
            byte keyType = KEY_TYPE; // Key A
            byte[] key = StringToByteArray(DEFAULT_PWD);

            // 1. 清空會員編號
            if (!WriteBlock(keyType, key, 1, 4, EmptyBlock()))
            {
                MessageBox.Show("清空會員編號失敗");
                return;
            }

            // 2. 清空姓名
            if (!WriteBlock(keyType, key, 1, 5, EmptyBlock()))
            {
                MessageBox.Show("清空姓名失敗");
                return;
            }

            // 3. 清空申請日期
            if (!WriteBlock(keyType, key, 1, 6, EmptyBlock()))
            {
                MessageBox.Show("清空日期失敗");
                return;
            }

            // 4. 重置點數 Value Block（寫成 0）
            if (!WriteValueBlock(2, 8, 0, keyType, key))
            {
                MessageBox.Show("清空點數失敗");
                return;
            }
            ClearIssueUI();

            lblIssueStatus.Text = "清空完成";
        }

        /// <summary>
        /// 消費點數
        /// </summary>
        private void btnConsume_Click(object sender, EventArgs e)
        {
            lblConsumeStatus.Text = ""; // 清空舊訊息

            // 1. 檢查輸入格式
            if (!int.TryParse(txtConsumePoint.Text, out int consumeValue) || consumeValue <= 0)
            {
                MessageBox.Show("請輸入有效的消費點數！");
                return;
            }

            byte keyType = KEY_TYPE;
            byte[] key = StringToByteArray(DEFAULT_PWD);

            // 2. Step 1：讀取原本點數
            int? oldValue = ReadValueBlock(keyType, key, 2, 8);
            if (oldValue == null)
            {
                MessageBox.Show("讀取原始點數失敗！");
                return;
            }

            int balance = oldValue.Value;
            int autoAddAmount = DEPOSIT_AMOUNT;   // 每次自動加值點數
            int autoAddCount = 0;       // 計算加值次數

            // 3. 自動加值：直到餘額足夠
            while (balance < consumeValue)
            {
                balance += autoAddAmount;
                autoAddCount++;
            }

            // 4. 扣款
            int newBalance = balance - consumeValue;

            // 5. 寫回 Value Block
            bool ok = WriteValueBlock(2, 8, newBalance, keyType, key);
            if (!ok)
            {
                MessageBox.Show("寫入 Value Block 失敗！");
                return;
            }

            // 6. 顯示結果
            if (autoAddCount > 0)
            {
                lblConsumeStatus.Text =
                    $"由於您的紅利點數不足，系統自動幫您加值！\r\n" +
                    $"自動加值：{autoAddAmount} \t次數：{autoAddCount}\r\n" +
                    $"消費：{consumeValue} \t可用餘額：{newBalance}";
            }
            else
            {
                lblConsumeStatus.Text =
                    $"消費：{consumeValue} \t可用餘額：{newBalance}";
            }
        }

        /// <summary>
        /// 加值點數
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddValue_Click(object sender, EventArgs e)
        {
            lblAddStatus.Text = ""; // 清空舊訊息

            // 1. 檢查輸入格式
            if (!int.TryParse(txtAddPoint.Text, out int addValue) || addValue <= 0)
            {
                MessageBox.Show("請輸入有效的儲值點數！");
                return;
            }

            byte keyType = KEY_TYPE;
            byte[] key = StringToByteArray(DEFAULT_PWD);

            // 2. Step 1：讀取原本點數
            int? oldValue = ReadValueBlock(keyType, key, 2, 8);
            if (oldValue == null)
            {
                MessageBox.Show("讀取原始點數失敗！");
                return;
            }

            // 3. 計算新點數
            int newValue = oldValue.Value + addValue;

            // 4. Step 2：寫回 Value Block
            bool ok = WriteValueBlock(2, 8, newValue, keyType, key);
            if (!ok)
            {
                MessageBox.Show("儲值失敗！");
                return;
            }

            // 5. 更新畫面顯示
            lblAddStatus.ForeColor = Color.Red;
            lblAddStatus.Text = $"儲值：{addValue}　可用餘額：{newValue}";
        }

        /// <summary>
        /// 關閉表單
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region 寫入功能
        /// <summary>
        /// 寫入區塊函式
        /// </summary>
        unsafe private bool WriteBlock(byte keyType, byte[] key, byte sector, byte block, byte[] data16)
        {
            byte[] cmd = BuildWriteCommand(STX, CMD_WRITE, keyType, key, sector, block, data16);
            byte[] readBuffer = new byte[READ_LENGTH];

            EasyPOD.VID = VENDOR_ID;
            EasyPOD.PID = PRODUCT_ID;

            UInt32 uiRead = 0, uiWritten = 0;

            fixed (MW_EasyPOD* pPOD = &EasyPOD)
            {
                var r = PODfuncs.ConnectPOD(pPOD, DEVICE_INDEX);
                if (r != 0) { MessageBox.Show("讀卡機未連線"); return false; }

                EasyPOD.ReadTimeOut = 200;
                EasyPOD.WriteTimeOut = 200;

                PODfuncs.WriteData(pPOD, cmd, (UInt32)cmd.Length, &uiWritten);

                PODfuncs.ReadData(pPOD, readBuffer, READ_LENGTH, &uiRead);

                byte status = readBuffer[3];

                PODfuncs.ClearPODBuffer(pPOD);
                PODfuncs.DisconnectPOD(pPOD);

                if (status == 0x00) return true;  // success
                if (status == 0x01) { MessageBox.Show("沒有卡片或 Key 錯誤"); return false; }
                if (status == 0x10) { MessageBox.Show("指令錯誤 CMD_WRITE"); return false; }

                MessageBox.Show($"未知狀態碼：0x{status:X2}");
                return false;
            }
        }

        /// <summary>
        /// 組寫入的封裝包函式 Request  = STX + LEN + CMD + DATA
        /// </summary>
        private byte[] BuildWriteCommand(byte stx, byte cmd, byte keyType, byte[] keyValue, byte sectorNo, byte blockNo, byte[] data16)
        {
            if (data16.Length != 16)
                throw new ArgumentException("寫入資料必須為 16 bytes");

            var data = new List<byte> { keyType };
            data.AddRange(keyValue);
            data.Add(sectorNo);
            data.Add(blockNo);
            data.AddRange(data16);

            byte len = (byte)(data.Count + 1); // CMD + DATA total length

            var buffer = new List<byte> { stx, len, cmd };
            buffer.AddRange(data);

            return buffer.ToArray();
        }

        /// <summary>
        /// 寫入 Value Block 函式
        /// </summary>
        private bool WriteValueBlock(byte sector, byte block, int value, byte keyType, byte[] key)
        {
            byte[] vb = BuildValueBlock(value, block);
            return WriteBlock(keyType, key, sector, block, vb);
        }

        /// <summary>
        /// 建立 Value Block 資料
        /// </summary>
        private byte[] BuildValueBlock(int value, byte blockAddr)
        {
            byte[] buf = new byte[16];
            byte[] v = BitConverter.GetBytes(value); // 4 bytes (LSB first)

            // Value, Value(complement), Value, Address*4
            buf[0] = v[0];
            buf[1] = v[1];
            buf[2] = v[2];
            buf[3] = v[3];

            buf[4] = (byte)~v[0];
            buf[5] = (byte)~v[1];
            buf[6] = (byte)~v[2];
            buf[7] = (byte)~v[3];

            buf[8] = v[0];
            buf[9] = v[1];
            buf[10] = v[2];
            buf[11] = v[3];

            // address
            buf[12] = blockAddr;
            buf[13] = (byte)~blockAddr;
            buf[14] = blockAddr;
            buf[15] = (byte)~blockAddr;

            return buf;
        }

        /// <summary>
        /// 將字串編碼為 16 bytes 的陣列
        /// </summary>
        private byte[] EncodeStringTo16Bytes(string text)
        {
            // 使用 Big5 編碼將字串轉為 byte 陣列，並確保長度為 16 bytes
            byte[] raw = Encoding.GetEncoding("Big5").GetBytes(text);
            byte[] buffer = new byte[16];
            Array.Clear(buffer, 0, 16);

            for (int i = 0; i < raw.Length && i < 16; i++)
                buffer[i] = raw[i];

            return buffer;
        }
        #endregion

        #region 讀取功能
        /// <summary>
        /// 讀取區塊函式
        /// </summary>
        unsafe private string ReadBlock(byte keyType, byte[] key, byte sector, byte block)
        {
            byte[] cmd = BuildReadCommand(STX, CMD_READ, keyType, key, sector, block);
            byte[] buffer = new byte[READ_LENGTH];

            UInt32 uiRead = 0, uiWritten = 0;

            EasyPOD.VID = VENDOR_ID;
            EasyPOD.PID = PRODUCT_ID;

            fixed (MW_EasyPOD* pPOD = &EasyPOD)
            {
                var r = PODfuncs.ConnectPOD(pPOD, DEVICE_INDEX);
                if (r != 0)
                {
                    MessageBox.Show("讀卡機未連線");
                    return null;
                }

                EasyPOD.ReadTimeOut = 200;
                EasyPOD.WriteTimeOut = 200;

                PODfuncs.WriteData(pPOD, cmd, (UInt32)cmd.Length, &uiWritten);
                PODfuncs.ReadData(pPOD, buffer, READ_LENGTH, &uiRead);

                byte status = buffer[3];

                PODfuncs.ClearPODBuffer(pPOD);
                PODfuncs.DisconnectPOD(pPOD);

                if (status != 0x00)
                {
                    if (status == 0x01) MessageBox.Show("讀取失敗：無卡片或 Key 錯誤");
                    else if (status == 0x10) MessageBox.Show("讀取失敗：CMD 錯誤");
                    else MessageBox.Show($"未知錯誤：0x{status:X2}");
                    return null;
                }

                byte[] data = new byte[16];
                Array.Copy(buffer, DATA_OFFSET, data, 0, 16);

                return Encoding.GetEncoding("Big5").GetString(data).Trim('\0');
            }
        }

        /// <summary>
        /// 讀取 Value Block 函式
        /// </summary>
        unsafe private int? ReadValueBlock(byte keyType, byte[] key, byte sector, byte block)
        {
            byte[] cmd = BuildReadCommand(STX, CMD_READ, keyType, key, sector, block);
            byte[] buffer = new byte[READ_LENGTH];

            UInt32 uiRead = 0, uiWritten = 0;

            EasyPOD.VID = VENDOR_ID;
            EasyPOD.PID = PRODUCT_ID;

            fixed (MW_EasyPOD* pPOD = &EasyPOD)
            {
                var r = PODfuncs.ConnectPOD(pPOD, DEVICE_INDEX);
                if (r != 0)
                {
                    MessageBox.Show("讀卡機未連線");
                    return null;
                }

                EasyPOD.ReadTimeOut = 200;
                EasyPOD.WriteTimeOut = 200;

                PODfuncs.WriteData(pPOD, cmd, (UInt32)cmd.Length, &uiWritten);
                PODfuncs.ReadData(pPOD, buffer, READ_LENGTH, &uiRead);

                byte status = buffer[3];

                PODfuncs.ClearPODBuffer(pPOD);
                PODfuncs.DisconnectPOD(pPOD);

                if (status != 0x00)
                {
                    MessageBox.Show("讀取 Value Block 失敗");
                    return null;
                }

                // Value Block 前 4 Bytes = 點數（LSB first）
                return BitConverter.ToInt32(buffer, DATA_OFFSET);
            }
        }

        /// <summary>
        /// 組讀取的封裝包函式 Request  = STX + LEN + CMD + DATA
        /// </summary>
        private byte[] BuildReadCommand(byte stx, byte cmd, byte keyType, byte[] keyValue, byte sectorNo, byte blockNo)
        {
            var data = new List<byte> { keyType };
            data.AddRange(keyValue);
            data.Add(sectorNo);
            data.Add(blockNo);

            byte len = (byte)(data.Count + 1); // CMD + DATA length

            var buffer = new List<byte> { stx, len, cmd };
            buffer.AddRange(data);

            return buffer.ToArray();
        }
        #endregion

        #region 清空各頁面 UI 資料
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabIssue)
            {
                ClearIssueUI();
            }
            else if (tabControl.SelectedTab == tabQuery)
            {
                ClearQueryUI();
            }
            else if (tabControl.SelectedTab == tabDeposit)
            {
                ClearDepositUI();
            }
            else if (tabControl.SelectedTab == tabConsume)
            {
                ClearConsumeUI();
            }
        }
        // 清空發卡 UI
        private void ClearIssueUI()
        {
            txtMemberId.Text = "";
            txtName.Text = "";
            txtDate.Text = DateTime.Now.ToShortDateString(); // 自動帶入今天日期
            txtPoint.Text = "";
            lblIssueStatus.Text = "";   // 清空狀態顯示
            lblIssueStatus.Text = "";
        }

        // 清空讀卡 UI
        private void ClearQueryUI()
        {
            txtQueryMemberId.Text = "";
            txtQueryName.Text = "";
            txtQueryDate.Text = "";
            txtQueryPoint.Text = "";
            lblQueryStatus.Text = "";
        }


        // 清空加值 UI
        private void ClearDepositUI()
        {
            txtAddPoint.Text = "";
            lblAddStatus.Text = "";
        }

        // 清空消費 UI
        private void ClearConsumeUI()
        {
            txtConsumePoint.Text = "";
            lblConsumeStatus.Text = "";
        }

        /// <summary>
        /// 16 bytes 全 0 的空資料
        /// </summary>
        private byte[] EmptyBlock()
        {
            return new byte[16]; // 預設即為 16 bytes 全 0
        }
        #endregion

        #region 通用方法
        /// <summary>
        /// 將 12 碼 HEX 字串轉為 byte 陣列
        /// </summary>
        private byte[] StringToByteArray(string txtKey)
        {
            string hex = txtKey.Trim(); // 移除前後空白
            hex = hex.Replace(" ", ""); // 移除空白
            if (hex.Length % 2 != 0)
                throw new ArgumentException("Key 必須是偶數長度");

            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return bytes;
        }

        /// <summary>
        /// 只能輸入數字
        /// </summary>
        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            //允許數字與 Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; //阻擋輸入
            }
        }

        /// <summary>
        /// 限制點數欄位只能輸入數字
        /// </summary>
        private void txtPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 允許控制鍵（例如 Backspace）
            if (char.IsControl(e.KeyChar)) return;

            // 允許數字
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;   // 阻擋輸入
            }
        }

        #endregion
    }
}
