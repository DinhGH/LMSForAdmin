using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace LMSForAdmin
{
    public partial class Home_admin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private frm_dschecked_in frmCheckIn;
        private frm_dsdatphong frmDSDatPhong;
        private frm_dscheck_out frmCheckOut;
        private frm_qldichvu frmQldichvu;
        private frm_qldsphongdat frmQlPhongdat;
        private frm_qldsphongtrong frmQlPhongtrong;
        private frm_inhoadon frm_Inhoadon;
        private frm_kiemtramdp frmKtraMDP;
        private frm_QLAccount frmQlAccount;
        private frm_QLRooms frmQlRooms;
        private frm_QLHSKHang frmQLHSKH;
        private frm_QLHSNvien frmQLHSNV;
        private frm_Quanlykho frmQuanlykho;
        private frm_quanlimadatphong frm_Quanlimadatphong;
        private frm_quanlidoanhthu frmQuanlidoanhthu;
        private frm_quanlydanhgia frmQuanlydanhgia;
        private frm_quanlysodophong frm_Quanlysodophong;
        private frm_quanlygiaphong frm_Quanlygiaphong;
        private frm_nhaphang nhaphang;
        private frm_xuathang xuathang;
        private frm_quanlibcsc frm_Quanlibcsc1;
        private frm_dsycdv frm_Dsycdv1;
        private frm_phongcandondep frm_phongcandondep1;
        private frm_sodophong sodophong;
        private frm_CancellationRoom frmHuyPhong;
        public Home_admin()
        {
            InitializeComponent();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenOrActivateForm(ref sodophong);
        }
        private void OpenOrActivateForm<T>(ref T formInstance) where T : Form, new()
        {
            if (formInstance == null || formInstance.IsDisposed)
            {
                // Tạo mới nếu form chưa tồn tại hoặc đã bị đóng
                formInstance = new T { MdiParent = this };
                formInstance.Show();
            }
            else
            {
                // Nếu đã mở, kích hoạt lại
                formInstance.Activate();
            }
        }
        private void Home_admin_Load(object sender, EventArgs e)
        {

        }

        private void imageEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenOrActivateForm(ref frm_phongcandondep1);
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenOrActivateForm(ref frm_Dsycdv1);

        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenOrActivateForm(ref frm_Quanlibcsc1);
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenOrActivateForm(ref xuathang);
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenOrActivateForm(ref nhaphang);
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {

            OpenOrActivateForm(ref frmKtraMDP);
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenOrActivateForm(ref frmDSDatPhong);

        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {

            OpenOrActivateForm(ref frmCheckIn);
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {

            OpenOrActivateForm(ref frmCheckOut);

        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            
            OpenOrActivateForm(ref frmQlPhongtrong);
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {

            OpenOrActivateForm(ref frmQlPhongdat);
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            
            OpenOrActivateForm(ref frmQldichvu);
        }

        private void I_ItemClick(object sender, ItemClickEventArgs e)
        {

            OpenOrActivateForm(ref frm_Inhoadon);
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenOrActivateForm(ref frmQlAccount);
        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenOrActivateForm(ref frmQlRooms);
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenOrActivateForm(ref frmQLHSKH);
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenOrActivateForm(ref frmQLHSNV);

        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenOrActivateForm(formInstance: ref frmQuanlykho);
        }

        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenOrActivateForm( ref frm_Quanlimadatphong);
        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenOrActivateForm(ref frmQuanlydanhgia);
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenOrActivateForm(ref frm_Quanlysodophong);
        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenOrActivateForm(ref frmQuanlidoanhthu);
        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenOrActivateForm(ref frm_Quanlygiaphong);
        }

        private void barButtonItem29_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenOrActivateForm(ref frmHuyPhong);
        }
    }
    }