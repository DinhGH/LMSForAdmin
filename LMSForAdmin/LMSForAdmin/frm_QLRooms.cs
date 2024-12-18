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
    public partial class frm_QLRooms : DevExpress.XtraEditors.XtraForm
    {
        public frm_QLRooms()
        {
            InitializeComponent();
        }

        private void textEdit5_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường không được để trống
            if (string.IsNullOrWhiteSpace(txtMaPhong.Text) ||
                string.IsNullOrWhiteSpace(txtPhongSo.Text) ||
                string.IsNullOrWhiteSpace(checkedComboTinhTrang.Text) ||
                string.IsNullOrWhiteSpace(txtTang.Text) ||
                string.IsNullOrWhiteSpace(txtDienTich.Text) ||
                string.IsNullOrWhiteSpace(txtLoaiPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thêm dữ liệu mới vào DataTable
            dataTable.Rows.Add(txtMaPhong.Text, txtPhongSo.Text, checkedComboTinhTrang.Text, txtTang.Text, txtDienTich.Text, txtLoaiPhong.Text);

            // Xóa dữ liệu nhập
            ClearFields();
        }
        private void ClearFields()
        {
            txtMaPhong.Clear();
            txtPhongSo.Clear();
            txtTang.Clear();
            txtDienTich.Clear();
            txtLoaiPhong.Clear();
            checkedComboTinhTrang.EditValue = null; // Clear CheckedComboBoxEdit
        }

        // Sự kiện chọn hàng trên DataGridView
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataTable.SelectedRows[0];
                txtMaPhong.Text = selectedRow.Cells["MaPhong"].Value?.ToString();
                txtPhongSo.Text = selectedRow.Cells["PhongSo"].Value?.ToString();
                checkedComboTinhTrang.Text = selectedRow.Cells["TinhTrang"].Value?.ToString();
                txtTang.Text = selectedRow.Cells["Tang"].Value?.ToString();
                txtDienTich.Text = selectedRow.Cells["DienTich"].Value?.ToString();
                txtLoaiPhong.Text = selectedRow.Cells["LoaiPhong"].Value?.ToString();
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dataTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hàng để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMaPhong.Text) ||
                string.IsNullOrWhiteSpace(txtPhongSo.Text) ||
                string.IsNullOrWhiteSpace(checkedComboTinhTrang.Text) ||
                string.IsNullOrWhiteSpace(txtTang.Text) ||
                string.IsNullOrWhiteSpace(txtDienTich.Text) ||
                string.IsNullOrWhiteSpace(txtLoaiPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy hàng được chọn
            DataGridViewRow selectedRow = dataTable.SelectedRows[0];

            // Cập nhật dữ liệu hàng
            selectedRow.Cells["MaPhong"].Value = txtMaPhong.Text;
            selectedRow.Cells["PhongSo"].Value = txtPhongSo.Text;
            selectedRow.Cells["TinhTrang"].Value = checkedComboTinhTrang.Text;
            selectedRow.Cells["Tang"].Value = txtTang.Text;
            selectedRow.Cells["DienTich"].Value = txtDienTich.Text;
            selectedRow.Cells["LoaiPhong"].Value = txtLoaiPhong.Text;

            // Xóa dữ liệu nhập
            ClearFields();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
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

        private void frm_QLRooms_Load(object sender, EventArgs e)
        {
            dataTable.CellClick += dataGridView1_SelectionChanged;
        }
    }
}