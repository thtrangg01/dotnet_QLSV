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
    public partial class Frm_TimKiem : Form
    {
        public Frm_TimKiem()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();
        private void Frm_TimKiem_Load(object sender, EventArgs e)
        {
            string sql = "select * from SINHVIEN sv, HEDAOTAO hdt, KHOAVIEN kv, LOP l where sv.MAHE = hdt.MAHE and sv.MALOP = l.MALOP and sv.MAKHOA = kv.MAKHOA";
            Grid_TimKiem.DataSource = kn.Lay_DulieuBang(sql);
            
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            bool isLopChecked = chk_Lop.Checked;
            bool isKhoaChecked = chk_Khoa.Checked;
            bool isHeDaoTaoChecked = chk_HeDT.Checked;
            string searchKey = txt_TimKiem.Text;
            string msv = txt_MSV.Text;
            string hoTen = txt_HoTen.Text;

            string sql = "select * from SINHVIEN sv, HEDAOTAO hdt, KHOAVIEN kv, LOP l where sv.MAHE = hdt.MAHE and sv.MALOP = l.MALOP and sv.MAKHOA = kv.MAKHOA ";
            if (msv != "")
            {
                sql = sql + "and sv.MASV ='" + msv + "' ";
            }

            if (hoTen != "")
            {
                sql = sql + "and sv.HOVATEN ='" + hoTen + "' ";
            }

            if (isLopChecked)
            {
                sql = sql + "and sv.MALOP ='" + searchKey + "' ";
            }

            if (isHeDaoTaoChecked)
            {
                sql = sql + "and sv.MAHE ='" + searchKey + "' ";
            }

            if (isKhoaChecked)
            {
                sql = sql + "and sv.MAKHOA ='" + searchKey + "' ";
            }

            sql += ";";

            Grid_TimKiem.DataSource = kn.Lay_DulieuBang(sql);

        }
    }
}
