using QuanLyNhaThuoc.BLL;
using QuanLyNhaThuoc.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaThuoc.GUI
{
    public partial class frmThuoc : Form
    {
        ThuocDTO thuoc = new ThuocDTO();
        public frmThuoc()
        {
            InitializeComponent();
        }

        private void frmThuoc_Load(object sender, EventArgs e)
        {
            HienThiDanhSachThuoc();
            DoDuLieuVaoComboBox();
        }
        private void HienThiDanhSachThuoc()
        {
            DataTable tb = new DataTable();
            tb = ThuocBLL.LayDanhSachThuoc();
            dgvThuoc.DataSource = tb;
        }

        private void DoDuLieuVaoComboBox()
        {
            DataTable tb1 = NhomThuocBLL.LayDanhSachNhomThuoc();
            foreach(DataRow i in tb1.Rows)
            {
                cbxNhomThuoc.Items.Add(new CBBItem { Text = i["TenNhom"].ToString(), Value = i["MaNhom"].ToString() });
            }

            DataTable tb2 = NhaSanXuatBLL.LayDanhSachNhaSanXuat();
            foreach (DataRow i in tb2.Rows)
            {
                cbxNSX.Items.Add(new CBBItem { Text = i["TenNSX"].ToString(), Value = i["MaNSX"].ToString() });
            }

        }

        private void dgvThuoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            txbMaThuoc.Text = dgvThuoc.Rows[dong].Cells[0].Value.ToString();
            txbTenThuoc.Text = dgvThuoc.Rows[dong].Cells[1].Value.ToString();
            cbxNhomThuoc.Text = dgvThuoc.Rows[dong].Cells[2].Value.ToString();
            cbxNSX.Text = dgvThuoc.Rows[dong].Cells[3].Value.ToString();
            txbDVBan.Text = dgvThuoc.Rows[dong].Cells[4].Value.ToString();
            txbDonGia.Text = dgvThuoc.Rows[dong].Cells[5].Value.ToString();
            txbQuyCach.Text = dgvThuoc.Rows[dong].Cells[6].Value.ToString();
        }


        

        private void btnThem_Click(object sender, EventArgs e)
        {

            thuoc.MaNSX = ((CBBItem)cbxNSX.Items[cbxNSX.SelectedIndex]).Value;
            thuoc.MaThuoc = txbMaThuoc.Text;
            thuoc.TenThuoc = txbTenThuoc.Text;
            thuoc.QuyCach = txbQuyCach.Text;
            thuoc.MaNhom = ((CBBItem)cbxNhomThuoc.Items[cbxNhomThuoc.SelectedIndex]).Value;
            thuoc.DonGia = int.Parse(txbDonGia.Text);
            thuoc.DVBan = int.Parse(txbDVBan.Text);
           

            if (ThuocBLL.ThemThuoc(thuoc))
            {
                MessageBox.Show("               Thêm thành công               ");
                HienThiDanhSachThuoc();
            }
            else
            {
                MessageBox.Show("                Thêm thất bại                 ");
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            thuoc.MaThuoc = txbMaThuoc.Text;

            if (ThuocBLL.XoaThuoc(thuoc))
            {
                MessageBox.Show("                 Xóa thành công                 ");
                HienThiDanhSachThuoc();

            }
            else
            {
                MessageBox.Show("                  Xóa thất bại                   ");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txbMaThuoc.Clear();
            txbTenThuoc.Clear();
            txbDonGia.Clear();
            txbDVBan.Clear();
            txbQuyCach.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            thuoc.MaNSX = ((CBBItem)cbxNSX.Items[cbxNSX.SelectedIndex]).Value;
            thuoc.MaThuoc = txbMaThuoc.Text;
            thuoc.TenThuoc = txbTenThuoc.Text;
            thuoc.QuyCach = txbQuyCach.Text;
            thuoc.MaNhom = ((CBBItem)cbxNhomThuoc.Items[cbxNhomThuoc.SelectedIndex]).Value;
            thuoc.DonGia = int.Parse(txbDonGia.Text);
            thuoc.DVBan = int.Parse(txbDVBan.Text);
            

            if (ThuocBLL.SuaThuoc(thuoc))
            {
                MessageBox.Show("                Sửa thành công                ");
                HienThiDanhSachThuoc();
            }
            else
            {
                MessageBox.Show("                 Sửa thất bại                  ");
            }
        }
    }
}
