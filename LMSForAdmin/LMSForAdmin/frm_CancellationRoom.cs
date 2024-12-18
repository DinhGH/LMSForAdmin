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
    public partial class frm_CancellationRoom : DevExpress.XtraEditors.XtraForm
    {
        public frm_CancellationRoom()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (dgvHuyPhong.SelectedRows.Count > 0)
            {
                // Hỏi người dùng có chắc chắn muốn xóa không
                DialogResult confirm = MessageBox.Show("Chấp nhận huỷ phòng ?",
                                                       "Xác nhận ",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Xóa hàng được chọn
                    foreach (DataGridViewRow row in dgvHuyPhong.SelectedRows)
                    {
                        if (!row.IsNewRow) // Không cho phép xóa dòng mới (trống)
                        {
                            dgvHuyPhong.Rows.Remove(row);
                            DialogResult ol = MessageBox.Show("Đã chấp nhận huỷ phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (dgvHuyPhong.SelectedRows.Count > 0)
            {
                // Hỏi người dùng có chắc chắn muốn xóa không
                DialogResult confirm = MessageBox.Show("Từ chối huỷ phòng ?",
                                                       "Xác nhận ",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Xóa hàng được chọn
                    foreach (DataGridViewRow row in dgvHuyPhong.SelectedRows)
                    {
                        if (!row.IsNewRow) // Không cho phép xóa dòng mới (trống)
                        {
                            dgvHuyPhong.Rows.Remove(row);
                            DialogResult ol = MessageBox.Show("Đã từ chối huỷ phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void dgvHuyPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}