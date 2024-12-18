namespace LMSForAdmin
{
    partial class frm_CancellationRoom
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.checkedComboBoxEdit1 = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.dgvHuyPhong = new System.Windows.Forms.DataGridView();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDatPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDatPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDoTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuyPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textEdit4);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.checkedComboBoxEdit1);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textEdit3);
            this.groupBox1.Controls.Add(this.textEdit2);
            this.groupBox1.Controls.Add(this.textEdit1);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.simpleButton5);
            this.groupBox1.Location = new System.Drawing.Point(361, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 236);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(383, 144);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(133, 67);
            this.simpleButton1.TabIndex = 50;
            this.simpleButton1.Text = "Từ chối";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // checkedComboBoxEdit1
            // 
            this.checkedComboBoxEdit1.EditValue = "";
            this.checkedComboBoxEdit1.Location = new System.Drawing.Point(383, 7);
            this.checkedComboBoxEdit1.Name = "checkedComboBoxEdit1";
            this.checkedComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEdit1.Properties.DropDownRows = 2;
            this.checkedComboBoxEdit1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Đã thanh toán"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Chưa thanh toán")});
            this.checkedComboBoxEdit1.Properties.SelectAllItemVisible = false;
            this.checkedComboBoxEdit1.Size = new System.Drawing.Size(177, 22);
            this.checkedComboBoxEdit1.TabIndex = 49;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 16);
            this.labelControl1.TabIndex = 48;
            this.labelControl1.Text = "Tên KH :";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(383, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 23);
            this.dateTimePicker1.TabIndex = 46;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(79, 86);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(148, 22);
            this.textEdit3.TabIndex = 45;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(102, 45);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(125, 22);
            this.textEdit2.TabIndex = 44;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(69, 7);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(158, 22);
            this.textEdit1.TabIndex = 43;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(240, 10);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(137, 16);
            this.labelControl7.TabIndex = 42;
            this.labelControl7.Text = "Tình trạng thanh toán : ";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(240, 48);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(89, 16);
            this.labelControl5.TabIndex = 40;
            this.labelControl5.Text = "Ngày đặt phòng";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 89);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 16);
            this.labelControl4.TabIndex = 39;
            this.labelControl4.Text = "Số CCCD :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 48);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 16);
            this.labelControl3.TabIndex = 38;
            this.labelControl3.Text = "Mã đặt phòng :";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(94, 144);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(133, 67);
            this.simpleButton5.TabIndex = 36;
            this.simpleButton5.Text = "Chấp nhận";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(240, 89);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 16);
            this.labelControl2.TabIndex = 51;
            this.labelControl2.Text = "Lý do huỷ phòng";
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(383, 86);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(177, 22);
            this.textEdit4.TabIndex = 52;
            // 
            // dgvHuyPhong
            // 
            this.dgvHuyPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHuyPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenKH,
            this.MaDatPhong,
            this.SoCCCD,
            this.NgayDatPhong,
            this.TinhTrangThanhToan,
            this.LyDoTra});
            this.dgvHuyPhong.Location = new System.Drawing.Point(361, 254);
            this.dgvHuyPhong.Name = "dgvHuyPhong";
            this.dgvHuyPhong.RowHeadersWidth = 51;
            this.dgvHuyPhong.RowTemplate.Height = 24;
            this.dgvHuyPhong.Size = new System.Drawing.Size(591, 348);
            this.dgvHuyPhong.TabIndex = 53;
            this.dgvHuyPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHuyPhong_CellContentClick);
            // 
            // TenKH
            // 
            this.TenKH.HeaderText = "Tên KH";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 125;
            // 
            // MaDatPhong
            // 
            this.MaDatPhong.HeaderText = "Mã đặt phòng";
            this.MaDatPhong.MinimumWidth = 6;
            this.MaDatPhong.Name = "MaDatPhong";
            this.MaDatPhong.Width = 125;
            // 
            // SoCCCD
            // 
            this.SoCCCD.HeaderText = "Số CCCD";
            this.SoCCCD.MinimumWidth = 6;
            this.SoCCCD.Name = "SoCCCD";
            this.SoCCCD.Width = 125;
            // 
            // NgayDatPhong
            // 
            this.NgayDatPhong.HeaderText = "Ngày đặt phòng";
            this.NgayDatPhong.MinimumWidth = 6;
            this.NgayDatPhong.Name = "NgayDatPhong";
            this.NgayDatPhong.Width = 125;
            // 
            // TinhTrangThanhToan
            // 
            this.TinhTrangThanhToan.HeaderText = "Tình trạng thanh toán";
            this.TinhTrangThanhToan.MinimumWidth = 6;
            this.TinhTrangThanhToan.Name = "TinhTrangThanhToan";
            this.TinhTrangThanhToan.Width = 125;
            // 
            // LyDoTra
            // 
            this.LyDoTra.HeaderText = "Lý do huỷ phòng";
            this.LyDoTra.MinimumWidth = 6;
            this.LyDoTra.Name = "LyDoTra";
            this.LyDoTra.Width = 125;
            // 
            // frm_CancellationRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 556);
            this.Controls.Add(this.dgvHuyPhong);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_CancellationRoom";
            this.Text = "frm_CancellationRoom";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuyPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DataGridView dgvHuyPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDatPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDatPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrangThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDoTra;
    }
}