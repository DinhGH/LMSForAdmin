namespace LMSForAdmin
{
    partial class frm_QLRooms
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
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtDienTich = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.checkedComboTinhTrang = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtLoaiPhong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtTang = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaPhong = new DevExpress.XtraEditors.TextEdit();
            this.txtPhongSo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienTich.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboTinhTrang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhongSo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.PhongSo,
            this.TinhTrang,
            this.Tang,
            this.DienTich,
            this.LoaiPhong});
            this.dataTable.Location = new System.Drawing.Point(489, 281);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 24;
            this.dataTable.Size = new System.Drawing.Size(631, 259);
            this.dataTable.TabIndex = 7;
            // 
            // MaPhong
            // 
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Width = 125;
            // 
            // PhongSo
            // 
            this.PhongSo.HeaderText = "Phòng số";
            this.PhongSo.MinimumWidth = 6;
            this.PhongSo.Name = "PhongSo";
            this.PhongSo.Width = 125;
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 125;
            // 
            // Tang
            // 
            this.Tang.HeaderText = "Tầng";
            this.Tang.MinimumWidth = 6;
            this.Tang.Name = "Tang";
            this.Tang.Width = 125;
            // 
            // DienTich
            // 
            this.DienTich.HeaderText = "Diện tích";
            this.DienTich.MinimumWidth = 6;
            this.DienTich.Name = "DienTich";
            this.DienTich.Width = 125;
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.HeaderText = "Loại phòng";
            this.LoaiPhong.MinimumWidth = 6;
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.Width = 125;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtDienTich);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.checkedComboTinhTrang);
            this.groupControl2.Controls.Add(this.simpleButton3);
            this.groupControl2.Controls.Add(this.simpleButton2);
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.txtLoaiPhong);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.txtTang);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.txtMaPhong);
            this.groupControl2.Controls.Add(this.txtPhongSo);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Location = new System.Drawing.Point(486, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(634, 259);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Quản lý phòng";
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(124, 121);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(115, 22);
            this.txtDienTich.TabIndex = 27;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(343, 124);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(75, 16);
            this.labelControl10.TabIndex = 26;
            this.labelControl10.Text = "Loại phòng : ";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(553, 126);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(0, 16);
            this.labelControl6.TabIndex = 24;
            // 
            // checkedComboTinhTrang
            // 
            this.checkedComboTinhTrang.EditValue = "";
            this.checkedComboTinhTrang.Location = new System.Drawing.Point(425, 36);
            this.checkedComboTinhTrang.Name = "checkedComboTinhTrang";
            this.checkedComboTinhTrang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboTinhTrang.Properties.DropDownRows = 2;
            this.checkedComboTinhTrang.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Đã thanh toán"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Chưa thanh toán")});
            this.checkedComboTinhTrang.Properties.SelectAllItemVisible = false;
            this.checkedComboTinhTrang.Size = new System.Drawing.Size(168, 22);
            this.checkedComboTinhTrang.TabIndex = 23;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(425, 183);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(136, 44);
            this.simpleButton3.TabIndex = 22;
            this.simpleButton3.Text = "Xoá";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(235, 183);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(136, 44);
            this.simpleButton2.TabIndex = 21;
            this.simpleButton2.Text = "Sửa";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(49, 183);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(136, 44);
            this.simpleButton1.TabIndex = 20;
            this.simpleButton1.Text = "Thêm mới";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Location = new System.Drawing.Point(425, 120);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(168, 22);
            this.txtLoaiPhong.TabIndex = 17;
            this.txtLoaiPhong.EditValueChanged += new System.EventHandler(this.textEdit5_EditValueChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(553, 126);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(0, 16);
            this.labelControl8.TabIndex = 16;
            // 
            // txtTang
            // 
            this.txtTang.Location = new System.Drawing.Point(425, 76);
            this.txtTang.Name = "txtTang";
            this.txtTang.Size = new System.Drawing.Size(168, 22);
            this.txtTang.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(343, 79);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 16);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Tầng :";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(124, 39);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(115, 22);
            this.txtMaPhong.TabIndex = 13;
            // 
            // txtPhongSo
            // 
            this.txtPhongSo.Location = new System.Drawing.Point(124, 76);
            this.txtPhongSo.Name = "txtPhongSo";
            this.txtPhongSo.Size = new System.Drawing.Size(115, 22);
            this.txtPhongSo.TabIndex = 8;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(46, 124);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(58, 16);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Diện tích :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(343, 42);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(68, 16);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Tình trạng :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(49, 79);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Phòng số :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(49, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mã phòng : ";
            // 
            // frm_QLRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 542);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.groupControl2);
            this.Name = "frm_QLRooms";
            this.Text = "Quản lý phòng";
            this.Load += new System.EventHandler(this.frm_QLRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienTich.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboTinhTrang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhongSo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTable;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboTinhTrang;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtLoaiPhong;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtTang;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMaPhong;
        private DevExpress.XtraEditors.TextEdit txtPhongSo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDienTich;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
    }
}