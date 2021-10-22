
namespace NguyenThiThuTrang
{
    partial class Frm_SinhVien
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
            this.lbl_SinhVien = new System.Windows.Forms.Label();
            this.lbl_msv = new System.Windows.Forms.Label();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.lbl_NoiSinh = new System.Windows.Forms.Label();
            this.lbl_MaKhoa = new System.Windows.Forms.Label();
            this.lbl_MaLop = new System.Windows.Forms.Label();
            this.lbl_MaHe = new System.Windows.Forms.Label();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.rdn_Nam = new System.Windows.Forms.RadioButton();
            this.rdn_Nu = new System.Windows.Forms.RadioButton();
            this.date_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_NoiSinh = new System.Windows.Forms.TextBox();
            this.cbo_MaKhoa = new System.Windows.Forms.ComboBox();
            this.cbo_MaHe = new System.Windows.Forms.ComboBox();
            this.cbo_MaLop = new System.Windows.Forms.ComboBox();
            this.Grid_SinhVien = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.box_GioiTinh = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_SinhVien)).BeginInit();
            this.box_GioiTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_SinhVien
            // 
            this.lbl_SinhVien.AutoSize = true;
            this.lbl_SinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_SinhVien.Location = new System.Drawing.Point(351, 26);
            this.lbl_SinhVien.Name = "lbl_SinhVien";
            this.lbl_SinhVien.Size = new System.Drawing.Size(241, 31);
            this.lbl_SinhVien.TabIndex = 0;
            this.lbl_SinhVien.Text = "Thông tin sinh viên";
            // 
            // lbl_msv
            // 
            this.lbl_msv.AutoSize = true;
            this.lbl_msv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_msv.Location = new System.Drawing.Point(36, 95);
            this.lbl_msv.Name = "lbl_msv";
            this.lbl_msv.Size = new System.Drawing.Size(71, 24);
            this.lbl_msv.TabIndex = 1;
            this.lbl_msv.Text = "Mã SV:";
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_HoTen.Location = new System.Drawing.Point(36, 128);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(79, 24);
            this.lbl_HoTen.TabIndex = 1;
            this.lbl_HoTen.Text = "Họ Tên:";
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_NgaySinh.Location = new System.Drawing.Point(36, 166);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(102, 24);
            this.lbl_NgaySinh.TabIndex = 1;
            this.lbl_NgaySinh.Text = "Ngày Sinh:";
            // 
            // lbl_NoiSinh
            // 
            this.lbl_NoiSinh.AutoSize = true;
            this.lbl_NoiSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_NoiSinh.Location = new System.Drawing.Point(467, 166);
            this.lbl_NoiSinh.Name = "lbl_NoiSinh";
            this.lbl_NoiSinh.Size = new System.Drawing.Size(87, 24);
            this.lbl_NoiSinh.TabIndex = 1;
            this.lbl_NoiSinh.Text = "Nơi Sinh:";
            // 
            // lbl_MaKhoa
            // 
            this.lbl_MaKhoa.AutoSize = true;
            this.lbl_MaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MaKhoa.Location = new System.Drawing.Point(292, 217);
            this.lbl_MaKhoa.Name = "lbl_MaKhoa";
            this.lbl_MaKhoa.Size = new System.Drawing.Size(90, 24);
            this.lbl_MaKhoa.TabIndex = 1;
            this.lbl_MaKhoa.Text = "Mã Khoa:";
            // 
            // lbl_MaLop
            // 
            this.lbl_MaLop.AutoSize = true;
            this.lbl_MaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MaLop.Location = new System.Drawing.Point(561, 217);
            this.lbl_MaLop.Name = "lbl_MaLop";
            this.lbl_MaLop.Size = new System.Drawing.Size(78, 24);
            this.lbl_MaLop.TabIndex = 1;
            this.lbl_MaLop.Text = "Mã Lớp:";
            // 
            // lbl_MaHe
            // 
            this.lbl_MaHe.AutoSize = true;
            this.lbl_MaHe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MaHe.Location = new System.Drawing.Point(36, 217);
            this.lbl_MaHe.Name = "lbl_MaHe";
            this.lbl_MaHe.Size = new System.Drawing.Size(71, 24);
            this.lbl_MaHe.TabIndex = 1;
            this.lbl_MaHe.Text = "Mã Hệ:";
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaSV.Location = new System.Drawing.Point(132, 91);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(329, 31);
            this.txt_MaSV.TabIndex = 2;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_HoTen.Location = new System.Drawing.Point(132, 128);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(329, 31);
            this.txt_HoTen.TabIndex = 2;
            // 
            // rdn_Nam
            // 
            this.rdn_Nam.AutoSize = true;
            this.rdn_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdn_Nam.Location = new System.Drawing.Point(6, 28);
            this.rdn_Nam.Name = "rdn_Nam";
            this.rdn_Nam.Size = new System.Drawing.Size(74, 29);
            this.rdn_Nam.TabIndex = 3;
            this.rdn_Nam.TabStop = true;
            this.rdn_Nam.Text = "Nam";
            this.rdn_Nam.UseVisualStyleBackColor = true;
            // 
            // rdn_Nu
            // 
            this.rdn_Nu.AutoSize = true;
            this.rdn_Nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdn_Nu.Location = new System.Drawing.Point(99, 28);
            this.rdn_Nu.Name = "rdn_Nu";
            this.rdn_Nu.Size = new System.Drawing.Size(57, 29);
            this.rdn_Nu.TabIndex = 3;
            this.rdn_Nu.TabStop = true;
            this.rdn_Nu.Text = "Nữ";
            this.rdn_Nu.UseVisualStyleBackColor = true;
            // 
            // date_NgaySinh
            // 
            this.date_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.date_NgaySinh.Location = new System.Drawing.Point(161, 166);
            this.date_NgaySinh.Name = "date_NgaySinh";
            this.date_NgaySinh.Size = new System.Drawing.Size(300, 26);
            this.date_NgaySinh.TabIndex = 4;
            // 
            // txt_NoiSinh
            // 
            this.txt_NoiSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_NoiSinh.Location = new System.Drawing.Point(560, 161);
            this.txt_NoiSinh.Name = "txt_NoiSinh";
            this.txt_NoiSinh.Size = new System.Drawing.Size(249, 31);
            this.txt_NoiSinh.TabIndex = 5;
            // 
            // cbo_MaKhoa
            // 
            this.cbo_MaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_MaKhoa.FormattingEnabled = true;
            this.cbo_MaKhoa.Location = new System.Drawing.Point(386, 213);
            this.cbo_MaKhoa.Name = "cbo_MaKhoa";
            this.cbo_MaKhoa.Size = new System.Drawing.Size(164, 33);
            this.cbo_MaKhoa.TabIndex = 6;
            // 
            // cbo_MaHe
            // 
            this.cbo_MaHe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_MaHe.FormattingEnabled = true;
            this.cbo_MaHe.Location = new System.Drawing.Point(113, 213);
            this.cbo_MaHe.Name = "cbo_MaHe";
            this.cbo_MaHe.Size = new System.Drawing.Size(164, 33);
            this.cbo_MaHe.TabIndex = 6;
            // 
            // cbo_MaLop
            // 
            this.cbo_MaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_MaLop.FormattingEnabled = true;
            this.cbo_MaLop.Location = new System.Drawing.Point(645, 213);
            this.cbo_MaLop.Name = "cbo_MaLop";
            this.cbo_MaLop.Size = new System.Drawing.Size(164, 33);
            this.cbo_MaLop.TabIndex = 6;
            // 
            // Grid_SinhVien
            // 
            this.Grid_SinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_SinhVien.Location = new System.Drawing.Point(44, 273);
            this.Grid_SinhVien.Name = "Grid_SinhVien";
            this.Grid_SinhVien.Size = new System.Drawing.Size(594, 269);
            this.Grid_SinhVien.TabIndex = 7;
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Them.Location = new System.Drawing.Point(721, 300);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(88, 38);
            this.btn_Them.TabIndex = 8;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Luu.Location = new System.Drawing.Point(721, 344);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(88, 38);
            this.btn_Luu.TabIndex = 8;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.Location = new System.Drawing.Point(721, 388);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(88, 38);
            this.btn_Sua.TabIndex = 8;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.Location = new System.Drawing.Point(721, 432);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(88, 38);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.Location = new System.Drawing.Point(721, 476);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(88, 38);
            this.btn_Thoat.TabIndex = 8;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // box_GioiTinh
            // 
            this.box_GioiTinh.Controls.Add(this.rdn_Nu);
            this.box_GioiTinh.Controls.Add(this.rdn_Nam);
            this.box_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.box_GioiTinh.Location = new System.Drawing.Point(515, 75);
            this.box_GioiTinh.Name = "box_GioiTinh";
            this.box_GioiTinh.Size = new System.Drawing.Size(225, 77);
            this.box_GioiTinh.TabIndex = 9;
            this.box_GioiTinh.TabStop = false;
            this.box_GioiTinh.Text = "Giới Tính";
            // 
            // Frm_SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 574);
            this.Controls.Add(this.box_GioiTinh);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.Grid_SinhVien);
            this.Controls.Add(this.cbo_MaLop);
            this.Controls.Add(this.cbo_MaHe);
            this.Controls.Add(this.cbo_MaKhoa);
            this.Controls.Add(this.txt_NoiSinh);
            this.Controls.Add(this.date_NgaySinh);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.txt_MaSV);
            this.Controls.Add(this.lbl_NoiSinh);
            this.Controls.Add(this.lbl_NgaySinh);
            this.Controls.Add(this.lbl_HoTen);
            this.Controls.Add(this.lbl_MaHe);
            this.Controls.Add(this.lbl_MaLop);
            this.Controls.Add(this.lbl_MaKhoa);
            this.Controls.Add(this.lbl_msv);
            this.Controls.Add(this.lbl_SinhVien);
            this.Name = "Frm_SinhVien";
            this.Text = "Sinh Viên";
            this.Load += new System.EventHandler(this.Frm_SinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_SinhVien)).EndInit();
            this.box_GioiTinh.ResumeLayout(false);
            this.box_GioiTinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SinhVien;
        private System.Windows.Forms.Label lbl_msv;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.Label lbl_NoiSinh;
        private System.Windows.Forms.Label lbl_MaKhoa;
        private System.Windows.Forms.Label lbl_MaLop;
        private System.Windows.Forms.Label lbl_MaHe;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.RadioButton rdn_Nam;
        private System.Windows.Forms.RadioButton rdn_Nu;
        private System.Windows.Forms.DateTimePicker date_NgaySinh;
        private System.Windows.Forms.TextBox txt_NoiSinh;
        private System.Windows.Forms.ComboBox cbo_MaKhoa;
        private System.Windows.Forms.ComboBox cbo_MaHe;
        private System.Windows.Forms.ComboBox cbo_MaLop;
        private System.Windows.Forms.DataGridView Grid_SinhVien;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.GroupBox box_GioiTinh;
    }
}