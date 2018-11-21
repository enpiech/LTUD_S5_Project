using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_ketoan
{
    public partial class frmTinhTien : Form
    {
        public frmTinhTien()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnTinhPhat_Click(object sender, EventArgs e)
        {
            //vi pham nghi co phep = so lan vi pham * 50.000
            double coPhep = Convert.ToDouble(txtNghiCoPhep.Text.Trim()) * 50000;
            //vi pham ngi co phep = so lan vi pham * 200.0000
            double khongPhep = Convert.ToDouble(txtNghiKhongPhep.Text.Trim()) * 200000;
            //vi pham di tre = so lan vi pham * 50.000
            double diTre = Convert.ToDouble(txtDiTre.Text.Trim()) * 50000;
            //vi pham quen bam ca = so lan vi pham * 20.000
            double quenBamCa = Convert.ToDouble(txtQuenBamCa.Text.Trim()) * 20000;
            //vi phham su dung dien thoai = so lan vi pham * 100.000
            double suDungDT = Convert.ToDouble(txtSuDungDienThoai.Text.Trim()) * 100000;
            //vi pham roi vi tri lam viec = so lan vi pham * 100000
            double roiViTri = Convert.ToDouble(txtRoiViTri.Text.Trim()) * 100000;

            //vi pham khac
            int soLanViPhamKhac = Convert.ToInt32(txtSoLanViPhamKhac.Text.Trim());
            double soTienViPhamKhac = Convert.ToDouble(txtSoTienViPhamKhac.Text.Trim());
            double viPhamKhac = soLanViPhamKhac * soTienViPhamKhac;

            //tong tien phat
            double tongTienPhat = coPhep + khongPhep + quenBamCa + suDungDT + roiViTri + viPhamKhac;
            //xuat tong tien
            txtTongTienPhat.Text = tongTienPhat.ToString();

        }

        private void frmTinhTien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("bạn muốn thoát", "thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNghiCoPhep_TextChanged(object sender, EventArgs e)
        {
            txtNghiCoPhep.Clear();
            txtNghiCoPhep.Focus();
        }

        private void txtNghiKhongPhep_TextChanged(object sender, EventArgs e)
        {
            txtNghiKhongPhep.Clear();
            txtNghiKhongPhep.Focus();
        }

        private void txtDiTre_TextChanged(object sender, EventArgs e)
        {
            txtDiTre.Clear();
            txtDiTre.Focus();
        }

        private void txtQuenBamCa_TextChanged(object sender, EventArgs e)
        {
            txtQuenBamCa.Clear();
            txtQuenBamCa.Focus();
        }

        private void txtSuDungDienThoai_TextChanged(object sender, EventArgs e)
        {
            txtSuDungDienThoai.Clear();
            txtSuDungDienThoai.Focus();
        }

        private void txtRoiViTri_TextChanged(object sender, EventArgs e)
        {
            txtRoiViTri.Clear();
            txtRoiViTri.Focus();
        }

        private void txtSoLanViPhamKhac_TextChanged(object sender, EventArgs e)
        {
            txtSoLanViPhamKhac.Clear();
            txtSoLanViPhamKhac.Focus();
        }

        private void txtTongLuong_TextChanged(object sender, EventArgs e)
        {
            double tongLuong = 0;
            double luongThuong = Convert.ToDouble(txtLuongThuong.Text.Trim());
            string chucVu = cbLuongCoBan.Text.Trim();
            //luong cua quan ly = luong thuong + 7.000.000
            if(chucVu == "QL")
            {
                tongLuong = luongThuong + 7000000;
            }
            //luong cua nhan vien phong ve = luong thuong + 5.500.000
            if(chucVu == "NVPV")
            {
                tongLuong = luongThuong + 5500000;
            }
            //luong cua bac tai = luong thuong + 4.500.000
            if(chucVu == "BT")
            {
                tongLuong = luongThuong + 4500000;
            }
            //luong cua lo xe = luong thuong + 4.000.000
            if(chucVu =="LX")
            {
                tongLuong = luongThuong + 4000000;
            }
            //luong cua bao ve = luong thuong + 3.500.000
            if(chucVu == "BV")
            {
                tongLuong = luongThuong + 3500000;
            }

            txtTongLuong.Text = tongLuong.ToString();
        }

        private void txtThucLanh_TextChanged(object sender, EventArgs e)
        {
            double viPham = Convert.ToDouble(txtViPham.Text.Trim());
            double tongLuong = Convert.ToDouble(txtTongLuong.Text.Trim());
            double thucLanh = tongLuong - viPham;
            txtThucLanh.Text = thucLanh.ToString();
        }

        private void txtViPham_TextChanged(object sender, EventArgs e)
        {
            double viPham = Convert.ToDouble(txtTongTienPhat.Text.Trim());
            txtViPham.Text = viPham.ToString();
        }


    }
}
