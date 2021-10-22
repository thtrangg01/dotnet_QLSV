using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenThiThuTrang
{
    public partial class Frm_SinhVien : Form
    {
        public Frm_SinhVien()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();

        private void Frm_SinhVien_Load(object sender, EventArgs e)
        {
            Grid_SinhVien.DataSource = kn.Lay_DulieuBang("Select * from SINHVIEN");
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
