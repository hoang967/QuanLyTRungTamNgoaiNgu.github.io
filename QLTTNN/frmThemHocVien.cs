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
    public partial class frmThemHocVien : Form
    {
        private DataTable data = new DataTable();
        public frmThemHocVien()
        {
            InitializeComponent();
            loadCbbLop();
            dgvHocVienDangKy.AutoGenerateColumns = false;
            data.Columns.Add("MaLop");
            data.Columns.Add("TenLop");
            data.Columns.Add("Diem");
        }
        public void loadCbbLop()
        {
            cbbLop.DataSource = database.ExecuteNonQuery("select * from Lop", new Dictionary<string, object>());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btoLuu_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmAddHocVien_Load(object sender, EventArgs e)
        {

        }

        private void btoThem_Click(object sender, EventArgs e)
        {
            erpMessage.Clear();
            for (int i = 0; i < data.Rows.Count; ++i)
                if (data.Rows[i]["MaLop"].ToString() == cbbLop.SelectedValue.ToString())
                {
                    erpMessage.SetError(cbbLop, "Mã Lớp đã được thêm");
                    return;
                }
            DataRow DangKyHocVien = data.NewRow();
            DangKyHocVien["Malop"] = cbbLop.SelectedValue.ToString();
            DangKyHocVien["TenLop"] = cbbLop.Text;
            DangKyHocVien["Diem"] = tboDiem.Text;
            data.Rows.Add(DangKyHocVien);
            dgvHocVienDangKy.DataSource = data;
            btoXoa.Enabled = dgvHocVienDangKy.Rows.Count > 0;
        }

        private void btoXoa_Click(object sender, EventArgs e)
        {
            data.Rows.RemoveAt(dgvHocVienDangKy.CurrentRow.Index);
            dgvHocVienDangKy.DataSource = data;
            btoXoa.Enabled = dgvHocVienDangKy.Rows.Count > 0;
        }

        private void btoLuu_Click_1(object sender, EventArgs e)
        {
            try
            {
                int maHocVien = (int)database.ExecuteNonQuery("SELECT MAX(MaHocVien) FROM HocVien", new Dictionary<string, object>()).Rows[0][0];
                string query = "exec USPaddHocVien @ho, @ten, @ngaySinh, @gioiTinh, @diaChi, @dienThoai, @email";
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

                string command = "exec USPaddDangKy @maHocVien, @maLop, @diem";
                for (int i = 0; i < data.Rows.Count; ++i)
                {
                    parameters = new Dictionary<string, object>();
                    parameters.Add("@maHocVien", maHocVien);
                    parameters.Add("@maLop", data.Rows[i]["MaLop"]);
                    parameters.Add("@diem", data.Rows[i]["Diem"]);
                    database.ExecuteQuery(command, parameters);
                }
                MessageBox.Show("thêm thành công", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            loadCbbLop();
        }
    }
}
