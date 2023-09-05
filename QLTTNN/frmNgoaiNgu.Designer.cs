namespace QLTTNN
{
    partial class frmNgoaiNgu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNgoaiNgu));
            this.trvGiaoVien = new System.Windows.Forms.TreeView();
            this.btoTimKiem = new System.Windows.Forms.Button();
            this.btoDong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbMaNgoaiNgu = new System.Windows.Forms.CheckBox();
            this.chbTenNgoaiNgu = new System.Windows.Forms.CheckBox();
            this.tboMaNgoaiNgu = new System.Windows.Forms.TextBox();
            this.tboTenNgoaiNgu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btoXoa = new System.Windows.Forms.Button();
            this.btoSua = new System.Windows.Forms.Button();
            this.dgvNgoaiNgu = new System.Windows.Forms.DataGridView();
            this.colMaNgoaiNgu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNgoaiNgu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btoThem = new System.Windows.Forms.Button();
            this.chbTimKiem = new System.Windows.Forms.CheckBox();
            this.eprError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNgoaiNgu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).BeginInit();
            this.SuspendLayout();
            // 
            // trvGiaoVien
            // 
            this.trvGiaoVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvGiaoVien.Location = new System.Drawing.Point(557, 209);
            this.trvGiaoVien.Name = "trvGiaoVien";
            this.trvGiaoVien.Size = new System.Drawing.Size(236, 229);
            this.trvGiaoVien.TabIndex = 36;
            // 
            // btoTimKiem
            // 
            this.btoTimKiem.Enabled = false;
            this.btoTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btoTimKiem.Image")));
            this.btoTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoTimKiem.Location = new System.Drawing.Point(446, 159);
            this.btoTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btoTimKiem.Name = "btoTimKiem";
            this.btoTimKiem.Size = new System.Drawing.Size(112, 42);
            this.btoTimKiem.TabIndex = 35;
            this.btoTimKiem.Text = "Tìm";
            this.btoTimKiem.UseVisualStyleBackColor = true;
            this.btoTimKiem.Click += new System.EventHandler(this.btoTimKiem_Click);
            // 
            // btoDong
            // 
            this.btoDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btoDong.Location = new System.Drawing.Point(680, 159);
            this.btoDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btoDong.Name = "btoDong";
            this.btoDong.Size = new System.Drawing.Size(112, 42);
            this.btoDong.TabIndex = 33;
            this.btoDong.Text = "Đóng";
            this.btoDong.UseVisualStyleBackColor = true;
            this.btoDong.Click += new System.EventHandler(this.btoDong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chbMaNgoaiNgu);
            this.groupBox1.Controls.Add(this.chbTenNgoaiNgu);
            this.groupBox1.Controls.Add(this.tboMaNgoaiNgu);
            this.groupBox1.Controls.Add(this.tboTenNgoaiNgu);
            this.groupBox1.Location = new System.Drawing.Point(14, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(779, 108);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ngoại ngữ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chbMaNgoaiNgu
            // 
            this.chbMaNgoaiNgu.AutoSize = true;
            this.chbMaNgoaiNgu.Checked = true;
            this.chbMaNgoaiNgu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbMaNgoaiNgu.Location = new System.Drawing.Point(7, 30);
            this.chbMaNgoaiNgu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbMaNgoaiNgu.Name = "chbMaNgoaiNgu";
            this.chbMaNgoaiNgu.Size = new System.Drawing.Size(91, 17);
            this.chbMaNgoaiNgu.TabIndex = 16;
            this.chbMaNgoaiNgu.Text = "Mã ngoại ngữ";
            this.chbMaNgoaiNgu.UseVisualStyleBackColor = true;
            // 
            // chbTenNgoaiNgu
            // 
            this.chbTenNgoaiNgu.AutoSize = true;
            this.chbTenNgoaiNgu.Checked = true;
            this.chbTenNgoaiNgu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTenNgoaiNgu.Location = new System.Drawing.Point(7, 65);
            this.chbTenNgoaiNgu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbTenNgoaiNgu.Name = "chbTenNgoaiNgu";
            this.chbTenNgoaiNgu.Size = new System.Drawing.Size(95, 17);
            this.chbTenNgoaiNgu.TabIndex = 15;
            this.chbTenNgoaiNgu.Text = "Tên ngoại ngữ";
            this.chbTenNgoaiNgu.UseVisualStyleBackColor = true;
            // 
            // tboMaNgoaiNgu
            // 
            this.tboMaNgoaiNgu.Location = new System.Drawing.Point(150, 27);
            this.tboMaNgoaiNgu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboMaNgoaiNgu.Name = "tboMaNgoaiNgu";
            this.tboMaNgoaiNgu.Size = new System.Drawing.Size(112, 20);
            this.tboMaNgoaiNgu.TabIndex = 1;
            // 
            // tboTenNgoaiNgu
            // 
            this.tboTenNgoaiNgu.Location = new System.Drawing.Point(150, 63);
            this.tboTenNgoaiNgu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboTenNgoaiNgu.Name = "tboTenNgoaiNgu";
            this.tboTenNgoaiNgu.Size = new System.Drawing.Size(412, 20);
            this.tboTenNgoaiNgu.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(477, 32);
            this.label3.TabIndex = 31;
            this.label3.Text = "QUẢN LÝ DANH SÁCH NGOẠI NGỮ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 445);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(810, 22);
            this.statusStrip1.TabIndex = 30;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 17);
            this.lblStatus.Text = "Thông báo:";
            // 
            // btoXoa
            // 
            this.btoXoa.Image = ((System.Drawing.Image)(resources.GetObject("btoXoa.Image")));
            this.btoXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoXoa.Location = new System.Drawing.Point(326, 159);
            this.btoXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btoXoa.Name = "btoXoa";
            this.btoXoa.Size = new System.Drawing.Size(112, 42);
            this.btoXoa.TabIndex = 29;
            this.btoXoa.Text = "Xóa";
            this.btoXoa.UseVisualStyleBackColor = true;
            this.btoXoa.Click += new System.EventHandler(this.btoXoa_Click);
            // 
            // btoSua
            // 
            this.btoSua.Image = ((System.Drawing.Image)(resources.GetObject("btoSua.Image")));
            this.btoSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoSua.Location = new System.Drawing.Point(207, 159);
            this.btoSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btoSua.Name = "btoSua";
            this.btoSua.Size = new System.Drawing.Size(112, 42);
            this.btoSua.TabIndex = 28;
            this.btoSua.Text = "Sửa";
            this.btoSua.UseVisualStyleBackColor = true;
            this.btoSua.Click += new System.EventHandler(this.btoSua_Click);
            // 
            // dgvNgoaiNgu
            // 
            this.dgvNgoaiNgu.AllowUserToAddRows = false;
            this.dgvNgoaiNgu.AllowUserToDeleteRows = false;
            this.dgvNgoaiNgu.AllowUserToResizeColumns = false;
            this.dgvNgoaiNgu.AllowUserToResizeRows = false;
            this.dgvNgoaiNgu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNgoaiNgu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNgoaiNgu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNgoaiNgu,
            this.colTenNgoaiNgu});
            this.dgvNgoaiNgu.Location = new System.Drawing.Point(14, 207);
            this.dgvNgoaiNgu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvNgoaiNgu.MultiSelect = false;
            this.dgvNgoaiNgu.Name = "dgvNgoaiNgu";
            this.dgvNgoaiNgu.ReadOnly = true;
            this.dgvNgoaiNgu.RowHeadersWidth = 62;
            this.dgvNgoaiNgu.RowTemplate.Height = 28;
            this.dgvNgoaiNgu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNgoaiNgu.Size = new System.Drawing.Size(537, 231);
            this.dgvNgoaiNgu.TabIndex = 27;
            this.dgvNgoaiNgu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNgoaiNgu_RowEnter);
            // 
            // colMaNgoaiNgu
            // 
            this.colMaNgoaiNgu.DataPropertyName = "MaNgoaiNgu";
            this.colMaNgoaiNgu.HeaderText = "Mã ngoại ngữ";
            this.colMaNgoaiNgu.MinimumWidth = 8;
            this.colMaNgoaiNgu.Name = "colMaNgoaiNgu";
            this.colMaNgoaiNgu.ReadOnly = true;
            this.colMaNgoaiNgu.Width = 200;
            // 
            // colTenNgoaiNgu
            // 
            this.colTenNgoaiNgu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenNgoaiNgu.DataPropertyName = "TenNgoaiNgu";
            this.colTenNgoaiNgu.HeaderText = "Tên ngoại ngữ";
            this.colTenNgoaiNgu.MinimumWidth = 8;
            this.colTenNgoaiNgu.Name = "colTenNgoaiNgu";
            this.colTenNgoaiNgu.ReadOnly = true;
            // 
            // btoThem
            // 
            this.btoThem.Image = ((System.Drawing.Image)(resources.GetObject("btoThem.Image")));
            this.btoThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoThem.Location = new System.Drawing.Point(88, 159);
            this.btoThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btoThem.Name = "btoThem";
            this.btoThem.Size = new System.Drawing.Size(112, 42);
            this.btoThem.TabIndex = 26;
            this.btoThem.Text = "Thêm";
            this.btoThem.UseVisualStyleBackColor = true;
            this.btoThem.Click += new System.EventHandler(this.btoThem_Click);
            // 
            // chbTimKiem
            // 
            this.chbTimKiem.AutoSize = true;
            this.chbTimKiem.Location = new System.Drawing.Point(14, 168);
            this.chbTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbTimKiem.Name = "chbTimKiem";
            this.chbTimKiem.Size = new System.Drawing.Size(68, 17);
            this.chbTimKiem.TabIndex = 34;
            this.chbTimKiem.Text = "Tìm kiếm";
            this.chbTimKiem.UseVisualStyleBackColor = true;
            this.chbTimKiem.CheckedChanged += new System.EventHandler(this.chbTimKiem_CheckedChanged);
            // 
            // eprError
            // 
            this.eprError.ContainerControl = this;
            // 
            // frmNgoaiNgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 467);
            this.Controls.Add(this.trvGiaoVien);
            this.Controls.Add(this.btoTimKiem);
            this.Controls.Add(this.btoDong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btoXoa);
            this.Controls.Add(this.btoSua);
            this.Controls.Add(this.dgvNgoaiNgu);
            this.Controls.Add(this.btoThem);
            this.Controls.Add(this.chbTimKiem);
            this.Name = "frmNgoaiNgu";
            this.Text = "frmNgoaiNgu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNgoaiNgu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trvGiaoVien;
        private System.Windows.Forms.Button btoTimKiem;
        private System.Windows.Forms.Button btoDong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbMaNgoaiNgu;
        private System.Windows.Forms.CheckBox chbTenNgoaiNgu;
        private System.Windows.Forms.TextBox tboMaNgoaiNgu;
        private System.Windows.Forms.TextBox tboTenNgoaiNgu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Button btoXoa;
        private System.Windows.Forms.Button btoSua;
        private System.Windows.Forms.DataGridView dgvNgoaiNgu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNgoaiNgu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNgoaiNgu;
        private System.Windows.Forms.Button btoThem;
        private System.Windows.Forms.CheckBox chbTimKiem;
        private System.Windows.Forms.ErrorProvider eprError;
    }
}