using QuanLyNhaThuoc.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaThuoc.DTO;

namespace QuanLyNhaThuoc.GUI
{
    public partial class frmHoaDon : Form
    {
        HoaDonDTO hoadon = new HoaDonDTO();
        CTHoaDonDTO cthoadon = new CTHoaDonDTO();
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            HienThiDanhSachHoaDon();
            DoDuLieuVaoComboBox();


        }
        

        private void HienThiDanhSachHoaDon()
        {
            DataTable tb = new DataTable();
            tb = HoaDonBLL.LayDanhSachHoaDon();
            dgvHoaDon.DataSource = tb;
        }

        private void DoDuLieuVaoComboBox()
        {
            DataTable tb1 = NhanVienBLL.LayDanhSachNhanVien();
            foreach (DataRow i in tb1.Rows)
            {
                cbxNhanVien.Items.Add(new CBBItem { Text = i["TenNV"].ToString(), Value = i["MaNV"].ToString() });
            }

            

            DataTable tb2 = ThuocBLL.LayDanhSachTenThuoc();
            foreach (DataRow i in tb2.Rows)
            {
                cbxTenThuoc.Items.Add(new CBBItem { Text = i["TenThuoc"].ToString(), Value = i["MaThuoc"].ToString() });
            }
        }

        private void TongTien()
        {
            int sum = 0;
            for (int i = 0; i < dgvThuocHD.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvThuocHD["ThanhTien", i].Value);
            }
            txbTongTien.Text = sum.ToString();
        }
        private void dgvHoaDon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            txbMaHD1.Text = dgvHoaDon.Rows[dong].Cells[0].Value.ToString();
            dtpNgayLap.Text = dgvHoaDon.Rows[dong].Cells[1].Value.ToString();
            cbxNhanVien.Text = dgvHoaDon.Rows[dong].Cells[2].Value.ToString();
            TongTien();           
        }

        

        private void txbMaHD_TextChanged(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb = CTHoaDonBLL.LayDanhSachChiTietHoaDon(txbMaHD1.Text.Trim());
            dgvThuocHD.DataSource = tb;
        }

        private void dgvThuocHD_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            txbMaHD2.Text = dgvThuocHD.Rows[dong].Cells[0].Value.ToString();
            cbxTenThuoc.Text = dgvThuocHD.Rows[dong].Cells[1].Value.ToString();
            txbDonGia.Text = dgvThuocHD.Rows[dong].Cells[2].Value.ToString();
            txbSoLuong.Text = dgvThuocHD.Rows[dong].Cells[3].Value.ToString();
            lblThanhTien.Text = dgvThuocHD.Rows[dong].Cells[4].Value.ToString();
        }

        

        private void btnThem1_Click(object sender, EventArgs e)
        {
            hoadon.MaHD = txbMaHD1.Text;
            hoadon.NgayLap = dtpNgayLap.Value;
            hoadon.MaNV= ((CBBItem)cbxNhanVien.Items[cbxNhanVien.SelectedIndex]).Value;

            

            if (HoaDonBLL.ThemHoaDon(hoadon))
            {
                MessageBox.Show("            Thêm thành công           ");
                HienThiDanhSachHoaDon();
            }
            else
            {
                MessageBox.Show("             Thêm thất bại             ");
            }
        }

        private void btnNhapLai1_Click(object sender, EventArgs e)
        {
            txbMaHD1.Clear();
            txbTongTien.Clear();
            dtpNgayLap.Value = DateTime.Today;
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            hoadon.MaHD = txbMaHD1.Text;

            if (HoaDonBLL.XoaHoaDon(hoadon))
            {
                MessageBox.Show("             Xóa thành công            ");
                HienThiDanhSachHoaDon();
            }
            else
            {
                MessageBox.Show("              Xóa thất bại              ");
            }
        }

        private void btnNhapLai2_Click(object sender, EventArgs e)
        {
            txbMaHD2.Clear();
            txbDonGia.Clear();
            txbSoLuong.Clear();
            lblThanhTien.Text = "0";
        }

 
        private void btnThem2_Click(object sender, EventArgs e)
        {
            cthoadon.MaHD = txbMaHD2.Text;
            cthoadon.MaThuoc= ((CBBItem)cbxTenThuoc.Items[cbxTenThuoc.SelectedIndex]).Value;
            cthoadon.SoLuong = int.Parse(txbSoLuong.Text);

           

            if (CTHoaDonBLL.ThemThuocVaoHoaDon(cthoadon))
            {
                MessageBox.Show("              Thêm thành công            ");
                DataTable tb1 = new DataTable();
                tb1 = CTHoaDonBLL.LayDanhSachChiTietHoaDon(txbMaHD1.Text.Trim());
                dgvThuocHD.DataSource = tb1;

                //HienThiDanhSachHoaDon();



            }
            else
            {
                MessageBox.Show("               Thêm thất bại              ");
            }

        }

        private void btnXoa2_Click(object sender, EventArgs e)
        {
            cthoadon.MaHD = txbMaHD2.Text;
            cthoadon.MaThuoc= cthoadon.MaThuoc = ((CBBItem)cbxTenThuoc.Items[cbxTenThuoc.SelectedIndex]).Value;

            if (CTHoaDonBLL.XoaThuocKhoiHoaDon(cthoadon))
            {
                MessageBox.Show("                 Xóa thành công               ");
                DataTable tb = new DataTable();
                tb = CTHoaDonBLL.LayDanhSachChiTietHoaDon(txbMaHD1.Text.Trim());
                dgvThuocHD.DataSource = tb;
            }
            else
            {
                MessageBox.Show("                  Xóa thất bại                 ");
            }
        }

        private void TinhThanhTien()
        {
            int soluong = 0;
            int dongia = 0;
            int thanhtien = 0;
            int.TryParse(txbSoLuong.Text, out soluong);
            int.TryParse(txbDonGia.Text, out dongia);
            thanhtien = soluong * dongia;
            lblThanhTien.Text = thanhtien.ToString();
        }

        private void txbSoLuong_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void cbxTenThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mathuoc = ((CBBItem)cbxTenThuoc.Items[cbxTenThuoc.SelectedIndex]).Value;
            DataTable tb = new DataTable();
            tb = ThuocBLL.LayDanhSachDonGiaThuoc(mathuoc);
            if (tb.Rows.Count > 0)
            {
                int dongia = int.Parse(tb.Rows[0]["DonGia"].ToString());
                txbDonGia.Text = dongia.ToString();
                TinhThanhTien();
            }
      
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
