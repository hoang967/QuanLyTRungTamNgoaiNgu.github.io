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
    public partial class frmHocVien : Form
    {
        public frmHocVien()
        {
            InitializeComponent();
            loadCbbLop();
            loadHocVien();
        }
        public void loadCbbLop()
        {
            cbbLop.DataSource = database.ExecuteNonQuery("select * from Lop", new Dictionary<string, object>());
        }
        public void loadHocVien()
        {
            string query = "SELECT DISTINCT HocVien.MaHocVien,Ho,Ten,NgaySinh, IIF(GioiTinh IS NULL,N'Không',IIF(GioiTinh='TRUE','Nam',N'Nữ')) GioiTinh,DiaChi,DienThoai,Email FROM HocVien LEFT JOIN DangKy ON HocVien.MaHocVien=DangKy.MaHocVien where 1=1 ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            if (chbMaHocVien.Checked)
            {
                query += "AND HocVien.MaHocVien=@maHocVien";
                parameters.Add("@maHocVien", int.Parse(tboMaHocVien.Text));
            }
            if (chbHo.Checked)
            {
                query += " AND Ho LIKE '%' + @ho + '%'";
                parameters.Add("@ho", tboHo.Text);
            }
            if (chbTen.Checked)
            {
                query += " AND Ten LIKE '%' + @ten + '%'";
                parameters.Add("@ten", tboTen.Text);
            }
            if (chbNgaySinhTu.Checked)
            {
                query += " AND NgaySinh>=@ngaySinhTu";
                parameters.Add("@ngaySinhTu", dtpNgaySinhTu.Value.Date);
            }
            if (chbNgaySinhDen.Checked)
            {
                query += " AND NgaySinh<=@ngaySinhDen";
                parameters.Add("@ngaySinhDen", dtpNgaySinhDen.Value.AddDays(1).Date);
            }
            if (chbGioiTinh.Checked)
            {
                query += " AND GioiTinh=@gioiTinh";
                parameters.Add("@gioiTinh", rdbNam.Checked);
            }
            if (chbDiaChi.Checked)
            {
                query += " AND DiaChi LIKE '%' + @diaChi + '%'";
                parameters.Add("@diaChi", tboDiaChi.Text);
            }
            if (chbDienThoai.Checked)
            {
                query += " AND DienThoai LIKE '%' + @dienThoai + '%'";
                parameters.Add("@dienThoai", tboDienThoai.Text);
            }
            if (chbEmail.Checked)
            {
                query += " AND Email LIKE '%' + @email + '%'";
                parameters.Add("@email", tboEmail.Text);
            }
            if (chbLop.Checked)
            {
                query += "and MaLop = @maLop";
                parameters.Add("@maLop", cbbLop.SelectedValue);
            }
            dgvHocVien.DataSource = database.ExecuteNonQuery(query, parameters);
            btoSua.Enabled = btoXoa.Enabled = dgvHocVien.Rows.Count > 0;
        }

        private void btoThem_Click(object sender, EventArgs e)
        {
            frmThemHocVien frm = new frmThemHocVien();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            loadHocVien();
        }

        private void btoSua_Click(object sender, EventArgs e)
        {
            int maHocVien = (int)dgvHocVien.CurrentRow.Cells["colMaHocVien"].Value;
            frmUpdateHocVien frm = new frmUpdateHocVien(maHocVien);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            loadHocVien();
        }

        private void chbMaHocVien_CheckedChanged(object sender, EventArgs e)
        {
            tboMaHocVien.Enabled = chbMaHocVien.Checked;
        }

        private void chbHo_CheckedChanged(object sender, EventArgs e)
        {
            tboHo.Enabled = chbHo.Checked;
        }

        private void chbTen_CheckedChanged(object sender, EventArgs e)
        {
            tboTen.Enabled = chbTen.Checked;
        }

        private void chbNgaySinhTu_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgaySinhTu.Enabled = chbNgaySinhTu.Checked;
        }

        private void chbNgaySinhDen_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgaySinhDen.Enabled = chbNgaySinhDen.Checked;
        }

        private void chbGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            grbGioiTinh.Enabled = chbGioiTinh.Checked;
        }

        private void chbDienThoai_CheckedChanged(object sender, EventArgs e)
        {
            tboDienThoai.Enabled = chbDienThoai.Checked;
        }

        private void chbDiaChi_CheckedChanged(object sender, EventArgs e)
        {
            tboDiaChi.Enabled = chbDiaChi.Checked;
        }

        private void chbLop_CheckedChanged(object sender, EventArgs e)
        {
            cbbLop.Enabled = chbLop.Checked;
        }

        private void chbEmail_CheckedChanged(object sender, EventArgs e)
        {
            tboEmail.Enabled = chbEmail.Checked;
        }

        private void btoTimKiem_Click(object sender, EventArgs e)
        {
            loadHocVien();
        }

        private void dgvHocVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            tboMaHocVienHienThi.Text = dgvHocVien.Rows[e.RowIndex].Cells["colMaHocVien"].Value.ToString();
            tboHoTenHienThi.Text = dgvHocVien.Rows[e.RowIndex].Cells["colHo"].Value.ToString() + " " + dgvHocVien.Rows[e.RowIndex].Cells["colTen"].Value.ToString();
            tboDiaChiHienThi.Text = dgvHocVien.Rows[e.RowIndex].Cells["colDiaChi"].Value.ToString();
            tboDienThoaiHienThi.Text = dgvHocVien.Rows[e.RowIndex].Cells["colDienThoai"].Value.ToString();
            tboEmailHienThi.Text = dgvHocVien.Rows[e.RowIndex].Cells["colEmail"].Value.ToString();
            dtpNgaySinhHienThi.Value = DateTime.Parse(dgvHocVien.Rows[e.RowIndex].Cells["colNgaySinh"].Value.ToString());
            tboGioiTinhHienThi.Text = dgvHocVien.Rows[e.RowIndex].Cells["colGioiTinh"].Value.ToString();

            int maHocVien = int.Parse(tboMaHocVienHienThi.Text);
            string query = "select * from UFloadDangKyByMaHocVien(@maHocVien)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maHocVien", maHocVien);
            DataTable data = database.ExecuteNonQuery(query, parameters);
            dgvDangKy.DataSource = data;

            trvDangKyHocVien.Nodes.Clear();
            for (int i = 0; i < data.Rows.Count; ++i)
            {
                TreeNode node = new TreeNode(data.Rows[i]["TenLop"].ToString());
                node.Nodes.Add("Điểm : " + data.Rows[i]["Diem"].ToString());
                node.Expand();
                trvDangKyHocVien.Nodes.Add(node);
            }
        }

        private void chbHienThiNgaySinh_CheckedChanged(object sender, EventArgs e)
        {
            dgvHocVien.Columns["colNgaySinh"].Visible = chbHienThiNgaySinh.Checked;
        }

        private void chbHienThiGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            dgvHocVien.Columns["colGioiTinh"].Visible = chbGioiTinh.Checked;
        }

        private void chbHienThiDiaChi_CheckedChanged(object sender, EventArgs e)
        {
            dgvHocVien.Columns["colDiaChi"].Visible = chbHienThiDiaChi.Checked;
        }

        private void chbHienThiDienThoai_CheckedChanged(object sender, EventArgs e)
        {
            dgvHocVien.Columns["colDienThoai"].Visible = chbHienThiDienThoai.Checked;
        }

        private void chbHienThiEmail_CheckedChanged(object sender, EventArgs e)
        {
            dgvHocVien.Columns["colEmail"].Visible = chbHienThiEmail.Checked;
        }

        private void btoXoa_Click(object sender, EventArgs e)
        {
            int maHocVien = (int)dgvHocVien.CurrentRow.Cells["colMaHocVien"].Value;
            string query = "exec USPxoaHocVien @maHocVien";
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@maHocVien", maHocVien);
                database.ExecuteQuery(query, parameters);
                loadHocVien();
                lblStatus.Text = "Xóa thành công";
            }
            catch (Exception ex)
            {
                if (ex.Message == "Còn lớp liên qua tới học viên")
                    lblStatus.Text = ex.Message;
            }
        }
    }
}
