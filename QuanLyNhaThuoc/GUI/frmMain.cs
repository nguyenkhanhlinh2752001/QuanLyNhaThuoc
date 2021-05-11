using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaThuoc.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnThuoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmThuoc().ShowDialog();
            this.Show();
        }

        private void btnNhomThuoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmNhomThuoc().ShowDialog();
            this.Show();
        }

        private void btnNSX_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmNhaSanXuat().ShowDialog();
            this.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmNhanVien().ShowDialog();
            this.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmHoaDon().ShowDialog();
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
