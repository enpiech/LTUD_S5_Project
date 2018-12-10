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

        private string loaiNV;

        public string LoaiNV
        {
            get { return loaiNV; }
            set { loaiNV = value; }
        }

        public NhanVien()
        {
            this.MaNV = "";
            this.LoaiNV = "";
        }

        public NhanVien(string maNV, string loaiNV)
        {
            MaNV = maNV;
            LoaiNV = loaiNV;
        }
    }
}
