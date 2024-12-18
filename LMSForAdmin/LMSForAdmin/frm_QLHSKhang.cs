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
    public partial class frm_QLHSKHang : DevExpress.XtraEditors.XtraForm
    {
        public frm_QLHSKHang()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            // Kiểm tra các ô có rỗng không
            if (string.IsNullOrWhiteSpace(txtTenKH.Text) ||
                string.IsNullOrWhiteSpace(txtCCCD.Text) ||
                string.IsNullOrWhiteSpace(txtMaDatPhong.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(cmbThanhToan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cập nhật dữ liệu của hàng đang chọn
            if (dtKhachHang.CurrentRow != null)
            {
                DataGridViewRow row = dtKhachHang.CurrentRow;

                row.Cells["TenKH"].Value = txtTenKH.Text;
                row.Cells["SoCCCD"].Value = txtCCCD.Text;
                row.Cells["MaDatPhong"].Value = txtMaDatPhong.Text;
                row.Cells["SoDT"].Value = txtSDT.Text;
                row.Cells["Email"].Value = txtEmail.Text;
                row.Cells["NgayDat"].Value = dtpNgayDat.Value;
                row.Cells["NgayTra"].Value = dtpNgayTra.Value;
                row.Cells["TinhTrangThanhToan"].Value = cmbThanhToan.Text;

                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (dtKhachHang.SelectedRows.Count > 0)
            {
                // Hỏi người dùng có chắc chắn muốn xóa không
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này không?",
                                                       "Xác nhận xóa",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Xóa hàng được chọn
                    foreach (DataGridViewRow row in dtKhachHang.SelectedRows)
                    {
                        if (!row.IsNewRow) // Không cho phép xóa dòng mới (trống)
                        {
                            dtKhachHang.Rows.Remove(row);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Kiểm tra các ô có rỗng không
            if (string.IsNullOrWhiteSpace(txtTenKH.Text) ||
                string.IsNullOrWhiteSpace(txtCCCD.Text) ||
                string.IsNullOrWhiteSpace(txtMaDatPhong.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(cmbThanhToan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thêm dữ liệu vào DataTable
            dtKhachHang.Rows.Add(
                txtTenKH.Text,
                txtCCCD.Text,
                txtMaDatPhong.Text,
                txtSDT.Text,
                txtEmail.Text,
                dtpNgayDat.Value,
                dtpNgayTra.Value,
                cmbThanhToan.Text
            );

            MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đảm bảo không chọn tiêu đề cột
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtKhachHang.Rows[e.RowIndex];

                txtTenKH.Text = row.Cells["TenKH"].Value?.ToString();
                txtCCCD.Text = row.Cells["SoCCCD"].Value?.ToString();
                txtMaDatPhong.Text = row.Cells["MaDatPhong"].Value?.ToString();
                txtSDT.Text = row.Cells["SoDT"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                dtpNgayDat.Value = row.Cells["NgayDat"].Value != null
                    ? Convert.ToDateTime(row.Cells["NgayTra"].Value)
                    : DateTime.Now;
                dtpNgayTra.Value = row.Cells["NgayTra"].Value != null
                    ? Convert.ToDateTime(row.Cells["NgayTra"].Value)
                    : DateTime.Now;
                cmbThanhToan.Text = row.Cells["TinhTrangThanhToan"].Value?.ToString();
            }
        }

        private void frm_QLHSKHang_Load(object sender, EventArgs e)
        {
            dtKhachHang.CellClick += dataGridView1_CellClick;
        }

        private void dtKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}