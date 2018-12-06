using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusStation
{
    public partial class frmQuanLy : Form
    {
        public frmQuanLy()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Yêu cầu xác nhận trước khi đóng form
        /// </summary>
        private void frmQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        /// <summary>
        /// Đăng xuất tài khoản nhân viên hiện tại
        /// </summary>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại
            this.Close();

        }

        /// <summary>
        /// Mở bảng khi theo lựa chọn trong combobox
        /// </summary>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string tenBang = this.cboTenBang.Text;
            if (tenBang == "Loại Xe")
            {
                ((frmMain)this.MdiParent).moForm("LoaiXe");
                //frmLoaiXe formLoaiXe = new frmLoaiXe();
                //formLoaiXe.Show();
                this.Visible = false;
            }
            else if (tenBang == "Hãng Xe")
            {
                ((frmMain)this.MdiParent).moForm("HangXe");
                //frmHangXe formHangXe = new frmHangXe();
                //formHangXe.Show();
                this.Visible = false;
            }
            else if (tenBang == "Xe")
            {
                ((frmMain)this.MdiParent).moForm("Xe");
                //frmXe formXe = new frmXe();
                //formXe.Show();
                this.Visible = false;
            }
            else if (tenBang == "Loại Nhân Viên")
            {
                ((frmMain)this.MdiParent).moForm("LoaiNhanVien");
                //frmLoaiNhanVien formLoaiNhanVien = new frmLoaiNhanVien();
                //formLoaiNhanVien.Show();
                this.Visible = false;
            }
            else if (tenBang == "Nhân Viên")
            {
                ((frmMain)this.MdiParent).moForm("NhanVien");
                //frmNhanVien formNhanVien = new frmNhanVien();
                //formNhanVien.Show();
                this.Visible = false;
            }
            else if (tenBang == "Tài Khoản Nhân Viên")
            {
                ((frmMain)this.MdiParent).moForm("TaiKhoanNhanVien");
                //frmTaiKhoanNhanVien formTaiKhoan = new frmTaiKhoanNhanVien();
                //formTaiKhoan.Show();
                this.Visible = false;
            }
            else if (tenBang == "Khách Hàng")
            {
                ((frmMain)this.MdiParent).moForm("KhachHang");
                //frmNhanVien formNhanVien = new frmNhanVien();
                //formNhanVien.Show();
                this.Visible = false;
            }
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {

        }

        private void lblTenBang_Click(object sender, EventArgs e)
        {

        }
    }
}
