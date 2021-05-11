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
using QuanLyNhaThuoc.BLL;

namespace QuanLyNhaThuoc.GUI
{
    public partial class frmNhanVien : Form
    {
        NhanVienDTO NV = new NhanVienDTO();

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNhanVien();
        }
        private void HienThiDanhSachNhanVien()
        {
            DataTable tb = new DataTable();
            tb = NhanVienBLL.LayDanhSachNhanVien();
            dgvNV.DataSource = tb;
        }

        private void dgvNV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            txbMaNV.Text = dgvNV.Rows[dong].Cells[0].Value.ToString();
            txbTenNV.Text = dgvNV.Rows[dong].Cells[1].Value.ToString();
            txbSDT.Text = dgvNV.Rows[dong].Cells[4].Value.ToString();
            txbCMND.Text = dgvNV.Rows[dong].Cells[3].Value.ToString();
            dtpNgaySinh.Text = dgvNV.Rows[dong].Cells[5].Value.ToString();
            if (dgvNV.Rows[dong].Cells[2].Value.ToString() == "Nữ")
                rdbNu.Checked = true;
            else if (dgvNV.Rows[dong].Cells[2].Value.ToString() == "Nam")
                rdbNam.Checked = true;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txbMaNV.Clear();
            txbTenNV.Clear();
            txbSDT.Clear();
            txbCMND.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NV.MaNV = txbMaNV.Text;
            NV.TenNV = txbTenNV.Text;
            NV.NgaySinh = dtpNgaySinh.Value;
            NV.CMND = txbCMND.Text;
            NV.SDT = txbSDT.Text;
            if (rdbNam.Checked == true)
                NV.GioiTinh = "Nam";
            else if (rdbNu.Checked == true)
                NV.GioiTinh = "Nữ";


            if (NhanVienBLL.ThemNhanVien(NV))
            {
                MessageBox.Show("              Thêm thành công              ");
                HienThiDanhSachNhanVien();
            }
            else
            {
                MessageBox.Show("               Thêm thất bại                 ");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NV.MaNV = txbMaNV.Text;
            NV.TenNV = txbTenNV.Text;
            NV.NgaySinh = dtpNgaySinh.Value;
            NV.CMND = txbCMND.Text;
            NV.SDT = txbSDT.Text;
            if (rdbNam.Checked == true)
                NV.GioiTinh = "Nam";
            else if (rdbNu.Checked == true)
                NV.GioiTinh = "Nữ";

            if (NhanVienBLL.SuaNhanVien(NV))
            {
                MessageBox.Show("                Sửa thành công               ");
                HienThiDanhSachNhanVien();
            }
            else
            {
                MessageBox.Show("                 Sửa thất bại                 ");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NV.MaNV = txbMaNV.Text;

            if (NhanVienBLL.XoaNhanVien(NV))
            {
                MessageBox.Show("               Xóa thành công              ");
                HienThiDanhSachNhanVien();
            }
            else
            {
                MessageBox.Show("                Xóa thất bại                ");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLapLich().ShowDialog();
            this.Show();
        }
    }
}
