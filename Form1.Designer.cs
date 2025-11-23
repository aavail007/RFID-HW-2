namespace WindowsFormsApplication6
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabIssue = new System.Windows.Forms.TabPage();
            this.lblIssueStatus = new System.Windows.Forms.Label();
            this.btnClearCard = new System.Windows.Forms.Button();
            this.btnMakeCard = new System.Windows.Forms.Button();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.lbl1Point = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lbl1Date = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbl1Name = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.lbl1MemberId = new System.Windows.Forms.Label();
            this.tabQuery = new System.Windows.Forms.TabPage();
            this.lblQueryStatus = new System.Windows.Forms.Label();
            this.btnReadCard = new System.Windows.Forms.Button();
            this.txtQueryPoint = new System.Windows.Forms.TextBox();
            this.lblPoint = new System.Windows.Forms.Label();
            this.txtQueryDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtQueryName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtQueryMemberId = new System.Windows.Forms.TextBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.tabDeposit = new System.Windows.Forms.TabPage();
            this.lblAddStatus = new System.Windows.Forms.Label();
            this.btnAddValue = new System.Windows.Forms.Button();
            this.txtAddPoint = new System.Windows.Forms.TextBox();
            this.lblAddPoint = new System.Windows.Forms.Label();
            this.tabConsume = new System.Windows.Forms.TabPage();
            this.lblConsumeStatus = new System.Windows.Forms.Label();
            this.btnConsume = new System.Windows.Forms.Button();
            this.txtConsumePoint = new System.Windows.Forms.TextBox();
            this.lblConsumePoint = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabIssue.SuspendLayout();
            this.tabQuery.SuspendLayout();
            this.tabDeposit.SuspendLayout();
            this.tabConsume.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(161, 332);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 28);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabIssue);
            this.tabControl.Controls.Add(this.tabQuery);
            this.tabControl.Controls.Add(this.tabDeposit);
            this.tabControl.Controls.Add(this.tabConsume);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(406, 301);
            this.tabControl.TabIndex = 12;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabIssue
            // 
            this.tabIssue.Controls.Add(this.lblIssueStatus);
            this.tabIssue.Controls.Add(this.btnClearCard);
            this.tabIssue.Controls.Add(this.btnMakeCard);
            this.tabIssue.Controls.Add(this.txtPoint);
            this.tabIssue.Controls.Add(this.lbl1Point);
            this.tabIssue.Controls.Add(this.txtDate);
            this.tabIssue.Controls.Add(this.lbl1Date);
            this.tabIssue.Controls.Add(this.txtName);
            this.tabIssue.Controls.Add(this.lbl1Name);
            this.tabIssue.Controls.Add(this.txtMemberId);
            this.tabIssue.Controls.Add(this.lbl1MemberId);
            this.tabIssue.Location = new System.Drawing.Point(4, 25);
            this.tabIssue.Name = "tabIssue";
            this.tabIssue.Padding = new System.Windows.Forms.Padding(3);
            this.tabIssue.Size = new System.Drawing.Size(398, 272);
            this.tabIssue.TabIndex = 0;
            this.tabIssue.Text = "發卡";
            this.tabIssue.UseVisualStyleBackColor = true;
            // 
            // lblIssueStatus
            // 
            this.lblIssueStatus.AutoSize = true;
            this.lblIssueStatus.ForeColor = System.Drawing.Color.Crimson;
            this.lblIssueStatus.Location = new System.Drawing.Point(25, 234);
            this.lblIssueStatus.Name = "lblIssueStatus";
            this.lblIssueStatus.Size = new System.Drawing.Size(0, 15);
            this.lblIssueStatus.TabIndex = 19;
            // 
            // btnClearCard
            // 
            this.btnClearCard.Location = new System.Drawing.Point(283, 121);
            this.btnClearCard.Name = "btnClearCard";
            this.btnClearCard.Size = new System.Drawing.Size(95, 23);
            this.btnClearCard.TabIndex = 9;
            this.btnClearCard.Text = "清空卡片";
            this.btnClearCard.UseVisualStyleBackColor = true;
            this.btnClearCard.Click += new System.EventHandler(this.btnClearCard_Click);
            // 
            // btnMakeCard
            // 
            this.btnMakeCard.Location = new System.Drawing.Point(283, 65);
            this.btnMakeCard.Name = "btnMakeCard";
            this.btnMakeCard.Size = new System.Drawing.Size(95, 23);
            this.btnMakeCard.TabIndex = 8;
            this.btnMakeCard.Text = "卡片製作";
            this.btnMakeCard.UseVisualStyleBackColor = true;
            this.btnMakeCard.Click += new System.EventHandler(this.btnMakeCard_Click);
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(102, 174);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(157, 25);
            this.txtPoint.TabIndex = 7;
            this.txtPoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPoint_KeyPress);
            // 
            // lbl1Point
            // 
            this.lbl1Point.AutoSize = true;
            this.lbl1Point.Location = new System.Drawing.Point(25, 184);
            this.lbl1Point.Name = "lbl1Point";
            this.lbl1Point.Size = new System.Drawing.Size(41, 15);
            this.lbl1Point.TabIndex = 6;
            this.lbl1Point.Text = "點數:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(102, 115);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(157, 25);
            this.txtDate.TabIndex = 5;
            // 
            // lbl1Date
            // 
            this.lbl1Date.AutoSize = true;
            this.lbl1Date.Location = new System.Drawing.Point(25, 125);
            this.lbl1Date.Name = "lbl1Date";
            this.lbl1Date.Size = new System.Drawing.Size(71, 15);
            this.lbl1Date.TabIndex = 4;
            this.lbl1Date.Text = "申請日期:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 25);
            this.txtName.TabIndex = 3;
            // 
            // lbl1Name
            // 
            this.lbl1Name.AutoSize = true;
            this.lbl1Name.Location = new System.Drawing.Point(25, 73);
            this.lbl1Name.Name = "lbl1Name";
            this.lbl1Name.Size = new System.Drawing.Size(41, 15);
            this.lbl1Name.TabIndex = 2;
            this.lbl1Name.Text = "姓名:";
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(102, 20);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(157, 25);
            this.txtMemberId.TabIndex = 1;
            // 
            // lbl1MemberId
            // 
            this.lbl1MemberId.AutoSize = true;
            this.lbl1MemberId.Location = new System.Drawing.Point(25, 30);
            this.lbl1MemberId.Name = "lbl1MemberId";
            this.lbl1MemberId.Size = new System.Drawing.Size(71, 15);
            this.lbl1MemberId.TabIndex = 0;
            this.lbl1MemberId.Text = "會員編號:";
            // 
            // tabQuery
            // 
            this.tabQuery.Controls.Add(this.lblQueryStatus);
            this.tabQuery.Controls.Add(this.btnReadCard);
            this.tabQuery.Controls.Add(this.txtQueryPoint);
            this.tabQuery.Controls.Add(this.lblPoint);
            this.tabQuery.Controls.Add(this.txtQueryDate);
            this.tabQuery.Controls.Add(this.lblDate);
            this.tabQuery.Controls.Add(this.txtQueryName);
            this.tabQuery.Controls.Add(this.lblName);
            this.tabQuery.Controls.Add(this.txtQueryMemberId);
            this.tabQuery.Controls.Add(this.lblMemberId);
            this.tabQuery.Location = new System.Drawing.Point(4, 25);
            this.tabQuery.Name = "tabQuery";
            this.tabQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuery.Size = new System.Drawing.Size(398, 272);
            this.tabQuery.TabIndex = 1;
            this.tabQuery.Text = "查詢";
            this.tabQuery.UseVisualStyleBackColor = true;
            // 
            // lblQueryStatus
            // 
            this.lblQueryStatus.AutoSize = true;
            this.lblQueryStatus.ForeColor = System.Drawing.Color.Red;
            this.lblQueryStatus.Location = new System.Drawing.Point(23, 240);
            this.lblQueryStatus.Name = "lblQueryStatus";
            this.lblQueryStatus.Size = new System.Drawing.Size(0, 15);
            this.lblQueryStatus.TabIndex = 18;
            // 
            // btnReadCard
            // 
            this.btnReadCard.Location = new System.Drawing.Point(281, 76);
            this.btnReadCard.Name = "btnReadCard";
            this.btnReadCard.Size = new System.Drawing.Size(95, 23);
            this.btnReadCard.TabIndex = 17;
            this.btnReadCard.Text = "讀取卡片";
            this.btnReadCard.UseVisualStyleBackColor = true;
            this.btnReadCard.Click += new System.EventHandler(this.btnReadCard_Click);
            // 
            // txtQueryPoint
            // 
            this.txtQueryPoint.Location = new System.Drawing.Point(100, 185);
            this.txtQueryPoint.Name = "txtQueryPoint";
            this.txtQueryPoint.Size = new System.Drawing.Size(157, 25);
            this.txtQueryPoint.TabIndex = 16;
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Location = new System.Drawing.Point(23, 195);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(41, 15);
            this.lblPoint.TabIndex = 15;
            this.lblPoint.Text = "點數:";
            // 
            // txtQueryDate
            // 
            this.txtQueryDate.Location = new System.Drawing.Point(100, 126);
            this.txtQueryDate.Name = "txtQueryDate";
            this.txtQueryDate.Size = new System.Drawing.Size(157, 25);
            this.txtQueryDate.TabIndex = 14;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(23, 136);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(71, 15);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "申請日期:";
            // 
            // txtQueryName
            // 
            this.txtQueryName.Location = new System.Drawing.Point(100, 74);
            this.txtQueryName.Name = "txtQueryName";
            this.txtQueryName.Size = new System.Drawing.Size(157, 25);
            this.txtQueryName.TabIndex = 12;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 15);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "姓名:";
            // 
            // txtQueryMemberId
            // 
            this.txtQueryMemberId.Location = new System.Drawing.Point(100, 31);
            this.txtQueryMemberId.Name = "txtQueryMemberId";
            this.txtQueryMemberId.Size = new System.Drawing.Size(157, 25);
            this.txtQueryMemberId.TabIndex = 10;
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Location = new System.Drawing.Point(23, 41);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(71, 15);
            this.lblMemberId.TabIndex = 9;
            this.lblMemberId.Text = "會員編號:";
            // 
            // tabDeposit
            // 
            this.tabDeposit.Controls.Add(this.lblAddStatus);
            this.tabDeposit.Controls.Add(this.btnAddValue);
            this.tabDeposit.Controls.Add(this.txtAddPoint);
            this.tabDeposit.Controls.Add(this.lblAddPoint);
            this.tabDeposit.Location = new System.Drawing.Point(4, 25);
            this.tabDeposit.Name = "tabDeposit";
            this.tabDeposit.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeposit.Size = new System.Drawing.Size(398, 272);
            this.tabDeposit.TabIndex = 2;
            this.tabDeposit.Text = "儲值";
            this.tabDeposit.UseVisualStyleBackColor = true;
            // 
            // lblAddStatus
            // 
            this.lblAddStatus.AutoSize = true;
            this.lblAddStatus.Location = new System.Drawing.Point(26, 177);
            this.lblAddStatus.Name = "lblAddStatus";
            this.lblAddStatus.Size = new System.Drawing.Size(109, 15);
            this.lblAddStatus.TabIndex = 19;
            this.lblAddStatus.Text = "儲值: 可用餘額:";
            // 
            // btnAddValue
            // 
            this.btnAddValue.Location = new System.Drawing.Point(286, 96);
            this.btnAddValue.Name = "btnAddValue";
            this.btnAddValue.Size = new System.Drawing.Size(95, 23);
            this.btnAddValue.TabIndex = 18;
            this.btnAddValue.Text = "加值點數";
            this.btnAddValue.UseVisualStyleBackColor = true;
            // 
            // txtAddPoint
            // 
            this.txtAddPoint.Location = new System.Drawing.Point(103, 90);
            this.txtAddPoint.Name = "txtAddPoint";
            this.txtAddPoint.Size = new System.Drawing.Size(157, 25);
            this.txtAddPoint.TabIndex = 3;
            // 
            // lblAddPoint
            // 
            this.lblAddPoint.AutoSize = true;
            this.lblAddPoint.Location = new System.Drawing.Point(26, 100);
            this.lblAddPoint.Name = "lblAddPoint";
            this.lblAddPoint.Size = new System.Drawing.Size(41, 15);
            this.lblAddPoint.TabIndex = 2;
            this.lblAddPoint.Text = "點數:";
            // 
            // tabConsume
            // 
            this.tabConsume.Controls.Add(this.lblConsumeStatus);
            this.tabConsume.Controls.Add(this.btnConsume);
            this.tabConsume.Controls.Add(this.txtConsumePoint);
            this.tabConsume.Controls.Add(this.lblConsumePoint);
            this.tabConsume.Location = new System.Drawing.Point(4, 25);
            this.tabConsume.Name = "tabConsume";
            this.tabConsume.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsume.Size = new System.Drawing.Size(398, 272);
            this.tabConsume.TabIndex = 3;
            this.tabConsume.Text = "消費";
            this.tabConsume.UseVisualStyleBackColor = true;
            // 
            // lblConsumeStatus
            // 
            this.lblConsumeStatus.AutoSize = true;
            this.lblConsumeStatus.Location = new System.Drawing.Point(22, 172);
            this.lblConsumeStatus.Name = "lblConsumeStatus";
            this.lblConsumeStatus.Size = new System.Drawing.Size(109, 15);
            this.lblConsumeStatus.TabIndex = 23;
            this.lblConsumeStatus.Text = "消費: 可用餘額:";
            // 
            // btnConsume
            // 
            this.btnConsume.Location = new System.Drawing.Point(282, 91);
            this.btnConsume.Name = "btnConsume";
            this.btnConsume.Size = new System.Drawing.Size(95, 23);
            this.btnConsume.TabIndex = 22;
            this.btnConsume.Text = "加值點數";
            this.btnConsume.UseVisualStyleBackColor = true;
            // 
            // txtConsumePoint
            // 
            this.txtConsumePoint.Location = new System.Drawing.Point(99, 85);
            this.txtConsumePoint.Name = "txtConsumePoint";
            this.txtConsumePoint.Size = new System.Drawing.Size(157, 25);
            this.txtConsumePoint.TabIndex = 21;
            // 
            // lblConsumePoint
            // 
            this.lblConsumePoint.AutoSize = true;
            this.lblConsumePoint.Location = new System.Drawing.Point(22, 95);
            this.lblConsumePoint.Name = "lblConsumePoint";
            this.lblConsumePoint.Size = new System.Drawing.Size(41, 15);
            this.lblConsumePoint.TabIndex = 20;
            this.lblConsumePoint.Text = "點數:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 372);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "電子錢包";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabIssue.ResumeLayout(false);
            this.tabIssue.PerformLayout();
            this.tabQuery.ResumeLayout(false);
            this.tabQuery.PerformLayout();
            this.tabDeposit.ResumeLayout(false);
            this.tabDeposit.PerformLayout();
            this.tabConsume.ResumeLayout(false);
            this.tabConsume.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabIssue;
        private System.Windows.Forms.TabPage tabQuery;
        private System.Windows.Forms.TabPage tabDeposit;
        private System.Windows.Forms.TabPage tabConsume;
        private System.Windows.Forms.Label lbl1MemberId;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.Label lbl1Point;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lbl1Date;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbl1Name;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Button btnClearCard;
        private System.Windows.Forms.Button btnMakeCard;
        private System.Windows.Forms.Button btnReadCard;
        private System.Windows.Forms.TextBox txtQueryPoint;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.TextBox txtQueryDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtQueryName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtQueryMemberId;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Label lblIssueStatus;
        private System.Windows.Forms.Label lblQueryStatus;
        private System.Windows.Forms.Button btnAddValue;
        private System.Windows.Forms.TextBox txtAddPoint;
        private System.Windows.Forms.Label lblAddPoint;
        private System.Windows.Forms.Label lblAddStatus;
        private System.Windows.Forms.Label lblConsumeStatus;
        private System.Windows.Forms.Button btnConsume;
        private System.Windows.Forms.TextBox txtConsumePoint;
        private System.Windows.Forms.Label lblConsumePoint;
    }
}

