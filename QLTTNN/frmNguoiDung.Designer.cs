namespace QLTTNN
{
    partial class frmNguoiDung
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNguoiDung));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeleteChucNang = new System.Windows.Forms.Button();
            this.cbbChucNang = new System.Windows.Forms.ComboBox();
            this.btnAddChucNang = new System.Windows.Forms.Button();
            this.trvTenDangNhap = new System.Windows.Forms.TreeView();
            this.dgvNguoiDung = new System.Windows.Forms.DataGridView();
            this.colTenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btoXoa = new System.Windows.Forms.Button();
            this.btoSua = new System.Windows.Forms.Button();
            this.btoThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsbTrangThai = new System.Windows.Forms.ListBox();
            this.btoTimKiem = new System.Windows.Forms.Button();
            this.chbTenDangNhap = new System.Windows.Forms.CheckBox();
            this.chbTrangThai = new System.Windows.Forms.CheckBox();
            this.chbMatKhau = new System.Windows.Forms.CheckBox();
            this.tboTenDangNhap = new System.Windows.Forms.TextBox();
            this.tboMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.eprError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnDeleteChucNang);
            this.groupBox3.Controls.Add(this.cbbChucNang);
            this.groupBox3.Controls.Add(this.btnAddChucNang);
            this.groupBox3.Location = new System.Drawing.Point(692, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 85);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Điều chỉnh chức năng của người dùng";
            // 
            // btnDeleteChucNang
            // 
            this.btnDeleteChucNang.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteChucNang.Image")));
            this.btnDeleteChucNang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteChucNang.Location = new System.Drawing.Point(247, 29);
            this.btnDeleteChucNang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteChucNang.Name = "btnDeleteChucNang";
            this.btnDeleteChucNang.Size = new System.Drawing.Size(73, 45);
            this.btnDeleteChucNang.TabIndex = 29;
            this.btnDeleteChucNang.Text = "Xóa";
            this.btnDeleteChucNang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteChucNang.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDeleteChucNang.UseVisualStyleBackColor = true;
            this.btnDeleteChucNang.Click += new System.EventHandler(this.btnDeleteChucNang_Click);
            // 
            // cbbChucNang
            // 
            this.cbbChucNang.DisplayMember = "TenChucNang";
            this.cbbChucNang.FormattingEnabled = true;
            this.cbbChucNang.Location = new System.Drawing.Point(6, 41);
            this.cbbChucNang.Name = "cbbChucNang";
            this.cbbChucNang.Size = new System.Drawing.Size(159, 22);
            this.cbbChucNang.TabIndex = 0;
            this.cbbChucNang.ValueMember = "TenChucNang";
            // 
            // btnAddChucNang
            // 
            this.btnAddChucNang.Image = ((System.Drawing.Image)(resources.GetObject("btnAddChucNang.Image")));
            this.btnAddChucNang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddChucNang.Location = new System.Drawing.Point(169, 29);
            this.btnAddChucNang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddChucNang.Name = "btnAddChucNang";
            this.btnAddChucNang.Size = new System.Drawing.Size(72, 45);
            this.btnAddChucNang.TabIndex = 26;
            this.btnAddChucNang.Text = "Thêm";
            this.btnAddChucNang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddChucNang.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddChucNang.UseVisualStyleBackColor = true;
            this.btnAddChucNang.Click += new System.EventHandler(this.btnAddChucNang_Click);
            // 
            // trvTenDangNhap
            // 
            this.trvTenDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvTenDangNhap.Location = new System.Drawing.Point(692, 135);
            this.trvTenDangNhap.Name = "trvTenDangNhap";
            this.trvTenDangNhap.Size = new System.Drawing.Size(327, 296);
            this.trvTenDangNhap.TabIndex = 41;
            // 
            // dgvNguoiDung
            // 
            this.dgvNguoiDung.AllowUserToAddRows = false;
            this.dgvNguoiDung.AllowUserToDeleteRows = false;
            this.dgvNguoiDung.AllowUserToResizeColumns = false;
            this.dgvNguoiDung.AllowUserToResizeRows = false;
            this.dgvNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenDangNhap,
            this.colMatKhau,
            this.colTrangThai});
            this.dgvNguoiDung.Location = new System.Drawing.Point(268, 44);
            this.dgvNguoiDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvNguoiDung.MultiSelect = false;
            this.dgvNguoiDung.Name = "dgvNguoiDung";
            this.dgvNguoiDung.ReadOnly = true;
            this.dgvNguoiDung.RowHeadersWidth = 62;
            this.dgvNguoiDung.RowTemplate.Height = 28;
            this.dgvNguoiDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNguoiDung.Size = new System.Drawing.Size(414, 387);
            this.dgvNguoiDung.TabIndex = 36;
            this.dgvNguoiDung.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguoiDung_RowEnter);
            // 
            // colTenDangNhap
            // 
            this.colTenDangNhap.DataPropertyName = "TenDangNhap";
            this.colTenDangNhap.HeaderText = "Tên đăng nhập";
            this.colTenDangNhap.MinimumWidth = 6;
            this.colTenDangNhap.Name = "colTenDangNhap";
            this.colTenDangNhap.ReadOnly = true;
            this.colTenDangNhap.Width = 157;
            // 
            // colMatKhau
            // 
            this.colMatKhau.DataPropertyName = "MatKhau";
            this.colMatKhau.HeaderText = "Mật khẩu";
            this.colMatKhau.MinimumWidth = 6;
            this.colMatKhau.Name = "colMatKhau";
            this.colMatKhau.ReadOnly = true;
            this.colMatKhau.Width = 157;
            // 
            // colTrangThai
            // 
            this.colTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btoXoa);
            this.groupBox2.Controls.Add(this.btoSua);
            this.groupBox2.Controls.Add(this.btoThem);
            this.groupBox2.Location = new System.Drawing.Point(3, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 85);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điều chỉnh thông tin";
            // 
            // btoXoa
            // 
            this.btoXoa.Image = ((System.Drawing.Image)(resources.GetObject("btoXoa.Image")));
            this.btoXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoXoa.Location = new System.Drawing.Point(176, 29);
            this.btoXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btoXoa.Name = "btoXoa";
            this.btoXoa.Size = new System.Drawing.Size(74, 45);
            this.btoXoa.TabIndex = 29;
            this.btoXoa.Text = "Xóa";
            this.btoXoa.UseVisualStyleBackColor = true;
            this.btoXoa.Click += new System.EventHandler(this.btoXoa_Click);
            // 
            // btoSua
            // 
            this.btoSua.Image = ((System.Drawing.Image)(resources.GetObject("btoSua.Image")));
            this.btoSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoSua.Location = new System.Drawing.Point(96, 29);
            this.btoSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btoSua.Name = "btoSua";
            this.btoSua.Size = new System.Drawing.Size(74, 45);
            this.btoSua.TabIndex = 28;
            this.btoSua.Text = "Sửa";
            this.btoSua.UseVisualStyleBackColor = true;
            this.btoSua.Click += new System.EventHandler(this.btoSua_Click);
            // 
            // btoThem
            // 
            this.btoThem.Image = ((System.Drawing.Image)(resources.GetObject("btoThem.Image")));
            this.btoThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoThem.Location = new System.Drawing.Point(16, 29);
            this.btoThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btoThem.Name = "btoThem";
            this.btoThem.Size = new System.Drawing.Size(74, 45);
            this.btoThem.TabIndex = 26;
            this.btoThem.Text = "Thêm";
            this.btoThem.UseVisualStyleBackColor = true;
            this.btoThem.Click += new System.EventHandler(this.btoThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lsbTrangThai);
            this.groupBox1.Controls.Add(this.btoTimKiem);
            this.groupBox1.Controls.Add(this.chbTenDangNhap);
            this.groupBox1.Controls.Add(this.chbTrangThai);
            this.groupBox1.Controls.Add(this.chbMatKhau);
            this.groupBox1.Controls.Add(this.tboTenDangNhap);
            this.groupBox1.Controls.Add(this.tboMatKhau);
            this.groupBox1.Location = new System.Drawing.Point(0, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(262, 295);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin người dùng";
            // 
            // lsbTrangThai
            // 
            this.lsbTrangThai.FormattingEnabled = true;
            this.lsbTrangThai.ItemHeight = 14;
            this.lsbTrangThai.Items.AddRange(new object[] {
            "cho phép",
            "khoá"});
            this.lsbTrangThai.Location = new System.Drawing.Point(15, 181);
            this.lsbTrangThai.Name = "lsbTrangThai";
            this.lsbTrangThai.Size = new System.Drawing.Size(123, 32);
            this.lsbTrangThai.TabIndex = 36;
            // 
            // btoTimKiem
            // 
            this.btoTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btoTimKiem.Image")));
            this.btoTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoTimKiem.Location = new System.Drawing.Point(15, 230);
            this.btoTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btoTimKiem.Name = "btoTimKiem";
            this.btoTimKiem.Size = new System.Drawing.Size(225, 45);
            this.btoTimKiem.TabIndex = 35;
            this.btoTimKiem.Text = "Tìm";
            this.btoTimKiem.UseVisualStyleBackColor = true;
            this.btoTimKiem.Click += new System.EventHandler(this.btoTimKiem_Click);
            // 
            // chbTenDangNhap
            // 
            this.chbTenDangNhap.AutoSize = true;
            this.chbTenDangNhap.Location = new System.Drawing.Point(15, 37);
            this.chbTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbTenDangNhap.Name = "chbTenDangNhap";
            this.chbTenDangNhap.Size = new System.Drawing.Size(98, 18);
            this.chbTenDangNhap.TabIndex = 16;
            this.chbTenDangNhap.Text = "Tên đăng nhập:";
            this.chbTenDangNhap.UseVisualStyleBackColor = true;
            // 
            // chbTrangThai
            // 
            this.chbTrangThai.AutoSize = true;
            this.chbTrangThai.Location = new System.Drawing.Point(17, 155);
            this.chbTrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbTrangThai.Name = "chbTrangThai";
            this.chbTrangThai.Size = new System.Drawing.Size(78, 18);
            this.chbTrangThai.TabIndex = 15;
            this.chbTrangThai.Text = "Trạng thái:";
            this.chbTrangThai.UseVisualStyleBackColor = true;
            // 
            // chbMatKhau
            // 
            this.chbMatKhau.AutoSize = true;
            this.chbMatKhau.Location = new System.Drawing.Point(17, 98);
            this.chbMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbMatKhau.Name = "chbMatKhau";
            this.chbMatKhau.Size = new System.Drawing.Size(73, 18);
            this.chbMatKhau.TabIndex = 15;
            this.chbMatKhau.Text = "Mật khẩu:";
            this.chbMatKhau.UseVisualStyleBackColor = true;
            // 
            // tboTenDangNhap
            // 
            this.tboTenDangNhap.Location = new System.Drawing.Point(15, 68);
            this.tboTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboTenDangNhap.Name = "tboTenDangNhap";
            this.tboTenDangNhap.Size = new System.Drawing.Size(223, 20);
            this.tboTenDangNhap.TabIndex = 1;
            this.tboTenDangNhap.TextChanged += new System.EventHandler(this.tboTenDangNhap_TextChanged);
            // 
            // tboMatKhau
            // 
            this.tboMatKhau.Location = new System.Drawing.Point(17, 125);
            this.tboMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboMatKhau.Name = "tboMatKhau";
            this.tboMatKhau.PasswordChar = '*';
            this.tboMatKhau.Size = new System.Drawing.Size(221, 20);
            this.tboMatKhau.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(364, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 31);
            this.label3.TabIndex = 38;
            this.label3.Text = "QUẢN LÝ PHÂN QUYỀN";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 437);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1024, 22);
            this.statusStrip1.TabIndex = 37;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 17);
            this.lblStatus.Text = "Thông báo:";
            // 
            // eprError
            // 
            this.eprError.ContainerControl = this;
            // 
            // frmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 459);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.trvTenDangNhap);
            this.Controls.Add(this.dgvNguoiDung);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmNguoiDung";
            this.Text = "frmQuanLyPhanQuyen";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDeleteChucNang;
        private System.Windows.Forms.ComboBox cbbChucNang;
        private System.Windows.Forms.Button btnAddChucNang;
        private System.Windows.Forms.TreeView trvTenDangNhap;
        private System.Windows.Forms.DataGridView dgvNguoiDung;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btoXoa;
        private System.Windows.Forms.Button btoSua;
        private System.Windows.Forms.Button btoThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btoTimKiem;
        private System.Windows.Forms.CheckBox chbTenDangNhap;
        private System.Windows.Forms.CheckBox chbTrangThai;
        private System.Windows.Forms.CheckBox chbMatKhau;
        private System.Windows.Forms.TextBox tboTenDangNhap;
        private System.Windows.Forms.TextBox tboMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ErrorProvider eprError;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.ListBox lsbTrangThai;
    }
}