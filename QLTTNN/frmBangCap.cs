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
    public partial class frmBangCap : Form
    {
        public frmBangCap()
        {
            InitializeComponent();
            loadBangCap();
        }
        public void loadBangCap()
        {
            if (chbTimKiem.Checked == false)
            {
                string query = "SELECT MaBangCap, TenBangCap FROM BangCap";
                DataTable data = database.ExecuteNonQuery(query, new Dictionary<string, object>());
                dgvBangCap.DataSource = data;
                btoThem.Enabled = btoSua.Enabled = btoXoa.Enabled = data.Rows.Count > 0;
            }
            else
            {
                string query = "SELECT * FROM UFtimBangCap(@maBangCap, @tenBangCap) ";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                if (chbMaBangCap.Checked)
                {
                    parameters.Add("@maBangCap", tboMaBangCap.Text);
                }
                else
                    parameters.Add("@maBangCap", "");

                if (chbTenBangCap.Checked)
                {
                    parameters.Add("@tenBangCap", tboTenBangCap.Text);
                }
                else
                    parameters.Add("@tenBangCap", "");
                DataTable data = database.ExecuteNonQuery(query, parameters);
                dgvBangCap.DataSource = data;
                btoThem.Enabled = btoSua.Enabled = btoXoa.Enabled = data.Rows.Count > 0;
            }
        }
        public bool CatchError()
        {
            eprError.Clear();
            bool result = true;
            if (tboMaBangCap.Text.Trim() == "")
            {
                eprError.SetError(tboMaBangCap, "Mã Bằng cấp Trống");
                result = false;
            }
            if (tboMaBangCap.Text.Length > 3)
            {
                eprError.SetError(tboMaBangCap, "Mã Bằng cấp Không đúng định dạng");
                result = false;
            }
            if (tboTenBangCap.Text.Trim() == "")
            {
                eprError.SetError(tboTenBangCap, "Chưa điền tên Bằng cấp");
                result = false;
            }
            if (tboTenBangCap.Text.Length > 30)
            {
                eprError.SetError(tboTenBangCap, "Tên Bằng cấp không đúng định dạng");
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

            string query = "EXEC USPthemBangCap @maBangCap, @tenBangCap";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maBangCap", tboMaBangCap.Text);
            parameters.Add("@tenBangCap", tboTenBangCap.Text);
            try
            {
                database.ExecuteQuery(query, parameters);
                loadBangCap();
            }
            catch (Exception ex)
            {

                if (ex.Message == "Trùng mã bằng cấp")
                    eprError.SetError(tboMaBangCap, ex.Message);
                if (ex.Message == "Trùng tên bằng cấp")
                    eprError.SetError(tboTenBangCap, ex.Message);
                lblStatus.Text = ex.Message;
            }
        }

        private void btoDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi chương trình ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void dgvBangCap_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                tboMaBangCap.Text = dgvBangCap.Rows[e.RowIndex].Cells["colMaBangCap"].Value.ToString();
                tboTenBangCap.Text = dgvBangCap.Rows[e.RowIndex].Cells["colTenBangCap"].Value.ToString();
                string strQuery = "SELECT * FROM UFtimGiaoVienByMaBangCap(@maBangCap)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@maBangCap", tboMaBangCap.Text);
                DataTable data = database.ExecuteNonQuery(strQuery, parameters);
                //Nạp dữ liệu lên treeview
                trvGiaoVien.Nodes.Clear();
                TreeNode node = new TreeNode("Giáo viên có bằng cấp");
                for (int i = 0; i < data.Rows.Count; ++i)
                    node.Nodes.Add(data.Rows[i]["MaGiaoVien"].ToString() + " - " + data.Rows[i]["Ho"].ToString() + " " + data.Rows[i]["Ten"].ToString());
                node.Expand();
                trvGiaoVien.Nodes.Add(node);
            }
        }

        private void btoXoa_Click(object sender, EventArgs e)
        {
            string query = "EXEC USPxoaBangCap @maBangCap";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maBangCap", tboMaBangCap.Text);
            try
            {
                database.ExecuteQuery(query, parameters);
                loadBangCap();
                lblStatus.Text = "THông báo: Xóa thành công";
            }
            catch (Exception ex)
            {
                if (ex.Message == "Còn lớp liên qua tới ngoại ngữ")
                    eprError.SetError(tboMaBangCap, ex.Message);
                lblStatus.Text = ex.Message;
            }
        }

        private void btoSua_Click(object sender, EventArgs e)
        {
            if (CatchError() == false) return;

            string query = "EXEC USPupdateBangCap @maBangCap, @tenBangCap";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maBangCap", dgvBangCap.CurrentRow.Cells["colMaBangCap"].Value.ToString());
            parameters.Add("@tenBangCap", tboTenBangCap.Text);
            try
            {
                database.ExecuteQuery(query, parameters);
                loadBangCap();
                lblStatus.Text = "THông báo: Sửa thành công";
            }
            catch (Exception ex)
            {
                if (ex.Message == "Còn lớp liên qua tới bằng cấp")
                    eprError.SetError(tboMaBangCap, ex.Message);
                lblStatus.Text = ex.Message;
            }
        }

        private void btoTimKiem_Click(object sender, EventArgs e)
        {
            loadBangCap();
        }

        private void chbTimKiem_CheckedChanged(object sender, EventArgs e)
        {
            btoTimKiem.Enabled = chbTimKiem.Checked;
            loadBangCap();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
