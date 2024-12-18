namespace LMSForAdmin
{
    partial class frm_qldsphongdat
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
            this.dgvPhongDaDat = new System.Windows.Forms.DataGridView();
            this.SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDatPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaPhong = new DevExpress.XtraEditors.TextEdit();
            this.txtNguoiDat = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDatPhong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtGiaTien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtLoaiPhong = new DevExpress.XtraEditors.TextEdit();
            this.txtTinhTrang = new DevExpress.XtraEditors.TextEdit();
            this.txtSoPhong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbTinhTrangThanhToan = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongDaDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoiDat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDatPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTinhTrang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTinhTrangThanhToan.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhongDaDat
            // 
            this.dgvPhongDaDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongDaDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhong,
            this.LoaiPhong,
            this.GiaTien,
            this.TinhTrang,
            this.MaPhong,
            this.NguoiDat,
            this.MaDatPhong,
            this.TinhTrangThanhToan});
            this.dgvPhongDaDat.Location = new System.Drawing.Point(637, 216);
            this.dgvPhongDaDat.Name = "dgvPhongDaDat";
            this.dgvPhongDaDat.RowHeadersWidth = 51;
            this.dgvPhongDaDat.RowTemplate.Height = 24;
            this.dgvPhongDaDat.Size = new System.Drawing.Size(1018, 254);
            this.dgvPhongDaDat.TabIndex = 1;
            this.dgvPhongDaDat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SoPhong
            // 
            this.SoPhong.HeaderText = "Số phòng";
            this.SoPhong.MinimumWidth = 6;
            this.SoPhong.Name = "SoPhong";
            this.SoPhong.Width = 125;
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.HeaderText = "Loại phòng";
            this.LoaiPhong.MinimumWidth = 6;
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.Width = 125;
            // 
            // GiaTien
            // 
            this.GiaTien.HeaderText = "Giá tiền";
            this.GiaTien.MinimumWidth = 6;
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.Width = 125;
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 125;
            // 
            // MaPhong
            // 
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Width = 125;
            // 
            // NguoiDat
            // 
            this.NguoiDat.HeaderText = "Người đặt";
            this.NguoiDat.MinimumWidth = 6;
            this.NguoiDat.Name = "NguoiDat";
            this.NguoiDat.Width = 125;
            // 
            // MaDatPhong
            // 
            this.MaDatPhong.HeaderText = "Mã đặt phòng";
            this.MaDatPhong.MinimumWidth = 6;
            this.MaDatPhong.Name = "MaDatPhong";
            this.MaDatPhong.Width = 125;
            // 
            // TinhTrangThanhToan
            // 
            this.TinhTrangThanhToan.HeaderText = "Tình trạng thanh toán";
            this.TinhTrangThanhToan.MinimumWidth = 6;
            this.TinhTrangThanhToan.Name = "TinhTrangThanhToan";
            this.TinhTrangThanhToan.Width = 125;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(351, 43);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(200, 22);
            this.txtMaPhong.TabIndex = 82;
            // 
            // txtNguoiDat
            // 
            this.txtNguoiDat.Location = new System.Drawing.Point(351, 82);
            this.txtNguoiDat.Name = "txtNguoiDat";
            this.txtNguoiDat.Size = new System.Drawing.Size(200, 22);
            this.txtNguoiDat.TabIndex = 81;
            // 
            // txtMaDatPhong
            // 
            this.txtMaDatPhong.Location = new System.Drawing.Point(714, 0);
            this.txtMaDatPhong.Name = "txtMaDatPhong";
            this.txtMaDatPhong.Size = new System.Drawing.Size(200, 22);
            this.txtMaDatPhong.TabIndex = 80;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(576, 6);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(87, 16);
            this.labelControl8.TabIndex = 79;
            this.labelControl8.Text = "Mã đặt phòng :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(576, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(133, 16);
            this.labelControl2.TabIndex = 78;
            this.labelControl2.Text = "Tình trạng thanh toán :";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(351, 3);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(200, 22);
            this.txtGiaTien.TabIndex = 77;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(4, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 16);
            this.labelControl1.TabIndex = 76;
            this.labelControl1.Text = "Số phòng :";
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Location = new System.Drawing.Point(82, 77);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(158, 22);
            this.txtLoaiPhong.TabIndex = 74;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(82, 42);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(158, 22);
            this.txtTinhTrang.TabIndex = 73;
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Location = new System.Drawing.Point(82, 9);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(158, 22);
            this.txtSoPhong.TabIndex = 72;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(255, 9);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(56, 16);
            this.labelControl7.TabIndex = 71;
            this.labelControl7.Text = "Giá tiền : ";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(255, 83);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(68, 16);
            this.labelControl6.TabIndex = 70;
            this.labelControl6.Text = "Người đặt : ";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(255, 46);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 16);
            this.labelControl5.TabIndex = 69;
            this.labelControl5.Text = "Mã phòng :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(4, 85);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 16);
            this.labelControl4.TabIndex = 68;
            this.labelControl4.Text = "Loại phòng : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(4, 45);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 16);
            this.labelControl3.TabIndex = 67;
            this.labelControl3.Text = "Tình trạng : ";
            // 
            // cmbTinhTrangThanhToan
            // 
            this.cmbTinhTrangThanhToan.EditValue = "";
            this.cmbTinhTrangThanhToan.Location = new System.Drawing.Point(714, 43);
            this.cmbTinhTrangThanhToan.Name = "cmbTinhTrangThanhToan";
            this.cmbTinhTrangThanhToan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTinhTrangThanhToan.Properties.DropDownRows = 2;
            this.cmbTinhTrangThanhToan.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Đã thanh toán"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Chưa thanh toán")});
            this.cmbTinhTrangThanhToan.Properties.SelectAllItemVisible = false;
            this.cmbTinhTrangThanhToan.Size = new System.Drawing.Size(200, 22);
            this.cmbTinhTrangThanhToan.TabIndex = 83;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(463, 123);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(133, 67);
            this.simpleButton1.TabIndex = 86;
            this.simpleButton1.Text = "Xoá";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(62, 123);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(136, 67);
            this.simpleButton4.TabIndex = 85;
            this.simpleButton4.Text = "Thêm mới";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(255, 123);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(133, 67);
            this.simpleButton5.TabIndex = 84;
            this.simpleButton5.Text = "Cập nhật";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.simpleButton4);
            this.groupBox1.Controls.Add(this.simpleButton5);
            this.groupBox1.Controls.Add(this.cmbTinhTrangThanhToan);
            this.groupBox1.Controls.Add(this.txtMaPhong);
            this.groupBox1.Controls.Add(this.txtNguoiDat);
            this.groupBox1.Controls.Add(this.txtMaDatPhong);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.txtGiaTien);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.txtLoaiPhong);
            this.groupBox1.Controls.Add(this.txtTinhTrang);
            this.groupBox1.Controls.Add(this.txtSoPhong);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Location = new System.Drawing.Point(637, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1021, 210);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            // 
            // frm_qldsphongdat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1925, 462);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPhongDaDat);
            this.Name = "frm_qldsphongdat";
            this.Text = "DS Phòng đã đặt";
            this.Load += new System.EventHandler(this.frm_qldsphongdat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongDaDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoiDat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDatPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTinhTrang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTinhTrangThanhToan.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhongDaDat;
        private DevExpress.XtraEditors.TextEdit txtMaPhong;
        private DevExpress.XtraEditors.TextEdit txtNguoiDat;
        private DevExpress.XtraEditors.TextEdit txtMaDatPhong;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtGiaTien;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtLoaiPhong;
        private DevExpress.XtraEditors.TextEdit txtTinhTrang;
        private DevExpress.XtraEditors.TextEdit txtSoPhong;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cmbTinhTrangThanhToan;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDatPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrangThanhToan;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}