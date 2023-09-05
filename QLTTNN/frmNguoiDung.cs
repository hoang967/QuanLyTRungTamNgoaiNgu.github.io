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
    public partial class frmNguoiDung : Form
    {
        public frmNguoiDung()
        {
            InitializeComponent();
            LoadFormNguoiDung();
            LoadCbbNgoaiNgu();
            dgvNguoiDung.AutoGenerateColumns = false;
        }
        public void LoadCbbNgoaiNgu()
        {
            string query = "select * from ChucNang";
            cbbChucNang.DataSource = database.ExecuteNonQuery(query, new Dictionary<string, object>());
        }
        public void LoadFormNguoiDung()
        {
            string query = "select TenDangNhap, MatKhau, IIF(TrangThai IS NULL,N'Cấp quyền',IIF(TrangThai='TRUE',N'Cấp quyền',N'Mất quyền')) TrangThai from NguoiDung where 1=1 ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            if (chbTenDangNhap.Checked)
            {
                query += "and NguoiDung.TenDangNhap LIKE '%' + @TenDangNhap + '%' ";
                parameters.Add("@tenDangNhap", tboTenDangNhap.Text);
            }
            if (chbMatKhau.Checked)
            {
                query += "and MatKhau LIKE '%' + @matKhau + '%' ";
                parameters.Add("@matKhau", tboMatKhau.Text);
            }
            bool trangThai = true;
            if (lsbTrangThai.Text == "Cấp quyền")
                trangThai = false;
            if (chbTrangThai.Checked)
            {
                query += "and NguoiDung.TrangThai=@trangThai ";
                parameters.Add("@trangThai", trangThai);
            }
            DataTable data = database.ExecuteNonQuery(query, parameters);
            dgvNguoiDung.DataSource = data;
        }

        private void tboTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btoThem_Click(object sender, EventArgs e)
        {
            string query = "exec USPthemNguoiDung @tenDangNhap, @matKhau, @trangThai";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tenDangNhap", tboTenDangNhap.Text);
            parameters.Add("@matKhau", tboMatKhau.Text);
            bool trangThai = false;
            if (lsbTrangThai.Text =="cho phép")
                trangThai = true;
            parameters.Add("@trangThai", trangThai);
            try
            {
                DataTable data = database.ExecuteNonQuery(query, parameters);
                dgvNguoiDung.DataSource = data;
                LoadFormNguoiDung();
                lblStatus.Text = "Thêm người dùng thành công";
            }
            catch (Exception ex)
            {
                if (ex.Message == "Tên người dùng đã tồn tại")
                    eprError.SetError(tboTenDangNhap, ex.Message);
                else
                    lblStatus.Text = ex.Message;
            }
        }

        private void btoTimKiem_Click(object sender, EventArgs e)
        {
            LoadFormNguoiDung();
        }

        private void dgvNguoiDung_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            tboTenDangNhap.Text = dgvNguoiDung.Rows[e.RowIndex].Cells["colTenDangNhap"].Value.ToString();
            tboMatKhau.Text = dgvNguoiDung.Rows[e.RowIndex].Cells["colMatKhau"].Value.ToString();
            lsbTrangThai.Text = dgvNguoiDung.Rows[e.RowIndex].Cells["colTrangThai"].Value.ToString();

            string query = "SELECT * FROM UFviewPhanQuyenByTenDangNhap (@tenDangNhap)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tenDangNhap", tboTenDangNhap.Text);
            DataTable data = database.ExecuteNonQuery(query, parameters);
            trvTenDangNhap.Nodes.Clear();
            TreeNode node = new TreeNode("Chức năng của tên đăng nhập là");
            for (int i = 0; i < data.Rows.Count; ++i)
                node.Nodes.Add(data.Rows[i]["TenChucNang"].ToString());
            node.Expand();
            trvTenDangNhap.Nodes.Add(node);
        }

        private void btoSua_Click(object sender, EventArgs e)
        {
            string query = "exec USPupdateNguoiDung @tenDangNhap, @matKhau, @trangThai";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tenDangNhap", tboTenDangNhap.Text);
            parameters.Add("@matKhau", tboMatKhau.Text);
            bool trangThai = true;
            if (lsbTrangThai.Text == "Mất quyền")
                trangThai = false;
            parameters.Add("@trangThai", trangThai);
            try
            {
                DataTable data = database.ExecuteNonQuery(query, parameters);
                dgvNguoiDung.DataSource = data;
                LoadFormNguoiDung();
                lblStatus.Text = "Sửa đổi người dùng thành công";
            }
            catch (Exception ex)
            {
                if (ex.Message == "Tên đăng nhập không tồn tại ")
                    eprError.SetError(tboTenDangNhap, ex.Message);
                else
                    lblStatus.Text = ex.Message;
            }
        }

        private void btoXoa_Click(object sender, EventArgs e)
        {
            string query = "exec USPxoaNguoiDung @tenDangNhap";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tenDangNhap", tboTenDangNhap.Text);
            try
            {
                DataTable data = database.ExecuteNonQuery(query, parameters);
                dgvNguoiDung.DataSource = data;
                LoadFormNguoiDung();
                lblStatus.Text = "Xóa người dùng thành công";
            }
            catch (Exception ex)
            {
                if (ex.Message == "Còn liên quan đến dữ liệu bảng phân quyền ")
                    eprError.SetError(tboTenDangNhap, ex.Message);
                else
                    lblStatus.Text = ex.Message;
            }
        }

        private void btnAddChucNang_Click(object sender, EventArgs e)
        {
            string query = "exec USPthemTenChucNangToNguoiDung @tenDangNhap, @tenChucNang";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tenDangNhap", dgvNguoiDung.CurrentRow.Cells["colTenDangNhap"].Value.ToString());
            parameters.Add("@tenChucNang", cbbChucNang.SelectedValue);
            try
            {
                DataTable data = database.ExecuteNonQuery(query, parameters);
                LoadFormNguoiDung();
                lblStatus.Text = "Thêm chức năng vào người dùng thành công";
            }
            catch (Exception ex)
            {
                if (ex.Message == "Chức năng này đã có sẵn")
                    eprError.SetError(trvTenDangNhap, ex.Message);
                else
                    lblStatus.Text = ex.Message;
            }
        }

        private void btnDeleteChucNang_Click(object sender, EventArgs e)
        {
            string query = "exec USPxoaTenChucNangToNguoiDung @tenDangNhap, @tenChucNang";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tenDangNhap", dgvNguoiDung.CurrentRow.Cells["colTenDangNhap"].Value.ToString());
            parameters.Add("@tenChucNang", cbbChucNang.SelectedValue);
            try
            {
                DataTable data =database.ExecuteNonQuery(query, parameters);
                LoadFormNguoiDung();
                lblStatus.Text = "Xóa chức năng trong người dùng thành công";
            }
            catch (Exception ex)
            {
                if (ex.Message == "Không có chức năng này bên trong người dùng này")
                    eprError.SetError(trvTenDangNhap, ex.Message);
                else
                    lblStatus.Text = ex.Message;
            }
        }

        private void rbKhoa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
