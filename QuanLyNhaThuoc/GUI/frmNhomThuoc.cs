using QuanLyNhaThuoc.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaThuoc.BLL;

namespace QuanLyNhaThuoc.GUI
{
    public partial class frmNhomThuoc : Form
    {
        NhomThuocDTO NT = new NhomThuocDTO();
        public frmNhomThuoc()
        {
            InitializeComponent();
        }

        private void frmNhomThuoc_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNhomThuoc();
        }
        private void HienThiDanhSachNhomThuoc()
        {
            DataTable tb = new DataTable();
            tb = NhomThuocBLL.LayDanhSachNhomThuoc();
            dgvNT.DataSource = tb;
        }
        

        private void dgvNT_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            this.txbMaNhom.Text = dgvNT.Rows[dong].Cells[0].Value.ToString();
            this.txbTenNhom.Text = dgvNT.Rows[dong].Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NT.MaNhom = txbMaNhom.Text;
            NT.TenNhom = txbTenNhom.Text;


            if (NhomThuocBLL.ThemNhomThuoc(NT))
            {
                MessageBox.Show("              Thêm thành công            ");
                HienThiDanhSachNhomThuoc();
            }
            else
            {
                MessageBox.Show("               Thêm thất bại              ");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NT.MaNhom = txbMaNhom.Text;
            NT.TenNhom = txbTenNhom.Text;

            if (NhomThuocBLL.SuaNhomThuoc(NT))
            {
                MessageBox.Show("                Sửa thành công              ");
                HienThiDanhSachNhomThuoc();
            }
            else
            {
                MessageBox.Show("                 Sửa thất bại                ");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NT.MaNhom = txbMaNhom.Text;

            if (NhomThuocBLL.XoaNhomThuoc(NT))
            {
                MessageBox.Show("               Xóa thành công               ");
                HienThiDanhSachNhomThuoc();
            }
            else
            {
                MessageBox.Show("               Xóa thất bại                 ");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txbMaNhom.Clear();
            txbTenNhom.Clear();
        }
    }
}
