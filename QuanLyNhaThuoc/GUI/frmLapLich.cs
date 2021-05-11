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
    public partial class frmLapLich : Form
    {
        public frmLapLich()
        {
            InitializeComponent();
        }

        class NHANVIEN
        {
            public int bot { get; set; }
            public int sum { get; set; }
            public int[] array = new int[50];
        }

        private void frmLapLich_Load(object sender, EventArgs e)
        {
            //int n, m;
            //int[] arrayviec = new int[50];

            ////Console.WriteLine("So Ca viec");
            ////n = int.Parse(Console.ReadLine());
            ////Console.WriteLine("Thoi gian tung ca: ");
            //NhapMang(arrayviec, 6);
            ////Console.WriteLine("Nhap so nhan vien: ");
            ////m = int.Parse(Console.ReadLine());
            //GiamDan(arrayviec, 6);
            //ChiaViec(arrayviec, 6, 3);

        }





        private void NhapMang(int[] a, int n)
        {
            a[0] = int.Parse(textBox1.Text);
            a[1] = int.Parse(textBox2.Text);
            a[2] = int.Parse(textBox3.Text);
            a[3] = int.Parse(textBox4.Text);
            a[4] = int.Parse(textBox5.Text);
            a[5] = int.Parse(textBox6.Text);
            a[6] = int.Parse(textBox7.Text);
            a[7] = int.Parse(textBox8.Text);
            a[8] = int.Parse(textBox9.Text);
            a[9] = int.Parse(textBox10.Text);
            a[10] = int.Parse(textBox11.Text);
            a[11] = int.Parse(textBox12.Text);
            a[12] = int.Parse(textBox13.Text);
            a[13] = int.Parse(textBox14.Text);
            a[14] = int.Parse(textBox15.Text);

        }

        

        

        private void Swap(ref int a, ref int b)
        {
            int tmp;
            tmp = a;
            a = b;
            b = tmp;
        }

        private void GiamDan(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] < a[j])
                    {
                        Swap(ref a[i], ref a[j]);
                    }
                }
            }
        }

        private void GanMangBangKhong(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                a[i] = 0;
            }
        }

        private int MinDong(NHANVIEN[] nv, int m)
        {
            int minwhere = 0;

            for (int i = 1; i < m; i++)
            {
                if (nv[i].sum < nv[minwhere].sum)
                {
                    minwhere = i;
                }
            }
            return minwhere;
        }

        

        

        private void XuatMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                txbLL.AppendText(a[i].ToString()+ "           ");
            }
        }

        private int ChiaViec(int[] viec, int n, int m)
        {
            NHANVIEN[] nv = new NHANVIEN[50];
            int min, max;

            for (int k = 0; k < m; k++)
            {
                nv[k] = new NHANVIEN();
                GanMangBangKhong(nv[k].array, 50);
                nv[k].bot = 0;
                nv[k].sum = 0;
            }

            for (int i = 0; i < n; i++)
            {
                min = MinDong(nv, m);
                nv[min].array[nv[min].bot++] = viec[i];
                nv[min].sum = nv[min].sum + viec[i];
            }

            max = nv[0].sum;

            //for (int j = 0; j < m; j++)
            //{
            //    Console.WriteLine("Nhan Vien " + (j + 1) + ":");
            //    XuatMang(nv[j].array, nv[j].bot);
            //    Console.WriteLine("Tong thoi gian lam cua nhan vien " + (j + 1) + " : " + nv[j].sum + "\n");

            //    Console.WriteLine("");

            //    if (nv[j].sum > max)
            //    {
            //        max = nv[j].sum;
            //    }
            //}

            for (int j = 0; j < m; j++)
            {
                txbLL.AppendText("Nhân Viên " + (j + 1) + ":"+Environment.NewLine);
                XuatMang(nv[j].array, nv[j].bot);
                txbLL.AppendText(Environment.NewLine);
                txbLL.AppendText("Tổng thời gian làm của nhân viên " + (j + 1) + " : " + nv[j].sum +" h"+ "\n");
                txbLL.AppendText(Environment.NewLine+Environment.NewLine+Environment.NewLine);


                if (nv[j].sum > max)
                {
                    max = nv[j].sum;
                }
            }
            return max;
        }

        

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txbLL.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLapLich_Click(object sender, EventArgs e)
        {
            txbLL.Clear();
            int n;
            int[] arrayviec = new int[50];
            n = int.Parse(txbNV.Text);
            NhapMang(arrayviec, 15);
            GiamDan(arrayviec, 15);
            ChiaViec(arrayviec, 15, n);
        }
    }
}
