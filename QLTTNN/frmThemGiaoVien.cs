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
    public partial class frmThemGiaoVien : Form
    {
        private DataTable trinhDoGiaoVien = new DataTable();
        public frmThemGiaoVien()
        {
            InitializeComponent();
            LoadCbbBangCap();
            LoadCbbNgoaiNgu();

            dgvTrinhDoGiaoVien.AutoGenerateColumns = false;

            trinhDoGiaoVien.Columns.Add("MaNgoaiNgu");
            trinhDoGiaoVien.Columns.Add("TenNgoaiNgu");
            trinhDoGiaoVien.Columns.Add("MaBangCap");
            trinhDoGiaoVien.Columns.Add("TenBangCap");
            trinhDoGiaoVien.Columns.Add("GhiChu");
        }
        public void LoadCbbNgoaiNgu()
        {
            cbbNgoaiNgu.DataSource = database.ExecuteNonQuery("select * from NgoaiNgu", new Dictionary<string, object>());
        }

        public void LoadCbbBangCap()
        {
            cbbBangCap.DataSource = database.ExecuteNonQuery("select * from BangCap", new Dictionary<string, object>());
        }

        private void btoNgoaiNgu_Click(object sender, EventArgs e)
        {
            frmNgoaiNgu frm = new frmNgoaiNgu();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            LoadCbbNgoaiNgu();
        }

        private void btoBangCap_Click(object sender, EventArgs e)
        {
            frmBangCap frm = new frmBangCap();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            LoadCbbBangCap();
        }

        private void btoThem_Click(object sender, EventArgs e)
        {
            erpMessage.Clear();
            for (int i = 0; i < trinhDoGiaoVien.Rows.Count; ++i)
            {
                if (trinhDoGiaoVien.Rows[i]["MaNgoaiNgu"].ToString() == cbbNgoaiNgu.SelectedValue.ToString() &&
                   trinhDoGiaoVien.Rows[i]["MaBangCap"].ToString() == cbbBangCap.SelectedValue.ToString())
                {
                    erpMessage.SetError(cbbNgoaiNgu, "Ngoại ngữ này đã được thêm");
                    erpMessage.SetError(cbbBangCap, "Bằng cấp này đã được thêm");
                    return;
                }
            }
            DataRow tDGV = trinhDoGiaoVien.NewRow();
            tDGV["MaNgoaiNgu"] = cbbNgoaiNgu.SelectedValue.ToString();
            tDGV["TenNgoaiNgu"] = cbbNgoaiNgu.Text;
            tDGV["MaBangCap"] = cbbBangCap.SelectedValue.ToString();
            tDGV["TenBangCap"] = cbbBangCap.Text;
            tDGV["GhiChu"] = tboGhiChu.Text;
            trinhDoGiaoVien.Rows.Add(tDGV);
            dgvTrinhDoGiaoVien.DataSource = trinhDoGiaoVien;
            btoXoa.Enabled = dgvTrinhDoGiaoVien.Rows.Count > 0;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btoXoa_Click(object sender, EventArgs e)
        {
            dgvTrinhDoGiaoVien.Rows.RemoveAt(dgvTrinhDoGiaoVien.CurrentRow.Index);
            dgvTrinhDoGiaoVien.DataSource = trinhDoGiaoVien;
            btoXoa.Enabled = dgvTrinhDoGiaoVien.Rows.Count > 0;
        }

        private void btoLuu_Click(object sender, EventArgs e)
        {
            string query = "exec USPaddGiaoVien @ho, @ten, @ngaySinh, @gioiTinh, @diaChi, @dienThoai, @email";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ho", tboHo.Text);
            parameters.Add("@ten", tboTen.Text);
            parameters.Add("@ngaySinh", dtpNgaySinh.Value);
            if (chbGioiTinh.Checked == false)
                parameters.Add("@gioiTinh", null);
            else
                parameters.Add("@gioiTinh", rdbNam.Checked);
            parameters.Add("@diaChi", tboDiaChi.Text);
            parameters.Add("@dienThoai", tboDienThoai.Text);
            parameters.Add("@email", tboEmail.Text);
            database.ExecuteQuery(query, parameters);

            int maGiaoVien = (int)database.ExecuteNonQuery("SELECT MAX(MaGiaoVien) FROM GiaoVien", new Dictionary<string, object>()).Rows[0][0];
            string command = "exec USPaddTrinhDoGiaoVien @maGiaoVien, @maNgoaiNgu, @maBangCap, @ghiChu";
            for (int i = 0; i < trinhDoGiaoVien.Rows.Count; ++i)
            {
                parameters = new Dictionary<string, object>();
                parameters.Add("@maGiaoVien", maGiaoVien);
                parameters.Add("@maNgoaiNgu", trinhDoGiaoVien.Rows[i]["MaNgoaiNgu"]);
                parameters.Add("@maBangCap", trinhDoGiaoVien.Rows[i]["MaBangCap"]);
                parameters.Add("@ghiChu", trinhDoGiaoVien.Rows[i]["GhiChu"]);
                database.ExecuteQuery(command, parameters);
            }
            MessageBox.Show("Đã thêm giáo viên thành công", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
