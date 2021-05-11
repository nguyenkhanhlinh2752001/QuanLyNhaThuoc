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
    public partial class frmNhaSanXuat : Form
    {

        NhaSanXuatDTO NSX = new NhaSanXuatDTO();

        public frmNhaSanXuat()
        {
            InitializeComponent();
        }

        private void frmNhaSanXuat_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNhaSanXuat();
        }
        private void HienThiDanhSachNhaSanXuat()
        {
            DataTable tb = new DataTable();
            tb = NhaSanXuatBLL.LayDanhSachNhaSanXuat();
            dgvNSX.DataSource = tb;
        }


        private void dgvNSX_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            txbMaNSX.Text = dgvNSX.Rows[dong].Cells[0].Value.ToString();
            txbTenNSX.Text = dgvNSX.Rows[dong].Cells[1].Value.ToString();
            txbDiaChi.Text = dgvNSX.Rows[dong].Cells[2].Value.ToString();
            txbEmail.Text = dgvNSX.Rows[dong].Cells[3].Value.ToString();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            NSX.MaNSX = txbMaNSX.Text;
            NSX.TenNSX = txbTenNSX.Text;
            NSX.DiaChi = txbDiaChi.Text;
            NSX.Email = txbEmail.Text;

            if (NhaSanXuatBLL.ThemNhaSanXuat(NSX))
            {
                MessageBox.Show("            Thêm thành công           ");
                HienThiDanhSachNhaSanXuat();
            }
            else
            {
                MessageBox.Show("            Thêm thất bại             ");
            }        
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NSX.MaNSX = txbMaNSX.Text;
            NSX.TenNSX = txbTenNSX.Text;
            NSX.DiaChi = txbDiaChi.Text;
            NSX.Email = txbEmail.Text;

            if (NhaSanXuatBLL.SuaNhaSanXuat(NSX))
            {
                MessageBox.Show("            Sửa thành công            ");
                HienThiDanhSachNhaSanXuat();
            }
            else
            {
                MessageBox.Show("            Sửa thất bại               ");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NSX.MaNSX = txbMaNSX.Text;
            NSX.DiaChi = txbDiaChi.Text;
            NSX.Email = txbEmail.Text;

            if (NhaSanXuatBLL.XoaNhaSanXuat(NSX))
            {
                MessageBox.Show("              Xóa thành công             ");
                HienThiDanhSachNhaSanXuat();
            }
            else
            {
                MessageBox.Show("               Xóa thất bại                ");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txbMaNSX.Clear();
            txbTenNSX.Clear();
            txbEmail.Clear();
            txbDiaChi.Clear();

        }

        
    }
}
