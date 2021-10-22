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
        private KetNoi kn = new KetNoi();
        public Frm_Lop()
        {
            InitializeComponent();
            kn = new KetNoi();
        }

        private void Grid_Lop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_MaLop.Clear();
            txt_MaLop.DataBindings.Add("Text", Grid_Lop.DataSource, "MALOP");

            txt_TenLop.Clear();
            txt_TenLop.DataBindings.Add("Text", Grid_Lop.DataSource, "TENLOP");

            txt_ghichu.Clear();
            txt_ghichu.DataBindings.Add("Text", Grid_Lop.DataSource, "GHICHU");

            txt_CVHT.Clear();
            txt_CVHT.DataBindings.Add("Text", Grid_Lop.DataSource, "CVHT");

            cbo_MaKhoa.DataBindings.Add("Text", Grid_Lop.DataSource, "MAKHOA");
        }

        private void LoadLopData()
        {
            Grid_Lop.DataSource = kn.Lay_DulieuBang("select * from LOP");
            cbo_MaKhoa.DataSource = kn.Lay_DulieuBang("select MAKHOA, TENKHOA from KHOAVIEN ");
            cbo_MaKhoa.DisplayMember = "TENKHOA";
            cbo_MaKhoa.ValueMember = "MAKHOA";
        }

        private void BindingData()
        {
            txt_MaLop.Clear();
            txt_MaLop.DataBindings.Add("Text", Grid_Lop.DataSource, "MALOP");

            txt_TenLop.Clear();
            txt_TenLop.DataBindings.Add("Text", Grid_Lop.DataSource, "TENLOP");

            txt_ghichu.Clear();
            txt_ghichu.DataBindings.Add("Text", Grid_Lop.DataSource, "GHICHU");

            txt_CVHT.Clear();
            txt_CVHT.DataBindings.Add("Text", Grid_Lop.DataSource, "CVHT");

            cbo_MaKhoa.DataBindings.Add("Text", Grid_Lop.DataSource, "MAKHOA");
        }
        private void Frm_Lop_Load(object sender, EventArgs e)
        {
            //Grid_Lop.DataSource = kn.Lay_DulieuBang("Select * from LOP");
            LoadLopData();
            BindingData();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string maLop = txt_MaLop.Text;
            string tenLop = txt_TenLop.Text;
            string ghiChu = txt_ghichu.Text;
            string cvht = txt_CVHT.Text;
            string maKhoa = (string)cbo_MaKhoa.SelectedValue;
            

            string prepapre = "insert into LOP values ('{0}','{1}', '{2}', '{3}', '{4}');";
            string sql = String.Format(prepapre, maLop, tenLop, maKhoa, cvht, ghiChu);
            try
            {
                kn.ThucThi(sql);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
            LoadLopData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string maLop = txt_MaLop.Text;
            string tenLop = txt_TenLop.Text;
            string ghiChu = txt_ghichu.Text;
            string cvht = txt_CVHT.Text;
            string maKhoa = (string)cbo_MaKhoa.SelectedValue;

            string prepapre = "update LOP set TENLOP='{0}', MAKHOA='{1}',CVHT='{2}',GHICHU='{3}' where MALOP='{4}';";
            string sql = String.Format(prepapre, tenLop, maKhoa, cvht, ghiChu, maLop);

            try
            {
                kn.ThucThi(sql);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maLop = txt_MaLop.Text;
            string prepare = "delete from LOP where MALOP = {0}";
            string sql = String.Format(prepare, maLop);

            DialogResult confirmDialogResult = MessageBox.Show("bạn muốn xóa mã lớp " + maLop);
            if (confirmDialogResult == DialogResult.OK)
            {
                try
                {
                    kn.ThucThi(sql);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
