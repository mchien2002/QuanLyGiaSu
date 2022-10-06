namespace QuanLyGiaSu
{
    partial class formMainPhuHuynh
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ThongTinhPhuHuynh = new System.Windows.Forms.Button();
            this.btn_LienHe = new System.Windows.Forms.Button();
            this.btn_TuyenDung = new System.Windows.Forms.Button();
            this.btn_LopMoi = new System.Windows.Forms.Button();
            this.btnTrangchu = new System.Windows.Forms.Button();
            this.uC_TrangChu1 = new DoAnCuoiKy_Nhom13.UC_TrangChu();
            this.uC_LopMoi1 = new QuanLyGiaSu.src.app.views.layer.UC_LopMoi();
            this.uC_TuyenDung1 = new QuanLyGiaSu.src.app.views.layer.UC_TuyenDung();
            this.uC_LienHe1 = new QuanLyGiaSu.src.app.views.layer.UC_LienHe();
            this.uC_ThongTinPhuHuynh1 = new QuanLyGiaSu.src.app.views.layer.UC_ThongTinPhuHuynh();
            this.uC_LichSuGiaoDich1 = new DoAnCuoiKy_Nhom13.UC_LichSuGiaoDich();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_ThongTinhPhuHuynh);
            this.panel1.Controls.Add(this.btn_LienHe);
            this.panel1.Controls.Add(this.btn_TuyenDung);
            this.panel1.Controls.Add(this.btn_LopMoi);
            this.panel1.Controls.Add(this.btnTrangchu);
            this.panel1.Location = new System.Drawing.Point(15, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 62);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(1085, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 62);
            this.button1.TabIndex = 9;
            this.button1.Text = "Lịch Sử Giao Dịch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ThongTinhPhuHuynh
            // 
            this.btn_ThongTinhPhuHuynh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_ThongTinhPhuHuynh.Location = new System.Drawing.Point(868, 0);
            this.btn_ThongTinhPhuHuynh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ThongTinhPhuHuynh.Name = "btn_ThongTinhPhuHuynh";
            this.btn_ThongTinhPhuHuynh.Size = new System.Drawing.Size(217, 62);
            this.btn_ThongTinhPhuHuynh.TabIndex = 2;
            this.btn_ThongTinhPhuHuynh.Text = "Thông Tin Phụ Huynh";
            this.btn_ThongTinhPhuHuynh.UseVisualStyleBackColor = true;
            this.btn_ThongTinhPhuHuynh.Click += new System.EventHandler(this.btn_ThongTinhPhuHuynh_Click);
            // 
            // btn_LienHe
            // 
            this.btn_LienHe.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_LienHe.Location = new System.Drawing.Point(651, 0);
            this.btn_LienHe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LienHe.Name = "btn_LienHe";
            this.btn_LienHe.Size = new System.Drawing.Size(217, 62);
            this.btn_LienHe.TabIndex = 4;
            this.btn_LienHe.Text = "Liên Hệ";
            this.btn_LienHe.UseVisualStyleBackColor = true;
            this.btn_LienHe.Click += new System.EventHandler(this.btn_LienHe_Click);
            // 
            // btn_TuyenDung
            // 
            this.btn_TuyenDung.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_TuyenDung.Location = new System.Drawing.Point(434, 0);
            this.btn_TuyenDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TuyenDung.Name = "btn_TuyenDung";
            this.btn_TuyenDung.Size = new System.Drawing.Size(217, 62);
            this.btn_TuyenDung.TabIndex = 4;
            this.btn_TuyenDung.Text = "Tuyển Dụng";
            this.btn_TuyenDung.UseVisualStyleBackColor = true;
            this.btn_TuyenDung.Click += new System.EventHandler(this.btn_TuyenDung_Click);
            // 
            // btn_LopMoi
            // 
            this.btn_LopMoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_LopMoi.Location = new System.Drawing.Point(217, 0);
            this.btn_LopMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LopMoi.Name = "btn_LopMoi";
            this.btn_LopMoi.Size = new System.Drawing.Size(217, 62);
            this.btn_LopMoi.TabIndex = 3;
            this.btn_LopMoi.Text = "Lớp Mới";
            this.btn_LopMoi.UseVisualStyleBackColor = true;
            this.btn_LopMoi.Click += new System.EventHandler(this.btn_LopMoi_Click);
            // 
            // btnTrangchu
            // 
            this.btnTrangchu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTrangchu.Location = new System.Drawing.Point(0, 0);
            this.btnTrangchu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrangchu.Name = "btnTrangchu";
            this.btnTrangchu.Size = new System.Drawing.Size(217, 62);
            this.btnTrangchu.TabIndex = 0;
            this.btnTrangchu.Text = "Trang Chủ";
            this.btnTrangchu.UseVisualStyleBackColor = true;
            this.btnTrangchu.Click += new System.EventHandler(this.btnTrangchu_Click);
            // 
            // uC_TrangChu1
            // 
            this.uC_TrangChu1.BackColor = System.Drawing.Color.AliceBlue;
            this.uC_TrangChu1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uC_TrangChu1.Location = new System.Drawing.Point(16, 82);
            this.uC_TrangChu1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_TrangChu1.Name = "uC_TrangChu1";
            this.uC_TrangChu1.Size = new System.Drawing.Size(1309, 533);
            this.uC_TrangChu1.TabIndex = 5;
            // 
            // uC_LopMoi1
            // 
            this.uC_LopMoi1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_LopMoi1.Location = new System.Drawing.Point(16, 82);
            this.uC_LopMoi1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_LopMoi1.Name = "uC_LopMoi1";
            this.uC_LopMoi1.Size = new System.Drawing.Size(1309, 533);
            this.uC_LopMoi1.TabIndex = 6;
            // 
            // uC_TuyenDung1
            // 
            this.uC_TuyenDung1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_TuyenDung1.Location = new System.Drawing.Point(16, 82);
            this.uC_TuyenDung1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_TuyenDung1.Name = "uC_TuyenDung1";
            this.uC_TuyenDung1.Size = new System.Drawing.Size(1309, 533);
            this.uC_TuyenDung1.TabIndex = 7;
            // 
            // uC_LienHe1
            // 
            this.uC_LienHe1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_LienHe1.Location = new System.Drawing.Point(16, 82);
            this.uC_LienHe1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_LienHe1.Name = "uC_LienHe1";
            this.uC_LienHe1.Size = new System.Drawing.Size(1309, 533);
            this.uC_LienHe1.TabIndex = 8;
            // 
            // uC_ThongTinPhuHuynh1
            // 
            this.uC_ThongTinPhuHuynh1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_ThongTinPhuHuynh1.Location = new System.Drawing.Point(16, 82);
            this.uC_ThongTinPhuHuynh1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uC_ThongTinPhuHuynh1.Name = "uC_ThongTinPhuHuynh1";
            this.uC_ThongTinPhuHuynh1.Size = new System.Drawing.Size(1309, 533);
            this.uC_ThongTinPhuHuynh1.TabIndex = 9;
            // 
            // uC_LichSuGiaoDich1
            // 
            this.uC_LichSuGiaoDich1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_LichSuGiaoDich1.Location = new System.Drawing.Point(16, 82);
            this.uC_LichSuGiaoDich1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_LichSuGiaoDich1.Name = "uC_LichSuGiaoDich1";
            this.uC_LichSuGiaoDich1.Size = new System.Drawing.Size(1309, 533);
            this.uC_LichSuGiaoDich1.TabIndex = 10;
            // 
            // formMainPhuHuynh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 625);
            this.Controls.Add(this.uC_TrangChu1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uC_LopMoi1);
            this.Controls.Add(this.uC_TuyenDung1);
            this.Controls.Add(this.uC_LienHe1);
            this.Controls.Add(this.uC_ThongTinPhuHuynh1);
            this.Controls.Add(this.uC_LichSuGiaoDich1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formMainPhuHuynh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formMainPhuHuynh";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_ThongTinhPhuHuynh;
        private System.Windows.Forms.Button btn_LienHe;
        private System.Windows.Forms.Button btn_TuyenDung;
        private System.Windows.Forms.Button btn_LopMoi;
        private System.Windows.Forms.Button btnTrangchu;
        private DoAnCuoiKy_Nhom13.UC_TrangChu uC_TrangChu1;
        private src.app.views.layer.UC_LopMoi uC_LopMoi1;
        private src.app.views.layer.UC_TuyenDung uC_TuyenDung1;
        private src.app.views.layer.UC_LienHe uC_LienHe1;
        private src.app.views.layer.UC_ThongTinPhuHuynh uC_ThongTinPhuHuynh1;
        private DoAnCuoiKy_Nhom13.UC_LichSuGiaoDich uC_LichSuGiaoDich1;
    }
}