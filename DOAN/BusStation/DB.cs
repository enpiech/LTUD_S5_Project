using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BusStation
{
    public class DB
    {
        /// <summary>
        /// Liên kết đến cơ sở dữ liệu
        /// </summary>
        private SqlConnection connectDB = new SqlConnection();
        private string connectionString = @"Data Source=DESKTOP-6VMB17O\SQLEXPRESS;Initial Catalog=QLyBenXe;Integrated Security=True";
        
        public DB()
        {
            try
            {
                connectDB.ConnectionString = connectionString;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Mở kết nối mới
        /// </summary>
        public void moKetNoi()
        {
            try
            {
                connectDB.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Đóng kết nối hiện tại
        /// </summary>
        public void dongKetNoi()
        {
            try
            {
                connectDB.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Kiểm tra tài khoản có trong cơ sở dữ liệu hay không
        /// </summary>
        /// <param name="taiKhoan">Mã tài khoản</param>
        /// <param name="matKhau">Mật khẩu</param>
        /// <returns></returns>
        public bool kiemTraDangNhap(string taiKhoan, string matKhau)
        {
            bool xacNhan = false;
            string tensp = "sp_kiemTraTaiKhoan";
            int soLuongKetQua = 0;

            try
            {
                SqlCommand cmd = new SqlCommand(tensp, connectDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maTK", taiKhoan);
                cmd.Parameters.AddWithValue("@matkhau", matKhau);

                // Nếu tìm thấy tài khoản trong csdl
                SqlDataReader duLieuTraVe = cmd.ExecuteReader();

                // Đếm số hàng trả về
                while (duLieuTraVe.Read())
                {
                    soLuongKetQua += 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            Console.WriteLine(soLuongKetQua);
            xacNhan = (soLuongKetQua >= 1) ? true : false;

            return xacNhan;
        }

        /// <summary>
        /// Lấy dữ liệu nhân viên đang đăng nhập
        /// </summary>
        /// <param name="maNV">Mã nhân viên đăng nhập</param>
        /// <returns>Bảng dữ liệu chứ thông tin nhân viên đang đang nhập</returns>
        public DataTable layDuLieuNhanVien(string maNV)
        {
            DataTable bangTraVe = new DataTable();
            string tensp = "sp_layDuLieuNhanVien";

            try
            {
                SqlCommand command = new SqlCommand(tensp, connectDB);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@maNV", maNV);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(bangTraVe);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            return bangTraVe;
        }

        /// <summary>
        /// Lấy dữ liệu từ csdl
        /// </summary>
        /// <param name="tenBang">Tên bảng cần lấy</param>
        /// <returns>Bảng dữ liệu lấy từ csdl</returns>
        public DataTable layDuLieuTuBang(string tenBang)
        {
            DataTable bangTraVe = new DataTable();
            string tensp = "sp_layDuLieuTuBang";

            SqlCommand command = new SqlCommand(tensp, connectDB);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@tenBang", tenBang);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(bangTraVe);

            return bangTraVe;
        }

        /// <summary>
        /// Xóa hãng xe theo mã hãng xe nhập vào
        /// </summary>
        /// <param name="maHangXe">Mã hãng xe cần xóa</param>
        /// <returns>-1 nếu có lỗi xảy ra</returns>
        public int xoaHangXe(string maHangXe)
        {
            string tensp = "sp_xoaHangXe";

            SqlCommand command = new SqlCommand(tensp, connectDB);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@maHangXe", maHangXe);

            int exc = command.ExecuteNonQuery();
            return exc;
        }

        /// <summary>
        /// Xóa khách hàng theo mã khách hàng nhập vào
        /// </summary>
        /// <param name="maHangXe">Mã khách hàng cần xóa</param>
        /// <returns>- 1 nếu có lỗi xảy ra</returns>
        public int xoaKhachHang(string maHangXe)
        {
            string tensp = "sp_xoaHangXe";

            SqlCommand command = new SqlCommand(tensp, connectDB);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@maHangXe", maHangXe);

            int exc = command.ExecuteNonQuery();
            return exc;
        }

        /// <summary>
        /// Xóa loại nhân viên theo mã loại nhân viên nhập vào
        /// </summary>
        /// <param name="maLoaiNV">Mã loại nhân viên cần xóa</param>
        /// <returns>-1 nếu có lỗi xảy ra</returns>
        public int xoaLoaiNV(string maLoaiNV)
        {
            string tensp = "sp_xoaLoaiNV";

            SqlCommand command = new SqlCommand(tensp, connectDB);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@maLoaiNV", maLoaiNV);

            int exc = command.ExecuteNonQuery();
            return exc;
        }

        /// <summary>
        /// Xóa loại xe theo mã loại xe nhập vào
        /// </summary>
        /// <param name="maLoaiXe">Mã loại xe cần xóa</param>
        /// <returns>-1 nếu có lỗi xảy ra</returns>
        public int xoaLoaiXe(string maLoaiXe)
        {
            string tensp = "sp_xoaLoaiXe";

            SqlCommand command = new SqlCommand(tensp, connectDB);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@maLoaiXe", maLoaiXe);

            int exc = command.ExecuteNonQuery();
            return exc;
        }

        /// <summary>
        /// Xóa nhân viên theo mã nhân viên nhập vào
        /// </summary>
        /// <param name="maNV">Mã nhân viên cần xóa</param>
        /// <returns>-1 nếu có lỗi xảy ra</returns>
        public int xoaNhanVien(string maNV)
        {
            string tensp = "sp_xoaNhanVien";

            SqlCommand command = new SqlCommand(tensp, connectDB);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@maNV", maNV);

            int exc = command.ExecuteNonQuery();
            return exc;
        }

        /// <summary>
        /// Xóa tài khoản nhân viên theo mã nhân viên nhập vào
        /// </summary>
        /// <param name="maNV">Mã nhân viên cần xóa tài khoản</param>
        /// <returns>-1 nếu có lỗi xảy ra</returns>
        public int xoaTaiKhoanNV(string maNV)
        {
            string tensp = "sp_xoaTaiKhoanNV";

            SqlCommand command = new SqlCommand(tensp, connectDB);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@maNV", maNV);

            int exc = command.ExecuteNonQuery();
            return exc;
        }

        /// <summary>
        /// Thêm hãng xe mới
        /// </summary>
        /// <param name="maHangXe">Mã hãng xe mới</param>
        /// <param name="tenHangXe">Tên hãng xe mới</param>
        /// <param name="soLuongXe">Số lượng xe mới</param>
        /// <param name="chiPhi">Chi phí xe mới</param>
        /// <returns>-1 nếu có lỗi xảy ra</returns>
        public int themHangXe(string maHangXe, string tenHangXe, int soLuongXe, double chiPhi)
        {
            string tensp = "sp_themHangXe";

            SqlCommand command = new SqlCommand(tensp, connectDB);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@maHangXe", maHangXe);
            command.Parameters.AddWithValue("@tenHangXe", tenHangXe);
            command.Parameters.AddWithValue("@soLuongXe", soLuongXe);
            command.Parameters.AddWithValue("@chiPhiThueBai", chiPhi);

            int exc = command.ExecuteNonQuery();
            return exc;
        }

        /// <summary>
        /// Thêm khách hàng mới
        /// </summary>
        /// <param name="maKH">Mã khách hàng mới</param>
        /// <param name="tenKH">Tên khách hàng mới</param>
        /// <param name="cmnd">CMND khách hàng mới</param>
        /// <param name="sdt">Sô điện thoại khách hàng mới</param>
        /// <param name="maXe">Mã xe khách hàng chọn</param>
        /// <param name="maGhe">Mã ghế khách hàng chọn</param>
        /// <returns>-1 nếu có lỗi xảy ra</returns>
        public int themKhachHang(string maKH, string tenKH, string cmnd , string sdt, string maXe, string maGhe)
        {
            string tensp = "sp_themKhachHang";

            SqlCommand command = new SqlCommand(tensp, connectDB);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@maKH", maKH);
            command.Parameters.AddWithValue("@tenKH", tenKH);
            command.Parameters.AddWithValue("@cmnd", cmnd);
            command.Parameters.AddWithValue("@soDienThoai", sdt);
            command.Parameters.AddWithValue("@maXe", maXe);
            command.Parameters.AddWithValue("@maGhe", maGhe);

            int exc = command.ExecuteNonQuery();
            return exc;
        }

        /// <summary>
        /// Thêm loại nhân viên mới
        /// </summary>
        /// <param name="maLoaiNV">Mã loại nhân viên mới</param>
        /// <param name="tenLoaiNV">Tên loại nhân viên mới</param>
        /// <param name="luongCoBan">Lương cơ bản của loại nhân viên mới</param>
        /// <returns>-1 nếu có lỗi xảy ra</returns>
        public int themLoaiNV(string maLoaiNV, string tenLoaiNV, double luongCoBan)
        {
            string tensp = "sp_themNV";

            SqlCommand command = new SqlCommand(tensp, connectDB);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@maLoaiNV", maLoaiNV);
            command.Parameters.AddWithValue("@tenLoaiNV", tenLoaiNV);
            command.Parameters.AddWithValue("@luongCoBan", luongCoBan);

            int exc = command.ExecuteNonQuery();
            return exc;
        }

        /// <summary>
        /// Thêm loại xe mới
        /// </summary>
        /// <param name="maLoaiXe">Mã loại xe mới</param>
        /// <param name="tenLoaiXe">Tên loại xe mới</param>
        /// <returns>-1 nếu có lỗi xảy ra</returns>
        public int themLoaiXe(string maLoaiXe, string tenLoaiXe)
        {
            string tensp = "sp_themNV";

            SqlCommand command = new SqlCommand(tensp, connectDB);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@maLoaiXe", maLoaiXe);
            command.Parameters.AddWithValue("@tenLoaiXe", tenLoaiXe);

            int exc = command.ExecuteNonQuery();
            return exc;
        }

        /// <summary>
        /// Thêm nhân viên mới
        /// </summary>
        /// <param name="maNV">Mã nhân viên mới</param>
        /// <param name="tenNV">Tên nhân viên mới</param>
        /// <param name="ngaySinh">Ngày sinh nhân viên mới</param>
        /// <param name="diaChi">Địa chỉ nhân viên mới</param>
        /// <param name="queQuan">Quê quán nhân viên mới</param>
        /// <param name="ngayBatDau">Ngày bắt đầu làm việc của nhân viên mới</param>
        /// <param name="maLoaiNV">Mã loại nhân viên mới</param>
        /// <param name="sdt">Số diện thoại nhân viên mới</param>
        /// <param name="luong">Lương của nhân viên mới</param>
        /// <returns>-1 nếu có lỗi xảy ra</returns>
        public int themNhanVien(string maNV, string tenNV, DateTime ngaySinh, string diaChi, string queQuan, DateTime ngayBatDau, string maLoaiNV, string sdt, double luong)
        {
            string tensp = "sp_themNV";

            SqlCommand command = new SqlCommand(tensp, connectDB);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@maNV", maNV);
            command.Parameters.AddWithValue("@tenNV", tenNV);
            command.Parameters.AddWithValue("@ngaySinh", ngaySinh);
            command.Parameters.AddWithValue("@diaChi", diaChi);
            command.Parameters.AddWithValue("@queQuan", queQuan);
            command.Parameters.AddWithValue("@ngayBatDau", ngayBatDau);
            command.Parameters.AddWithValue("@maLoaiNV", maLoaiNV);
            command.Parameters.AddWithValue("@soDienThoai", sdt);
            command.Parameters.AddWithValue("@luong", luong);

            int exc = command.ExecuteNonQuery();
            return exc;
        }

        /// <summary>
        /// Thêm tài khoản nhân viên mới
        /// </summary>
        /// <param name="maNV">Mã nhân viên mới</param>
        /// <param name="maTK">Mã tài khoản nhân viên mới</param>
        /// <param name="matKhau">Mật khẩu mới</param>
        /// <returns>-1 nếu có lỗi xảy ra</returns>
        public int themTaiKhoanNV(string maNV, string maTK, string matKhau)
        {
            string tensp = "sp_themTaiKhoanNV";

            SqlCommand command = new SqlCommand(tensp, connectDB);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@maNV", maNV);
            command.Parameters.AddWithValue("@maTK", maTK);
            command.Parameters.AddWithValue("@matKhau", matKhau);

            int exc = command.ExecuteNonQuery();
            return exc;
        }

        /// <summary>
        /// Thêm xe mới
        /// </summary>
        /// <param name="maXe">Mã xe mới</param>
        /// <param name="maHangXe">Mã hãng xe xe mới</param>
        /// <param name="soXe">Số xe mới</param>
        /// <param name="maLoaiXe">Mã loại xe xe mới</param>
        /// <param name="hanhTrinh">Hành trình xe mới</param>
        /// <param name="gia">Giá vé xe mới</param>
        /// <param name="gioXuatPhat">Giờ xuất phát xe mới</param>
        /// <param name="soLuongGhe">Số lượng ghế xe mới</param>
        /// <param name="soLuongKhachHang">Số lượng khách hàng xe mới</param>
        /// <param name="maNVLaiXe">Mã nhân viên lái xe mới</param>
        /// <returns>-1 nếu có lỗi xảy ra</returns>
        public int themXe(string maXe, string maHangXe, string soXe, string maLoaiXe, string hanhTrinh, int gia, DateTime gioXuatPhat, int soLuongGhe, int soLuongKhachHang, string maNVLaiXe)
        {
            string tensp = "sp_themTaiKhoanNV";

            SqlCommand command = new SqlCommand(tensp, connectDB);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@maXe", maXe);
            command.Parameters.AddWithValue("@maHangXe", maHangXe);
            command.Parameters.AddWithValue("@soXe", soXe);
            command.Parameters.AddWithValue("@maLoaiXe", maLoaiXe);
            command.Parameters.AddWithValue("@hanhTrinh", hanhTrinh);
            command.Parameters.AddWithValue("@gia", gia);
            command.Parameters.AddWithValue("@gioXuatPhat", gioXuatPhat);
            command.Parameters.AddWithValue("@soLuongGhe", soLuongGhe);
            command.Parameters.AddWithValue("@soLuongKhachHang", soLuongKhachHang);
            command.Parameters.AddWithValue("@maNVLaiXe", maNVLaiXe);

            int exc = command.ExecuteNonQuery();
            return exc;
        }

        /// <summary>
        /// Sửa hãng xe
        /// </summary>
        /// <param name="maHangXe">Mã hãng xe cần sửa</param>
        /// <param name="tenHangXe">Tên hãng xe mới</param>
        /// <param name="soLuongXe">Số lượng xe mới</param>
        /// <param name="chiPhi">Chi phí xe mới</param>
        /// <returns>-1 nếu có lỗi xảy ra</returns>
        public int suaHangXe(string maHangXe, string tenHangXe, int soLuongXe, double chiPhi)
        {
            string tensp = "sp_suaHangXe";

            SqlCommand command = new SqlCommand(tensp, connectDB);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@maHangXe", maHangXe);
            command.Parameters.AddWithValue("@tenHangXe", tenHangXe);
            command.Parameters.AddWithValue("@soLuongXe", soLuongXe);
            command.Parameters.AddWithValue("@chiPhiThueBai", chiPhi);

            int exc = command.ExecuteNonQuery();
            return exc;
        }

        /// <summary>
        /// Sửa khách hàng
        /// </summary>
        /// <param name="maKH">Mã khách hàng cần sửa</param>
        /// <param name="tenKH">Tên khách hàng mới</param>
        /// <param name="cmnd">CMND khách hàng mới</param>
        /// <param name="sdt">Sô điện thoại khách hàng mới</param>
        /// <param name="maXe">Mã xe khách hàng chọn</param>
        /// <param name="maGhe">Mã ghế khách hàng chọn</param>
        /// <returns>-1 nếu có lỗi xảy ra</returns>
        public int suaKhachHang(string maKH, string tenKH, string cmnd, string sdt, string maXe, string maGhe)
        {
            string tensp = "sp_suaKhachHang";

            SqlCommand command = new SqlCommand(tensp, connectDB);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@maKH", maKH);
            command.Parameters.AddWithValue("@tenKH", tenKH);
            command.Parameters.AddWithValue("@cmnd", cmnd);
            command.Parameters.AddWithValue("@soDienThoai", sdt);
            command.Parameters.AddWithValue("@maXe", maXe);
            command.Parameters.AddWithValue("@maGhe", maGhe);

            int exc = command.ExecuteNonQuery();
            return exc;
        }

        /// <summary>
        /// Sửa loại nhân viên
        /// </summary>
        /// <param name="maLoaiNV">Mã loại nhân viên cần sửa</param>
        /// <param name="tenLoaiNV">Tên loại nhân viên mới</param>
        /// <param name="luongCoBan">Lương cơ bản của loại nhân viên mới</param>
        /// <returns>-1 nếu có lỗi xảy ra</returns>
        public int suaLoaiNV(string maLoaiNV, string tenLoaiNV, double luongCoBan)
        {
            string tensp = "sp_suaNV";

            SqlCommand command = new SqlCommand(tensp, connectDB);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@maLoaiNV", maLoaiNV);
            command.Parameters.AddWithValue("@tenLoaiNV", tenLoaiNV);
            command.Parameters.AddWithValue("@luongCoBan", luongCoBan);

            int exc = command.ExecuteNonQuery();
            return exc;
        }

        /// <summary>
        /// Sửa loại xe
        /// </summary>
        /// <param name="maLoaiXe">Mã loại xe cần sửa</param>
        /// <param name="tenLoaiXe">Tên loại xe mới</param>
        /// <returns></returns>
        public int suaLoaiXe(string maLoaiXe, string tenLoaiXe)
        {
            string tensp = "sp_suaNV";

            SqlCommand command = new SqlCommand(tensp, connectDB);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@maLoaiXe", maLoaiXe);
            command.Parameters.AddWithValue("@tenLoaiXe", tenLoaiXe);

            int exc = command.ExecuteNonQuery();
            return exc;
        }

        /// <summary>
        /// Sửa nhân viên
        /// </summary>
        /// <param name="maNV">Mã nhân viên cần sửa</param>
        /// <param name="tenNV">Tên nhân viên mới</param>
        /// <param name="ngaySinh">Ngày sinh nhân viên mới</param>
        /// <param name="diaChi">Địa chỉ nhân viên mới</param>
        /// <param name="queQuan">Quê quán nhân viên mới</param>
        /// <param name="ngayBatDau">Ngày bắt đầu làm việc của nhân viên mới</param>
        /// <param name="maLoaiNV">Mã loại nhân viên mới</param>
        /// <param name="sdt">Số diện thoại nhân viên mới</param>
        /// <param name="luong">Lương của nhân viên mới</param>
        /// <returns></returns>
        public int suaNhanVien(string maNV, string tenNV, DateTime ngaySinh, string diaChi, string queQuan, DateTime ngayBatDau, string maLoaiNV, string sdt, double luong)
        {
            string tensp = "sp_suaNV";

            SqlCommand command = new SqlCommand(tensp, connectDB);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@maNV", maNV);
            command.Parameters.AddWithValue("@tenNV", tenNV);
            command.Parameters.AddWithValue("@ngaySinh", ngaySinh);
            command.Parameters.AddWithValue("@diaChi", diaChi);
            command.Parameters.AddWithValue("@queQuan", queQuan);
            command.Parameters.AddWithValue("@ngayBatDau", ngayBatDau);
            command.Parameters.AddWithValue("@maLoaiNV", maLoaiNV);
            command.Parameters.AddWithValue("@soDienThoai", sdt);
            command.Parameters.AddWithValue("@luong", luong);

            int exc = command.ExecuteNonQuery();
            return exc;
        }

        /// <summary>
        /// Sửa tài khoản nhân viên
        /// </summary>
        /// <param name="maNV">Mã nhân viên cần sửa</param>
        /// <param name="maTK">Mã tài khoản nhân viên mới</param>
        /// <param name="matKhau">Mật khẩu mới</param>
        /// <returns></returns>
        public int suaTaiKhoanNV(string maNV, string maTK, string matKhau)
        {
            string tensp = "sp_suaTaiKhoanNV";

            SqlCommand command = new SqlCommand(tensp, connectDB);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@maNV", maNV);
            command.Parameters.AddWithValue("@maTK", maTK);
            command.Parameters.AddWithValue("@matKhau", matKhau);

            int exc = command.ExecuteNonQuery();
            return exc;
        }

        /// <summary>
        /// Sửa xe
        /// </summary>
        /// <param name="maXe">Mã xe cần sửa</param>
        /// <param name="maHangXe">Mã hãng xe xe mới</param>
        /// <param name="soXe">Số xe mới</param>
        /// <param name="maLoaiXe">Mã loại xe xe mới</param>
        /// <param name="hanhTrinh">Hành trình xe mới</param>
        /// <param name="gia">Giá vé xe mới</param>
        /// <param name="gioXuatPhat">Giờ xuất phát xe mới</param>
        /// <param name="soLuongGhe">Số lượng ghế xe mới</param>
        /// <param name="soLuongKhachHang">Số lượng khách hàng xe mới</param>
        /// <param name="maNVLaiXe">Mã nhân viên lái xe mới</param>
        /// <returns></returns>
        public int suaXe(string maXe, string maHangXe, string soXe, string maLoaiXe, string hanhTrinh, int gia, DateTime gioXuatPhat, int soLuongGhe, int soLuongKhachHang, string maNVLaiXe)
        {
            string tensp = "sp_suaTaiKhoanNV";

            SqlCommand command = new SqlCommand(tensp, connectDB);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@maXe", maXe);
            command.Parameters.AddWithValue("@maHangXe", maHangXe);
            command.Parameters.AddWithValue("@soXe", soXe);
            command.Parameters.AddWithValue("@maLoaiXe", maLoaiXe);
            command.Parameters.AddWithValue("@hanhTrinh", hanhTrinh);
            command.Parameters.AddWithValue("@gia", gia);
            command.Parameters.AddWithValue("@gioXuatPhat", gioXuatPhat);
            command.Parameters.AddWithValue("@soLuongGhe", soLuongGhe);
            command.Parameters.AddWithValue("@soLuongKhachHang", soLuongKhachHang);
            command.Parameters.AddWithValue("@maNVLaiXe", maNVLaiXe);

            int exc = command.ExecuteNonQuery();
            return exc;
        }

        /// <summary>
        /// Cập nhật dữ liệu trong DataGridView từ CSDL
        /// </summary>
        /// <param name="dgv_ten">Tên DataGridView</param>
        /// <param name="tenBang">Tên bảng dữ liệu</param>
        public static void dgv_capNhat(DataGridView dgv_ten, string tenBang)
        {
            DB db = new DB();
            db.moKetNoi();
            dgv_ten.DataSource = db.layDuLieuTuBang(tenBang);
            db.dongKetNoi();
        }
    }
}
