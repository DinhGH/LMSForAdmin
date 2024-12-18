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
    public partial class frm_QLHSNvien : DevExpress.XtraEditors.XtraForm
    {
        public frm_QLHSNvien()
        {
            InitializeComponent();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Kiểm tra các ô có rỗng không
            if (string.IsNullOrWhiteSpace(txtTen.Text) ||
                string.IsNullOrWhiteSpace(txtCCCD.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(cmbChucVu.Text) ||
                string.IsNullOrWhiteSpace(cmbGioiTinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thêm dữ liệu vào DataTable
                 dtNhanVien.Rows.Add(
                txtTen.Text,
                txtCCCD.Text,
                cmbChucVu.Text,
                txtSDT.Text,
                txtEmail.Text,
                cmbGioiTinh.Text,
                dtpNgayBatDau.Value
            );

            MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtNhanVien.Rows[e.RowIndex];

                txtTen.Text = row.Cells["TenNV"].Value?.ToString();
                txtCCCD.Text = row.Cells["SoCCCD"].Value?.ToString();
                cmbChucVu.Text = row.Cells["ChucVu"].Value?.ToString();
                txtSDT.Text = row.Cells["SoDT"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                cmbGioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString();
                dtpNgayBatDau.Value = row.Cells["NgayBatDauLamViec"].Value != null
                    ? Convert.ToDateTime(row.Cells["NgayBatDauLamViec"].Value)
                    : DateTime.Now;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dtNhanVien.CurrentRow != null)
            {
                DataGridViewRow row = dtNhanVien.CurrentRow;

                row.Cells["TenNV"].Value = txtTen.Text;
                row.Cells["SoCCCD"].Value = txtCCCD.Text;
                row.Cells["ChucVu"].Value = cmbChucVu.Text;
                row.Cells["SoDT"].Value = txtSDT.Text;
                row.Cells["Email"].Value = txtEmail.Text;
                row.Cells["GioiTinh"].Value = cmbGioiTinh.Text;
                row.Cells["NgayBatDauLamViec"].Value = dtpNgayBatDau.Value;

                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (dtNhanVien.CurrentRow != null)
            {
                dtNhanVien.Rows.Remove(dtNhanVien.CurrentRow);
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_QLHSNvien_Load(object sender, EventArgs e)
        {
            dtNhanVien.CellClick += dataGridView1_CellClick;
        }

        private void cmbChucVu_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}