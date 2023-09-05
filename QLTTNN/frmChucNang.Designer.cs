namespace QLTTNN
{
    partial class frmChucNang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChucNang));
            this.trvHienThi = new System.Windows.Forms.TreeView();
            this.dgvChucNang = new System.Windows.Forms.DataGridView();
            this.colMaChucNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenChucNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btoXoa = new System.Windows.Forms.Button();
            this.btoSua = new System.Windows.Forms.Button();
            this.btoThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btoTimKiem = new System.Windows.Forms.Button();
            this.chbMaChucNang = new System.Windows.Forms.CheckBox();
            this.chbTrangThai = new System.Windows.Forms.CheckBox();
            this.chbTenChucNang = new System.Windows.Forms.CheckBox();
            this.tboMaChucNang = new System.Windows.Forms.TextBox();
            this.tboTrangThai = new System.Windows.Forms.TextBox();
            this.tboTenChucNang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.eprError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucNang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).BeginInit();
            this.SuspendLayout();
            // 
            // trvHienThi
            // 
            this.trvHienThi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvHienThi.Location = new System.Drawing.Point(945, 52);
            this.trvHienThi.Name = "trvHienThi";
            this.trvHienThi.Size = new System.Drawing.Size(255, 421);
            this.trvHienThi.TabIndex = 46;
            // 
            // dgvChucNang
            // 
            this.dgvChucNang.AllowUserToAddRows = false;
            this.dgvChucNang.AllowUserToDeleteRows = false;
            this.dgvChucNang.AllowUserToResizeColumns = false;
            this.dgvChucNang.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvChucNang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChucNang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChucNang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucNang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaChucNang,
            this.colTenChucNang,
            this.colTrangThai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChucNang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChucNang.Location = new System.Drawing.Point(330, 52);
            this.dgvChucNang.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvChucNang.MultiSelect = false;
            this.dgvChucNang.Name = "dgvChucNang";
            this.dgvChucNang.ReadOnly = true;
            this.dgvChucNang.RowHeadersWidth = 62;
            this.dgvChucNang.RowTemplate.Height = 28;
            this.dgvChucNang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChucNang.Size = new System.Drawing.Size(609, 421);
            this.dgvChucNang.TabIndex = 41;
            this.dgvChucNang.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChucNang_RowEnter);
            // 
            // colMaChucNang
            // 
            this.colMaChucNang.DataPropertyName = "MaChucNang";
            this.colMaChucNang.HeaderText = "Mã chức năng";
            this.colMaChucNang.MinimumWidth = 6;
            this.colMaChucNang.Name = "colMaChucNang";
            this.colMaChucNang.ReadOnly = true;
            // 
            // colTenChucNang
            // 
            this.colTenChucNang.DataPropertyName = "TenChucNang";
            this.colTenChucNang.HeaderText = "Tên chức năng";
            this.colTenChucNang.MinimumWidth = 6;
            this.colTenChucNang.Name = "colTenChucNang";
            this.colTenChucNang.ReadOnly = true;
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
            this.groupBox2.Location = new System.Drawing.Point(0, 372);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(324, 101);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điều chỉnh";
            // 
            // btoXoa
            // 
            this.btoXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btoXoa.Image = ((System.Drawing.Image)(resources.GetObject("btoXoa.Image")));
            this.btoXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoXoa.Location = new System.Drawing.Point(226, 24);
            this.btoXoa.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btoXoa.Name = "btoXoa";
            this.btoXoa.Size = new System.Drawing.Size(92, 54);
            this.btoXoa.TabIndex = 29;
            this.btoXoa.Text = "Xóa";
            this.btoXoa.UseVisualStyleBackColor = true;
            this.btoXoa.Click += new System.EventHandler(this.btoXoa_Click);
            // 
            // btoSua
            // 
            this.btoSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btoSua.Image = ((System.Drawing.Image)(resources.GetObject("btoSua.Image")));
            this.btoSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoSua.Location = new System.Drawing.Point(116, 24);
            this.btoSua.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btoSua.Name = "btoSua";
            this.btoSua.Size = new System.Drawing.Size(92, 54);
            this.btoSua.TabIndex = 28;
            this.btoSua.Text = "Sửa";
            this.btoSua.UseVisualStyleBackColor = true;
            this.btoSua.Click += new System.EventHandler(this.btoSua_Click);
            // 
            // btoThem
            // 
            this.btoThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btoThem.Image = ((System.Drawing.Image)(resources.GetObject("btoThem.Image")));
            this.btoThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoThem.Location = new System.Drawing.Point(6, 24);
            this.btoThem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btoThem.Name = "btoThem";
            this.btoThem.Size = new System.Drawing.Size(92, 54);
            this.btoThem.TabIndex = 26;
            this.btoThem.Text = "Thêm";
            this.btoThem.UseVisualStyleBackColor = true;
            this.btoThem.Click += new System.EventHandler(this.btoThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btoTimKiem);
            this.groupBox1.Controls.Add(this.chbMaChucNang);
            this.groupBox1.Controls.Add(this.chbTrangThai);
            this.groupBox1.Controls.Add(this.chbTenChucNang);
            this.groupBox1.Controls.Add(this.tboMaChucNang);
            this.groupBox1.Controls.Add(this.tboTrangThai);
            this.groupBox1.Controls.Add(this.tboTenChucNang);
            this.groupBox1.Location = new System.Drawing.Point(0, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(324, 310);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chức năng";
            // 
            // btoTimKiem
            // 
            this.btoTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btoTimKiem.Image")));
            this.btoTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoTimKiem.Location = new System.Drawing.Point(19, 232);
            this.btoTimKiem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btoTimKiem.Name = "btoTimKiem";
            this.btoTimKiem.Size = new System.Drawing.Size(250, 54);
            this.btoTimKiem.TabIndex = 35;
            this.btoTimKiem.Text = "Tìm";
            this.btoTimKiem.UseVisualStyleBackColor = true;
            this.btoTimKiem.Click += new System.EventHandler(this.btoTimKiem_Click);
            // 
            // chbMaChucNang
            // 
            this.chbMaChucNang.AutoSize = true;
            this.chbMaChucNang.Location = new System.Drawing.Point(19, 47);
            this.chbMaChucNang.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chbMaChucNang.Name = "chbMaChucNang";
            this.chbMaChucNang.Size = new System.Drawing.Size(94, 18);
            this.chbMaChucNang.TabIndex = 16;
            this.chbMaChucNang.Text = "Mã chức năng:";
            this.chbMaChucNang.UseVisualStyleBackColor = true;
            // 
            // chbTrangThai
            // 
            this.chbTrangThai.AutoSize = true;
            this.chbTrangThai.Location = new System.Drawing.Point(19, 170);
            this.chbTrangThai.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chbTrangThai.Name = "chbTrangThai";
            this.chbTrangThai.Size = new System.Drawing.Size(78, 18);
            this.chbTrangThai.TabIndex = 15;
            this.chbTrangThai.Text = "Trạng thái:";
            this.chbTrangThai.UseVisualStyleBackColor = true;
            // 
            // chbTenChucNang
            // 
            this.chbTenChucNang.AutoSize = true;
            this.chbTenChucNang.Location = new System.Drawing.Point(19, 109);
            this.chbTenChucNang.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chbTenChucNang.Name = "chbTenChucNang";
            this.chbTenChucNang.Size = new System.Drawing.Size(98, 18);
            this.chbTenChucNang.TabIndex = 15;
            this.chbTenChucNang.Text = "Tên chức năng:";
            this.chbTenChucNang.UseVisualStyleBackColor = true;
            // 
            // tboMaChucNang
            // 
            this.tboMaChucNang.Location = new System.Drawing.Point(19, 76);
            this.tboMaChucNang.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tboMaChucNang.Name = "tboMaChucNang";
            this.tboMaChucNang.Size = new System.Drawing.Size(250, 20);
            this.tboMaChucNang.TabIndex = 1;
            // 
            // tboTrangThai
            // 
            this.tboTrangThai.Location = new System.Drawing.Point(19, 199);
            this.tboTrangThai.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tboTrangThai.Name = "tboTrangThai";
            this.tboTrangThai.Size = new System.Drawing.Size(250, 20);
            this.tboTrangThai.TabIndex = 2;
            // 
            // tboTenChucNang
            // 
            this.tboTenChucNang.Location = new System.Drawing.Point(19, 138);
            this.tboTenChucNang.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tboTenChucNang.Name = "tboTenChucNang";
            this.tboTenChucNang.Size = new System.Drawing.Size(250, 20);
            this.tboTenChucNang.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 31);
            this.label3.TabIndex = 43;
            this.label3.Text = "QUẢN LÝ CHỨC NĂNG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1208, 22);
            this.statusStrip1.TabIndex = 42;
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
            // frmChucNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 532);
            this.Controls.Add(this.trvHienThi);
            this.Controls.Add(this.dgvChucNang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmChucNang";
            this.Load += new System.EventHandler(this.frmChucNang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucNang)).EndInit();
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

        private System.Windows.Forms.TreeView trvHienThi;
        private System.Windows.Forms.DataGridView dgvChucNang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btoXoa;
        private System.Windows.Forms.Button btoSua;
        private System.Windows.Forms.Button btoThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btoTimKiem;
        private System.Windows.Forms.CheckBox chbMaChucNang;
        private System.Windows.Forms.CheckBox chbTrangThai;
        private System.Windows.Forms.CheckBox chbTenChucNang;
        private System.Windows.Forms.TextBox tboMaChucNang;
        private System.Windows.Forms.TextBox tboTrangThai;
        private System.Windows.Forms.TextBox tboTenChucNang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ErrorProvider eprError;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaChucNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenChucNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}