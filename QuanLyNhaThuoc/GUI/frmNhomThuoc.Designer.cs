namespace QuanLyNhaThuoc.GUI
{
    partial class frmNhomThuoc
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
            this.txbTenNhom = new System.Windows.Forms.TextBox();
            this.txbMaNhom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNT = new System.Windows.Forms.DataGridView();
            this.MaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox1.Controls.Add(this.txbTenNhom);
            this.groupBox1.Controls.Add(this.txbMaNhom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // txbTenNhom
            // 
            this.txbTenNhom.Location = new System.Drawing.Point(197, 104);
            this.txbTenNhom.Name = "txbTenNhom";
            this.txbTenNhom.Size = new System.Drawing.Size(489, 28);
            this.txbTenNhom.TabIndex = 3;
            // 
            // txbMaNhom
            // 
            this.txbMaNhom.Location = new System.Drawing.Point(197, 35);
            this.txbMaNhom.Name = "txbMaNhom";
            this.txbMaNhom.Size = new System.Drawing.Size(489, 28);
            this.txbMaNhom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhóm thuốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhóm thuốc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNT);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 325);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhóm thuốc";
            // 
            // dgvNT
            // 
            this.dgvNT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhom,
            this.TenNhom});
            this.dgvNT.Location = new System.Drawing.Point(16, 38);
            this.dgvNT.Name = "dgvNT";
            this.dgvNT.RowHeadersWidth = 51;
            this.dgvNT.RowTemplate.Height = 24;
            this.dgvNT.Size = new System.Drawing.Size(699, 281);
            this.dgvNT.TabIndex = 0;
            this.dgvNT.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNT_RowEnter);
            // 
            // MaNhom
            // 
            this.MaNhom.DataPropertyName = "MaNhom";
            this.MaNhom.HeaderText = "Mã nhóm thuốc";
            this.MaNhom.MinimumWidth = 6;
            this.MaNhom.Name = "MaNhom";
            this.MaNhom.Width = 130;
            // 
            // TenNhom
            // 
            this.TenNhom.DataPropertyName = "TenNhom";
            this.TenNhom.HeaderText = "Tên nhóm thuốc";
            this.TenNhom.MinimumWidth = 6;
            this.TenNhom.Name = "TenNhom";
            this.TenNhom.Width = 350;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnReset.Location = new System.Drawing.Point(795, 34);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(147, 69);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Nhập lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnThem.Location = new System.Drawing.Point(795, 131);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(147, 67);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnSua.Location = new System.Drawing.Point(795, 230);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(147, 67);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnXoa.Location = new System.Drawing.Point(795, 334);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(147, 67);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnThoat.Location = new System.Drawing.Point(795, 443);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(147, 65);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmNhomThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(971, 550);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNhomThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhóm thuốc";
            this.Load += new System.EventHandler(this.frmNhomThuoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbTenNhom;
        private System.Windows.Forms.TextBox txbMaNhom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNT;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhom;
    }
}