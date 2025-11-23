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
        const UInt32 VENDOR_ID = 0xe6a; // 設定裝置 Vendor ID (對應 RD200_RD300_Tools_V0225_20160913.exe 應用程式中的 VID)
        const UInt32 PRODUCT_ID = 0x317; // 設定裝置 Product ID (對應 RD200_RD300_Tools_V0225_20160913.exe 應用程式中的 PID)
        const UInt32 READ_LENGTH = 64; // 讀取緩衝區長度
        const int DATA_OFFSET = 4; // 資料區起始位置 (跳過 STX、LEN、CMD、STATUS)
        const int DATA_SIZE = 16; // 成功時回傳的卡片區塊內容固定 16 Bytes
        const uint DEVICE_INDEX = 1; // 裝置索引
        const string DEFAULT_LOAD_KEY = "FFFFFFFFFFFF"; // Load Key 預設值

        public Form1()
        {
            InitializeComponent();
        }

        MW_EasyPOD EasyPOD; // 讀卡機結構體
        UInt32 dwResult, Index;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 關閉表單
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
