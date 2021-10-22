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
        KetNoi kn;
        public Frm_SinhVien()
        {
            InitializeComponent();
            kn = new KetNoi();
        }

        private void Frm_SinhVien_Load(object sender, EventArgs e)
        {
            LoadDataToForm();
            BindingData();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LoadDataToForm() {
            kn.KetNoi_Dulieu();
            Grid_SinhVien.DataSource = kn.Lay_DulieuBang("Select * from SINHVIEN");
        }

        private void BindingData() {
            txt_HoTen.Clear();
            txt_HoTen.DataBindings.Add("Text", Grid_SinhVien.DataSource, "HOVATEN");

            txt_MaSV.Clear();
            txt_MaSV.DataBindings.Add("Text", Grid_SinhVien.DataSource, "MASV");

            txt_NoiSinh.Clear();
            txt_NoiSinh.DataBindings.Add("Text", Grid_SinhVien.DataSource, "NOISINH");

            cbo_MaLop.DataBindings.Add("Text", Grid_SinhVien.DataSource, "MALOP");
            cbo_MaKhoa.DataBindings.Add("Text", Grid_SinhVien.DataSource, "MAKHOA");
            cbo_MaHe.DataBindings.Add("Text", Grid_SinhVien.DataSource, "MAHE");
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txt_HoTen.Text = "";
            txt_MaSV.Text = "";
            txt_NoiSinh.Text = "";
           // btn_Luu.Enabled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string msv = txt_MaSV.Text;
            string hoTen = txt_HoTen.Text;
            string noiSinh = txt_NoiSinh.Text;
            DateTime ngaysinh = date_NgaySinh.Value;
            string gioiTinh = rdn_Nam.Checked ? "nam" : "nu";
            string malop = (string)cbo_MaLop.SelectedValue;
            string maKhoa = (string)cbo_MaKhoa.SelectedValue;
            string maHe = (string)cbo_MaHe.SelectedValue;

            string prepare =
                "insert into SINHVIEN values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');";
            string sql = String.Format(prepare, msv, hoTen, gioiTinh, ngaysinh.ToString(), noiSinh, maKhoa, malop, maHe);

            try
            {
                kn.ThucThi(sql);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            LoadDataToForm();
           // btn_Luu.Enabled = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string msv = txt_MaSV.Text;
            string hoTen = txt_HoTen.Text;
            string noiSinh = txt_NoiSinh.Text;
            DateTime ngaysinh = date_NgaySinh.Value;
            string gioiTinh = rdn_Nam.Checked ? "nam" : "nu";
            string malop = (string)cbo_MaLop.SelectedValue;
            string maKhoa = (string)cbo_MaKhoa.SelectedValue;
            string maHe = (string)cbo_MaHe.SelectedValue;

            string prepapre =
                "update SINHVIEN set HOVATEN = '{0}', GIOITINH = '{1}', NGAYSINH='{2}', NOISINH='{3}', MAKHOA='{4}', MAHE = '{5}' where MASV='{6}' ;";

            string sql = String.Format(prepapre, hoTen, gioiTinh, ngaysinh.ToString(), noiSinh, maKhoa, malop, maHe, msv);

            try
            {
                kn.ThucThi(sql);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            LoadDataToForm();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string msv = txt_MaSV.Text;
            string prepare = "delete from SINHVIEN where MASV = '{0}'";
            string sql = String.Format(prepare, msv);

            DialogResult confirmDialogResult = MessageBox.Show("bạn muốn xóa mã lớp " + msv);
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
            LoadDataToForm();
        }
    }
}
