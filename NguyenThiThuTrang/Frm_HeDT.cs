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
    public partial class Frm_HeDT : Form
    {
        private KetNoi kn;
        public Frm_HeDT()
        {
            InitializeComponent();
            kn = new KetNoi();
        }

        private void Grid_HeDaoTao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaHe.DataBindings.Clear();
            txt_MaHe.DataBindings.Add("text", Grid_HeDaoTao.DataSource, "MAHE");

            txt_TenHe.DataBindings.Clear();
            txt_TenHe.DataBindings.Add("text", Grid_HeDaoTao.DataSource, "TENHE");

            num_MucHP.DataBindings.Clear();
            num_MucHP.DataBindings.Add("value", Grid_HeDaoTao.DataSource, "MUCHP");

            num_SoNam.DataBindings.Clear();
            num_SoNam.DataBindings.Add("value", Grid_HeDaoTao.DataSource, "SONAM");

            txt_Ghichu.DataBindings.Clear();
            txt_Ghichu.DataBindings.Add("text", Grid_HeDaoTao.DataSource, "GHICHU");

        }

        private void LoadHEDTData()
        {
            //KetNoi kn = new KetNoi();
            kn.KetNoi_Dulieu();
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * FROM HEDAOTAO");
            Grid_HeDaoTao.DataSource = dta;
            btn_Luu.Enabled = false;
        }

        private void Frm_HeDT_Load(object sender, EventArgs e)
        {
            // Grid_HeDaoTao.DataSource = kn.Lay_DulieuBang("Select * from HEDAOTAO");
            LoadHEDTData();
            btn_Luu.Enabled = false;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txt_MaHe.Text = " ";
            txt_TenHe.Text = " ";
            num_MucHP.Value = 0;
            num_SoNam.Value = 0;
            txt_Ghichu.Text = " ";

            txt_MaHe.Focus();
            btn_Luu.Enabled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string sql_Luu = "Insert into HEDAOTAO values ('" + txt_MaHe.Text + "', '" + txt_TenHe.Text + "', " + num_MucHP.Value + " , " + num_SoNam.Value + " ,'" + txt_Ghichu.Text + "') ";
            kn.ThucThi(sql_Luu);
            LoadHEDTData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string maHe = txt_MaHe.Text;
            string tenHe = txt_TenHe.Text;
            decimal mucHP = num_MucHP.Value;
            decimal soNam = num_SoNam.Value;
            string ghiChu = txt_Ghichu.Text;
            
            string prepapre = "update HEDAOTAO set TENHE ='{0}', MUCHP = {1}, SONAM = {2}, GHICHU='{3}' where MAHE='{4}';";
            string sql = String.Format(prepapre, tenHe, mucHP, soNam, ghiChu, maHe);

            try
            {
                kn.ThucThi(sql);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            LoadHEDTData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql_Xoa = "Delete HEDAOTAO where MAHE ='" + txt_MaHe.Text + "'";
            kn.ThucThi(sql_Xoa);
            LoadHEDTData();
        }
    }
}
