using QuanLyNhaThuoc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaThuoc.DAL;
using QuanLyNhaThuoc.GUI;
using QuanLyNhaThuoc.BLL;


namespace QuanLyNhaThuoc.BLL
{
    class ThuocBLL
    {
        public static DataTable LayDanhSachThuoc()
        {
            DataTable tb = new DataTable();
            try
            {
                string sql = @"select Thuoc.MaThuoc, Thuoc.TenThuoc, NhomThuoc.TenNhom , NhaSanXuat.TenNSX, 
                            Thuoc.DVBan, Thuoc.DonGia, Thuoc.QuyCach from Thuoc, NhomThuoc, NhaSanXuat 
                            where Thuoc.MaNhom=NhomThuoc.MaNhom and Thuoc.MaNSX=NhaSanXuat.MaNSX ";
                tb = ConnectionData.ExecQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return tb;
        }

        public static DataTable LayDanhSachTenThuoc()
        {
            DataTable tb = new DataTable();
            try
            {
                string sql = @"select MaThuoc, TenThuoc from Thuoc";
                tb = ConnectionData.ExecQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return tb;
        }



        public static bool ThemThuoc(ThuocDTO th)
        {
            try
            {
                string sql = @"INSERT INTO Thuoc (MaThuoc,TenThuoc,MaNhom,MaNSX,DVBan,DonGia,QuyCach) 
                             Values('" + th.MaThuoc + "', N'" + th.TenThuoc + "', '" + th.MaNhom + "', " +
                             "'" + th.MaNSX + "', '" + th.DVBan + "', '" + th.DonGia + "', N'" + th.QuyCach + "')";
                ConnectionData.ExeNonQuery(sql);
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }




        public static bool XoaThuoc(ThuocDTO th)
        {
            try
            {
                string sql = @"DELETE from Thuoc WHERE MaThuoc='" + th.MaThuoc + "' ";
                ConnectionData.ExeNonQuery(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool SuaThuoc(ThuocDTO th)
        {
            try
            {
                string sql = @"UPDATE Thuoc SET TenThuoc= N'" + th.TenThuoc + "', MaNhom= '" + th.MaNhom + "', " +
                    "MaNSX= '" + th.MaNSX + "', DVBan= '" + th.DVBan + "', DonGia= '" + th.DonGia + "', " +
                    "QuyCach= N'" + th.QuyCach + "' WHERE MaThuoc= '" + th.MaThuoc + "'";
                ConnectionData.ExeNonQuery(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        
        public static DataTable LayDanhSachDonGiaThuoc(string MaThuoc )
        {
            DataTable tb = new DataTable();
            try
            {
                string sql = @"select DonGia from Thuoc where MaThuoc='"+MaThuoc+"'";
                tb = ConnectionData.ExecQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return tb;

        }



    }
}
