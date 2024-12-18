namespace LMSForAdmin
{
    partial class frm_dscheck_out
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
            this.dataGridViewCheckOut = new System.Windows.Forms.DataGridView();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDatPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDatPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTraPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedComboBoxEdit1 = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckOut)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCheckOut
            // 
            this.dataGridViewCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCheckOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenKH,
            this.MaDatPhong,
            this.SoCCCD,
            this.NgayDatPhong,
            this.NgayTraPhong,
            this.TinhTrangThanhToan});
            this.dataGridViewCheckOut.Location = new System.Drawing.Point(415, 239);
            this.dataGridViewCheckOut.Name = "dataGridViewCheckOut";
            this.dataGridViewCheckOut.RowHeadersWidth = 51;
            this.dataGridViewCheckOut.RowTemplate.Height = 24;
            this.dataGridViewCheckOut.Size = new System.Drawing.Size(772, 348);
            this.dataGridViewCheckOut.TabIndex = 2;
            this.dataGridViewCheckOut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCheckOut_CellContentClick);
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
            // NgayTraPhong
            // 
            this.NgayTraPhong.HeaderText = "Ngày trả phòng";
            this.NgayTraPhong.MinimumWidth = 6;
            this.NgayTraPhong.Name = "NgayTraPhong";
            this.NgayTraPhong.Width = 125;
            // 
            // TinhTrangThanhToan
            // 
            this.TinhTrangThanhToan.HeaderText = "Tình trạng thanh toán";
            this.TinhTrangThanhToan.MinimumWidth = 6;
            this.TinhTrangThanhToan.Name = "TinhTrangThanhToan";
            this.TinhTrangThanhToan.Width = 125;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(427, 144);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(133, 67);
            this.simpleButton1.TabIndex = 50;
            this.simpleButton1.Text = "Xoá";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 16);
            this.labelControl1.TabIndex = 48;
            this.labelControl1.Text = "Tên KH :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(360, 89);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 47;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(360, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 46;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(240, 10);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(137, 16);
            this.labelControl7.TabIndex = 42;
            this.labelControl7.Text = "Tình trạng thanh toán : ";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(240, 89);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(87, 16);
            this.labelControl6.TabIndex = 41;
            this.labelControl6.Text = "Ngày trả phòng";
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
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(12, 144);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(136, 67);
            this.simpleButton4.TabIndex = 37;
            this.simpleButton4.Text = "Thêm mới";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(224, 144);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(133, 67);
            this.simpleButton5.TabIndex = 36;
            this.simpleButton5.Text = "Cập nhật";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.checkedComboBoxEdit1);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textEdit3);
            this.groupBox1.Controls.Add(this.textEdit2);
            this.groupBox1.Controls.Add(this.textEdit1);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.simpleButton4);
            this.groupBox1.Controls.Add(this.simpleButton5);
            this.groupBox1.Location = new System.Drawing.Point(415, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 236);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // frm_dscheck_out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewCheckOut);
            this.Name = "frm_dscheck_out";
            this.Text = "DS Check out";
            this.Load += new System.EventHandler(this.frm_dscheck_out_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckOut)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDatPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDatPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTraPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrangThanhToan;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}