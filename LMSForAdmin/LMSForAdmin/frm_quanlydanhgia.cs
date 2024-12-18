using System;
using System.Windows.Forms;

namespace LMSForAdmin
{
    public partial class frm_quanlydanhgia : Form
    {
        private int maDanhGiaCounter = 1; // Số tự động tăng cho mã đánh giá

        public frm_quanlydanhgia()
        {
            InitializeComponent();
        }

        // Nút Thêm
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Tạo mã đánh giá tự động
            string maDanhGia = "DG" + maDanhGiaCounter.ToString("D3");
            string maPhong = "P" + (dataGridView1.Rows.Count + 1).ToString("D3"); // Tạo mã phòng tự động

            // Thêm dữ liệu vào DataGridView
            dataGridView1.Rows.Add(maDanhGia, maPhong, txtTenKhachHang.Text, txtDanhGia.Text, txtYkien.Text, dtpThoiGianDanhGia.Value.ToString("dd/MM/yyyy"));

            maDanhGiaCounter++; // Tăng chỉ số mã đánh giá

            MessageBox.Show("Đã thêm đánh giá!");
        }

        // Nút Sửa
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy chỉ số dòng đã chọn
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                // Cập nhật dữ liệu trong các cột tương ứng
                dataGridView1.Rows[rowIndex].Cells[2].Value = txtTenKhachHang.Text; // Cột Tên Khách Hàng
                dataGridView1.Rows[rowIndex].Cells[3].Value = txtDanhGia.Text;      // Cột Đánh Giá
                dataGridView1.Rows[rowIndex].Cells[4].Value = txtYkien.Text;        // Cột Ý Kiến Khách Hàng
                dataGridView1.Rows[rowIndex].Cells[5].Value = dtpThoiGianDanhGia.Value.ToString("dd/MM/yyyy"); // Cột Thời Gian Đánh Giá

                MessageBox.Show("Đã sửa đánh giá!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để sửa!");
            }
        }


        // Nút Xóa
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

        // Nút Thoát
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng cửa sổ hiện tại
        }

        private void txtDanhGia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
