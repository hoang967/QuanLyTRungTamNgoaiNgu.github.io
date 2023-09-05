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
    public partial class frmNgoaiNgu : Form
    {
        public frmNgoaiNgu()
        {
            InitializeComponent();
            loadNgoaiNgu();
        }
        public void loadNgoaiNgu()
        {
            if (chbTimKiem.Checked == false)
            {
                string strQuery = "select MaNgoaiNgu, TenNgoaiNgu from NgoaiNgu";
                DataTable data =database.ExecuteNonQuery(strQuery, new Dictionary<string, object>());
                dgvNgoaiNgu.DataSource = data;
                btoSua.Enabled = btoXoa.Enabled = data.Rows.Count > 0;
            }
            else
            {
                string query = "SELECT * FROM UFtimNgoaingu(@maNgoaiNgu, @tenNgoaiNgu) ";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                if (chbMaNgoaiNgu.Checked == true)
                {
                    parameters.Add("@maNgoaiNgu", tboMaNgoaiNgu.Text);
                }
                else
                    parameters.Add("@maNgoaiNgu", "");

                if (chbTenNgoaiNgu.Checked == true)
                {
                    parameters.Add("@tenNgoaiNgu", tboTenNgoaiNgu.Text);
                }
                else
                    parameters.Add("@tenNgoaiNgu", "");
                DataTable data = database.ExecuteNonQuery(query, parameters);
                dgvNgoaiNgu.DataSource = data;
                btoSua.Enabled = btoXoa.Enabled = data.Rows.Count > 0;
            }
        }
        public bool CatchError()
        {
            eprError.Clear();
            bool result = true;
            if (tboMaNgoaiNgu.Text.Trim() == "")
            {
                eprError.SetError(tboMaNgoaiNgu, "Mã Ngoại Ngữ Trống");
                result = false;
            }
            if (tboMaNgoaiNgu.Text.Length > 3)
            {
                eprError.SetError(tboMaNgoaiNgu, "Mã Ngoại Ngữ Không đúng định dạng");
                result = false;
            }
            if (tboTenNgoaiNgu.Text.Trim() == "")
            {
                //MessageBox.Show("Chưa điền tên ngoại ngữ");
                eprError.SetError(tboTenNgoaiNgu, "Chưa điền tên ngoại ngữ");
                result = false;
            }
            if (tboTenNgoaiNgu.Text.Length > 30)
            {
                //MessageBox.Show("Tên ngoại ngữ không đúng định dạng");
                eprError.SetError(tboTenNgoaiNgu, "Tên ngoại ngữ không đúng định dạng");
                result = false;
            }
            if (result == false)
                lblStatus.Text = "Thông báo: dữ liệu không đúng định dạng";
            return result;
        }
        private void btoThem_Click(object sender, EventArgs e)
        {
            eprError.Clear();
            if (CatchError() == false) return;
            string query = "EXEC USPthemNgoaiNgu @maNgoaiNgu, @tenNgoaiNgu, @nguoiSua";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maNgoaiNgu", tboMaNgoaiNgu.Text);
            parameters.Add("@tenNgoaiNgu", tboTenNgoaiNgu.Text);
            parameters.Add("@nguoiSua", Program.TenDangNhap);
            try
            {
                database.ExecuteQuery(query, parameters);
                loadNgoaiNgu();
                lblStatus.Text = "THông báp: Thêm dữ liệu thành công";
            }
            catch (Exception ex)
            {
                if (ex.Message == "Trùng mã ngoại ngữ")
                    eprError.SetError(tboMaNgoaiNgu, ex.Message);
                if (ex.Message == "Trùng mã tên ngoại ngữ")
                    eprError.SetError(tboTenNgoaiNgu, ex.Message);
                lblStatus.Text = ex.Message;
            }
        }

        private void dgvNgoaiNgu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                tboMaNgoaiNgu.Text = dgvNgoaiNgu.Rows[e.RowIndex].Cells["colMaNgoaiNgu"].Value.ToString();
                tboTenNgoaiNgu.Text = dgvNgoaiNgu.Rows[e.RowIndex].Cells["colTenNgoaiNgu"].Value.ToString();
                string strQuery = "SELECT * FROM UFtimGiaoVienByMaNgoaiNgu(@maNgoaiNgu)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@maNgoaiNgu", tboMaNgoaiNgu.Text);
                DataTable data = database.ExecuteNonQuery(strQuery, parameters);
                //Nạp dữ liệu lên treeview
                trvGiaoVien.Nodes.Clear();
                TreeNode node = new TreeNode("Giáo viên biết ngoại ngữ");
                for (int i = 0; i < data.Rows.Count; ++i)
                    node.Nodes.Add(data.Rows[i]["MaGiaoVien"].ToString() + " - " + data.Rows[i]["Ho"].ToString() + " " + data.Rows[i]["Ten"].ToString());
                node.Expand();
                trvGiaoVien.Nodes.Add(node);
            }
        }

        private void btoXoa_Click(object sender, EventArgs e)
        {
            string query = "EXEC USPxoaNgoaiNgu @maNgoaiNgu";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maNgoaiNgu", tboMaNgoaiNgu.Text);
            try
            {
                database.ExecuteQuery(query, parameters);
                loadNgoaiNgu();
                lblStatus.Text = "THông báo: Xóa dữ liệu thành công";
            }
            catch (Exception ex)
            {
                if (ex.Message == "Còn lớp liên qua tới ngoại ngữ")
                    eprError.SetError(tboMaNgoaiNgu, ex.Message);
                lblStatus.Text = ex.Message;
            }
        }

        private void btoSua_Click(object sender, EventArgs e)
        {
            if (CatchError() == false) return;

            string query = "EXEC USPupdateNgoaiNgu @maNgoaiNgu, @tenNgoaiNgu";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maNgoaiNgu", dgvNgoaiNgu.CurrentRow.Cells["colMaNgoaiNgu"].Value.ToString());
            parameters.Add("@tenNgoaiNgu", tboTenNgoaiNgu.Text);
            try
            {
                database.ExecuteQuery(query, parameters);
                loadNgoaiNgu();
                lblStatus.Text = "Thông báp: Sửa dữ liệu thành công";
            }
            catch (Exception ex)
            {
                if (ex.Message == "Trùng tên ngoại ngữ")
                    eprError.SetError(tboMaNgoaiNgu, ex.Message);
                lblStatus.Text = ex.Message;
            }
        }

        private void btoTimKiem_Click(object sender, EventArgs e)
        {
            loadNgoaiNgu();
        }

        private void chbTimKiem_CheckedChanged(object sender, EventArgs e)
        {
            btoTimKiem.Enabled = chbTimKiem.Checked;
            loadNgoaiNgu();
        }

        private void btoDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
