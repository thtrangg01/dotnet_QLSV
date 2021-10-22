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
    public partial class Frm_Lop : Form
    {
        public Frm_Lop()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();
        private void Grid_Lop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            
        }

        private void Frm_Lop_Load(object sender, EventArgs e)
        {
            Grid_Lop.DataSource = kn.Lay_DulieuBang("Select * from LOP");
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
