namespace Accounting
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnEditLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnCustomers = new System.Windows.Forms.ToolStripButton();
            this.btnNewTransaction = new System.Windows.Forms.ToolStripButton();
            this.btnReportPay = new System.Windows.Forms.ToolStripButton();
            this.btnReportRecive = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecive = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(782, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditLogin});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(78, 28);
            this.toolStripDropDownButton1.Text = "تنظیمات";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // btnEditLogin
            // 
            this.btnEditLogin.Name = "btnEditLogin";
            this.btnEditLogin.Size = new System.Drawing.Size(180, 26);
            this.btnEditLogin.Text = "تنظیمات ورود";
            this.btnEditLogin.Click += new System.EventHandler(this.btnEditLogin_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCustomers,
            this.btnNewTransaction,
            this.btnReportPay,
            this.btnReportRecive});
            this.toolStrip2.Location = new System.Drawing.Point(0, 31);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(782, 67);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnCustomers
            // 
            this.btnCustomers.Image = global::Accounting.Properties.Resources._1371476468_preferences_contact_list;
            this.btnCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(90, 64);
            this.btnCustomers.Text = "طرف حساب";
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.Image = global::Accounting.Properties.Resources._1370791030_credit_card;
            this.btnNewTransaction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewTransaction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(92, 64);
            this.btnNewTransaction.Text = "تراکنش جدید";
            this.btnNewTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewTransaction.Click += new System.EventHandler(this.btnNewTransaction_Click);
            // 
            // btnReportPay
            // 
            this.btnReportPay.Image = global::Accounting.Properties.Resources.servicesCosts;
            this.btnReportPay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReportPay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportPay.Name = "btnReportPay";
            this.btnReportPay.Size = new System.Drawing.Size(124, 64);
            this.btnReportPay.Text = "گزارش پرداختی ها";
            this.btnReportPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportPay.Click += new System.EventHandler(this.btnReportPay_Click);
            // 
            // btnReportRecive
            // 
            this.btnReportRecive.Image = global::Accounting.Properties.Resources._1371476143_deliverables;
            this.btnReportRecive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReportRecive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportRecive.Name = "btnReportRecive";
            this.btnReportRecive.Size = new System.Drawing.Size(125, 64);
            this.btnReportRecive.Text = "گزارش دریافتی ها";
            this.btnReportRecive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportRecive.Click += new System.EventHandler(this.btnReportRecive_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Accounting.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 232);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDate,
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(782, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(151, 20);
            this.lblDate.Text = "toolStripStatusLabel1";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(151, 20);
            this.lblTime.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAccountBalance);
            this.groupBox1.Controls.Add(this.lblPay);
            this.groupBox1.Controls.Add(this.lblRecive);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(406, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 195);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزارش این ماه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "دریافتی ها :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "پرداختی ها :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "مانده :";
            // 
            // lblRecive
            // 
            this.lblRecive.Location = new System.Drawing.Point(22, 37);
            this.lblRecive.Name = "lblRecive";
            this.lblRecive.Size = new System.Drawing.Size(247, 17);
            this.lblRecive.TabIndex = 3;
            this.lblRecive.Text = "0";
            // 
            // lblPay
            // 
            this.lblPay.Location = new System.Drawing.Point(22, 78);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(247, 17);
            this.lblPay.TabIndex = 4;
            this.lblPay.Text = "0";
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.Location = new System.Drawing.Point(22, 130);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(247, 17);
            this.lblAccountBalance.TabIndex = 5;
            this.lblAccountBalance.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابداری شخصی من";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnCustomers;
        private System.Windows.Forms.ToolStripButton btnNewTransaction;
        private System.Windows.Forms.ToolStripButton btnReportPay;
        private System.Windows.Forms.ToolStripButton btnReportRecive;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem btnEditLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRecive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAccountBalance;
        private System.Windows.Forms.Label lblPay;
    }
}

