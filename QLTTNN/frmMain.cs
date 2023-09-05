using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTTNN
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mniGiaoVien_Click(object sender, EventArgs e)
        {

        }

        private void mniGiaoVien_Click_1(object sender, EventArgs e)
        {
            frmGiaoVien form = new frmGiaoVien();
            for (int i = 0; i < this.MdiChildren.Length; ++i)
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            form.MdiParent = this;
            form.Show();
        }

        private void mniHocVien_Click(object sender, EventArgs e)
        {
            frmHocVien form = new frmHocVien();
            for (int i = 0; i < this.MdiChildren.Length; ++i)
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            form.MdiParent = this;
            form.Show();
        }

        private void mniLop_Click(object sender, EventArgs e)
        {
            frmLop form = new frmLop();
            for (int i = 0; i < this.MdiChildren.Length; ++i)
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            form.MdiParent = this;
            form.Show();
        }

        private void mniNgoaiNgu_Click(object sender, EventArgs e)
        {
            frmNgoaiNgu form = new frmNgoaiNgu();
            for (int i = 0; i < this.MdiChildren.Length; ++i)
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            form.MdiParent = this;
            form.Show();
        }

        private void mniBangCap_Click(object sender, EventArgs e)
        {
            frmBangCap form = new frmBangCap();
            for (int i = 0; i < this.MdiChildren.Length; ++i)
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            form.MdiParent = this;
            form.Show();
        }

        private void mniNguoiDung_Click(object sender, EventArgs e)
        {
            frmNguoiDung form = new frmNguoiDung();
            for (int i = 0; i < this.MdiChildren.Length; ++i)
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            form.MdiParent = this;
            form.Show();
        }

        private void mniChucNang_Click(object sender, EventArgs e)
        {
            frmChucNang form = new frmChucNang();
            for (int i = 0; i < this.MdiChildren.Length; ++i)
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            form.MdiParent = this;
            form.Show();
        }

        private void mniNhatKy_Click(object sender, EventArgs e)
        {
            frmNhatKy form = new frmNhatKy();
            for (int i = 0; i < this.MdiChildren.Length; ++i)
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            form.MdiParent = this;
            form.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
            if (frm.Authentication == false)
                Application.Exit();
            else
            {
                string query = "select * from ufLayPhanQuyen(@tenDangNhap)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@tenDangNhap", Program.TenDangNhap);
                DataTable data = database.ExecuteNonQuery(query, parameters);
                List<string> lstChucNang = new List<string>();
                for (int i = 0; i < data.Rows.Count; ++i)
                {
                    lstChucNang.Add(data.Rows[i]["TenChucNang"].ToString());
                }
                mniNgoaiNgu.Enabled = lstChucNang.Contains("QuanLyNgoaiNgu");
                mniBangCap.Enabled = lstChucNang.Contains("QuanLyBangCap");
                mniHocVien.Enabled = lstChucNang.Contains("QuanLyHocVien");
                mniGiaoVien.Enabled = lstChucNang.Contains("QuanLyGiaoVien");
                mniNguoiDung.Enabled = lstChucNang.Contains("QuanLyNguoiDung");
                mniLop.Enabled = lstChucNang.Contains("QuanLyLop");
                mniNhatKy.Enabled = lstChucNang.Contains("QuanLyNhatKy");
                mniChucNang.Enabled = lstChucNang.Contains("QuanLyChucNang");
                mniThemHocVien.Enabled = lstChucNang.Contains("ThemGiaoVien");
                mniThemHocVien.Enabled = lstChucNang.Contains("ThemHocVien");
            }
        }

        private void thêmGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemGiaoVien form = new frmThemGiaoVien();
            for (int i = 0; i < this.MdiChildren.Length; ++i)
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            form.MdiParent = this;
            form.Show();
        }

        private void thêmHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemHocVien form = new frmThemHocVien();
            for (int i = 0; i < this.MdiChildren.Length; ++i)
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            form.MdiParent = this;
            form.Show();
        }

        private void thêmLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmThemLop form = new frmThemLop();
            for (int i = 0; i < this.MdiChildren.Length; ++i)
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            form.MdiParent = this;
            form.Show();
        */}
    }
}
