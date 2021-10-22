
namespace NguyenThiThuTrang
{
    partial class Frm_TimKiem
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
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.chk_Lop = new System.Windows.Forms.CheckBox();
            this.chk_Khoa = new System.Windows.Forms.CheckBox();
            this.chk_HeDT = new System.Windows.Forms.CheckBox();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.Grid_TimKiem = new System.Windows.Forms.DataGridView();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.lbl_MSV = new System.Windows.Forms.Label();
            this.lbl_hoten = new System.Windows.Forms.Label();
            this.txt_MSV = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_TimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TimKiem.Location = new System.Drawing.Point(240, 25);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(279, 33);
            this.lbl_TimKiem.TabIndex = 0;
            this.lbl_TimKiem.Text = "Tìm Kiếm Thông Tin";
            // 
            // chk_Lop
            // 
            this.chk_Lop.AutoSize = true;
            this.chk_Lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chk_Lop.Location = new System.Drawing.Point(476, 150);
            this.chk_Lop.Name = "chk_Lop";
            this.chk_Lop.Size = new System.Drawing.Size(103, 29);
            this.chk_Lop.TabIndex = 1;
            this.chk_Lop.Text = "Mã Lớp";
            this.chk_Lop.UseVisualStyleBackColor = true;
            // 
            // chk_Khoa
            // 
            this.chk_Khoa.AutoSize = true;
            this.chk_Khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chk_Khoa.Location = new System.Drawing.Point(596, 150);
            this.chk_Khoa.Name = "chk_Khoa";
            this.chk_Khoa.Size = new System.Drawing.Size(117, 29);
            this.chk_Khoa.TabIndex = 1;
            this.chk_Khoa.Text = "Mã Khoa";
            this.chk_Khoa.UseVisualStyleBackColor = true;
            // 
            // chk_HeDT
            // 
            this.chk_HeDT.AutoSize = true;
            this.chk_HeDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chk_HeDT.Location = new System.Drawing.Point(739, 150);
            this.chk_HeDT.Name = "chk_HeDT";
            this.chk_HeDT.Size = new System.Drawing.Size(128, 29);
            this.chk_HeDT.TabIndex = 1;
            this.chk_HeDT.Text = "Mã Hệ ĐT";
            this.chk_HeDT.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TimKiem.Location = new System.Drawing.Point(620, 88);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(226, 31);
            this.txt_TimKiem.TabIndex = 2;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TimKiem.Location = new System.Drawing.Point(726, 253);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(141, 45);
            this.btn_TimKiem.TabIndex = 3;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.Location = new System.Drawing.Point(726, 345);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(141, 45);
            this.btn_Thoat.TabIndex = 3;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // Grid_TimKiem
            // 
            this.Grid_TimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_TimKiem.Location = new System.Drawing.Point(64, 218);
            this.Grid_TimKiem.Name = "Grid_TimKiem";
            this.Grid_TimKiem.Size = new System.Drawing.Size(623, 210);
            this.Grid_TimKiem.TabIndex = 4;
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Search.Location = new System.Drawing.Point(471, 91);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(123, 25);
            this.lbl_Search.TabIndex = 5;
            this.lbl_Search.Text = "SearchKey:";
            // 
            // lbl_MSV
            // 
            this.lbl_MSV.AutoSize = true;
            this.lbl_MSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MSV.Location = new System.Drawing.Point(77, 94);
            this.lbl_MSV.Name = "lbl_MSV";
            this.lbl_MSV.Size = new System.Drawing.Size(146, 25);
            this.lbl_MSV.TabIndex = 6;
            this.lbl_MSV.Text = "Mã Sinh Viên:";
            // 
            // lbl_hoten
            // 
            this.lbl_hoten.AutoSize = true;
            this.lbl_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_hoten.Location = new System.Drawing.Point(77, 150);
            this.lbl_hoten.Name = "lbl_hoten";
            this.lbl_hoten.Size = new System.Drawing.Size(88, 25);
            this.lbl_hoten.TabIndex = 6;
            this.lbl_hoten.Text = "Họ Tên:";
            // 
            // txt_MSV
            // 
            this.txt_MSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MSV.Location = new System.Drawing.Point(229, 91);
            this.txt_MSV.Name = "txt_MSV";
            this.txt_MSV.Size = new System.Drawing.Size(226, 31);
            this.txt_MSV.TabIndex = 2;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_HoTen.Location = new System.Drawing.Point(229, 148);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(226, 31);
            this.txt_HoTen.TabIndex = 2;
            // 
            // Frm_TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.lbl_hoten);
            this.Controls.Add(this.lbl_MSV);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.Grid_TimKiem);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.txt_MSV);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.chk_HeDT);
            this.Controls.Add(this.chk_Khoa);
            this.Controls.Add(this.chk_Lop);
            this.Controls.Add(this.lbl_TimKiem);
            this.Name = "Frm_TimKiem";
            this.Text = "Tìm Kiếm";
            this.Load += new System.EventHandler(this.Frm_TimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_TimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.CheckBox chk_Lop;
        private System.Windows.Forms.CheckBox chk_Khoa;
        private System.Windows.Forms.CheckBox chk_HeDT;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.DataGridView Grid_TimKiem;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.Label lbl_MSV;
        private System.Windows.Forms.Label lbl_hoten;
        private System.Windows.Forms.TextBox txt_MSV;
        private System.Windows.Forms.TextBox txt_HoTen;
    }
}