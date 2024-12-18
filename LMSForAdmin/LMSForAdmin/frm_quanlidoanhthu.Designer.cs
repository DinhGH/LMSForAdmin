namespace LMSForAdmin
{
    partial class frm_quanlidoanhthu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simpleButtonAdd = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonEdit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonExit = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInvoiceID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceID,
            this.InvoiceDate,
            this.CustomerName,
            this.RoomNumber,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(17, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // InvoiceID
            // 
            this.InvoiceID.HeaderText = "Mã hóa đơn";
            this.InvoiceID.Name = "InvoiceID";
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.HeaderText = "Ngày hóa đơn";
            this.InvoiceDate.Name = "InvoiceDate";
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Tên khách hàng";
            this.CustomerName.Name = "CustomerName";
            // 
            // RoomNumber
            // 
            this.RoomNumber.HeaderText = "Số phòng";
            this.RoomNumber.Name = "RoomNumber";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Thành tiền";
            this.Amount.Name = "Amount";
            // 
            // simpleButtonAdd
            // 
            this.simpleButtonAdd.Location = new System.Drawing.Point(17, 118);
            this.simpleButtonAdd.Name = "simpleButtonAdd";
            this.simpleButtonAdd.Size = new System.Drawing.Size(100, 40);
            this.simpleButtonAdd.TabIndex = 1;
            this.simpleButtonAdd.Text = "Thêm";
            this.simpleButtonAdd.Click += new System.EventHandler(this.simpleButtonAdd_Click);
            // 
            // simpleButtonEdit
            // 
            this.simpleButtonEdit.Location = new System.Drawing.Point(163, 118);
            this.simpleButtonEdit.Name = "simpleButtonEdit";
            this.simpleButtonEdit.Size = new System.Drawing.Size(100, 40);
            this.simpleButtonEdit.TabIndex = 2;
            this.simpleButtonEdit.Text = "Sửa";
            this.simpleButtonEdit.Click += new System.EventHandler(this.simpleButtonEdit_Click);
            // 
            // simpleButtonDelete
            // 
            this.simpleButtonDelete.Location = new System.Drawing.Point(313, 118);
            this.simpleButtonDelete.Name = "simpleButtonDelete";
            this.simpleButtonDelete.Size = new System.Drawing.Size(100, 40);
            this.simpleButtonDelete.TabIndex = 3;
            this.simpleButtonDelete.Text = "Xóa";
            this.simpleButtonDelete.Click += new System.EventHandler(this.simpleButtonDelete_Click);
            // 
            // simpleButtonExit
            // 
            this.simpleButtonExit.Location = new System.Drawing.Point(463, 118);
            this.simpleButtonExit.Name = "simpleButtonExit";
            this.simpleButtonExit.Size = new System.Drawing.Size(100, 40);
            this.simpleButtonExit.TabIndex = 4;
            this.simpleButtonExit.Text = "Thoát";
            this.simpleButtonExit.Click += new System.EventHandler(this.simpleButtonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã hóa đơn";
            // 
            // textBoxInvoiceID
            // 
            this.textBoxInvoiceID.Location = new System.Drawing.Point(113, 14);
            this.textBoxInvoiceID.Name = "textBoxInvoiceID";
            this.textBoxInvoiceID.Size = new System.Drawing.Size(200, 20);
            this.textBoxInvoiceID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ngày hóa đơn";
            // 
            // dateTimePickerInvoiceDate
            // 
            this.dateTimePickerInvoiceDate.Location = new System.Drawing.Point(113, 51);
            this.dateTimePickerInvoiceDate.Name = "dateTimePickerInvoiceDate";
            this.dateTimePickerInvoiceDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerInvoiceDate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên khách hàng";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(448, 14);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(200, 20);
            this.textBoxCustomerName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số phòng";
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Location = new System.Drawing.Point(448, 51);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Size = new System.Drawing.Size(200, 20);
            this.textBoxRoomNumber.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Thành tiền";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(113, 85);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(200, 20);
            this.textBoxAmount.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCustomerName);
            this.groupBox1.Controls.Add(this.textBoxAmount);
            this.groupBox1.Controls.Add(this.textBoxRoomNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePickerInvoiceDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxInvoiceID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.simpleButtonExit);
            this.groupBox1.Controls.Add(this.simpleButtonDelete);
            this.groupBox1.Controls.Add(this.simpleButtonEdit);
            this.groupBox1.Controls.Add(this.simpleButtonAdd);
            this.groupBox1.Location = new System.Drawing.Point(300, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 419);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý doanh thu";
            // 
            // frm_quanlidoanhthu
            // 
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_quanlidoanhthu";
            this.Text = "Quản Lý Doanh Thu Khách Sạn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAdd;
        private DevExpress.XtraEditors.SimpleButton simpleButtonEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDelete;
        private DevExpress.XtraEditors.SimpleButton simpleButtonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInvoiceID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerInvoiceDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRoomNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }

}