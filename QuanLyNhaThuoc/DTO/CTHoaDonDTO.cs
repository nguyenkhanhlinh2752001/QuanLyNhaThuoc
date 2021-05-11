using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaThuoc.DTO
{
    class CTHoaDonDTO
    {
        string mahd;
        public string MaHD
        {
            get { return mahd; }
            set { mahd = value; }
        }


        string mathuoc;
        public string MaThuoc
        {
            get { return mathuoc; }
            set { mathuoc = value; }
        }

        int soluong;
        public int SoLuong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        int dongia;
        public int DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }
    }
}
