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
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
            LoadGiaoVien();
            loadCbbBangCap();
            loadCbbNgoaingu();
        }
        public void LoadGiaoVien()
        {
            string strQuery = "SELECT DISTINCT GiaoVien.MaGiaoVien,Ho,Ten,NgaySinh,IIF(GioiTinh IS NULL,N'Không',IIF(GioiTinh='TRUE','Nam',N'Nữ')) GioiTinh,DiaChi,DienThoai,Email FROM GiaoVien LEFT JOIN TrinhDoGiaoVien ON GiaoVien.MaGiaoVien=TrinhDoGiaoVien.MaGiaoVien WHERE 1=1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            if (chbMaGiaoVien.Checked)
            {
                strQuery += " AND GiaoVien.MaGiaoVien=@maGiaoVien";
                parameters.Add("@maGiaoVien", int.Parse(tboMaGiaoVien.Text));
            }
            if (chbHo.Checked)
            {
                strQuery += " AND Ho LIKE '%' + @ho + '%'";
                parameters.Add("@ho", tboHo.Text);
            }
            if (chbTen.Checked)
            {
                strQuery += " AND Ten LIKE '%' + @ten + '%'";
                parameters.Add("@ten", tboTen.Text);
            }
            if (chbNgaySinhTu.Checked)
            {
                strQuery += " AND NgaySinh>=@ngaySinhTu";
                parameters.Add("@ngaySinhTu", dtpNgaySinhTu.Value.Date);
            }
            if (chbNgaySinhDen.Checked)
            {
                strQuery += " AND NgaySinh<=@ngaySinhDen";
                parameters.Add("@ngaySinhDen", dtpNgaySinhDen.Value.AddDays(1).Date);
            }
            if (chbGioiTinh.Checked)
            {
                strQuery += " AND GioiTinh=@gioiTinh";
                parameters.Add("@gioiTinh", rdbNam.Checked);
            }
            if (chbDiaChi.Checked)
            {
                strQuery += " AND DiaChi LIKE '%' + @diaChi + '%'";
                parameters.Add("@diaChi", tboDiaChi.Text);
            }
            if (chbDienThoai.Checked)
            {
                strQuery += " AND DienThoai LIKE '%' + @dienThoai + '%'";
                parameters.Add("@dienThoai", tboDienThoai.Text);
            }
            if (chbEmail.Checked)
            {
                strQuery += " AND Email LIKE '%' + @email + '%'";
                parameters.Add("@email", tboEmail.Text);
            }
            if (chbNgoaiNgu.Checked)
            {
                strQuery += " AND MaNgoaiNgu = @maNgoaiNgu";
                parameters.Add("@maNgoaiNgu", cbbNgoaiNgu.SelectedValue);
            }
            if (chbBangCap.Checked)
            {
                strQuery += " AND MaBangCap = @maBangCap";
                parameters.Add("@maBangCap", cbbBangCap.SelectedValue);
            }
            dgvGiaoVien.DataSource = database.ExecuteNonQuery(strQuery, parameters);
            btoSua.Enabled = btoXoa.Enabled = dgvGiaoVien.Rows.Count > 0;
        }
        public void loadCbbNgoaingu()
        {
            cbbNgoaiNgu.DataSource = database.ExecuteNonQuery("SELECT * FROM NgoaiNgu", new Dictionary<string, object>());
        }

        public void loadCbbBangCap()
        {
            cbbBangCap.DataSource = database.ExecuteNonQuery("SELECT * FROM BangCap", new Dictionary<string, object>());
        }
        private void btoThem_Click(object sender, EventArgs e)
        {
            frmThemGiaoVien frm = new frmThemGiaoVien();
            frm.ShowDialog();
            LoadGiaoVien();
        }

        private void chbMaGiaoVien_CheckedChanged(object sender, EventArgs e)
        {
            tboMaGiaoVien.Enabled = chbMaGiaoVien.Checked;
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

        private void chbDiaChi_CheckedChanged(object sender, EventArgs e)
        {
            tboDiaChi.Enabled = chbDiaChi.Checked;
        }

        private void chbDienThoai_CheckedChanged(object sender, EventArgs e)
        {
            tboDienThoai.Enabled = chbDienThoai.Checked;
        }

        private void chbEmail_CheckedChanged(object sender, EventArgs e)
        {
            tboEmail.Enabled = chbEmail.Checked;
        }

        private void chbNgoaiNgu_CheckedChanged(object sender, EventArgs e)
        {
            cbbNgoaiNgu.Enabled = chbNgoaiNgu.Checked;
        }

        private void chbBangCap_CheckedChanged(object sender, EventArgs e)
        {
            cbbBangCap.Enabled = chbBangCap.Checked;
        }

        private void btoTimKiem_Click(object sender, EventArgs e)
        {
            LoadGiaoVien();
        }

        private void dgvGiaoVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            tboMaGiaoVienHienThi.Text = dgvGiaoVien.Rows[e.RowIndex].Cells["colMaGiaoVien"].Value.ToString();
            tboHoTenHienThi.Text = dgvGiaoVien.Rows[e.RowIndex].Cells["colHo"].Value.ToString() + dgvGiaoVien.Rows[e.RowIndex].Cells["colTen"].Value.ToString();
            tboGioiTinhHienThi.Text = dgvGiaoVien.Rows[e.RowIndex].Cells["colGioiTinh"].Value.ToString();
            tboEmailHienThi.Text = dgvGiaoVien.Rows[e.RowIndex].Cells["colEmail"].Value.ToString();
            dtpNgaySinhHienThi.Value = DateTime.Parse(dgvGiaoVien.Rows[e.RowIndex].Cells["colNgaySinh"].Value.ToString());
            tboDiaChiHienThi.Text = dgvGiaoVien.Rows[e.RowIndex].Cells["colDiaChi"].Value.ToString();
            tboDienThoaiHienThi.Text = dgvGiaoVien.Rows[e.RowIndex].Cells["colDienThoai"].Value.ToString();
            // Lấy mã giáo viên hiển thị
            int maGiaoVien = int.Parse(tboMaGiaoVienHienThi.Text);
            // Dựa vào maGiaoVien lấy ra bảng TrinhDoGiaoVien
            string query = "SELECT * FROM UFxemTrinhDoGiaoVienByMagiaoVien (@maGiaoVien)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maGiaoVien", maGiaoVien);
            DataTable data = database.ExecuteNonQuery(query, parameters);
            dgvTrinhDoGiaoVien.DataSource = data;

            trvTrinhDoGiaoVien.Nodes.Clear();
            for (int i = 0; i < data.Rows.Count; ++i)
            {
                TreeNode node = new TreeNode(data.Rows[i]["TenNgoaiNgu"].ToString());
                node.Nodes.Add("Bằng cấp: " + data.Rows[i]["TenBangCap"].ToString());
                if (data.Rows[i]["GhiChu"].ToString() != "")
                    node.Nodes.Add("Ghi Chú: " + data.Rows[i]["GhiChu"].ToString());
                node.ExpandAll();
                trvTrinhDoGiaoVien.Nodes.Add(node);
            }
        }

        private void chbHienThiNgaySinh_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private void chbHienThiNgaySinh_CheckedChanged(object sender, EventArgs e)
        {
            dgvGiaoVien.Columns["colNgaySinh"].Visible = chbHienThiNgaySinh.Checked;
        }

        private void chbHienThiGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            dgvGiaoVien.Columns["colGioiTinh"].Visible = chbHienThiGioiTinh.Checked;
        }

        private void chbHienThiDienThoai_CheckedChanged(object sender, EventArgs e)
        {
            dgvGiaoVien.Columns["colDienThoai"].Visible = chbHienThiDienThoai.Checked;
        }

        private void chbHienThiEmail_CheckedChanged(object sender, EventArgs e)
        {
            dgvGiaoVien.Columns["colEmail"].Visible = chbHienThiEmail.Checked;
        }

        private void chbHienThiDiaChi_CheckedChanged(object sender, EventArgs e)
        {
            dgvGiaoVien.Columns["colDiaChi"].Visible = chbHienThiDiaChi.Checked;
        }

        private void btoXoa_Click(object sender, EventArgs e)
        {
            int maGiaoVien = (int)dgvGiaoVien.CurrentRow.Cells["colMaGiaoVien"].Value;
            string query = "EXEC USPxoaGiaoVien @maGiaoVien";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maGiaoVien", maGiaoVien);
            try
            {
                database.ExecuteNonQuery(query, parameters);
                LoadGiaoVien();
                lblStatus.Text = "Xóa thành công";
            }
            catch (Exception ex)
            {
                if (ex.Message == "Còn lớp liên qua tới giáo viên")
                {
                    lblStatus.Text = ex.Message;
                }
            }
        }

        private void btoSua_Click(object sender, EventArgs e)
        {
            int maGiaoVien = (int)dgvGiaoVien.CurrentRow.Cells["colmaGiaoVien"].Value;
            frmUpdateGiaoVien frm = new frmUpdateGiaoVien(maGiaoVien);
            frm.ShowDialog();
            LoadGiaoVien();
        }
    }
}
