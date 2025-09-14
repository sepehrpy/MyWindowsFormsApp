namespace Accounting
{
    partial class frmNewTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewTransaction));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgCustomers = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbReceive = new System.Windows.Forms.RadioButton();
            this.rbPay = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiscription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.rangeValidator1 = new ValidationComponents.RangeValidator(this.components);
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.dgCustomers);
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 429);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اشخاص";
            // 
            // dgCustomers
            // 
            this.dgCustomers.AllowUserToAddRows = false;
            this.dgCustomers.AllowUserToDeleteRows = false;
            this.dgCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.ID});
            this.dgCustomers.Location = new System.Drawing.Point(6, 51);
            this.dgCustomers.Name = "dgCustomers";
            this.dgCustomers.ReadOnly = true;
            this.dgCustomers.RowHeadersWidth = 51;
            this.dgCustomers.RowTemplate.Height = 24;
            this.dgCustomers.Size = new System.Drawing.Size(235, 372);
            this.dgCustomers.TabIndex = 2;
            this.dgCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomers_CellClick);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(23, 22);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(187, 23);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "نام شخص";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "CustomerID";
            this.ID.HeaderText = "Column1";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.99F);
            this.label1.Location = new System.Drawing.Point(583, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "طرف حساب :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(308, 12);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(269, 23);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightBlue;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.99F);
            this.label3.Location = new System.Drawing.Point(583, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = " نوع تراکنش :";
            // 
            // rbReceive
            // 
            this.rbReceive.AutoSize = true;
            this.rbReceive.Location = new System.Drawing.Point(494, 60);
            this.rbReceive.Name = "rbReceive";
            this.rbReceive.Size = new System.Drawing.Size(64, 20);
            this.rbReceive.TabIndex = 5;
            this.rbReceive.TabStop = true;
            this.rbReceive.Text = "دریافت";
            this.rbReceive.UseVisualStyleBackColor = true;
            this.rbReceive.CheckedChanged += new System.EventHandler(this.rbReceive_CheckedChanged);
            // 
            // rbPay
            // 
            this.rbPay.AutoSize = true;
            this.rbPay.Location = new System.Drawing.Point(409, 60);
            this.rbPay.Name = "rbPay";
            this.rbPay.Size = new System.Drawing.Size(67, 20);
            this.rbPay.TabIndex = 6;
            this.rbPay.TabStop = true;
            this.rbPay.Text = "پرداخت";
            this.rbPay.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.99F);
            this.label2.Location = new System.Drawing.Point(609, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "مبلغ :";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(355, 102);
            this.txtAmount.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(222, 23);
            this.txtAmount.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightBlue;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.99F);
            this.label4.Location = new System.Drawing.Point(609, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "شرح :";
            // 
            // txtDiscription
            // 
            this.txtDiscription.Location = new System.Drawing.Point(308, 158);
            this.txtDiscription.Multiline = true;
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.Size = new System.Drawing.Size(287, 229);
            this.txtDiscription.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSave.Font = new System.Drawing.Font("Viner Hand ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(571, 409);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 32);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rangeValidator1
            // 
            this.rangeValidator1.CancelFocusChangeWhenInvalid = false;
            this.rangeValidator1.ControlToValidate = this.txtAmount;
            this.rangeValidator1.ErrorMessage = "از مبلغ وارد شده اطمینان حاصل فرمایید";
            this.rangeValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("rangeValidator1.Icon")));
            this.rangeValidator1.MaximumValue = "10000000000";
            this.rangeValidator1.MinimumValue = "1000";
            this.rangeValidator1.Type = ValidationComponents.ValidationDataType.Double;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtName;
            this.requiredFieldValidator1.ErrorMessage = " شخص طرف حساب را از لیست انتخاب کنید";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // frmNewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = global::Accounting.Properties.Resources.servicesCosts;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDiscription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbPay);
            this.Controls.Add(this.rbReceive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewTransaction";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لیست تراکنش ها";
            this.Load += new System.EventHandler(this.frmNewTransaction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbReceive;
        private System.Windows.Forms.RadioButton rbPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiscription;
        private System.Windows.Forms.Button btnSave;
        private ValidationComponents.RangeValidator rangeValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
    }
}