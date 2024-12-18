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
    public partial class frm_quanlidoanhthu : Form
    {
        public frm_quanlidoanhthu()
        {
            InitializeComponent();
        }

        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các trường nhập liệu
            string invoiceID = textBoxInvoiceID.Text;
            string invoiceDate = dateTimePickerInvoiceDate.Value.ToString("dd/MM/yyyy");
            string customerName = textBoxCustomerName.Text;
            string roomNumber = textBoxRoomNumber.Text;
            string amount = textBoxAmount.Text;

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(invoiceID) || string.IsNullOrEmpty(customerName) ||
                string.IsNullOrEmpty(roomNumber) || string.IsNullOrEmpty(amount))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm dữ liệu vào DataGridView
            dataGridView1.Rows.Add(invoiceID, invoiceDate, customerName, roomNumber, amount);

            // Xóa trắng các trường nhập liệu sau khi thêm
            ClearInputFields();
        }

        private void simpleButtonEdit_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy hàng được chọn
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // Cập nhật dữ liệu từ các trường nhập liệu
            selectedRow.Cells["InvoiceID"].Value = textBoxInvoiceID.Text;
            selectedRow.Cells["InvoiceDate"].Value = dateTimePickerInvoiceDate.Value.ToString("dd/MM/yyyy");
            selectedRow.Cells["CustomerName"].Value = textBoxCustomerName.Text;
            selectedRow.Cells["RoomNumber"].Value = textBoxRoomNumber.Text;
            selectedRow.Cells["Amount"].Value = textBoxAmount.Text;

            // Xóa trắng các trường nhập liệu sau khi sửa
            ClearInputFields();
        }

        private void simpleButtonDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Xóa hàng được chọn
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void simpleButtonExit_Click(object sender, EventArgs e)
        {
            // Thoát ứng dụng
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ClearInputFields()
        {
            // Xóa trắng các trường nhập liệu
            textBoxInvoiceID.Text = string.Empty;
            textBoxCustomerName.Text = string.Empty;
            textBoxRoomNumber.Text = string.Empty;
            textBoxAmount.Text = string.Empty;
            dateTimePickerInvoiceDate.Value = DateTime.Now;
        }
    }
}
