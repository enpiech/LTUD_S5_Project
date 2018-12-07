using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace BusStation
{
    public partial class frmBanVe : Form
    {
        DB db = new DB();

        public frmBanVe()
        {
            InitializeComponent();
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control) sender;
            if (KiemTraNhapLieu.laChuoi(txtTenKH.Text))
            {
                errorProvider1.SetError(ctrl, ThongBao.duLieuKhongPhuHop);
                txtTenKH.Clear();
                txtTenKH.Focus();
            }
            else if(txtTenKH.Text.Length == 0)
            {
                errorProvider1.SetError(ctrl, "vui lòng nhập tên khách hàng");
                txtTenKH.Clear();
                txtTenKH.Focus();
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (KiemTraNhapLieu.laSoNguyen(txtCMND.Text))
            {
                errorProvider1.SetError(txtCMND, "không được nhập chữ");
                txtCMND.Clear();
                txtCMND.Focus();
            }
            else if (txtCMND.Text.Length == 0)
            {
                errorProvider1.SetError(ctrl, "vui lòng nhập tên khách hàng");
                txtCMND.Clear();
                txtCMND.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (KiemTraNhapLieu.laSoNguyen(txtSoDienThoai.Text))
            {
                errorProvider1.SetError(txtSoDienThoai, "không được nhập chữ");
                txtCMND.Clear();
                txtCMND.Focus();
            }
            else if (txtSoDienThoai.Text.Length == 0)
            {
                errorProvider1.SetError(ctrl, "vui lòng nhập tên khách hàng");
                txtSoDienThoai.Clear();
                txtSoDienThoai.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnMuaVe_Click(object sender, FormClosingEventArgs e)
        {
            string tenKH = txtTenKH.Text.Trim();
            string cmnd = txtCMND.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string hangXe = cboHangXe.Text.Trim();
            string loaiXe = cboLoaiXe.Text.Trim();
            int soGhe = Convert.ToInt32(cboGhe.Text.Trim());

            string kq = "Họ Tên " + tenKH 
                + "\nSố CMND " + cmnd
                + "\n Số Điện Thoại " + sdt
                + "\nHãng Xe " + hangXe 
                + "\nLoại Xe" + loaiXe
                + "\nSố Ghế" + soGhe;

            DialogResult r;
            r = MessageBox.Show(kq.ToString(), "Thông Báo", MessageBoxButtons.YesNo);
            if(r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void MuaVe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn muốn thoát", "Thoát Chương Trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại
            this.Close();
        }

        private void btnMuaVe_Click(object sender, EventArgs e)
        {
            string tenKH = txtTenKH.Text.Trim();
            string cmnd = txtCMND.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string hangXe = cboHangXe.Text.Trim();
            string loaiXe = cboLoaiXe.Text.Trim();
            string soGhe = cboGhe.Text.Trim();

            string kq = "Thông Tin Khách Hàng\n";
            kq += "Họ Tên " + tenKH 
                + "\nSố CMND " + cmnd 
                + "\nSố Điện Thoại " + sdt 
                + "\nThông Tin Vé Xe\n"
                + "\nHãng Xe " + hangXe 
                + "\nLoại Xe " + loaiXe 
                + "\nSố Ghế" + soGhe;

            DialogResult r;
            r = MessageBox.Show(kq.ToString(), "Thông Báo", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                MessageBox.Show("Mua Vé Thành Công");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tenKH = txtTenKH.Text.Trim();
            string cmnd = txtCMND.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string hangXe = cboHangXe.Text.Trim();
            string loaiXe = cboLoaiXe.Text.Trim();
            string soGhe = cboGhe.Text.Trim();
      
        }

        private void frmBanVe_Load(object sender, EventArgs e)
        {
            //gọi hàm để hiển thị
            dataGridView1.DataSource = db.layDuLieuTuBang("HangXe");
        }  
    }
}
