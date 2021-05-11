namespace QuanLyNhaThuoc.GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnThuoc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnNSX = new System.Windows.Forms.Button();
            this.btnNhomThuoc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThuoc
            // 
            this.btnThuoc.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThuoc.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuoc.ForeColor = System.Drawing.Color.Crimson;
            this.btnThuoc.Image = global::QuanLyNhaThuoc.Properties.Resources.icons8_pills_64;
            this.btnThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThuoc.Location = new System.Drawing.Point(694, 405);
            this.btnThuoc.Name = "btnThuoc";
            this.btnThuoc.Size = new System.Drawing.Size(665, 80);
            this.btnThuoc.TabIndex = 0;
            this.btnThuoc.Text = "Thuốc";
            this.btnThuoc.UseVisualStyleBackColor = false;
            this.btnThuoc.Click += new System.EventHandler(this.btnThuoc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox1.BackgroundImage = global::QuanLyNhaThuoc.Properties.Resources.Screenshot_2020_11_09_204706;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1347, 372);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(851, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trang Quản Lý";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThoat.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Crimson;
            this.btnThoat.Image = global::QuanLyNhaThuoc.Properties.Resources.icons8_shutdown_64;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(694, 612);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(665, 80);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnHoaDon.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.Crimson;
            this.btnHoaDon.Image = global::QuanLyNhaThuoc.Properties.Resources.icons8_bill_64;
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(12, 405);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(665, 80);
            this.btnHoaDon.TabIndex = 4;
            this.btnHoaDon.Text = "Hóa Đơn";
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnNhanVien.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.Crimson;
            this.btnNhanVien.Image = global::QuanLyNhaThuoc.Properties.Resources.icons8_doctor_female_64;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(12, 612);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(665, 80);
            this.btnNhanVien.TabIndex = 3;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnNSX
            // 
            this.btnNSX.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnNSX.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNSX.ForeColor = System.Drawing.Color.Crimson;
            this.btnNSX.Image = global::QuanLyNhaThuoc.Properties.Resources.icons8_factory_64;
            this.btnNSX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNSX.Location = new System.Drawing.Point(694, 508);
            this.btnNSX.Name = "btnNSX";
            this.btnNSX.Size = new System.Drawing.Size(665, 80);
            this.btnNSX.TabIndex = 2;
            this.btnNSX.Text = "Nhà Sản Xuất";
            this.btnNSX.UseVisualStyleBackColor = false;
            this.btnNSX.Click += new System.EventHandler(this.btnNSX_Click);
            // 
            // btnNhomThuoc
            // 
            this.btnNhomThuoc.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnNhomThuoc.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhomThuoc.ForeColor = System.Drawing.Color.Crimson;
            this.btnNhomThuoc.Image = global::QuanLyNhaThuoc.Properties.Resources.icons8_doctors_bag_64__2_;
            this.btnNhomThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhomThuoc.Location = new System.Drawing.Point(12, 508);
            this.btnNhomThuoc.Name = "btnNhomThuoc";
            this.btnNhomThuoc.Size = new System.Drawing.Size(665, 80);
            this.btnNhomThuoc.TabIndex = 1;
            this.btnNhomThuoc.Text = "Nhóm Thuốc";
            this.btnNhomThuoc.UseVisualStyleBackColor = false;
            this.btnNhomThuoc.Click += new System.EventHandler(this.btnNhomThuoc_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1371, 720);
            this.Controls.Add(this.btnThuoc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.btnNhanVien);
            this.Controls.Add(this.btnNSX);
            this.Controls.Add(this.btnNhomThuoc);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThuoc;
        private System.Windows.Forms.Button btnNhomThuoc;
        private System.Windows.Forms.Button btnNSX;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}