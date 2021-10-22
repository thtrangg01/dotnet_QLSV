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
    public partial class Frm_Khoa : Form
    {

        private KetNoi kn;
        public Frm_Khoa()
        {
            InitializeComponent();
            kn = new KetNoi();
        }

        
        private void Grid_Khoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaKhoa.DataBindings.Clear();
            txt_MaKhoa.DataBindings.Add("text", Grid_Khoa.DataSource, "MAKHOA");

            txt_TenKhoa.DataBindings.Clear();
            txt_TenKhoa.DataBindings.Add("text", Grid_Khoa.DataSource, "TENKHOA");

            txt_DiaChi.DataBindings.Clear();
            txt_DiaChi.DataBindings.Add("text", Grid_Khoa.DataSource, "DiaChi");


            txt_SDT.DataBindings.Clear();
            txt_SDT.DataBindings.Add("text", Grid_Khoa.DataSource, "SODT");

            
        }

        private void LoadKhoaData()
        {
            //KetNoi kn = new KetNoi();
            kn.KetNoi_Dulieu();
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * FROM KHOAVIEN");
            Grid_Khoa.DataSource = dta;
            btn_Luu.Enabled = false;
        }

        private void Frm_Khoa_Load(object sender, EventArgs e)
        {
            // Grid_Khoa.DataSource = kn.Lay_DulieuBang("Select * from KHOAVIEN");
            LoadKhoaData();
            btn_Luu.Enabled = false;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txt_MaKhoa.Text = " ";
            txt_TenKhoa.Text = " ";
            txt_DiaChi.Text = " ";
            txt_SDT.Text = " ";
            
            txt_MaKhoa.Focus();
            btn_Luu.Enabled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string sql_Luu = "Insert into KHOAVIEN values ('" + txt_MaKhoa.Text + "', '"+ txt_TenKhoa.Text + "', '"+ txt_DiaChi.Text + "', ' " + txt_SDT.Text + "') ";
            kn.ThucThi(sql_Luu);
            LoadKhoaData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql_Sua = "Update KHOAVIEN set  TENKHOA = '" + txt_TenKhoa.Text + "', DIACHI = '" + txt_DiaChi.Text + "', SODT = '" + txt_SDT.Text  + "' where MAKHOA = '" + txt_MaKhoa.Text + "'";
            kn.ThucThi(sql_Sua);
            LoadKhoaData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql_Xoa = "Delete KHOAVIEN where MAKHOA ='" + txt_MaKhoa.Text + "'";
            kn.ThucThi(sql_Xoa);
            LoadKhoaData();
        }
    }
}
