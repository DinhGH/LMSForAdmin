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
    public partial class frm_phongcandondep : DevExpress.XtraEditors.XtraForm
    {
        public frm_phongcandondep()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu không có dòng nào được chọn
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy dòng hiện tại
                DataGridViewRow currentRow = dataGridView1.CurrentRow;

                // Kiểm tra nếu dòng là New Row
                if (currentRow.IsNewRow)
                {
                    MessageBox.Show("Không thể xóa dòng trống (New Row)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận xóa
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Xóa dòng
                    dataGridView1.Rows.Remove(currentRow);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int lastWarehouseCode = 0;  // Biến lưu trữ mã kho hàng cuối cùng

        // Hàm sinh mã kho hàng mới
        private string GenerateWarehouseCode()
        {
            lastWarehouseCode++;  // Tăng mã kho hàng cuối cùng lên 1
            return lastWarehouseCode.ToString("D2");  // Đảm bảo mã kho hàng luôn có 2 chữ số (01, 02, ...)
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Tạo mã kho hàng tự động bằng cách gọi hàm GenerateWarehouseCode
            string maphong = GenerateWarehouseCode();  // Mã kho hàng tự động
            // Lấy thông tin từ các điều khiển
            string ghichu = textBox1.Text;
            string tinhtrang = comboBox1.SelectedItem.ToString();
            DateTime thoigianbatdaudon = dateTimePicker1.Value;
            string nhanvien = textBox6.Text;
            DateTime thoigianhoanthanh = dateTimePicker2.Value;

            // Thêm dữ liệu vào DataGridView
            dataGridView1.Rows.Add(maphong, ghichu, thoigianbatdaudon, tinhtrang, nhanvien, thoigianhoanthanh);

            // Xóa dữ liệu đã nhập sau khi thêm
            textBox1.Clear();
            textBox6.Clear();
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }


        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy chỉ số dòng đã chọn
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                // Cập nhật thông tin
                dataGridView1.Rows[rowIndex].Cells["Ghichu"].Value = textBox1.Text;
                dataGridView1.Rows[rowIndex].Cells["Tinhtrangphong"].Value = comboBox1.SelectedItem.ToString();
                dataGridView1.Rows[rowIndex].Cells["Thoigianbatdaudon"].Value = dateTimePicker1.Value;
                dataGridView1.Rows[rowIndex].Cells["Nhanviendondep"].Value = textBox6.Text;
                dataGridView1.Rows[rowIndex].Cells["Thoigianhoanthanh"].Value = dateTimePicker2.Value;
            }
            else
            {
                MessageBox.Show("Hãy chọn một dòng để sửa.");
            }
        }

    }
}