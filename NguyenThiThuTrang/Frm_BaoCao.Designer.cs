
namespace NguyenThiThuTrang
{
    partial class Frm_BaoCao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.view_Baocao = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // view_Baocao
            // 
            this.view_Baocao.ActiveViewIndex = -1;
            this.view_Baocao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.view_Baocao.Cursor = System.Windows.Forms.Cursors.Default;
            this.view_Baocao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_Baocao.Location = new System.Drawing.Point(0, 0);
            this.view_Baocao.Name = "view_Baocao";
            this.view_Baocao.Size = new System.Drawing.Size(800, 450);
            this.view_Baocao.TabIndex = 0;
            // 
            // Frm_BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.view_Baocao);
            this.Name = "Frm_BaoCao";
            this.Text = "Frm_BaoCao";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer view_Baocao;
    }
}