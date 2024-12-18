namespace LMSForAdmin
{
    partial class frm_xuathang
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridViewCheckOut = new System.Windows.Forms.DataGridView();
            this.Makhohang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenmathang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaynhaphang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donvidoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(506, 135);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(114, 54);
            this.simpleButton1.TabIndex = 66;
            this.simpleButton1.Text = "Xoá";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 27);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.TabIndex = 64;
            this.labelControl1.Text = "Tên mặt hàng:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(350, 83);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 21);
            this.dateTimePicker1.TabIndex = 62;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(101, 88);
            this.textEdit3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(127, 20);
            this.textEdit3.TabIndex = 61;
            this.textEdit3.EditValueChanged += new System.EventHandler(this.textEdit3_EditValueChanged);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(101, 24);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(135, 20);
            this.textEdit1.TabIndex = 59;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(248, 27);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(76, 13);
            this.labelControl7.TabIndex = 58;
            this.labelControl7.Text = "Đơn bị đo lường";
            this.labelControl7.Click += new System.EventHandler(this.labelControl7_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(248, 91);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(79, 13);
            this.labelControl5.TabIndex = 56;
            this.labelControl5.Text = "Ngày nhập hàng";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(29, 91);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 13);
            this.labelControl4.TabIndex = 55;
            this.labelControl4.Text = "Số lượng :";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(29, 135);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(117, 54);
            this.simpleButton4.TabIndex = 53;
            this.simpleButton4.Text = "Xuất kho";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(350, 135);
            this.simpleButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(114, 54);
            this.simpleButton5.TabIndex = 52;
            this.simpleButton5.Text = "Cập nhật";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
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
            this.dataGridViewCheckOut.Location = new System.Drawing.Point(45, 202);
            this.dataGridViewCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCheckOut.Name = "dataGridViewCheckOut";
            this.dataGridViewCheckOut.RowHeadersWidth = 51;
            this.dataGridViewCheckOut.RowTemplate.Height = 24;
            this.dataGridViewCheckOut.Size = new System.Drawing.Size(662, 283);
            this.dataGridViewCheckOut.TabIndex = 51;
            this.dataGridViewCheckOut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCheckOut_CellContentClick);
            // 
            // Makhohang
            // 
            this.Makhohang.HeaderText = "Mã mặt hàng";
            this.Makhohang.MinimumWidth = 6;
            this.Makhohang.Name = "Makhohang";
            this.Makhohang.Width = 125;
            // 
            // Tenmathang
            // 
            this.Tenmathang.HeaderText = "Tên mặt hàng";
            this.Tenmathang.MinimumWidth = 6;
            this.Tenmathang.Name = "Tenmathang";
            this.Tenmathang.Width = 125;
            // 
            // SL
            // 
            this.SL.HeaderText = "Số lượng";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            this.SL.Width = 125;
            // 
            // Ngaynhaphang
            // 
            this.Ngaynhaphang.HeaderText = "Ngày nhập hàng";
            this.Ngaynhaphang.MinimumWidth = 6;
            this.Ngaynhaphang.Name = "Ngaynhaphang";
            this.Ngaynhaphang.Width = 125;
            // 
            // Donvidoluong
            // 
            this.Donvidoluong.HeaderText = "Đvt";
            this.Donvidoluong.MinimumWidth = 6;
            this.Donvidoluong.Name = "Donvidoluong";
            this.Donvidoluong.Width = 125;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(350, 24);
            this.textEdit2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(135, 20);
            this.textEdit2.TabIndex = 67;
            this.textEdit2.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(187, 135);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(114, 54);
            this.simpleButton2.TabIndex = 68;
            this.simpleButton2.Text = "Thêm mới";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(663, 135);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(114, 54);
            this.simpleButton3.TabIndex = 69;
            this.simpleButton3.Text = "Thoát";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
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
            this.groupBox1.Controls.Add(this.simpleButton4);
            this.groupBox1.Controls.Add(this.simpleButton5);
            this.groupBox1.Controls.Add(this.dataGridViewCheckOut);
            this.groupBox1.Location = new System.Drawing.Point(300, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 539);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xuất hàng";
            // 
            // frm_xuathang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 483);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_xuathang";
            this.Text = "Xuất hàng";
            this.Load += new System.EventHandler(this.frm_xuathang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.DataGridView dataGridViewCheckOut;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Makhohang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenmathang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaynhaphang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donvidoluong;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}