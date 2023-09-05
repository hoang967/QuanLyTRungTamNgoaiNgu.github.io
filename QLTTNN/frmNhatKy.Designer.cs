namespace QLTTNN
{
    partial class frmNhatKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhatKy));
            this.dgvNhatKy = new System.Windows.Forms.DataGridView();
            this.colMaNhatky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.btoTimKiem = new System.Windows.Forms.Button();
            this.chbNoiDung = new System.Windows.Forms.CheckBox();
            this.tboNoiDung = new System.Windows.Forms.TextBox();
            this.chbTenDangNhap = new System.Windows.Forms.CheckBox();
            this.tboTenDangNhap = new System.Windows.Forms.TextBox();
            this.chbThoiDiemDen = new System.Windows.Forms.CheckBox();
            this.chbThoiDiemTu = new System.Windows.Forms.CheckBox();
            this.dtpThoiDiemDen = new System.Windows.Forms.DateTimePicker();
            this.dtpThoiDiemTu = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhatKy)).BeginInit();
            this.grbTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhatKy
            // 
            this.dgvNhatKy.AllowUserToAddRows = false;
            this.dgvNhatKy.AllowUserToDeleteRows = false;
            this.dgvNhatKy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhatKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhatKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNhatky,
            this.colTenDangNhap,
            this.colThoiDiem,
            this.colNoiDung});
            this.dgvNhatKy.Location = new System.Drawing.Point(12, 148);
            this.dgvNhatKy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvNhatKy.Name = "dgvNhatKy";
            this.dgvNhatKy.ReadOnly = true;
            this.dgvNhatKy.RowHeadersWidth = 51;
            this.dgvNhatKy.RowTemplate.Height = 24;
            this.dgvNhatKy.Size = new System.Drawing.Size(828, 408);
            this.dgvNhatKy.TabIndex = 3;
            this.dgvNhatKy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhatKy_CellContentClick);
            // 
            // colMaNhatky
            // 
            this.colMaNhatky.DataPropertyName = "MaNhatKy";
            this.colMaNhatky.HeaderText = "Mã nhật ký";
            this.colMaNhatky.MinimumWidth = 6;
            this.colMaNhatky.Name = "colMaNhatky";
            this.colMaNhatky.ReadOnly = true;
            this.colMaNhatky.Width = 125;
            // 
            // colTenDangNhap
            // 
            this.colTenDangNhap.DataPropertyName = "TenDangNhap";
            this.colTenDangNhap.HeaderText = "Tên đăng nhập";
            this.colTenDangNhap.MinimumWidth = 6;
            this.colTenDangNhap.Name = "colTenDangNhap";
            this.colTenDangNhap.ReadOnly = true;
            this.colTenDangNhap.Width = 150;
            // 
            // colThoiDiem
            // 
            this.colThoiDiem.DataPropertyName = "ThoiDiem";
            this.colThoiDiem.HeaderText = "Thời điểm";
            this.colThoiDiem.MinimumWidth = 6;
            this.colThoiDiem.Name = "colThoiDiem";
            this.colThoiDiem.ReadOnly = true;
            this.colThoiDiem.Width = 250;
            // 
            // colNoiDung
            // 
            this.colNoiDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNoiDung.DataPropertyName = "NoiDung";
            this.colNoiDung.HeaderText = "Nội dung";
            this.colNoiDung.MinimumWidth = 6;
            this.colNoiDung.Name = "colNoiDung";
            this.colNoiDung.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "THÔNG TIN NHẬT KÝ";
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbTimKiem.Controls.Add(this.chbThoiDiemDen);
            this.grbTimKiem.Controls.Add(this.chbThoiDiemTu);
            this.grbTimKiem.Controls.Add(this.dtpThoiDiemDen);
            this.grbTimKiem.Controls.Add(this.dtpThoiDiemTu);
            this.grbTimKiem.Controls.Add(this.btoTimKiem);
            this.grbTimKiem.Controls.Add(this.chbNoiDung);
            this.grbTimKiem.Controls.Add(this.tboNoiDung);
            this.grbTimKiem.Controls.Add(this.chbTenDangNhap);
            this.grbTimKiem.Controls.Add(this.tboTenDangNhap);
            this.grbTimKiem.Location = new System.Drawing.Point(12, 54);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(828, 87);
            this.grbTimKiem.TabIndex = 35;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tiêu chí tìm kiếm";
            // 
            // btoTimKiem
            // 
            this.btoTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btoTimKiem.Image")));
            this.btoTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoTimKiem.Location = new System.Drawing.Point(698, 26);
            this.btoTimKiem.Name = "btoTimKiem";
            this.btoTimKiem.Size = new System.Drawing.Size(124, 43);
            this.btoTimKiem.TabIndex = 20;
            this.btoTimKiem.Text = "Tìm";
            this.btoTimKiem.UseVisualStyleBackColor = true;
            this.btoTimKiem.Click += new System.EventHandler(this.btoTimKiem_Click);
            // 
            // chbNoiDung
            // 
            this.chbNoiDung.AutoSize = true;
            this.chbNoiDung.Location = new System.Drawing.Point(234, 26);
            this.chbNoiDung.Name = "chbNoiDung";
            this.chbNoiDung.Size = new System.Drawing.Size(71, 17);
            this.chbNoiDung.TabIndex = 1;
            this.chbNoiDung.Text = "Nội Dung";
            this.chbNoiDung.UseVisualStyleBackColor = true;
            this.chbNoiDung.CheckedChanged += new System.EventHandler(this.chbTenDangNhap_CheckedChanged);
            // 
            // tboNoiDung
            // 
            this.tboNoiDung.Enabled = false;
            this.tboNoiDung.Location = new System.Drawing.Point(234, 49);
            this.tboNoiDung.Name = "tboNoiDung";
            this.tboNoiDung.Size = new System.Drawing.Size(192, 20);
            this.tboNoiDung.TabIndex = 0;
            // 
            // chbTenDangNhap
            // 
            this.chbTenDangNhap.AutoSize = true;
            this.chbTenDangNhap.Location = new System.Drawing.Point(6, 26);
            this.chbTenDangNhap.Name = "chbTenDangNhap";
            this.chbTenDangNhap.Size = new System.Drawing.Size(100, 17);
            this.chbTenDangNhap.TabIndex = 1;
            this.chbTenDangNhap.Text = "Tên đăng nhập";
            this.chbTenDangNhap.UseVisualStyleBackColor = true;
            this.chbTenDangNhap.CheckedChanged += new System.EventHandler(this.chbTenDangNhap_CheckedChanged);
            // 
            // tboTenDangNhap
            // 
            this.tboTenDangNhap.Enabled = false;
            this.tboTenDangNhap.Location = new System.Drawing.Point(6, 49);
            this.tboTenDangNhap.Name = "tboTenDangNhap";
            this.tboTenDangNhap.Size = new System.Drawing.Size(192, 20);
            this.tboTenDangNhap.TabIndex = 0;
            // 
            // chbThoiDiemDen
            // 
            this.chbThoiDiemDen.AutoSize = true;
            this.chbThoiDiemDen.Location = new System.Drawing.Point(446, 53);
            this.chbThoiDiemDen.Margin = new System.Windows.Forms.Padding(2);
            this.chbThoiDiemDen.Name = "chbThoiDiemDen";
            this.chbThoiDiemDen.Size = new System.Drawing.Size(92, 17);
            this.chbThoiDiemDen.TabIndex = 24;
            this.chbThoiDiemDen.Text = "Thời gian đến";
            this.chbThoiDiemDen.UseVisualStyleBackColor = true;
            this.chbThoiDiemDen.CheckedChanged += new System.EventHandler(this.chbThoiDiemDen_CheckedChanged);
            // 
            // chbThoiDiemTu
            // 
            this.chbThoiDiemTu.AutoSize = true;
            this.chbThoiDiemTu.Location = new System.Drawing.Point(446, 26);
            this.chbThoiDiemTu.Margin = new System.Windows.Forms.Padding(2);
            this.chbThoiDiemTu.Name = "chbThoiDiemTu";
            this.chbThoiDiemTu.Size = new System.Drawing.Size(82, 17);
            this.chbThoiDiemTu.TabIndex = 23;
            this.chbThoiDiemTu.Text = "Thời gian từ";
            this.chbThoiDiemTu.UseVisualStyleBackColor = true;
            this.chbThoiDiemTu.CheckedChanged += new System.EventHandler(this.chbThoiDiemTu_CheckedChanged);
            // 
            // dtpThoiDiemDen
            // 
            this.dtpThoiDiemDen.CustomFormat = "dd/MM/yyyy";
            this.dtpThoiDiemDen.Enabled = false;
            this.dtpThoiDiemDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiDiemDen.Location = new System.Drawing.Point(554, 50);
            this.dtpThoiDiemDen.Margin = new System.Windows.Forms.Padding(2);
            this.dtpThoiDiemDen.Name = "dtpThoiDiemDen";
            this.dtpThoiDiemDen.Size = new System.Drawing.Size(98, 20);
            this.dtpThoiDiemDen.TabIndex = 22;
            // 
            // dtpThoiDiemTu
            // 
            this.dtpThoiDiemTu.CustomFormat = "dd/MM/yyyy";
            this.dtpThoiDiemTu.Enabled = false;
            this.dtpThoiDiemTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiDiemTu.Location = new System.Drawing.Point(554, 23);
            this.dtpThoiDiemTu.Margin = new System.Windows.Forms.Padding(2);
            this.dtpThoiDiemTu.Name = "dtpThoiDiemTu";
            this.dtpThoiDiemTu.Size = new System.Drawing.Size(98, 20);
            this.dtpThoiDiemTu.TabIndex = 21;
            // 
            // frmNhatKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 569);
            this.Controls.Add(this.grbTimKiem);
            this.Controls.Add(this.dgvNhatKy);
            this.Controls.Add(this.label1);
            this.Name = "frmNhatKy";
            this.Text = "frmNhatKy";
            this.Load += new System.EventHandler(this.frmNhatKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhatKy)).EndInit();
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhatKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhatky;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoiDung;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.Button btoTimKiem;
        private System.Windows.Forms.CheckBox chbTenDangNhap;
        private System.Windows.Forms.TextBox tboTenDangNhap;
        private System.Windows.Forms.CheckBox chbNoiDung;
        private System.Windows.Forms.TextBox tboNoiDung;
        private System.Windows.Forms.CheckBox chbThoiDiemDen;
        private System.Windows.Forms.CheckBox chbThoiDiemTu;
        private System.Windows.Forms.DateTimePicker dtpThoiDiemDen;
        private System.Windows.Forms.DateTimePicker dtpThoiDiemTu;
    }
}