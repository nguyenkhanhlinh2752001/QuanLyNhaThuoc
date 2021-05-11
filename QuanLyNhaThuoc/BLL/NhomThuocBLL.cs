using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using QuanLyNhaThuoc.DAL;
using QuanLyNhaThuoc.DTO;

namespace QuanLyNhaThuoc.BLL
{
    class NhomThuocBLL
    {
        public static DataTable LayDanhSachNhomThuoc()
        {
            DataTable tb = new DataTable();
            try
            {
                string sql = @"select * from NhomThuoc";
                tb = ConnectionData.ExecQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return tb;
        }

        public static bool ThemNhomThuoc(NhomThuocDTO nt)
        {
            try
            {
                string sql = @"INSERT INTO NhomThuoc (MaNhom,TenNhom) Values('" + nt.MaNhom + "', N'" + nt.TenNhom + "' )";
                ConnectionData.ExeNonQuery(sql);
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool XoaNhomThuoc(NhomThuocDTO nt)
        {
            try
            {
                string sql = @"DELETE from NhomThuoc WHERE MaNhom='" + nt.MaNhom + "' ";
                ConnectionData.ExeNonQuery(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool SuaNhomThuoc(NhomThuocDTO nt)
        {
            try
            {
                string sql = @"UPDATE NhomThuoc SET TenNhom= N'" + nt.TenNhom + "' WHERE MaNhom= '" + nt.MaNhom + "'";
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
