using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BusStation
{
    public partial class frmHangXe : Form
    {
        public frmHangXe()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Thêm hãng xe mới vào cơ sở dữ liệu
        /// </summary>
        private bool themHangXe()
        {
            string tenHangXe = this.txtTenHangXe.Text;
            //int soLuongXe = Convert.ToInt32(this.numSoLuongXe);
            //double chiPhiThueBai = Convert.ToDouble(this.numChiPhi);

           // MessageBox.Show(tenHangXe + soLuongXe + chiPhiThueBai);

            return false;
        }

        

        /// <summary>
        /// Sửa hãng xe trong cơ sở dữ liệu
        /// </summary>
        private bool suaHangXe()
        {
            string tenHangXe = this.txtTenHangXe.Text;
           //int soLuongXe = Convert.ToInt32(this.numSoLuongXe);
            //double chiPhiThueBai = Convert.ToDouble(this.numChiPhi);

            //MessageBox.Show(tenHangXe + soLuongXe + chiPhiThueBai);

            return false;
        }

        /// <summary>
        /// Kiểm tra chuỗi chỉ chứa các kí từ là chữ
        /// </summary>
        private bool stringValidator(string input)
        {
            string pattern = "[^a-zA-Z]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Kiểm tra nếu chuỗi nhập vào là số
        /// </summary>
        private bool integerValidator(string input)
        {
            string pattern = "[^0-9]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Kiểm tra lỗi nhập liệu
        /// </summary>
        private bool isError()
        {
            string tenHangXe = this.txtTenHangXe.Text.Trim();
            //int soLuong = Convert.ToInt32(this.numSoLuongXe.Value);
            //double chiPhi = Convert.ToDouble(this.numChiPhi.Value);

            if (!stringValidator(tenHangXe) || tenHangXe == "")
            {
                MessageBox.Show("Tên không phù hợp, vui lòng nhập lại!");
                return true;
            }

            return false;
        }


        /// <summary>
        /// Kiểm tra lỗi rồi thêm hãng xe mới
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //themHangXe(txtMaHangXe.Text,txtTenHangXe.Text,Convert.ToInt32(numSoLuongXe),Convert.ToInt32(numChiPhi));
        }



        /// <summary>
        /// Kiểm tra lỗi rồi xóa hãng xe
        /// </summary>
        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    if (deleteConfirm())
        //    {
        //        // Kiểm tra xem đã xóa thành công
        //        if (xoaHangXe())
        //        {
        //            MessageBox.Show("Xóa hãng xe thành công!");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Không thể xóa hãng xe này!");
        //        }
        //    }
        //}

        /// <summary>
        /// Trở về form chọn bảng
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            foreach (Form form in ((frmMain)this.MdiParent).MdiChildren)
            {
                if (form.Text == "Quản Lý")
                {
                    form.Visible = true;
                    break;
                }
            }
            this.Close();
        }

        /// <summary>
        /// Sửa thông tin hãng xe đang chọn
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Lấy tên hãng xe từ text box
            string tenHangXe = this.txtTenHangXe.Text;
            // Nếu người dùng chưa nhập tên hãng xe
            if (!isError())
            {
                // Kiểm tra xem đã thêm thành công
                if (themHangXe())
                {
                    MessageBox.Show("Thêm hãng xe mới thành công!");
                }
                else
                {
                    MessageBox.Show("Có lỗi phát sinh, không thể thêm hãng xe mới!");
                }
            }
        }

        
        /***** Doc Du Lieu Tu Database Va Thuc Hien Cac Phuong Thuc xem xoa sua *****/



        //khoi tao gia tri 
        xuLyDB xuly = new xuLyDB();
        

        /// <summary>
        /// hàm đọc database
        /// </summary>
        /// <returns></returns>
        public DataTable getAllHangXe()
        {
            DataTable dtHangXe = new DataTable();
            string nameSp = "SP_layBangHangXe";
            SqlCommand cm = new SqlCommand(nameSp, xuLyDB.connect);
            cm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adepter = new SqlDataAdapter(cm);
            adepter.Fill(dtHangXe);
            xuLyDB.connect.Close();

            dataGridView1.DataSource = dtHangXe;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            return dtHangXe;
        }
        //load dữ liệu lên datagidview
        private void frmHangXe_Load(object sender, EventArgs e)
        {
            //gọi hàm để hiển thị
          getAllHangXe();
        }


        /// <summary>
        /// hàm thêm dữ liệu vào trong database
        /// </summary>
        /// <param name="MaHangXe"></param>
        /// <param name="TenHangXe"></param>
        /// <param name="SoLuongXe"></param>
        /// <param name="ChiPhiThueBai"></param>
        /// <returns></returns>
        public int themDataHangXe(string MaHangXe, string TenHangXe, int SoLuongXe, int ChiPhiThueBai)
        {
            xuLyDB.connect.Open();
            int result = 0;
            string nameSP = "SP_ThemHangXe";
            SqlCommand cm = new SqlCommand(nameSP, xuLyDB.connect);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@maHangXe", MaHangXe);
            cm.Parameters.AddWithValue("@tenHangXe", TenHangXe);
            cm.Parameters.AddWithValue("@soLuongXe", SoLuongXe);
            cm.Parameters.AddWithValue("@chiPhiThueBai", ChiPhiThueBai);
            result = cm.ExecuteNonQuery();
            xuLyDB.connect.Close();
            return result;
        }
        //them du lieu
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            themDataHangXe(txtMaHangXe.Text, txtTenHangXe.Text, Convert.ToInt32(txtSoLuongXe.Text), Convert.ToInt32(txtChiPhiThueBai.Text));
            //gọi hàm để hiển thị
            getAllHangXe();
        }


        /// <summary>
        /// hàm xóa dữ liệu trong database
        /// </summary>
        /// <param name="MaHangXe"></param>
        /// <returns></returns>
        public bool xoaHangXe(string MaHangXe)
        {
            try
            {
                xuLyDB.connect.Open();
                string nameSP = "SP_xoaHangXe";
                SqlCommand cm = new SqlCommand(nameSP, xuLyDB.connect);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@maHangXe", MaHangXe);
                cm.ExecuteNonQuery();
                xuLyDB.connect.Close();

            }
            catch
            {
                xuLyDB.connect.Close();
                return false;
            }
            return true;
        }
        /// <summary>
        /// hàm kiểm tra trước khi xóa
        /// </summary>
        private bool deleteConfirm()
        {
            string hangXe = this.txtMaHangXe.Text;

            if (hangXe == "")
            {
                MessageBox.Show("Vui lòng chọn hãng xe muốn xóa!");
                return false;
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa hãng xe này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.No)
                {
                    return false;
                }
            }

            return true;
        }
        //xoa hang xe theo ma xe
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (deleteConfirm() )
            {
                xoaHangXe(txtMaHangXe.Text);
                MessageBox.Show("Xóa Thành Công");
            }else
            {
                MessageBox.Show("xóa chưa thành công vui lòng kiểm tra lại");
            }
            //hien thi lai danh sach sau khi xoa
            getAllHangXe();
        }
        //sua du lieu
        public bool suaDataLop(string MaHangXe, string TenHangXe, int SoLuongXe, int ChiPhiThueBai)
        {
            try
            {
                xuLyDB.connect.Open();
                string nameSP = "SP_SuaHangXe";
                SqlCommand cm = new SqlCommand(nameSP, xuLyDB.connect);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@maHangXe", MaHangXe);
                cm.Parameters.AddWithValue("@tenHangXe", TenHangXe);
                cm.Parameters.AddWithValue("@soLuongXe", SoLuongXe);
                cm.Parameters.AddWithValue("@chiPhiThueBai", ChiPhiThueBai);
                cm.ExecuteNonQuery();
                xuLyDB.connect.Close();
            }
            catch
            {

                return false;
            }
            return true;
        }
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
        }





    }
}
