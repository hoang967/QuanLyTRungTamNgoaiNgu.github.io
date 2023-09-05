namespace QLTTNN
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.btoThoat = new System.Windows.Forms.Button();
            this.btoDangNhap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tboTenDangNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboMatKhau = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // btoThoat
            // 
            this.btoThoat.Image = ((System.Drawing.Image)(resources.GetObject("btoThoat.Image")));
            this.btoThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoThoat.Location = new System.Drawing.Point(307, 158);
            this.btoThoat.Name = "btoThoat";
            this.btoThoat.Size = new System.Drawing.Size(100, 38);
            this.btoThoat.TabIndex = 21;
            this.btoThoat.Text = "Thoát";
            this.btoThoat.UseVisualStyleBackColor = true;
            this.btoThoat.Click += new System.EventHandler(this.btoThoat_Click);
            // 
            // btoDangNhap
            // 
            this.btoDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("btoDangNhap.Image")));
            this.btoDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoDangNhap.Location = new System.Drawing.Point(191, 158);
            this.btoDangNhap.Name = "btoDangNhap";
            this.btoDangNhap.Size = new System.Drawing.Size(110, 38);
            this.btoDangNhap.TabIndex = 20;
            this.btoDangNhap.Text = "Đăng nhập";
            this.btoDangNhap.UseVisualStyleBackColor = true;
            this.btoDangNhap.Click += new System.EventHandler(this.btoDangNhap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tboTenDangNhap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tboMatKhau);
            this.groupBox1.Location = new System.Drawing.Point(8, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 95);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "thông tin đăng nhập";
            // 
            // tboTenDangNhap
            // 
            this.tboTenDangNhap.Location = new System.Drawing.Point(117, 24);
            this.tboTenDangNhap.Name = "tboTenDangNhap";
            this.tboTenDangNhap.Size = new System.Drawing.Size(270, 20);
            this.tboTenDangNhap.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhâp:";
            // 
            // tboMatKhau
            // 
            this.tboMatKhau.Location = new System.Drawing.Point(117, 55);
            this.tboMatKhau.Name = "tboMatKhau";
            this.tboMatKhau.PasswordChar = '*';
            this.tboMatKhau.Size = new System.Drawing.Size(270, 20);
            this.tboMatKhau.TabIndex = 1;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 213);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btoThoat);
            this.Controls.Add(this.btoDangNhap);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDangNhap";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btoThoat;
        private System.Windows.Forms.Button btoDangNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tboTenDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboMatKhau;
    }
}