using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LMSForAdmin
{
    public partial class frm_sodophong : DevExpress.XtraEditors.XtraForm
    {
        public frm_sodophong()
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

        // Xử lý nút "Thoát"
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();  // Đóng form
        }
    }
}
