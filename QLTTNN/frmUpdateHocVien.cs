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
    public partial class frmUpdateHocVien : Form
    {
        private int maHocVien = 0;
        private DataTable data = new DataTable();
        public frmUpdateHocVien()
        {
            InitializeComponent();
        }
        public void loadCbbLop()
        {
            cbbLop.DataSource = database.ExecuteNonQuery("select * from Lop", new Dictionary<string, object>());
        }
        public void loadForm()
        {
            string query = "select * from UF_LoadHocVienByMaHocVien(@maHocVien)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maHocVien", maHocVien);
            DataRow data = database.ExecuteNonQuery(query, parameters).Rows[0];
            dgvHocVienDangKy.DataSource = data;

            tboMaGiaoVien.Text = data["MaHocVien"].ToString();
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
            query = "select * from UF_LoadDangKyByMaHocVien(@maHocVien)";
            parameters.Add("@maHocVien", maHocVien);
            DataTable table =database.ExecuteNonQuery(query, parameters);
            dgvHocVienDangKy.DataSource = table;
        }
        public frmUpdateHocVien(int maHocVien)
        {
            InitializeComponent();
            this.maHocVien = maHocVien;

            loadCbbLop();
            loadForm();

            dgvHocVienDangKy.AutoGenerateColumns = false;
            data.Columns.Add("MaLop");
            data.Columns.Add("TenLop");
            data.Columns.Add("Diem");
        }
        private void btoThem_Click(object sender, EventArgs e)
        {
            eprError.Clear();
            string query = "exec USPthemDangKy @maHocVien, @maLop, @diem";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maHocVien", maHocVien);
            parameters.Add("@maLop", cbbLop.SelectedValue);
            parameters.Add("@diem", tboDiem.Text);
            try
            {
                DataTable data = database.ExecuteNonQuery(query, parameters);
                dgvHocVienDangKy.DataSource = data;
                loadForm();
            }
            catch (Exception ex)
            {
                if (ex.Message == "Học viên đã có trong lớp ")
                    lblStatus.Text = ex.Message;
                else
                    lblStatus.Text = ex.Message;
            }
        }

        private void btoXoa_Click(object sender, EventArgs e)
        {
            string query = "exec USPxoaDangKy @maHocVien, @maLop";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maHocVien", maHocVien);
            parameters.Add("@maLop", cbbLop.SelectedValue);
            try
            {
                DataTable data = database.ExecuteNonQuery(query, parameters);
                dgvHocVienDangKy.DataSource = data;
                loadForm();
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        private void btoLuu_Click(object sender, EventArgs e)
        {
            string query = "exec USPupdateHocVien @maHocVien, @ho, @ten, @gioiTinh, @ngaySinh, @diaChi, @dienThoai, @email";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maHocVien", maHocVien);
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
                query = "exec USP_UpdateDangKy @maHocVien, @tenLop, @diem";
                for (int i = 0; i < data.Rows.Count; ++i)
                {
                    parameters.Clear();
                    parameters.Add("@maHocVien", maHocVien);
                    parameters.Add("@maLop", data.Rows[i]["Malop"]);
                    parameters.Add("@diem", data.Rows[i]["Diem"]);
                    data =database.ExecuteNonQuery(query, parameters);
                }
                MessageBox.Show("Sửa thông tin học viên thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        private void btoLop_Click(object sender, EventArgs e)
        {
            frmLop frm = new frmLop();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            loadForm();
        }
    }
}
