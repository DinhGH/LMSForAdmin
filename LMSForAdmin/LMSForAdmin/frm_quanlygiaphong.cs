using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSForAdmin
{
    public partial class frm_quanlygiaphong : Form
    {
        public frm_quanlygiaphong()
        {
            InitializeComponent();
        }
        private int lastRequestCode = 0;  // Biến lưu trữ mã yêu cầu cuối cùng

        // Hàm sinh mã yêu cầu mới
        private string GenerateWarehouseCode()
        {
            lastRequestCode++;  // Tăng mã kho hàng cuối cùng lên 1
            return lastRequestCode.ToString("D2");  // Đảm bảo mã kho hàng luôn có 2 chữ số (01, 02, ...)
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các trường
                string requestCode = GenerateWarehouseCode();
                string loaiPhong = textBox1.Text.Trim();
                string giaTieuChuan = textBox3.Text.Trim();
                string giaKhuyenMai = textBox2.Text.Trim();
                DateTime ngayBatDau = dateTimePicker1.Value;
                DateTime ngayKetThuc = dateTimePicker2.Value;

                // Thêm vào DataGridView
                dataGridView1.Rows.Add(requestCode, loaiPhong, giaTieuChuan, giaKhuyenMai, ngayBatDau, ngayKetThuc);

                // Reset các trường nhập liệu
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;

                MessageBox.Show("Thêm mới thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi");
            }
        }


        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Lấy dòng được chọn
                DataGridViewRow row = dataGridView1.CurrentRow;

                // Cập nhật dữ liệu
                row.Cells["Loaiphong"].Value = textBox1.Text.Trim();
                row.Cells["Giatieuchaun"].Value = textBox3.Text.Trim();
                row.Cells["Giakhuyenmai"].Value = textBox2.Text.Trim();
                row.Cells["Ngaybatdau"].Value = dateTimePicker1.Value;
                row.Cells["Ngayketthuc"].Value = dateTimePicker2.Value;

                MessageBox.Show("Cập nhật thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!", "Thông báo");
            }
        }


        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow currentRow = dataGridView1.CurrentRow;

                if (currentRow.IsNewRow)
                {
                    MessageBox.Show("Không thể xóa dòng trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dataGridView1.Rows.Remove(currentRow);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý nút "Thoát"
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();  // Đóng form
        }
    }
}
