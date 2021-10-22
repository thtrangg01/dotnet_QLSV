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
    public partial class Frm_BaoCao_SV : Form
    {
        public Frm_BaoCao_SV()
        {
            InitializeComponent();
        }

        private void Frm_BaoCao_SV_Load(object sender, EventArgs e)
        {
           
            BC_Sinhvien bc = new BC_Sinhvien();
            bc.SetDatabaseLogon("sa", "Admin1234");
            crv.ReportSource = bc;
        }
    }
}
