namespace QuanLyNhaThuoc.GUI
{
    partial class frmHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbTongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbMaHD1 = new System.Windows.Forms.TextBox();
            this.cbxNhanVien = new System.Windows.Forms.ComboBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.txbMaHD2 = new System.Windows.Forms.TextBox();
            this.cbxTenThuoc = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbSoLuong = new System.Windows.Forms.TextBox();
            this.txbDonGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvThuocHD = new System.Windows.Forms.DataGridView();
            this.MaHD2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem1 = new System.Windows.Forms.Button();
            this.btnXoa1 = new System.Windows.Forms.Button();
            this.btnNhapLai1 = new System.Windows.Forms.Button();
            this.btnThem2 = new System.Windows.Forms.Button();
            this.btnXoa2 = new System.Windows.Forms.Button();
            this.btnNhapLai2 = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuocHD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupBox1.Controls.Add(this.txbTongTien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbMaHD1);
            this.groupBox1.Controls.Add(this.cbxNhanVien);
            this.groupBox1.Controls.Add(this.dtpNgayLap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // txbTongTien
            // 
            this.txbTongTien.Location = new System.Drawing.Point(148, 156);
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.Size = new System.Drawing.Size(328, 28);
            this.txbTongTien.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tổng Tiền";
            // 
            // txbMaHD1
            // 
            this.txbMaHD1.Location = new System.Drawing.Point(148, 31);
            this.txbMaHD1.Name = "txbMaHD1";
            this.txbMaHD1.Size = new System.Drawing.Size(328, 28);
            this.txbMaHD1.TabIndex = 6;
            this.txbMaHD1.TextChanged += new System.EventHandler(this.txbMaHD_TextChanged);
            // 
            // cbxNhanVien
            // 
            this.cbxNhanVien.FormattingEnabled = true;
            this.cbxNhanVien.Location = new System.Drawing.Point(148, 116);
            this.cbxNhanVien.Name = "cbxNhanVien";
            this.cbxNhanVien.Size = new System.Drawing.Size(328, 30);
            this.cbxNhanVien.TabIndex = 5;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(148, 74);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(328, 28);
            this.dtpNgayLap.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Lập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHoaDon);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(566, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(818, 285);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Hóa Đơn";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.NgayLap,
            this.MaNV});
            this.dgvHoaDon.Location = new System.Drawing.Point(15, 26);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(797, 234);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_RowEnter);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã Hóa Đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 130;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Width = 130;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "TenNV";
            this.MaNV.HeaderText = "Nhân Viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 270;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox3.Controls.Add(this.lblThanhTien);
            this.groupBox3.Controls.Add(this.txbMaHD2);
            this.groupBox3.Controls.Add(this.cbxTenThuoc);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txbSoLuong);
            this.groupBox3.Controls.Add(this.txbDonGia);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(28, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(979, 124);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết Hóa Đơn";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(761, 87);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(20, 24);
            this.lblThanhTien.TabIndex = 12;
            this.lblThanhTien.Text = "0";
            // 
            // txbMaHD2
            // 
            this.txbMaHD2.Location = new System.Drawing.Point(134, 34);
            this.txbMaHD2.Name = "txbMaHD2";
            this.txbMaHD2.Size = new System.Drawing.Size(125, 28);
            this.txbMaHD2.TabIndex = 11;
            // 
            // cbxTenThuoc
            // 
            this.cbxTenThuoc.FormattingEnabled = true;
            this.cbxTenThuoc.Location = new System.Drawing.Point(416, 31);
            this.cbxTenThuoc.Name = "cbxTenThuoc";
            this.cbxTenThuoc.Size = new System.Drawing.Size(538, 30);
            this.cbxTenThuoc.TabIndex = 10;
            this.cbxTenThuoc.SelectedIndexChanged += new System.EventHandler(this.cbxTenThuoc_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Mã Hóa Đơn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(642, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Thành Tiền:";
            // 
            // txbSoLuong
            // 
            this.txbSoLuong.Location = new System.Drawing.Point(416, 83);
            this.txbSoLuong.Name = "txbSoLuong";
            this.txbSoLuong.Size = new System.Drawing.Size(114, 28);
            this.txbSoLuong.TabIndex = 6;
            this.txbSoLuong.TextChanged += new System.EventHandler(this.txbSoLuong_TextChanged);
            // 
            // txbDonGia
            // 
            this.txbDonGia.Location = new System.Drawing.Point(134, 82);
            this.txbDonGia.Name = "txbDonGia";
            this.txbDonGia.Size = new System.Drawing.Size(125, 28);
            this.txbDonGia.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Số Lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đơn Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên Thuốc";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvThuocHD);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 463);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1372, 285);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh Sách Thuốc";
            // 
            // dgvThuocHD
            // 
            this.dgvThuocHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuocHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD2,
            this.TenThuoc,
            this.DonGia,
            this.SoLuong,
            this.ThanhTien});
            this.dgvThuocHD.Location = new System.Drawing.Point(15, 21);
            this.dgvThuocHD.Name = "dgvThuocHD";
            this.dgvThuocHD.RowHeadersWidth = 51;
            this.dgvThuocHD.RowTemplate.Height = 24;
            this.dgvThuocHD.Size = new System.Drawing.Size(1334, 234);
            this.dgvThuocHD.TabIndex = 0;
            this.dgvThuocHD.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuocHD_RowEnter);
            // 
            // MaHD2
            // 
            this.MaHD2.DataPropertyName = "MaHD";
            this.MaHD2.HeaderText = "Mã Hóa Đơn";
            this.MaHD2.MinimumWidth = 6;
            this.MaHD2.Name = "MaHD2";
            this.MaHD2.Width = 130;
            // 
            // TenThuoc
            // 
            this.TenThuoc.DataPropertyName = "TenThuoc";
            this.TenThuoc.HeaderText = "Tên Thuốc";
            this.TenThuoc.MinimumWidth = 6;
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.Width = 440;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 130;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 130;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 130;
            // 
            // btnThem1
            // 
            this.btnThem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnThem1.Location = new System.Drawing.Point(28, 231);
            this.btnThem1.Name = "btnThem1";
            this.btnThem1.Size = new System.Drawing.Size(138, 56);
            this.btnThem1.TabIndex = 4;
            this.btnThem1.Text = "Thêm";
            this.btnThem1.UseVisualStyleBackColor = true;
            this.btnThem1.Click += new System.EventHandler(this.btnThem1_Click);
            // 
            // btnXoa1
            // 
            this.btnXoa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnXoa1.Location = new System.Drawing.Point(213, 231);
            this.btnXoa1.Name = "btnXoa1";
            this.btnXoa1.Size = new System.Drawing.Size(138, 56);
            this.btnXoa1.TabIndex = 6;
            this.btnXoa1.Text = "Xóa";
            this.btnXoa1.UseVisualStyleBackColor = true;
            this.btnXoa1.Click += new System.EventHandler(this.btnXoa1_Click);
            // 
            // btnNhapLai1
            // 
            this.btnNhapLai1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnNhapLai1.Location = new System.Drawing.Point(396, 231);
            this.btnNhapLai1.Name = "btnNhapLai1";
            this.btnNhapLai1.Size = new System.Drawing.Size(136, 56);
            this.btnNhapLai1.TabIndex = 7;
            this.btnNhapLai1.Text = "Nhập Lại";
            this.btnNhapLai1.UseVisualStyleBackColor = true;
            this.btnNhapLai1.Click += new System.EventHandler(this.btnNhapLai1_Click);
            // 
            // btnThem2
            // 
            this.btnThem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem2.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnThem2.Location = new System.Drawing.Point(1041, 326);
            this.btnThem2.Name = "btnThem2";
            this.btnThem2.Size = new System.Drawing.Size(138, 56);
            this.btnThem2.TabIndex = 8;
            this.btnThem2.Text = "Thêm";
            this.btnThem2.UseVisualStyleBackColor = true;
            this.btnThem2.Click += new System.EventHandler(this.btnThem2_Click);
            // 
            // btnXoa2
            // 
            this.btnXoa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa2.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnXoa2.Location = new System.Drawing.Point(1223, 324);
            this.btnXoa2.Name = "btnXoa2";
            this.btnXoa2.Size = new System.Drawing.Size(138, 56);
            this.btnXoa2.TabIndex = 9;
            this.btnXoa2.Text = "Xóa";
            this.btnXoa2.UseVisualStyleBackColor = true;
            this.btnXoa2.Click += new System.EventHandler(this.btnXoa2_Click);
            // 
            // btnNhapLai2
            // 
            this.btnNhapLai2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai2.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnNhapLai2.Location = new System.Drawing.Point(1041, 401);
            this.btnNhapLai2.Name = "btnNhapLai2";
            this.btnNhapLai2.Size = new System.Drawing.Size(138, 56);
            this.btnNhapLai2.TabIndex = 10;
            this.btnNhapLai2.Text = "Nhập Lại";
            this.btnNhapLai2.UseVisualStyleBackColor = true;
            this.btnNhapLai2.Click += new System.EventHandler(this.btnNhapLai2_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnThoat.Location = new System.Drawing.Point(1223, 401);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(138, 56);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1396, 760);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNhapLai2);
            this.Controls.Add(this.btnXoa2);
            this.Controls.Add(this.btnThem2);
            this.Controls.Add(this.btnNhapLai1);
            this.Controls.Add(this.btnXoa1);
            this.Controls.Add(this.btnThem1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuocHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbMaHD1;
        private System.Windows.Forms.ComboBox cbxNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txbSoLuong;
        private System.Windows.Forms.TextBox txbDonGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvThuocHD;
        private System.Windows.Forms.Button btnThem1;
        private System.Windows.Forms.Button btnXoa1;
        private System.Windows.Forms.Button btnNhapLai1;
        private System.Windows.Forms.Button btnThem2;
        private System.Windows.Forms.Button btnXoa2;
        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxTenThuoc;
        private System.Windows.Forms.TextBox txbMaHD2;
        private System.Windows.Forms.Button btnNhapLai2;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
    }
}