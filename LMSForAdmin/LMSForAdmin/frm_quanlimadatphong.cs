using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QRCoder;

namespace LMSForAdmin
{
    public partial class frm_quanlimadatphong : Form
    {
        public frm_quanlimadatphong()
        {
            InitializeComponent();
        }

        // Hàm tạo mã đặt phòng ngẫu nhiên
        private string GenerateBookingCode()
        {
            return "BP" + Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
        }

        // Hàm tạo mã QR cho mã đặt phòng
        private void GenerateQRCode(string bookingCode)
        {
            string qrContent = $"Mã đặt phòng: {bookingCode}, Tên khách hàng: {textBox3.Text},Giá phòng :{textBox2.Text}, Ngày nhận phòng: {dateTimePicker1.Value.ToString("dd/MM/yyyy")}, Ngày trả phòng: {dateTimePicker2.Value.ToString("dd/MM/yyyy")}";

            // Tạo đối tượng QRCodeGenerator
            QRCodeGenerator qrGenerator = new QRCodeGenerator();

            // Tạo mã QR
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrContent, QRCodeGenerator.ECCLevel.Q); // Mức độ sửa lỗi Q
            QRCode qrCode = new QRCode(qrCodeData);

            // Vẽ mã QR thành hình ảnh (bitmap)
            Bitmap qrBitmap = qrCode.GetGraphic(5);

            // Lưu mã QR dưới dạng hình ảnh
            string filePath = Path.Combine(Application.StartupPath, "QRCodeImages", $"{bookingCode}_QR.png");
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));  // Đảm bảo thư mục tồn tại
            qrBitmap.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

            // Hiển thị mã QR trong PictureBox
            pictureBoxQRCode.Image = qrBitmap;
        }

        // Xử lý sự kiện khi bấm nút "Thêm"
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string bookingCode = GenerateBookingCode();  // Tạo mã đặt phòng
            GenerateQRCode(bookingCode);  // Tạo và hiển thị mã QR

            // Thêm mã đặt phòng và thông tin vào DataGridView
            dataGridView1.Rows.Add(
                bookingCode,                     // Mã đặt phòng
                textBox1.Text,                   // Loại phòng
                textBox3.Text,                   // Tên khách hàng
                dateTimePicker1.Value.ToString("dd/MM/yyyy HH:mm"),  // Thời gian đặt phòng
                textBox2.Text,                   // Giá phòng
                dateTimePicker2.Value.ToString("dd/MM/yyyy HH:mm")   // Thời gian trả phòng
            );

            MessageBox.Show("Mã QR cho đặt phòng đã được tạo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Xử lý sự kiện khi bấm nút "Sửa"
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            // Cập nhật mã QR cho mã đặt phòng đã có trong DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string bookingCode = selectedRow.Cells["Madatphong"].Value.ToString();
                GenerateQRCode(bookingCode);  // Tạo lại mã QR

                MessageBox.Show("Mã QR đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Xử lý sự kiện khi bấm nút "Xoá"
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

        // Xử lý sự kiện khi bấm nút "Thoát"
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxQRCode_Click(object sender, EventArgs e)
        {

        }
    }
}
