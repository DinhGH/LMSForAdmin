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
    public partial class frm_quanlibcsc : DevExpress.XtraEditors.XtraForm
    {
        public frm_quanlibcsc()
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

        // Xử lý nút "Thêm"
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string requestCode = GenerateWarehouseCode();  // Sinh mã yêu cầu tự động

            // Thêm dòng mới với mã yêu cầu tự động và thông tin từ các ô nhập liệu
            dataGridView1.Rows.Add(
                requestCode,  // Mã yêu cầu được sinh tự động
                textBox1.Text, // Mô tả yêu cầu
                textBox2.Text, // Phòng cần dịch vụ
                textBox3.Text, // Tên khách hàng
                dateTimePicker1.Value.ToString("dd/MM/yyyy HH:mm"), // Thời gian yêu cầu
                comboBox1.SelectedItem?.ToString() ?? "Đang chờ xử lý", // Trạng thái
                textBox6.Text, // Nhân viên xử lý
                dateTimePicker2.Value.ToString("dd/MM/yyyy HH:mm") // Thời gian hoàn thành
            );

            MessageBox.Show("Thêm yêu cầu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Xử lý nút "Sửa"
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dataGridView1.CurrentRow;

            row.Cells["Motasuco"].Value = textBox1.Text;
            row.Cells["Phongxayrasuco"].Value = textBox2.Text;
            row.Cells["Nguoibaocao"].Value = textBox3.Text;
            row.Cells["Thoigianxayrasuco"].Value = dateTimePicker1.Value.ToString("dd/MM/yyyy HH:mm");
            row.Cells["Trangthai"].Value = comboBox1.SelectedItem?.ToString() ?? "Đang chờ xử lý";
            row.Cells["Nhanvienxuly"].Value = textBox6.Text;
            row.Cells["Thoigianhoanthanh"].Value = dateTimePicker2.Value.ToString("dd/MM/yyyy HH:mm");

            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Xử lý nút "Xóa"
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



        // Xử lý nút "Thoát"
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
