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

using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LMSForAdmin
{
    public partial class frm_xuathang : DevExpress.XtraEditors.XtraForm
    {
        public frm_xuathang()
        {
            InitializeComponent();
        }

        // Event handler khi form được load
        private void frm_xuathang_Load(object sender, EventArgs e)
        {
       
        }

        private int lastWarehouseCode = 0;  // Biến lưu trữ mã kho hàng cuối cùng

        // Hàm sinh mã kho hàng mới
        private string GenerateWarehouseCode()
        {
            lastWarehouseCode++;  // Tăng mã kho hàng cuối cùng lên 1
            return lastWarehouseCode.ToString("D2");  // Đảm bảo mã kho hàng luôn có 2 chữ số (01, 02, ...)
        }

        // Event handler khi bấm nút "Xuất kho"
        // Event handler khi bấm nút "Xuất kho"
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string itemName = textEdit1.Text; // Lấy tên mặt hàng
            string unit = textEdit2.Text; // Lấy đơn vị đo lường
            int quantity;
            bool isQuantityValid = int.TryParse(textEdit3.Text, out quantity); // Kiểm tra số lượng có hợp lệ không
            DateTime importDate = dateTimePicker1.Value; // Lấy ngày nhập hàng

            if (dataGridViewCheckOut.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dataGridViewCheckOut.SelectedRows[0];

                string rowItemName = selectedRow.Cells["Tenmathang"].Value?.ToString();
                int currentQuantity = Convert.ToInt32(selectedRow.Cells["SL"].Value);

                // Kiểm tra nếu mặt hàng trong dòng được chọn có tên khớp với tên mặt hàng nhập vào
                if (itemName == rowItemName)
                {
                    if (isQuantityValid && quantity <= currentQuantity)
                    {
                        // Trừ số lượng xuất kho từ số lượng hiện có
                        selectedRow.Cells["SL"].Value = currentQuantity - quantity;

                        // Cập nhật thông tin xuất kho (Ngày nhập hàng)
                        selectedRow.Cells["Ngaynhaphang"].Value = importDate.ToString("dd MMMM yyyy");

                        MessageBox.Show("Hàng đã được xuất kho thành công.");
                    }
                    else if (quantity > currentQuantity)
                    {
                        MessageBox.Show("Số lượng xuất kho vượt quá số lượng hiện có.");
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập số lượng hợp lệ.");
                    }
                }
                else
                {
                    MessageBox.Show("Tên mặt hàng không khớp với mặt hàng được chọn trong kho.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xuất kho.");
            }
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

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewCheckOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




