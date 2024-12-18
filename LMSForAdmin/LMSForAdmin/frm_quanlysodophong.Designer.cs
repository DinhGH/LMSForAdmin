namespace LMSForAdmin
{
    partial class frm_quanlysodophong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.Trangthaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Succhua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sophong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonChangeStatus = new DevExpress.XtraEditors.SimpleButton();
            this.btnPhong301 = new DevExpress.XtraEditors.SimpleButton();
            this.btnPhong302 = new DevExpress.XtraEditors.SimpleButton();
            this.btnPhong201 = new DevExpress.XtraEditors.SimpleButton();
            this.btnPhong202 = new DevExpress.XtraEditors.SimpleButton();
            this.btnPhong101 = new DevExpress.XtraEditors.SimpleButton();
            this.btnPhong102 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPhong303 = new DevExpress.XtraEditors.SimpleButton();
            this.btnPhong203 = new DevExpress.XtraEditors.SimpleButton();
            this.btnPhong103 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(529, 115);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(95, 35);
            this.simpleButton3.TabIndex = 152;
            this.simpleButton3.Text = "Hủy chỉnh sửa";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 136;
            this.label1.Text = "Số phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 137;
            this.label3.Text = "Sức chứa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 139;
            this.label5.Text = "Trạng thái phòng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(572, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 141;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(572, 43);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(142, 20);
            this.textBox3.TabIndex = 142;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Có sẵn",
            "Có người ở",
            "Đang hoạt động"});
            this.comboBox1.Location = new System.Drawing.Point(572, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 145;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(764, 115);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(95, 35);
            this.simpleButton4.TabIndex = 149;
            this.simpleButton4.Text = "Thoát";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // Trangthaiphong
            // 
            this.Trangthaiphong.HeaderText = "Trạng thái phòng";
            this.Trangthaiphong.Name = "Trangthaiphong";
            // 
            // Succhua
            // 
            this.Succhua.HeaderText = "Sức chứa";
            this.Succhua.Name = "Succhua";
            // 
            // Sophong
            // 
            this.Sophong.HeaderText = "Số phòng";
            this.Sophong.Name = "Sophong";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sophong,
            this.Succhua,
            this.Trangthaiphong});
            this.dataGridView1.Location = new System.Drawing.Point(434, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(338, 219);
            this.dataGridView1.TabIndex = 135;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(416, 115);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(95, 35);
            this.simpleButton2.TabIndex = 151;
            this.simpleButton2.Text = "Lưu thay đổi";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButtonChangeStatus
            // 
            this.simpleButtonChangeStatus.Location = new System.Drawing.Point(642, 115);
            this.simpleButtonChangeStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButtonChangeStatus.Name = "simpleButtonChangeStatus";
            this.simpleButtonChangeStatus.Size = new System.Drawing.Size(97, 35);
            this.simpleButtonChangeStatus.TabIndex = 154;
            this.simpleButtonChangeStatus.Text = "Thay đổi trạng thái";
            this.simpleButtonChangeStatus.Click += new System.EventHandler(this.simpleButtonChangeStatus_Click);
            // 
            // btnPhong301
            // 
            this.btnPhong301.Location = new System.Drawing.Point(3, 19);
            this.btnPhong301.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhong301.Name = "btnPhong301";
            this.btnPhong301.Size = new System.Drawing.Size(95, 54);
            this.btnPhong301.TabIndex = 154;
            this.btnPhong301.Text = "Phòng 301";
            this.btnPhong301.Click += new System.EventHandler(this.btnPhong301_Click);
            // 
            // btnPhong302
            // 
            this.btnPhong302.Location = new System.Drawing.Point(133, 19);
            this.btnPhong302.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhong302.Name = "btnPhong302";
            this.btnPhong302.Size = new System.Drawing.Size(95, 54);
            this.btnPhong302.TabIndex = 155;
            this.btnPhong302.Text = "Phòng 302";
            // 
            // btnPhong201
            // 
            this.btnPhong201.Location = new System.Drawing.Point(3, 110);
            this.btnPhong201.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhong201.Name = "btnPhong201";
            this.btnPhong201.Size = new System.Drawing.Size(95, 54);
            this.btnPhong201.TabIndex = 156;
            this.btnPhong201.Text = "Phòng 201";
            // 
            // btnPhong202
            // 
            this.btnPhong202.Location = new System.Drawing.Point(133, 110);
            this.btnPhong202.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhong202.Name = "btnPhong202";
            this.btnPhong202.Size = new System.Drawing.Size(95, 54);
            this.btnPhong202.TabIndex = 157;
            this.btnPhong202.Text = "Phòng 202";
            // 
            // btnPhong101
            // 
            this.btnPhong101.Location = new System.Drawing.Point(3, 193);
            this.btnPhong101.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhong101.Name = "btnPhong101";
            this.btnPhong101.Size = new System.Drawing.Size(95, 54);
            this.btnPhong101.TabIndex = 158;
            this.btnPhong101.Text = "Phòng 101";
            // 
            // btnPhong102
            // 
            this.btnPhong102.Location = new System.Drawing.Point(133, 193);
            this.btnPhong102.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhong102.Name = "btnPhong102";
            this.btnPhong102.Size = new System.Drawing.Size(95, 54);
            this.btnPhong102.TabIndex = 159;
            this.btnPhong102.Text = "Phòng 102";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnPhong303);
            this.panel1.Controls.Add(this.btnPhong203);
            this.panel1.Controls.Add(this.btnPhong103);
            this.panel1.Controls.Add(this.btnPhong102);
            this.panel1.Controls.Add(this.btnPhong101);
            this.panel1.Controls.Add(this.btnPhong202);
            this.panel1.Controls.Add(this.btnPhong201);
            this.panel1.Controls.Add(this.btnPhong302);
            this.panel1.Controls.Add(this.btnPhong301);
            this.panel1.Location = new System.Drawing.Point(20, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 277);
            this.panel1.TabIndex = 153;
            // 
            // btnPhong303
            // 
            this.btnPhong303.Location = new System.Drawing.Point(271, 19);
            this.btnPhong303.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhong303.Name = "btnPhong303";
            this.btnPhong303.Size = new System.Drawing.Size(95, 54);
            this.btnPhong303.TabIndex = 162;
            this.btnPhong303.Text = "Phòng 303";
            // 
            // btnPhong203
            // 
            this.btnPhong203.Location = new System.Drawing.Point(271, 110);
            this.btnPhong203.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhong203.Name = "btnPhong203";
            this.btnPhong203.Size = new System.Drawing.Size(95, 54);
            this.btnPhong203.TabIndex = 161;
            this.btnPhong203.Text = "Phòng 203";
            // 
            // btnPhong103
            // 
            this.btnPhong103.Location = new System.Drawing.Point(271, 193);
            this.btnPhong103.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhong103.Name = "btnPhong103";
            this.btnPhong103.Size = new System.Drawing.Size(95, 54);
            this.btnPhong103.TabIndex = 160;
            this.btnPhong103.Text = "Phòng 102";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButtonChangeStatus);
            this.groupBox1.Controls.Add(this.simpleButton3);
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.simpleButton4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(300, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(859, 379);
            this.groupBox1.TabIndex = 155;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý sơ đồ phòng";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(887, 22);
            this.statusStrip1.TabIndex = 156;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frm_quanlysodophong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_quanlysodophong";
            this.Text = "Quản lý sơ đồ phòng";
            this.Load += new System.EventHandler(this.frm_quanlysodophong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trangthaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Succhua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sophong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonChangeStatus;
        private DevExpress.XtraEditors.SimpleButton btnPhong301;
        private DevExpress.XtraEditors.SimpleButton btnPhong302;
        private DevExpress.XtraEditors.SimpleButton btnPhong201;
        private DevExpress.XtraEditors.SimpleButton btnPhong202;
        private DevExpress.XtraEditors.SimpleButton btnPhong101;
        private DevExpress.XtraEditors.SimpleButton btnPhong102;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnPhong303;
        private DevExpress.XtraEditors.SimpleButton btnPhong203;
        private DevExpress.XtraEditors.SimpleButton btnPhong103;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}