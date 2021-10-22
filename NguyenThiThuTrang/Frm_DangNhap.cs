using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NguyenThiThuTrang
{
    public partial class Frm_DangNhap : Form
    {
        public Frm_DangNhap()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string username = txt_TenDangNhap.Text;
            string password = txt_MK.Text;
            string selectFomat = "select * from HETHONG where BINARY_CHECKSUM(TENDN) = BINARY_CHECKSUM('{0}') and BINARY_CHECKSUM(MATKHAU) = BINARY_CHECKSUM('{1}');";
            string sql = String.Format(selectFomat, username, password);
            bool logedIn = kn.DocDuLieu(sql).Read();

            txt_TenDangNhap.Focus();

            if(logedIn)
            {
                MDIMain main = new MDIMain();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập");
            }    
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
