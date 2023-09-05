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
            this.StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNgoaiNgu = new System.Windows.Forms.ToolStripMenuItem();
            this.mniBangCap = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.StripMenuItem,
            this.ToolStripMenuItem});
            menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            menuStrip1.Size = new System.Drawing.Size(964, 23);
            menuStrip1.TabIndex = 2;
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
            // 
            // mniChucNang
            // 
            this.mniChucNang.Name = "mniChucNang";
            this.mniChucNang.Size = new System.Drawing.Size(180, 22);
            this.mniChucNang.Text = "Quản lý chức năng";
            // 
            // mniNhatKy
            // 
            this.mniNhatKy.Name = "mniNhatKy";
            this.mniNhatKy.Size = new System.Drawing.Size(180, 22);
            this.mniNhatKy.Text = "Quản lý nhật ký ";
            // 
            // StripMenuItem
            // 
            this.StripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniNgoaiNgu,
            this.mniBangCap});
            this.StripMenuItem.Name = "StripMenuItem";
            this.StripMenuItem.Size = new System.Drawing.Size(74, 19);
            this.StripMenuItem.Text = "Danh mục";
            // 
            // mniNgoaiNgu
            // 
            this.mniNgoaiNgu.Name = "mniNgoaiNgu";
            this.mniNgoaiNgu.Size = new System.Drawing.Size(180, 22);
            this.mniNgoaiNgu.Text = "Ngoại ngữ";
            // 
            // mniBangCap
            // 
            this.mniBangCap.Name = "mniBangCap";
            this.mniBangCap.Size = new System.Drawing.Size(180, 22);
            this.mniBangCap.Text = "Bằng Cấp";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniGiaoVien,
            this.mniHocVien,
            this.mniLop});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(162, 19);
            this.ToolStripMenuItem.Text = "Quản lý Giáo viên Học sinh";
            // 
            // mniGiaoVien
            // 
            this.mniGiaoVien.Name = "mniGiaoVien";
            this.mniGiaoVien.Size = new System.Drawing.Size(180, 22);
            this.mniGiaoVien.Text = "Giáo Viên";
            // 
            // mniHocVien
            // 
            this.mniHocVien.Name = "mniHocVien";
            this.mniHocVien.Size = new System.Drawing.Size(180, 22);
            this.mniHocVien.Text = "Học Sinh";
            // 
            // mniLop
            // 
            this.mniLop.Name = "mniLop";
            this.mniLop.Size = new System.Drawing.Size(180, 22);
            this.mniLop.Text = "Lớp học";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 531);
            this.Controls.Add(menuStrip1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trung Tâm Ngoại Ngữ";
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
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniNgoaiNgu;
        private System.Windows.Forms.ToolStripMenuItem mniBangCap;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniGiaoVien;
        private System.Windows.Forms.ToolStripMenuItem mniHocVien;
        private System.Windows.Forms.ToolStripMenuItem mniLop;
    }
}

