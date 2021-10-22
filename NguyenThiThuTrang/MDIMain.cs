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
    public partial class MDIMain : Form
    {
        private int childFormNumber = 0;

        public MDIMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIMain_Load(object sender, EventArgs e)
        {
            // Frm_DangNhap frm_DangNhap = new Frm_DangNhap();
            // frm_DangNhap.Show();
        }

        private void mnu_DangNhap_Click(object sender, EventArgs e)
        {
            Frm_DangNhap frm_DangNhap = new Frm_DangNhap();
            frm_DangNhap.Show();
            this.Close();
        }

        private void mnu_SinhVien_Click(object sender, EventArgs e)
        {
            Frm_SinhVien frm_SinhVien = new Frm_SinhVien();
            frm_SinhVien.Show();
        }

        private void mnu_Lop_Click(object sender, EventArgs e)
        {
            Frm_Lop frm_Lop = new Frm_Lop();
            frm_Lop.Show();
        }

        private void mnu_Khoa_Click(object sender, EventArgs e)
        {
            Frm_Khoa frm_Khoa = new Frm_Khoa();
            frm_Khoa.Show();
        }

        private void mnu_HeDT_Click(object sender, EventArgs e)
        {
            Frm_HeDT frm_HeDT = new Frm_HeDT();
            frm_HeDT.Show();
        }

        private void mnu_BaoCao_Click(object sender, EventArgs e)
        {
          
        }

        private void mnu_TimKiem_Click(object sender, EventArgs e)
        {
            Frm_TimKiem frm_TimKiem = new Frm_TimKiem();
            frm_TimKiem.Show();
        }

        private void mnu_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void báoCáoKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_BaoCao baoCao = new Frm_BaoCao();
            baoCao.Show();
        }

        private void mnu_baocao_lop_Click(object sender, EventArgs e)
        {
            Frm_BaoCao_Lop bc = new Frm_BaoCao_Lop();
            bc.Show();
        }

        private void mnu_baocao_hedt_Click(object sender, EventArgs e)
        {
            Frm_BaoCao_HeDT bc = new Frm_BaoCao_HeDT();
            bc.Show();
        }

        private void mnu_baocao_sv_Click(object sender, EventArgs e)
        {
            Frm_BaoCao_SV bc = new Frm_BaoCao_SV();
            bc.Show();
        }
    }
}
