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
    public partial class frmNhatKy : Form
    {
        public frmNhatKy()
        {
            InitializeComponent();
            loadHocVien();
        }
        public void loadHocVien()
        {
            string query = "SELECT DISTINCT MaNhatKy, TenDangNhap,ThoiDiem,NoiDung FROM NhatKy where 1=1 ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            if (chbTenDangNhap.Checked)
            {
                query += " AND TenDangNhap LIKE '%' + @TenDangNhap + '%' ";
                parameters.Add("@tenDangNhap", tboTenDangNhap.Text);
            }
            if (chbNoiDung.Checked)
            {
                query += " AND NoiDung LIKE '%' + @NoiDung + '%' ";
                parameters.Add("@NoiDung", tboNoiDung.Text);
            }
            if (chbThoiDiemTu.Checked)
            {
                query += " AND ThoiDiem>=@ThoiDiemTu";
                parameters.Add("@ThoiDiemTu", dtpThoiDiemTu.Value.Date);
            }
            if (chbThoiDiemDen.Checked)
            {
                query += " AND ThoiDiem<=@ThoiDiemDen";
                parameters.Add("@ThoiDiemDen", dtpThoiDiemDen.Value.AddDays(1).Date);
            }
            dgvNhatKy.DataSource = database.ExecuteNonQuery(query, parameters);
        }
        private void dgvNhatKy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmNhatKy_Load(object sender, EventArgs e)
        {
            string query = "select * from NhatKy";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable data = database.ExecuteNonQuery(query, parameters);
            dgvNhatKy.DataSource = data;
        }

        private void btoTimKiem_Click(object sender, EventArgs e)
        {
            loadHocVien();
        }

        private void chbTenDangNhap_CheckedChanged(object sender, EventArgs e)
        {
            tboTenDangNhap.Enabled = chbTenDangNhap.Checked;
            tboNoiDung.Enabled = chbNoiDung.Checked;
        }

        private void chbThoiDiem_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chbThoiDiemTu_CheckedChanged(object sender, EventArgs e)
        {
            dtpThoiDiemTu.Enabled = chbThoiDiemTu.Checked;
        }

        private void chbThoiDiemDen_CheckedChanged(object sender, EventArgs e)
        {
            dtpThoiDiemDen.Enabled = chbThoiDiemDen.Checked;
        }
    }
}
