namespace QLTTNN
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
            System.Windows.Forms.MenuStrip menuStrip1;
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.mniChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNhatKy = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNgoaiNgu = new System.Windows.Forms.ToolStripMenuItem();
            this.mniBangCap = new System.Windows.Forms.ToolStripMenuItem();
            this.mniThemGiaoVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mniThemHocVien = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýGiáoViênHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniGiaoVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHocVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mniLop = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.quảnLýGiáoViênHọcSinhToolStripMenuItem});
            menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            menuStrip1.Size = new System.Drawing.Size(800, 23);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "Hệ thống thông tin";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniNguoiDung,
            this.mniChucNang,
            this.mniNhatKy});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 19);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mniNguoiDung
            // 
            this.mniNguoiDung.Name = "mniNguoiDung";
            this.mniNguoiDung.Size = new System.Drawing.Size(180, 22);
            this.mniNguoiDung.Text = "Quản lý người dùng";
            this.mniNguoiDung.Click += new System.EventHandler(this.mniNguoiDung_Click);
            // 
            // mniChucNang
            // 
            this.mniChucNang.Name = "mniChucNang";
            this.mniChucNang.Size = new System.Drawing.Size(180, 22);
            this.mniChucNang.Text = "Quản lý chức năng";
            this.mniChucNang.Click += new System.EventHandler(this.mniChucNang_Click);
            // 
            // mniNhatKy
            // 
            this.mniNhatKy.Name = "mniNhatKy";
            this.mniNhatKy.Size = new System.Drawing.Size(180, 22);
            this.mniNhatKy.Text = "Quản lý nhật ký ";
            this.mniNhatKy.Click += new System.EventHandler(this.mniNhatKy_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniNgoaiNgu,
            this.mniBangCap,
            this.mniThemGiaoVien,
            this.mniThemHocVien});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(74, 19);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // mniNgoaiNgu
            // 
            this.mniNgoaiNgu.Name = "mniNgoaiNgu";
            this.mniNgoaiNgu.Size = new System.Drawing.Size(180, 22);
            this.mniNgoaiNgu.Text = "Ngoại ngữ";
            this.mniNgoaiNgu.Click += new System.EventHandler(this.mniNgoaiNgu_Click);
            // 
            // mniBangCap
            // 
            this.mniBangCap.Name = "mniBangCap";
            this.mniBangCap.Size = new System.Drawing.Size(180, 22);
            this.mniBangCap.Text = "Bằng Cấp";
            this.mniBangCap.Click += new System.EventHandler(this.mniBangCap_Click);
            // 
            // mniThemGiaoVien
            // 
            this.mniThemGiaoVien.Name = "mniThemGiaoVien";
            this.mniThemGiaoVien.Size = new System.Drawing.Size(180, 22);
            this.mniThemGiaoVien.Text = "Thêm Giáo Viên";
            this.mniThemGiaoVien.Click += new System.EventHandler(this.thêmGiáoViênToolStripMenuItem_Click);
            // 
            // mniThemHocVien
            // 
            this.mniThemHocVien.Name = "mniThemHocVien";
            this.mniThemHocVien.Size = new System.Drawing.Size(180, 22);
            this.mniThemHocVien.Text = "Thêm Học Sinh";
            this.mniThemHocVien.Click += new System.EventHandler(this.thêmHọcSinhToolStripMenuItem_Click);
            // 
            // quảnLýGiáoViênHọcSinhToolStripMenuItem
            // 
            this.quảnLýGiáoViênHọcSinhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniGiaoVien,
            this.mniHocVien,
            this.mniLop});
            this.quảnLýGiáoViênHọcSinhToolStripMenuItem.Name = "quảnLýGiáoViênHọcSinhToolStripMenuItem";
            this.quảnLýGiáoViênHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(162, 19);
            this.quảnLýGiáoViênHọcSinhToolStripMenuItem.Text = "Quản lý Giáo viên Học sinh";
            // 
            // mniGiaoVien
            // 
            this.mniGiaoVien.Name = "mniGiaoVien";
            this.mniGiaoVien.Size = new System.Drawing.Size(180, 22);
            this.mniGiaoVien.Text = "Giáo Viên";
            this.mniGiaoVien.Click += new System.EventHandler(this.mniGiaoVien_Click_1);
            // 
            // mniHocVien
            // 
            this.mniHocVien.Name = "mniHocVien";
            this.mniHocVien.Size = new System.Drawing.Size(180, 22);
            this.mniHocVien.Text = "Học Sinh";
            this.mniHocVien.Click += new System.EventHandler(this.mniHocVien_Click);
            // 
            // mniLop
            // 
            this.mniLop.Name = "mniLop";
            this.mniLop.Size = new System.Drawing.Size(180, 22);
            this.mniLop.Text = "Lớp học";
            this.mniLop.Click += new System.EventHandler(this.mniLop_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem mniChucNang;
        private System.Windows.Forms.ToolStripMenuItem mniNhatKy;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniNgoaiNgu;
        private System.Windows.Forms.ToolStripMenuItem mniBangCap;
        private System.Windows.Forms.ToolStripMenuItem quảnLýGiáoViênHọcSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniGiaoVien;
        private System.Windows.Forms.ToolStripMenuItem mniHocVien;
        private System.Windows.Forms.ToolStripMenuItem mniLop;
        private System.Windows.Forms.ToolStripMenuItem mniThemGiaoVien;
        private System.Windows.Forms.ToolStripMenuItem mniThemHocVien;
    }
}