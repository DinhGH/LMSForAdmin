using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LMSForAdmin
{
    public partial class frm_QLAccount : DevExpress.XtraEditors.XtraForm
    {
        public frm_QLAccount()
        {
            InitializeComponent();
        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text) ||
                   string.IsNullOrWhiteSpace(txtMatKhau.Text) ||
                   string.IsNullOrWhiteSpace(txtEmail.Text) ||
                   string.IsNullOrWhiteSpace(comboTinhTrang.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thêm dữ liệu mới vào DataTable
            dataTable.Rows.Add(txtTenDangNhap.Text, txtMatKhau.Text, txtEmail.Text, comboTinhTrang.Text);

            // Xóa dữ liệu nhập
            ClearFields();
        }
        private void ClearFields()
        {
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtEmail.Clear();
            comboTinhTrang.EditValue = null;
        }

        // Sự kiện chọn hàng trên DataGridView
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataTable.SelectedRows[0];
                txtTenDangNhap.Text = selectedRow.Cells["TenDangNhap"].Value?.ToString();
                txtMatKhau.Text = selectedRow.Cells["MatKhau"].Value?.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value?.ToString();
                comboTinhTrang.Text = selectedRow.Cells["TinhTrang"].Value?.ToString();
            }
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (dataTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hàng để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhau.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(comboTinhTrang.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy hàng được chọn
            DataGridViewRow selectedRow = dataTable.SelectedRows[0];

            // Cập nhật dữ liệu hàng
            selectedRow.Cells["TenDangNhap"].Value = txtTenDangNhap.Text;
            selectedRow.Cells["MatKhau"].Value = txtMatKhau.Text;
            selectedRow.Cells["Email"].Value = txtEmail.Text;
            selectedRow.Cells["TinhTrang"].Value = comboTinhTrang.Text;

            // Xóa dữ liệu nhập
            ClearFields();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dataTable.SelectedRows.Count > 0)
            {
                // Hỏi người dùng có chắc chắn muốn xóa không
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này không?",
                                                       "Xác nhận xóa",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Xóa hàng được chọn
                    foreach (DataGridViewRow row in dataTable.SelectedRows)
                    {
                        if (!row.IsNewRow) // Không cho phép xóa dòng mới (trống)
                        {
                            dataTable.Rows.Remove(row);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frm_QLAccount_Load(object sender, EventArgs e)
        {
            dataTable.CellClick += dataGridView1_SelectionChanged;
        }
    }
}