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
        private string tenNV;
        private string loaiNV;
        private double luong;
        private bool isLogged;

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

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string LoaiNV { get => loaiNV; set => loaiNV = value; }
        public double Luong { get => luong; set => luong = value; }
        public bool IsLogged { get => isLogged; set => isLogged = value; }
    }
}
