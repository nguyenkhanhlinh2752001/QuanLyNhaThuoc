using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaThuoc.DAL;
using QuanLyNhaThuoc.DTO;

namespace QuanLyNhaThuoc.BLL
{
    class NhaSanXuatBLL
    {
        public static DataTable LayDanhSachNhaSanXuat()
        {
            DataTable tb = new DataTable();
            try
            {
                string sql = @"select * from NhaSanXuat";
                tb = ConnectionData.ExecQuery(sql);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return tb;
        }

        public static bool ThemNhaSanXuat(NhaSanXuatDTO nsx)
        {
            try
            {
                string sql = @"INSERT INTO NhaSanXuat(MaNSX,TenNSX,DiaChi,Email) 
                            Values('" + nsx.MaNSX + "', N'" + nsx.TenNSX + "', N'"+nsx.DiaChi+"', '"+nsx.Email+"' )";
                ConnectionData.ExeNonQuery(sql);
                return true;
  
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool XoaNhaSanXuat(NhaSanXuatDTO nsx)
        {
            try
            {
                string sql = @"DELETE from NhaSanXuat WHERE MaNSX='" + nsx.MaNSX + "' ";
                ConnectionData.ExeNonQuery(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool SuaNhaSanXuat(NhaSanXuatDTO nsx)
        {
            try
            {
                string sql = @"UPDATE NhaSanXuat SET TenNSX= N'" + nsx.TenNSX + "', " + "Diachi= N'" + nsx.DiaChi + "', Email= N'" + nsx.Email + "'" +
                    " WHERE MaNSX= '" + nsx.MaNSX + "'";
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
