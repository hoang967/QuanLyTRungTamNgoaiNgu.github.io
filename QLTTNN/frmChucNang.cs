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
    public partial class frmChucNang : Form
    {
        public frmChucNang()
        {
            InitializeComponent();
            LoadFormChucNang();
            dgvChucNang.AutoGenerateColumns = false;
        }
        public void LoadFormChucNang()
        {
            string query = "select MaChucNang, TenChucNang, IIF(TrangThai IS NULL,N'Hiện hữu',IIF(TrangThai='TRUE',N'Hiện hữu',N'Vô hiệu')) TrangThai from ChucNang where 1=1 ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            if (chbMaChucNang.Checked)
            {
                query += "and MaChucNang LIKE '%' + @maChucNang + '%' ";
                parameters.Add("@maChucNang", tboMaChucNang.Text);
            }
            if (chbTenChucNang.Checked)
            {
                query += "and TenChucNang LIKE '%' + @tenChucNang + '%' ";
                parameters.Add("@tenChucNang", tboTenChucNang.Text);
            }
            bool trangThai = true;
            if (tboTrangThai.Text == "Hiện hữu")
                trangThai = false;
            if (chbTrangThai.Checked)
            {
                query += "and TrangThai=@trangThai ";
                parameters.Add("@trangThai", trangThai);
            }
            DataTable data = database.ExecuteNonQuery(query, parameters);
            dgvChucNang.DataSource = data;
        }

        private void frmChucNang_Load(object sender, EventArgs e)
        {

        }

        private void dgvChucNang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            tboMaChucNang.Text = dgvChucNang.Rows[e.RowIndex].Cells["colMaChucNang"].Value.ToString();
            tboTenChucNang.Text = dgvChucNang.Rows[e.RowIndex].Cells["colTenChucNang"].Value.ToString();
            tboTrangThai.Text = dgvChucNang.Rows[e.RowIndex].Cells["colTrangThai"].Value.ToString();

            trvHienThi.Nodes.Clear();
            string query = "select * from UF_ViewtenDangNhapByMaChucNang (@maChucNang)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maChucNang", tboMaChucNang.Text);
            DataTable data = database.ExecuteNonQuery(query, parameters);
            trvHienThi.Nodes.Clear();
            TreeNode node = new TreeNode("người dùng liên quan đến Chức Năng này là");
            for (int i = 0; i < data.Rows.Count; ++i)
                node.Nodes.Add(data.Rows[i]["TenDangNhap"].ToString());
            node.Expand();
            trvHienThi.Nodes.Add(node);
        }

        private void btoTimKiem_Click(object sender, EventArgs e)
        {
            LoadFormChucNang();
        }

        private void btoThem_Click(object sender, EventArgs e)
        {
            string query = "exec USPthemChucNang @maChucNang, @tenChucNang, @trangThai";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maChucNang", tboMaChucNang.Text);
            parameters.Add("@tenChucNang", tboTenChucNang.Text);
            bool trangThai = true;
            if (tboTrangThai.Text == "Hiện hữu")
                trangThai = false;
            parameters.Add("@trangThai", trangThai);
            try
            {
                DataTable data = database.ExecuteNonQuery(query, parameters);
                dgvChucNang.DataSource = data;
                LoadFormChucNang();
                lblStatus.Text = "Thêm người chức năng thành công";
            }
            catch (Exception ex)
            {
                if (ex.Message == "Đã tồn tại chức năng này ")
                    eprError.SetError(tboMaChucNang, ex.Message);
                else
                    lblStatus.Text = ex.Message;
            }
        }

        private void btoSua_Click(object sender, EventArgs e)
        {
            string query = "exec USPupdateChucNang @maChucNang, @tenChucNang, @trangThai";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maChucNang", tboMaChucNang.Text);
            parameters.Add("@tenChucNang", tboTenChucNang.Text);
            bool trangThai = true;
            if (tboTrangThai.Text == "Vô hiệu")
                trangThai = false;
            parameters.Add("@trangThai", trangThai);
            try
            {
                DataTable data = database.ExecuteNonQuery(query, parameters);
                dgvChucNang.DataSource = data;
                LoadFormChucNang();
                lblStatus.Text = "Sửa đổi người dùng thành công";
            }
            catch (Exception ex)
            {
                if (ex.Message == "Tên đăng nhập này không tồn tại  ")
                    eprError.SetError(tboMaChucNang, ex.Message);
                else
                    lblStatus.Text = ex.Message;
            }
        }

        private void btoXoa_Click(object sender, EventArgs e)
        {
            string query = "exec USPxoaChucNang @maChucNang";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maChucNang", tboMaChucNang.Text);
            try
            {
                DataTable data = database.ExecuteNonQuery(query, parameters);
                dgvChucNang.DataSource = data;
                LoadFormChucNang();
                lblStatus.Text = "Xóa người dùng thành công";
            }
            catch (Exception ex)
            {
                if (ex.Message == "Còn liên quan đến dữ liệu bảng phân quyền ")
                    eprError.SetError(tboMaChucNang, ex.Message);
                else
                    lblStatus.Text = ex.Message;
            }
        }
    }
}
