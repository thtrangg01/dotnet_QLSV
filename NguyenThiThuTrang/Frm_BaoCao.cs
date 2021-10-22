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
    public partial class Frm_BaoCao : Form
    {
        public Frm_BaoCao()
        {
            InitializeComponent();
        }

        private void view_Baocao_Load(object sender, EventArgs e)
        {

        }

        private void Frm_BaoCao_Load(object sender, EventArgs e)
        {
            KetNoi kn = new KetNoi();
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("select * from KHOAVIEN");
            BC_KhoaVien bc = new BC_KhoaVien();
            bc.SetDatabaseLogon("sa", "Admin1234");
            view_Baocao.ReportSource = bc;

           
            //luong_report bc = new luong_report();
            //bc.SetDataSource(dta);
           // CRV.ReportSource = bc;
        }
    }
}
