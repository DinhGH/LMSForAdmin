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
    public partial class frm_Quanlykho : Form
    {
        public frm_Quanlykho()
        {
            InitializeComponent();
        }
        private int lastWarehouseCode = 0;  // Biến lưu trữ mã kho hàng cuối cùng

        // Hàm sinh mã kho hàng mới
        private string GenerateWarehouseCode()
        {
            lastWarehouseCode++;  // Tăng mã kho hàng cuối cùng lên 1
            return lastWarehouseCode.ToString("D2");  // Đảm bảo mã kho hàng luôn có 2 chữ số (01, 02, ...)
        }
        // Event handler khi bấm nút "Cập nhật"
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (dataGridViewCheckOut.SelectedRows.Count > 0)
            {
                var row = dataGridViewCheckOut.SelectedRows[0];
                row.Cells["Tenmathang"].Value = textEdit1.Text;  // Cập nhật tên mặt hàng
                row.Cells["SL"].Value = textEdit3.Text;  // Cập nhật số lượng
                row.Cells["Ngaynhaphang"].Value = dateTimePicker1.Value.ToString("dd MMMM yyyy");  // Cập nhật ngày nhập hàng
                row.Cells["Donvidoluong"].Value = textEdit2.Text;  // Cập nhật đơn vị đo lường

                MessageBox.Show("Mặt hàng đã được cập nhật.");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.");
            }
        }
        // Event handler khi bấm nút "Xoá"
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (dataGridViewCheckOut.SelectedRows.Count > 0)
            {
                // Duyệt qua tất cả các dòng được chọn
                foreach (DataGridViewRow selectedRow in dataGridViewCheckOut.SelectedRows)
                {
                    // Kiểm tra xem dòng có phải là dòng mới hay không
                    if (selectedRow.Index != dataGridViewCheckOut.NewRowIndex)
                    {
                        // Xoá dòng được chọn
                        dataGridViewCheckOut.Rows.RemoveAt(selectedRow.Index);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xoá dòng trống.");
                        return;
                    }
                }
                MessageBox.Show("Mặt hàng đã được xoá.");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xoá.");
            }
        }

        // Event handler khi bấm nút "Thêm mới"
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string itemName = textEdit1.Text;
            string unit = textEdit2.Text;
            int quantity;
            bool isQuantityValid = int.TryParse(textEdit3.Text, out quantity);
            DateTime importDate = dateTimePicker1.Value;

            if (isQuantityValid && !string.IsNullOrWhiteSpace(itemName) && !string.IsNullOrWhiteSpace(unit))
            {
                // Tạo mã kho hàng tự động bằng cách gọi hàm GenerateWarehouseCode
                string warehouseCode = GenerateWarehouseCode();  // Mã kho hàng tự động

                // Thêm mặt hàng vào DataGridView với mã kho hàng tự động
                dataGridViewCheckOut.Rows.Add(new object[] { warehouseCode, itemName, quantity, importDate.ToString("dd MMMM yyyy"), unit });
                MessageBox.Show("Hàng đã được thêm vào kho.");
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
