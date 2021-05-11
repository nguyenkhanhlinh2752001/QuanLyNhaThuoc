namespace QuanLyNhaThuoc.GUI
{
    partial class frmNhaSanXuat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMaNSX = new System.Windows.Forms.TextBox();
            this.txbTenNSX = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.bong = new System.Windows.Forms.Label();
            this.nhim = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNSX = new System.Windows.Forms.DataGridView();
            this.MaNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNSX)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhà sản xuât";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhà sản xuất";
            // 
            // txbMaNSX
            // 
            this.txbMaNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaNSX.Location = new System.Drawing.Point(188, 41);
            this.txbMaNSX.Name = "txbMaNSX";
            this.txbMaNSX.Size = new System.Drawing.Size(369, 27);
            this.txbMaNSX.TabIndex = 3;
            // 
            // txbTenNSX
            // 
            this.txbTenNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenNSX.Location = new System.Drawing.Point(188, 102);
            this.txbTenNSX.Name = "txbTenNSX";
            this.txbTenNSX.Size = new System.Drawing.Size(369, 27);
            this.txbTenNSX.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Thistle;
            this.groupBox1.Controls.Add(this.txbEmail);
            this.groupBox1.Controls.Add(this.txbDiaChi);
            this.groupBox1.Controls.Add(this.bong);
            this.groupBox1.Controls.Add(this.nhim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbTenNSX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbMaNSX);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1381, 175);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(671, 99);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(690, 27);
            this.txbEmail.TabIndex = 8;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDiaChi.Location = new System.Drawing.Point(671, 41);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(690, 27);
            this.txbDiaChi.TabIndex = 7;
            // 
            // bong
            // 
            this.bong.AutoSize = true;
            this.bong.Location = new System.Drawing.Point(584, 102);
            this.bong.Name = "bong";
            this.bong.Size = new System.Drawing.Size(57, 24);
            this.bong.TabIndex = 6;
            this.bong.Text = "Email";
            // 
            // nhim
            // 
            this.nhim.AutoSize = true;
            this.nhim.Location = new System.Drawing.Point(584, 45);
            this.nhim.Name = "nhim";
            this.nhim.Size = new System.Drawing.Size(70, 24);
            this.nhim.TabIndex = 5;
            this.nhim.Text = "Địa Chỉ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNSX);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1378, 340);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Nhà Sản Xuất";
            // 
            // dgvNSX
            // 
            this.dgvNSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNSX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNSX,
            this.TenNSX,
            this.DiaChi,
            this.Email});
            this.dgvNSX.Location = new System.Drawing.Point(26, 21);
            this.dgvNSX.Name = "dgvNSX";
            this.dgvNSX.RowHeadersWidth = 51;
            this.dgvNSX.RowTemplate.Height = 24;
            this.dgvNSX.Size = new System.Drawing.Size(1346, 306);
            this.dgvNSX.TabIndex = 0;
            this.dgvNSX.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNSX_RowEnter);
            // 
            // MaNSX
            // 
            this.MaNSX.DataPropertyName = "MaNSX";
            this.MaNSX.HeaderText = "Mã nhà sản xuất";
            this.MaNSX.MinimumWidth = 6;
            this.MaNSX.Name = "MaNSX";
            this.MaNSX.Width = 150;
            // 
            // TenNSX
            // 
            this.TenNSX.DataPropertyName = "TenNSX";
            this.TenNSX.HeaderText = "Tên nhà sản xuất";
            this.TenNSX.MinimumWidth = 6;
            this.TenNSX.Name = "TenNSX";
            this.TenNSX.Width = 290;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 340;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 180;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnReset.Location = new System.Drawing.Point(53, 222);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(184, 54);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Nhập lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnThem.Location = new System.Drawing.Point(335, 222);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(184, 54);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnSua.Location = new System.Drawing.Point(603, 222);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(184, 54);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Purple;
            this.btnXoa.Location = new System.Drawing.Point(869, 222);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(184, 54);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Purple;
            this.btnThoat.Location = new System.Drawing.Point(1120, 222);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(184, 54);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmNhaSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1408, 646);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNhaSanXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà Sản Xuất";
            this.Load += new System.EventHandler(this.frmNhaSanXuat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNSX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMaNSX;
        private System.Windows.Forms.TextBox txbTenNSX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvNSX;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.Label bong;
        private System.Windows.Forms.Label nhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}