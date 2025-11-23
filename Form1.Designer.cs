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
            this.tabIssue = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabQuery = new System.Windows.Forms.TabPage();
            this.tabDeposit = new System.Windows.Forms.TabPage();
            this.tabConsume = new System.Windows.Forms.TabPage();
            this.memberId = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtPoint = new System.Windows.Forms.Label();
            this.btnMakeCard = new System.Windows.Forms.Button();
            this.btnClearCard = new System.Windows.Forms.Button();
            this.btnReadCard = new System.Windows.Forms.Button();
            this.txtQueryPoint = new System.Windows.Forms.TextBox();
            this.lblPoint = new System.Windows.Forms.Label();
            this.txtQueryDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtQueryName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtQueryMemberId = new System.Windows.Forms.TextBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.lblQueryStatus = new System.Windows.Forms.Label();
            this.lblIssueStatus = new System.Windows.Forms.Label();
            this.txtAddPoint = new System.Windows.Forms.TextBox();
            this.lblAddPoint = new System.Windows.Forms.Label();
            this.btnAddValue = new System.Windows.Forms.Button();
            this.lblAddStatus = new System.Windows.Forms.Label();
            this.lblConsumeStatus = new System.Windows.Forms.Label();
            this.btnConsume = new System.Windows.Forms.Button();
            this.txtConsumePoint = new System.Windows.Forms.TextBox();
            this.lblConsumePoint = new System.Windows.Forms.Label();
            this.tabIssue.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            // tabIssue
            // 
            this.tabIssue.Controls.Add(this.tabPage1);
            this.tabIssue.Controls.Add(this.tabQuery);
            this.tabIssue.Controls.Add(this.tabDeposit);
            this.tabIssue.Controls.Add(this.tabConsume);
            this.tabIssue.Location = new System.Drawing.Point(12, 12);
            this.tabIssue.Name = "tabIssue";
            this.tabIssue.SelectedIndex = 0;
            this.tabIssue.Size = new System.Drawing.Size(406, 301);
            this.tabIssue.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblIssueStatus);
            this.tabPage1.Controls.Add(this.btnClearCard);
            this.tabPage1.Controls.Add(this.btnMakeCard);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.txtPoint);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.txtDate);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtMemberId);
            this.tabPage1.Controls.Add(this.memberId);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(398, 272);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "發卡";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // memberId
            // 
            this.memberId.AutoSize = true;
            this.memberId.Location = new System.Drawing.Point(25, 30);
            this.memberId.Name = "memberId";
            this.memberId.Size = new System.Drawing.Size(71, 15);
            this.memberId.TabIndex = 0;
            this.memberId.Text = "會員編號:";
            this.memberId.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(102, 20);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(157, 25);
            this.txtMemberId.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 25);
            this.txtName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "姓名:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 25);
            this.textBox1.TabIndex = 5;
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Location = new System.Drawing.Point(25, 125);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(71, 15);
            this.txtDate.TabIndex = 4;
            this.txtDate.Text = "申請日期:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 25);
            this.textBox2.TabIndex = 7;
            // 
            // txtPoint
            // 
            this.txtPoint.AutoSize = true;
            this.txtPoint.Location = new System.Drawing.Point(25, 184);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(41, 15);
            this.txtPoint.TabIndex = 6;
            this.txtPoint.Text = "點數:";
            // 
            // btnMakeCard
            // 
            this.btnMakeCard.Location = new System.Drawing.Point(283, 65);
            this.btnMakeCard.Name = "btnMakeCard";
            this.btnMakeCard.Size = new System.Drawing.Size(95, 23);
            this.btnMakeCard.TabIndex = 8;
            this.btnMakeCard.Text = "卡片製作";
            this.btnMakeCard.UseVisualStyleBackColor = true;
            // 
            // btnClearCard
            // 
            this.btnClearCard.Location = new System.Drawing.Point(283, 121);
            this.btnClearCard.Name = "btnClearCard";
            this.btnClearCard.Size = new System.Drawing.Size(95, 23);
            this.btnClearCard.TabIndex = 9;
            this.btnClearCard.Text = "清空卡片";
            this.btnClearCard.UseVisualStyleBackColor = true;
            // 
            // btnReadCard
            // 
            this.btnReadCard.Location = new System.Drawing.Point(281, 76);
            this.btnReadCard.Name = "btnReadCard";
            this.btnReadCard.Size = new System.Drawing.Size(95, 23);
            this.btnReadCard.TabIndex = 17;
            this.btnReadCard.Text = "讀取卡片";
            this.btnReadCard.UseVisualStyleBackColor = true;
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
            // lblQueryStatus
            // 
            this.lblQueryStatus.AutoSize = true;
            this.lblQueryStatus.Location = new System.Drawing.Point(23, 240);
            this.lblQueryStatus.Name = "lblQueryStatus";
            this.lblQueryStatus.Size = new System.Drawing.Size(67, 15);
            this.lblQueryStatus.TabIndex = 18;
            this.lblQueryStatus.Text = "讀取完成";
            // 
            // lblIssueStatus
            // 
            this.lblIssueStatus.AutoSize = true;
            this.lblIssueStatus.Location = new System.Drawing.Point(25, 234);
            this.lblIssueStatus.Name = "lblIssueStatus";
            this.lblIssueStatus.Size = new System.Drawing.Size(67, 15);
            this.lblIssueStatus.TabIndex = 19;
            this.lblIssueStatus.Text = "寫入完成";
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
            // btnAddValue
            // 
            this.btnAddValue.Location = new System.Drawing.Point(286, 96);
            this.btnAddValue.Name = "btnAddValue";
            this.btnAddValue.Size = new System.Drawing.Size(95, 23);
            this.btnAddValue.TabIndex = 18;
            this.btnAddValue.Text = "加值點數";
            this.btnAddValue.UseVisualStyleBackColor = true;
            // 
            // lblAddStatus
            // 
            this.lblAddStatus.AutoSize = true;
            this.lblAddStatus.Location = new System.Drawing.Point(26, 177);
            this.lblAddStatus.Name = "lblAddStatus";
            this.lblAddStatus.Size = new System.Drawing.Size(109, 15);
            this.lblAddStatus.TabIndex = 19;
            this.lblAddStatus.Text = "儲值: 可用餘額:";
            this.lblAddStatus.Click += new System.EventHandler(this.label2_Click);
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
            this.Controls.Add(this.tabIssue);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "電子錢包";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabIssue.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.TabControl tabIssue;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabQuery;
        private System.Windows.Forms.TabPage tabDeposit;
        private System.Windows.Forms.TabPage tabConsume;
        private System.Windows.Forms.Label memberId;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtPoint;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
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

