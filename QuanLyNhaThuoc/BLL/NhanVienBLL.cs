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
    class NhanVienBLL
    {
        public static DataTable LayDanhSachNhanVien()
        {
            DataTable tb = new DataTable();
            try
            {
                string sql = @"select * from NhanVien";
                tb = ConnectionData.ExecQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return tb;
        }


        public static bool ThemNhanVien(NhanVienDTO nv)
        {
            try
            {
                string sql = @"INSERT INTO NhanVien(MaNV,TenNV,SDT,NgaySinh,GioiTinh,CMND) 
                             Values('" + nv.MaNV + "', N'" + nv.TenNV + "', '" + nv.SDT + "', " +
                             "'" + nv.NgaySinh.ToString("yyyy-MM-dd") + "', N'" + nv.GioiTinh + "', '" + nv.CMND + "')";
                ConnectionData.ExeNonQuery(sql);
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool XoaNhanVien(NhanVienDTO nv)
        {
            try
            {
                string sql = @"DELETE from NhanVien WHERE MaNV='" + nv.MaNV + "' ";
                ConnectionData.ExeNonQuery(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool SuaNhanVien(NhanVienDTO nv)
        {
            try
            {
                string sql = @"UPDATE NhanVien SET TenNV= N'" + nv.TenNV + "'," +
                    " SDT= '" + nv.SDT + "', NgaySinh= '" + nv.NgaySinh.ToString("yyyy-MM-dd") + "', " +
                    "GioiTinh= N'" + nv.GioiTinh + "', CMND= '" + nv.CMND + "'  " +
                    "WHERE MaNV= '" + nv.MaNV + "'";
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
