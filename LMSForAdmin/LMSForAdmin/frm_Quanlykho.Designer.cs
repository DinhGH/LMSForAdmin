namespace LMSForAdmin
{
    partial class frm_Quanlykho
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
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.Donvidoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaynhaphang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenmathang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Makhohang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckOut = new System.Windows.Forms.DataGridView();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(636, 123);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(114, 54);
            this.simpleButton3.TabIndex = 109;
            this.simpleButton3.Text = "Thoát";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(253, 123);
            this.simpleButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(114, 54);
            this.simpleButton5.TabIndex = 97;
            this.simpleButton5.Text = "Cập nhật";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // Donvidoluong
            // 
            this.Donvidoluong.HeaderText = "Đvt";
            this.Donvidoluong.MinimumWidth = 6;
            this.Donvidoluong.Name = "Donvidoluong";
            this.Donvidoluong.Width = 125;
            // 
            // Ngaynhaphang
            // 
            this.Ngaynhaphang.HeaderText = "Ngày nhập hàng";
            this.Ngaynhaphang.MinimumWidth = 6;
            this.Ngaynhaphang.Name = "Ngaynhaphang";
            this.Ngaynhaphang.Width = 125;
            // 
            // SL
            // 
            this.SL.HeaderText = "Số lượng";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            this.SL.Width = 125;
            // 
            // Tenmathang
            // 
            this.Tenmathang.HeaderText = "Tên mặt hàng";
            this.Tenmathang.MinimumWidth = 6;
            this.Tenmathang.Name = "Tenmathang";
            this.Tenmathang.Width = 125;
            // 
            // Makhohang
            // 
            this.Makhohang.HeaderText = "Mã mặt hàng";
            this.Makhohang.MinimumWidth = 6;
            this.Makhohang.Name = "Makhohang";
            this.Makhohang.Width = 125;
            // 
            // dataGridViewCheckOut
            // 
            this.dataGridViewCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCheckOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Makhohang,
            this.Tenmathang,
            this.SL,
            this.Ngaynhaphang,
            this.Donvidoluong});
            this.dataGridViewCheckOut.Location = new System.Drawing.Point(72, 190);
            this.dataGridViewCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCheckOut.Name = "dataGridViewCheckOut";
            this.dataGridViewCheckOut.RowHeadersWidth = 51;
            this.dataGridViewCheckOut.RowTemplate.Height = 24;
            this.dataGridViewCheckOut.Size = new System.Drawing.Size(678, 283);
            this.dataGridViewCheckOut.TabIndex = 96;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(56, 79);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 13);
            this.labelControl4.TabIndex = 99;
            this.labelControl4.Text = "Số lượng :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(275, 79);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(86, 13);
            this.labelControl5.TabIndex = 100;
            this.labelControl5.Text = "Ngày nhập hàng :";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(275, 15);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(83, 13);
            this.labelControl7.TabIndex = 101;
            this.labelControl7.Text = "Đơn bị đo lường :";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(128, 12);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(135, 20);
            this.textEdit1.TabIndex = 102;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(128, 76);
            this.textEdit3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(127, 20);
            this.textEdit3.TabIndex = 103;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(377, 71);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker1.TabIndex = 104;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(56, 15);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.TabIndex = 105;
            this.labelControl1.Text = "Tên mặt hàng:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(445, 123);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(114, 54);
            this.simpleButton1.TabIndex = 106;
            this.simpleButton1.Text = "Xoá";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(377, 12);
            this.textEdit2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(135, 20);
            this.textEdit2.TabIndex = 107;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(72, 123);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(114, 54);
            this.simpleButton2.TabIndex = 108;
            this.simpleButton2.Text = "Thêm mới";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton3);
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.textEdit2);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textEdit3);
            this.groupBox1.Controls.Add(this.textEdit1);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.simpleButton5);
            this.groupBox1.Controls.Add(this.dataGridViewCheckOut);
            this.groupBox1.Location = new System.Drawing.Point(300, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 516);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý kho";
            // 
            // frm_Quanlykho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 484);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Quanlykho";
            this.Text = "Quản lý kho";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donvidoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaynhaphang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenmathang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Makhohang;
        private System.Windows.Forms.DataGridView dataGridViewCheckOut;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}