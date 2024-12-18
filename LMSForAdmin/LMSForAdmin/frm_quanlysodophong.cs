using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Drawing;
using DevExpress.XtraEditors;

namespace LMSForAdmin
{
    public partial class frm_quanlysodophong : Form
    {
        private Dictionary<string, DevExpress.XtraEditors.SimpleButton> roomButtons;

        public frm_quanlysodophong()
        {
            InitializeComponent();
        }

        private void frm_quanlysodophong_Load(object sender, EventArgs e)
        {
            // Ánh xạ số phòng với các nút
            roomButtons = new Dictionary<string, DevExpress.XtraEditors.SimpleButton>
            {
                { "101", btnPhong101 },
                { "102", btnPhong102 },
                { "103", btnPhong103 },
                { "201", btnPhong201 },
                { "202", btnPhong202 },
                { "203", btnPhong203 },
                { "301", btnPhong301 },
                { "302", btnPhong302 },
                { "303", btnPhong303 }

            };
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            comboBox1.SelectedItem = null; // Reset trạng thái
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string soPhong = textBox1.Text.Trim(); // Lấy số phòng từ textBox và loại bỏ khoảng trắng
            string sucChua = textBox3.Text.Trim(); // Lấy sức chứa
            string trangThai = comboBox1.SelectedItem?.ToString() ?? ""; // Lấy trạng thái, nếu không có chọn thì để trống

            // Kiểm tra nếu số phòng hợp lệ và không phải là null hoặc chuỗi rỗng
            if (string.IsNullOrEmpty(soPhong) || !roomButtons.ContainsKey(soPhong))
            {
                MessageBox.Show("Số phòng không hợp lệ. Vui lòng nhập lại.");
                return;
            }

            // Kiểm tra nếu trạng thái phòng được chọn
            if (string.IsNullOrEmpty(trangThai))
            {
                MessageBox.Show("Vui lòng chọn trạng thái phòng.");
                return;
            }

            // Kiểm tra nếu số phòng đã có trong DataGridView rồi
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Sophong"].Value?.ToString() == soPhong)
                {
                    MessageBox.Show("Số phòng đã tồn tại trong danh sách. Vui lòng nhập số phòng khác.");
                    return;
                }
            }

            // Thêm thông tin vào bảng dữ liệu (DataGridView)
            dataGridView1.Rows.Add(soPhong, sucChua, trangThai);

            // Cập nhật màu cho nút phòng tương ứng
            UpdateRoomButtonColors();
        }

        private void UpdateRoomButtonColors()
        {
            // Duyệt qua từng dòng trong DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string soPhong = row.Cells["Sophong"].Value?.ToString();
                string trangThai = row.Cells["Trangthaiphong"].Value?.ToString();

                // Kiểm tra xem số phòng có hợp lệ và có trong danh sách roomButtons hay không
                if (string.IsNullOrEmpty(soPhong)) continue; // Bỏ qua nếu số phòng là null hoặc rỗng

                SimpleButton roomButton = GetRoomButton(soPhong);
                if (roomButton != null)
                {
                    // Sử dụng Appearance.BackColor để thay đổi màu nền
                    switch (trangThai)
                    {
                        case "Có sẵn":
                            roomButton.Appearance.BackColor = Color.Green;
                            break;
                        case "Có người ở":
                            roomButton.Appearance.BackColor = Color.Red;
                            break;
                        case "Đang hoạt động":
                            roomButton.Appearance.BackColor = Color.Yellow;
                            break;
                        default:
                            roomButton.Appearance.BackColor = Color.Gray;
                            break;
                    }

                    // Đảm bảo rằng UseBackColor được đặt là true
                    roomButton.Appearance.Options.UseBackColor = true;
                }
            }
        }

        private DevExpress.XtraEditors.SimpleButton GetRoomButton(string soPhong)
        {
            // Kiểm tra và trả về nút phòng từ dictionary
            if (string.IsNullOrEmpty(soPhong)) return null; // Tránh gọi TryGetValue nếu soPhong là null hoặc rỗng

            if (roomButtons.TryGetValue(soPhong, out DevExpress.XtraEditors.SimpleButton btn))
            {
                return btn;
            }

            MessageBox.Show("Button không tồn tại cho số phòng: " + soPhong);
            return null;
        }


        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonChangeStatus_Click(object sender, EventArgs e)
        {
            string soPhong = textBox1.Text.Trim(); // Lấy số phòng từ textBox
            string trangThaiMoi = comboBox1.SelectedItem?.ToString() ?? ""; // Lấy trạng thái mới từ comboBox

            // Kiểm tra nếu số phòng hợp lệ và không phải là null hoặc chuỗi rỗng
            if (string.IsNullOrEmpty(soPhong) || !roomButtons.ContainsKey(soPhong))
            {
                MessageBox.Show("Số phòng không hợp lệ. Vui lòng nhập lại.");
                return;
            }

            // Kiểm tra nếu trạng thái phòng được chọn
            if (string.IsNullOrEmpty(trangThaiMoi))
            {
                MessageBox.Show("Vui lòng chọn trạng thái phòng.");
                return;
            }

            // Cập nhật trạng thái trong DataGridView
            bool found = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Sophong"].Value?.ToString() == soPhong)
                {
                    row.Cells["Trangthaiphong"].Value = trangThaiMoi;
                    found = true;
                    break;
                }
            }

            if (found)
            {
                // Cập nhật màu cho nút phòng tương ứng
                UpdateRoomButtonColors();
                MessageBox.Show($"Trạng thái của phòng {soPhong} đã được thay đổi.");
            }
            else
            {
                MessageBox.Show("Số phòng không tồn tại trong danh sách.");
            }
        }

        private void btnPhong301_Click(object sender, EventArgs e)
        {

        }
    }
}
