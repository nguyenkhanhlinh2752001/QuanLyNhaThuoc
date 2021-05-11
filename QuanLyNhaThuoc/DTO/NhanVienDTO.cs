using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaThuoc.DTO
{
    class NhanVienDTO
    {
        string manv;
        public string MaNV
        {
            get { return manv; }
            set { manv = value; }
        }

        string tennv;
        public string TenNV
        {
            get { return tennv; }
            set { tennv = value; }
        }

        DateTime ngaysinh;
        public DateTime NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }

        string cmnd;
        public string CMND
        {
            get { return cmnd; }
            set { cmnd = value; }
        }

        string gioitinh;
        public string GioiTinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        string sdt;
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }
    }
}
