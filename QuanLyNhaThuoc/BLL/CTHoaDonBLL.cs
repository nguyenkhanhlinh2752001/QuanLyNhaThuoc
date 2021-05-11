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
    class CTHoaDonBLL
    {
        public static DataTable LayDanhSachChiTietHoaDon( string mahd )
        {
            DataTable tb = new DataTable();
            try
            {
                string sql = @"select CTHoaDon.MaHD, Thuoc.TenThuoc,Thuoc.DonGia,
                             CTHoaDon.SoLuong,CTHoaDon.SoLuong*Thuoc.DonGia ThanhTien from CTHoaDon,
                             HoaDon, Thuoc WHERE HoaDon.MaHD = CTHoaDon.MaHD and 
                             CTHoaDon.MaThuoc = Thuoc.MaThuoc and CTHoaDon.MaHD='"+mahd+"' ";
                tb = ConnectionData.ExecQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return tb;
        }

        public static bool ThemThuocVaoHoaDon(CTHoaDonDTO ct)
        {
            try
            {
                string sql = @"INSERT INTO CTHoaDon (MaHD,MaThuoc,SoLuong) 
                             Values('" + ct.MaHD + "', '" + ct.MaThuoc + "', '" + ct.SoLuong + "')";
                ConnectionData.ExeNonQuery(sql);
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool SuaThuocTrongHoaDon(CTHoaDonDTO ct)
        {
            try
            {
                string sql = @"UPDATE CTHoaDon SET SoLuong= '" + ct.SoLuong + "'" +
                            " WHERE MaHD= '" + ct.MaHD + "' and MaThuoc= '" + ct.MaThuoc + "' ";
                ConnectionData.ExeNonQuery(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool XoaThuocKhoiHoaDon(CTHoaDonDTO ct)
        {
            try
            {
                string sql = @"DELETE from CTHoaDon WHERE MaHD='" + ct.MaHD + "' and MaThuoc='"+ct.MaThuoc+"' ";
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
