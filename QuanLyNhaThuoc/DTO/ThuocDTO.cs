using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaThuoc.DTO
{
    class ThuocDTO
    {
        string mathuoc;
        public string MaThuoc
        {
            get { return mathuoc; }
            set { mathuoc = value; }
        }

        string tenthuoc;
        public string TenThuoc
        {
            get { return tenthuoc; }
            set { tenthuoc = value; }
        }

        int dvban;
        public int DVBan
        {
            get { return dvban; }
            set { dvban = value; }
        }

        string mansx;
        public string MaNSX
        {
            get { return mansx; }
            set { mansx = value; }
        }

        string manhom;
        public string MaNhom
        {
            get { return manhom; }
            set { manhom = value; }
        }

        int dongia;
        public int DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }

        int soluong;
        public int SoLuong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        string quycach;
        public string QuyCach
        {
            get { return quycach; }
            set { quycach = value; }
        }
    }
}
