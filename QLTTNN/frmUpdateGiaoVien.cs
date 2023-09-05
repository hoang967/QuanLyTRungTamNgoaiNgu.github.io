using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTTNN
{
    public partial class frmUpdateGiaoVien : Form
    {
        private int maGiaoVien;

        private DataTable data = new DataTable();

        public frmUpdateGiaoVien(int maGiaoVien)
        {
            InitializeComponent();
            loadCbbBangCap();
            loadCbbNgoaiNgu();
            //Nhận mã giáo viên được truyền vào
            this.maGiaoVien = maGiaoVien;
            //Dựa vào mã giáo viên nhận được, lấy ra các thông tin của giáo viên và nạp lên form
            loadForm();

            dgvTrinhDoGiaoVien.AutoGenerateColumns = false;
            data.Columns.Add("MaNgoaiNgu");
            data.Columns.Add("TenNgoaiNgu");
            data.Columns.Add("MaBangCap");
            data.Columns.Add("TenBangCap");
            data.Columns.Add("GhiChu");
        }
        public void loadCbbNgoaiNgu()
        {
            cbbNgoaiNgu.DataSource = database.ExecuteNonQuery("select * from NgoaiNgu", new Dictionary<string, object>());
        }

        public void loadCbbBangCap()
        {
            cbbBangCap.DataSource = database.ExecuteNonQuery("select * from BangCap", new Dictionary<string, object>());
        }
        public void loadForm()
        {
            // dùng maGiaoVien lấy tt 
            string query = "select * from GiaoVien where @maGiaoVien=MaGiaoVien";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maGiaoVien", maGiaoVien);
            DataRow data = database.ExecuteNonQuery(query, parameters).Rows[0];
            dgvTrinhDoGiaoVien.DataSource = data;

            tboMaGiaoVien.Text = data["MaGiaoVien"].ToString();
            tboHo.Text = data["Ho"].ToString();
            tboTen.Text = data["Ten"].ToString();
            dtpNgaySinh.Value = DateTime.Parse(data["NgaySinh"].ToString());
            tboDiaChi.Text = data["DiaChi"].ToString();
            tboDienThoai.Text = data["DienThoai"].ToString();
            tboEmail.Text = data["Email"].ToString();
            if (data["GioiTinh"] == null)
                chbGioiTinh.Checked = false;
            else if (data["GioiTinh"].ToString().ToLower() == "true")
                rdbNam.Checked = true;
            else
                rdbNu.Checked = true;

            parameters.Clear();
            query = "select * from UFloadTrinhDoGiaoVien(@maGiaoVien)";
            parameters.Add("@maGiaoVien", maGiaoVien);
            DataTable table = database.ExecuteNonQuery(query, parameters);
            dgvTrinhDoGiaoVien.DataSource = table;
        }

        public frmUpdateGiaoVien()
        {
            InitializeComponent();
        }

        private void btoNgoaiNgu_Click(object sender, EventArgs e)
        {
            frmNgoaiNgu frm = new frmNgoaiNgu();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            loadForm();
        }

        private void btoThem_Click(object sender, EventArgs e)
        {
            string query = "exec USPaddTrinhDoGiaoVien @maGiaoVien, @maNgoaiNgu, @maBangCap, @ghiChu";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maGiaoVien", maGiaoVien);
            parameters.Add("@maNgoaiNgu", cbbNgoaiNgu.SelectedValue);
            parameters.Add("@maBangCap", cbbBangCap.SelectedValue);
            parameters.Add("@ghiChu", tboGhiChu.Text);
            try
            {
                DataTable data = database.ExecuteNonQuery(query, parameters);
                dgvTrinhDoGiaoVien.DataSource = data;
                loadForm();
            }
            catch (Exception ex)
            {
                if (ex.Message == "đã có bằng ngoại ngữ này")
                    lblStatus.Text = ex.Message;
                else
                    lblStatus.Text = ex.Message;
            }
        }

        private void btoXoa_Click(object sender, EventArgs e)
        {
            string query = "exec USPxoaTrinhDoGiaoVien @maGiaoVien, @maNgoaiNgu, @maBangCap";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maGiaoVien", maGiaoVien);
            parameters.Add("@maNgoaiNgu", cbbNgoaiNgu.SelectedValue);
            parameters.Add("@maBangCap", cbbBangCap.SelectedValue);
            try
            {
                DataTable data = database.ExecuteNonQuery(query, parameters);
                dgvTrinhDoGiaoVien.DataSource = data;
                loadForm();
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        private void dgvTrinhDoGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTrinhDoGiaoVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.RowIndex > -1)
                {
                    cbbBangCap.Text = dgvTrinhDoGiaoVien.Rows[e.RowIndex].Cells["colTenBangCap"].Value.ToString();
                    cbbNgoaiNgu.Text = dgvTrinhDoGiaoVien.Rows[e.RowIndex].Cells["colTenNgoaiNgu"].Value.ToString();
                    tboGhiChu.Text = dgvTrinhDoGiaoVien.Rows[e.RowIndex].Cells["colGhiChu"].Value.ToString();
                }
            }
        }

        private void btoBangCap_Click(object sender, EventArgs e)
        {
            frmBangCap frm = new frmBangCap();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            loadForm();
        }

        private void btoLuu_Click(object sender, EventArgs e)
        {
            string query = "exec USPupdateGiaoVien @maGiaoVien, @ho, @ten, @ngaySinh, @gioiTinh, @diaChi, @dienThoai, @email";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maGiaoVien", maGiaoVien);
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
            try
            {
                database.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Sửa thông tin thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }
    }
}
