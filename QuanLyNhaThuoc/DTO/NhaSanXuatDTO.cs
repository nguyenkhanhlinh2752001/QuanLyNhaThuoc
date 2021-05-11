using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaThuoc.DTO
{
    class NhaSanXuatDTO
    {
        string mansx;
        public string MaNSX
        {
            get { return mansx; }
            set { mansx = value; }
        }

        string tennsx;
        public string TenNSX
        {
            get { return tennsx; }
            set { tennsx = value; }
        }

        string diachi;
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

    }
}
