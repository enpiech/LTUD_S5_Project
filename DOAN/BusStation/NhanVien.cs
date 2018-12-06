using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation
{
    class NhanVien
    {
        private string maNV;

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        private string tenNV;

        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }
        private string loaiNV;

        public string LoaiNV
        {
            get { return loaiNV; }
            set { loaiNV = value; }
        }
        private double luong;

        public double Luong
        {
            get { return luong; }
            set { luong = value; }
        }
        private bool isLogged;

        public bool IsLogged
        {
            get { return isLogged; }
            set { isLogged = value; }
        }

        public NhanVien()
        {
            this.MaNV = "";
            this.TenNV = "";
            this.LoaiNV = "";
            this.IsLogged = false;
        }

        public NhanVien(string maNV, string tenNV, string loaiNV, double luong)
        {
            MaNV = maNV;
            TenNV = tenNV;
            LoaiNV = loaiNV;
            Luong = luong;
            this.IsLogged = false;
        }

        
    }
}
