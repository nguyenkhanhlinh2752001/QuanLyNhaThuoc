using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaThuoc.DAL;
using QuanLyNhaThuoc.DTO;
using System.Data;


namespace QuanLyNhaThuoc.BLL
{
    class HoaDonBLL
    {
        public static DataTable LayDanhSachHoaDon()
        {
            DataTable tb = new DataTable();
            try
            {
                string sql = @"select HoaDon.MaHD, HoaDon.NgayLap, NhanVien.TenNV  
                            from HoaDon, NhanVien Where HoaDon.MaNV=NhanVien.MaNV  ";
                tb = ConnectionData.ExecQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return tb;
        }

        public static bool ThemHoaDon( HoaDonDTO hd)
        {
            try
            {
                string sql = @"INSERT INTO HoaDon(MaHD,NgayLap,MaNV) 
                             Values('" + hd.MaHD + "', '"+ hd.NgayLap.ToString("yyyy-MM-dd") + "' , '" + hd.MaNV+ "')";
                ConnectionData.ExeNonQuery(sql);
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static bool XoaHoaDon(HoaDonDTO hd)
        {
            try
            {
                string sql = @"DELETE from HoaDon WHERE MaHD='" + hd.MaHD + "' ";
                ConnectionData.ExeNonQuery(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool SuaHoaDon(HoaDonDTO hd)
        {
            try
            {
                string sql = @"UPDATE HoaDon SET  NgayLap= '" + hd.NgayLap.ToString("yyyy-MM-dd") + "', " +
                                "" +  "MaNV= N'" + hd.MaNV + "' WHERE MaHD= '" + hd.MaHD + "'";
                ConnectionData.ExeNonQuery(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
