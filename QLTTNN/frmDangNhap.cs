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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private bool authentication = false;
        public bool Authentication
        {
            get { return authentication; }
        }
        private void btoDangNhap_Click(object sender, EventArgs e)
        {
            string strCommand = "EXEC spdangNhap @tenDangNhap,@matKhau";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tenDangNhap", tboTenDangNhap.Text);
            parameters.Add("@matKhau", tboMatKhau.Text);
            try
            {
                database.ExecuteQuery(strCommand, parameters);
                authentication = true;
                Program.TenDangNhap = tboTenDangNhap.Text;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btoThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
