using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BusStation
{
    public partial class frmLogin : Form
    {
        private NhanVien nhanVien;

        internal NhanVien NhanVien
        {
            get { return nhanVien; }
            set { nhanVien = value; }
        }
        //internal NhanVien NhanVien { get => nhanVien; set => nhanVien = value; }

        public frmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Thoát chương trình
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Xác nhận trước khi đóng form
        /// </summary>
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Nếu người dùng chưa đăng nhập
            if (this.NhanVien == null)
            {
                DialogResult result;
                result = MessageBox.Show("Bạn muốn thoát?", "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (result == DialogResult.No)
                    e.Cancel = true;
            }
        }



        /// <summary>
        /// Truyền dữ liệu vào main form
        /// </summary>
        private void enableFormMain()
        {
            ((frmMain)this.MdiParent).ActiveNhanVien = this.NhanVien;
            ((frmMain)this.MdiParent).enableFormMain();
        }

        /// <summary>
        /// Kiểm tra tài khoản nhân viên và mật khẩu rồi đăng nhập vào hệ thống
        /// </summary>
        SqlConnection conn = new SqlConnection();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "SELECT *  FROM TaiKhoanNhanVien WHERE MaTK = @taikhoan AND MatKhau = @matkhau";
            SqlCommand cm = new SqlCommand(sql,conn);
            cm.Parameters.AddWithValue("@taikhoan", txtUser.Text);
            cm.Parameters.AddWithValue("@matkhau", txtPassword.Text);

            Login login = new Login(txtUser.Text, txtPassword.Text);
            SqlDataReader dr = cm.ExecuteReader();
            int count = 0;
            while(dr.Read())
            {
                count += 1;
            }
            if(count == 1)
            {
                MessageBox.Show("dang nhap thanh cong", "thong bao");
                this.NhanVien = new NhanVien();

                this.NhanVien.IsLogged = false;
                this.NhanVien.MaNV = string.Empty;
                this.NhanVien.TenNV = string.Empty;
                this.NhanVien.LoaiNV = string.Empty;
                this.NhanVien.Luong = 0;

                this.NhanVien.LoaiNV = "QL";
                this.NhanVien.IsLogged = true;
                // Truyền dữ liệu vào form main
                enableFormMain();

                // Đóng form hiện tại
                this.Close();

            }
            else if(count > 1)
            {
                MessageBox.Show("Null");
            }else
            {
                lblThongBao.Text = "sai ten tai khoan hoac mat khau! vui long kiem tra lai!";
            }
            conn.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QLyBenXe;Integrated Security=True";
            txtPassword.UseSystemPasswordChar = true;
        }


    }
}
