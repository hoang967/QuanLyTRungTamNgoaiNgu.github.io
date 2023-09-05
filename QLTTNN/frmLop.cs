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
    public partial class frmLop : Form
    {
        public void loadFormLop()
        {
            string strQuery = "select * from Lop where 1=1 ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            if (chbMaLop.Checked)
            {
                strQuery += " AND MaLop LIKE '%' + @maLop + '%'";
                parameters.Add("@maLop", tboMaLop.Text);
            }
            if (chbTenLop.Checked)
            {
                strQuery += " AND TenLop LIKE '%' + @tenLop + '%'";
                parameters.Add("@tenLop", tboTenLop.Text);
            }
            if (chbMaGiaoVien.Checked)
            {
                strQuery += " AND MaGiaoVien LIKE '%' + @maGiaoVien + '%'";
                parameters.Add("@maGiaoVien", tboMaGiaoVien.Text);
            }
            if (chbNgayBatDau.Checked)
            {
                strQuery += " AND NgayBatDau >= @ngayBatDau";
                parameters.Add("@ngayBatDau", dtpNgayBatDau.Value.Date);
            }
            if (chbNgayKetThuc.Checked)
            {
                strQuery += " AND NgayKetThuc <= @ngayKetThuc";
                parameters.Add("@ngayKetThuc", dtpNgayKetThuc.Value.AddDays(1).Date);
            }
            if (chbMaNgoaiNgu.Checked)
            {
                strQuery += " AND MaNgoaiNgu LIKE '%' + @maNgoaiNgu + '%'";
                parameters.Add("@maNgoaiNgu", tboMaNgoaiNgu.Text);
            }
            if (chbDiaDiem.Checked)
            {
                strQuery += " AND DiaDiem LIKE '%' + @diaDiem + '%'";
                parameters.Add("@diaDiem", tboDiaDiem.Text);
            }
            if (chbThoiGian.Checked)
            {
                strQuery += " AND ThoiGian LIKE '%' + @thoiGian + '%'";
                parameters.Add("@thoiGian", tboThoiGian.Text);
            }
            if (chbGhiChu.Checked)
            {
                strQuery += " AND GhiChu LIKE '%' + @ghiChu + '%'";
                parameters.Add("@ghiChu", tboGhiChu.Text);
            }
            dgvLop.DataSource = database.ExecuteNonQuery(strQuery, parameters);
            btoSua.Enabled = btoXoa.Enabled = dgvLop.Rows.Count > 0;
        }

        public frmLop()
        {
            InitializeComponent();
            loadFormLop();
            dgvLop.AutoGenerateColumns = false;
        }

        private void frmLop_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btoThem_Click(object sender, EventArgs e)
        {
            string query = "exec USPthemLop @maLop, @tenLop, @maGiaoVien, @ngayBatDau, @ngayKetThuc, @maNgoaiNgu, @diaDiem, @thoiGian, @ghiChu";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maLop", tboMaLop.Text);
            parameters.Add("@tenLop", tboTenLop.Text);
            parameters.Add("@maGiaoVien", tboMaGiaoVien.Text);
            parameters.Add("@ngayBatDau", dtpNgayBatDau.Value);
            parameters.Add("@ngayKetThuc", dtpNgayKetThuc.Value);
            parameters.Add("@maNgoaiNgu", tboMaNgoaiNgu.Text);
            parameters.Add("@diaDiem", tboDiaDiem.Text);
            parameters.Add("@thoiGian", tboDiaDiem.Text);
            parameters.Add("@ghiChu", tboGhiChu.Text);
            try
            {
                database.ExecuteQuery(query, parameters);
                loadFormLop();
            }
            catch (Exception ex)
            {
                if (ex.Message == "Đã có mã lớp này")
                    lblStatus.Text = ex.Message;
                else lblStatus.Text = ex.Message;
            }
        }

        private void btoTimKiem_Click(object sender, EventArgs e)
        {
            loadFormLop();
        }

        private void dgvLop_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            tboMaLop.Text = dgvLop.Rows[e.RowIndex].Cells["colMaLop"].Value.ToString();
            tboTenLop.Text = dgvLop.Rows[e.RowIndex].Cells["colTenLop"].Value.ToString();
            tboMaGiaoVien.Text = dgvLop.Rows[e.RowIndex].Cells["colMaGiaoVien"].Value.ToString();
            dtpNgayBatDau.Value = DateTime.Parse(dgvLop.Rows[e.RowIndex].Cells["colNgayBatDau"].Value.ToString());
            dtpNgayKetThuc.Value = DateTime.Parse(dgvLop.Rows[e.RowIndex].Cells["colNgayKetThuc"].Value.ToString());
            tboMaNgoaiNgu.Text = dgvLop.Rows[e.RowIndex].Cells["colMaNgoaiNgu"].Value.ToString();
            tboDiaDiem.Text = dgvLop.Rows[e.RowIndex].Cells["colDiaDiem"].Value.ToString();
            tboThoiGian.Text = dgvLop.Rows[e.RowIndex].Cells["colThoiGian"].Value.ToString();
            tboGhiChu.Text = dgvLop.Rows[e.RowIndex].Cells["colGhiChu"].Value.ToString();
            // Dữ liệu bảng học viên
            string query = "SELECT * FROM UFviewTenHocVienbyLop(@maLop)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maLop", tboMaLop.Text);
            DataTable data = database.ExecuteNonQuery(query, parameters);
            trvThongTinLop.Nodes.Clear();
            TreeNode node = new TreeNode("Học sinh trong lớp gồm:");
            for (int i = 0; i < data.Rows.Count; ++i)
                node.Nodes.Add(data.Rows[i]["MaHocVien"].ToString() + " - " + data.Rows[i]["Ho"].ToString() + " " + data.Rows[i]["Ten"].ToString());
            node.Expand();
            trvThongTinLop.Nodes.Add(node);
        }

        private void btoSua_Click(object sender, EventArgs e)
        {
            string query = "exec USPupdateLop @maLop, @tenLop, @maGiaoVien, @ngayBatDau, @ngayKetThuc, @maNgoaiNgu, @diaDiem, @thoiGian, @ghiChu";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maLop", tboMaLop.Text);
            parameters.Add("@tenLop", tboTenLop.Text);
            parameters.Add("@maGiaoVien", tboMaGiaoVien.Text);
            parameters.Add("@ngayBatDau", dtpNgayBatDau.Value);
            parameters.Add("@ngayKetThuc", dtpNgayKetThuc.Value);
            parameters.Add("@maNgoaiNgu", tboMaNgoaiNgu.Text);
            parameters.Add("@diaDiem", tboDiaDiem.Text);
            parameters.Add("@thoiGian", tboDiaDiem.Text);
            parameters.Add("@ghiChu", tboGhiChu.Text);
            try
            {
                database.ExecuteQuery(query, parameters);
                loadFormLop();
            }
            catch (Exception ex)
            {
                if (ex.Message == "lớp không tồn tại ")
                    lblStatus.Text = ex.Message;
                else lblStatus.Text = ex.Message;
            }
        }

        private void btoXoa_Click(object sender, EventArgs e)
        {
            string query = "exec USPxoaLop @maLop";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maLop", tboMaLop.Text);
            try
            {
                database.ExecuteQuery(query, parameters);
                loadFormLop();
            }
            catch (Exception ex)
            {
                if (ex.Message == "Còn liên kết với bảng đăng ký ")
                    lblStatus.Text = ex.Message;
                else lblStatus.Text = ex.Message;
            }
        }

        private void chbTimkiem_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTimkiem.Checked == true)
            {
                chbMaLop.Checked = chbTenLop.Checked = chbMaNgoaiNgu.Checked = chbMaGiaoVien.Checked = chbNgayBatDau.Checked = chbNgayKetThuc.Checked = chbThoiGian.Checked = chbGhiChu.Checked = chbDiaDiem.Checked = false;
                chbMaLop.Enabled = chbTenLop.Enabled = chbMaNgoaiNgu.Enabled = chbMaGiaoVien.Enabled = chbNgayBatDau.Enabled = chbNgayKetThuc.Enabled = chbThoiGian.Enabled = chbGhiChu.Enabled = chbDiaDiem.Enabled = true;
                tboMaLop.Enabled = tboTenLop.Enabled = tboMaNgoaiNgu.Enabled = tboMaGiaoVien.Enabled = dtpNgayBatDau.Enabled = dtpNgayKetThuc.Enabled = tboThoiGian.Enabled = tboGhiChu.Enabled = tboDiaDiem.Enabled = false;
                btoTimKiem.Enabled = true;
            }
            if(chbTimkiem.Checked == false)
            {
                chbMaLop.Checked = chbTenLop.Checked = chbMaNgoaiNgu.Checked = chbMaGiaoVien.Checked = chbNgayBatDau.Checked = chbNgayKetThuc.Checked = chbThoiGian.Checked = chbGhiChu.Checked = chbDiaDiem.Checked = true;
                chbMaLop.Enabled = chbTenLop.Enabled = chbMaNgoaiNgu.Enabled = chbMaGiaoVien.Enabled = chbNgayBatDau.Enabled = chbNgayKetThuc.Enabled = chbThoiGian.Enabled = chbGhiChu.Enabled = chbDiaDiem.Enabled = false;
                tboMaLop.Enabled = tboTenLop.Enabled = tboMaNgoaiNgu.Enabled = tboMaGiaoVien.Enabled = dtpNgayBatDau.Enabled = dtpNgayKetThuc.Enabled = tboThoiGian.Enabled = tboGhiChu.Enabled = tboDiaDiem.Enabled = true;
                btoTimKiem.Enabled = false;
            }
           
        }

        private void chbMaLop_CheckedChanged(object sender, EventArgs e)
        {
            tboMaLop.Enabled = chbMaLop.Checked;
        }

        private void chbTenLop_CheckedChanged(object sender, EventArgs e)
        {
            tboTenLop.Enabled = chbTenLop.Checked;
        }

        private void chbMaGiaoVien_CheckedChanged(object sender, EventArgs e)
        {
            tboMaGiaoVien.Enabled = chbMaGiaoVien.Checked;
        }

        private void chbNgayBatDau_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgayBatDau.Enabled = chbNgayBatDau.Checked;
        }

        private void chbNgayKetThuc_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgayKetThuc.Enabled = chbNgayKetThuc.Checked;
        }

        private void chbMaNgoaiNgu_CheckedChanged(object sender, EventArgs e)
        {
            tboMaNgoaiNgu.Enabled = chbMaNgoaiNgu.Checked;
        }

        private void chbDiaDiem_CheckedChanged(object sender, EventArgs e)
        {
            tboDiaDiem.Enabled = chbDiaDiem.Checked;
        }

        private void chbThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            tboThoiGian.Enabled = chbThoiGian.Checked;
        }

        private void chbGhiChu_CheckedChanged(object sender, EventArgs e)
        {
            tboGhiChu.Enabled = chbGhiChu.Checked;
        }
    }
}
