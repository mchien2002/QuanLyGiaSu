
namespace QuanLyGiaSu
{
    partial class formMain
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
            this.btn_QlyDSLOP = new System.Windows.Forms.Button();
            this.btn_QlyPhuHuynh = new System.Windows.Forms.Button();
            this.btn_QlyGiaSu = new System.Windows.Forms.Button();
            this.btn_QlyLop = new System.Windows.Forms.Button();
            this.btn_GiaSu = new System.Windows.Forms.Button();
            this.btn_LienHe = new System.Windows.Forms.Button();
            this.btn_TuyenDung = new System.Windows.Forms.Button();
            this.btn_LopMoi = new System.Windows.Forms.Button();
            this.btnTrangchu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_TrangChu1 = new DoAnCuoiKy_Nhom13.UC_TrangChu();
            this.uC_GiaSu1 = new DoAnCuoiKy_Nhom13.UC_GiaSu();
            this.uC_PhuHuynh1 = new DoAnCuoiKy_Nhom13.UC_LichSuGiaoDich();
            this.uC_LopMoi1 = new QuanLyGiaSu.src.app.views.layer.UC_LopMoi();
            this.uC_TuyenDung1 = new QuanLyGiaSu.src.app.views.layer.UC_TuyenDung();
            this.uC_LienHe1 = new QuanLyGiaSu.src.app.views.layer.UC_LienHe();
            this.uC_QuanLyLop1 = new QuanLyGiaSu.src.app.views.layer.UC_QuanLyLop();
            this.uC_QuanLyGiaSu1 = new QuanLyGiaSu.src.app.views.layer.UC_QuanLyGiaSu();
            this.uC_QuanLyPhuHuynh1 = new QuanLyGiaSu.src.app.views.layer.UC_QuanLyPhuHuynh();
            this.uC_DanhSachLopDaDangKy1 = new QuanLyGiaSu.src.app.views.layer.UC_DanhSachLopDaDangKy();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_QlyDSLOP);
            this.panel1.Controls.Add(this.btn_QlyPhuHuynh);
            this.panel1.Controls.Add(this.btn_QlyGiaSu);
            this.panel1.Controls.Add(this.btn_QlyLop);
            this.panel1.Controls.Add(this.btn_GiaSu);
            this.panel1.Controls.Add(this.btn_LienHe);
            this.panel1.Controls.Add(this.btn_TuyenDung);
            this.panel1.Controls.Add(this.btn_LopMoi);
            this.panel1.Controls.Add(this.btnTrangchu);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 62);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(1161, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 62);
            this.button1.TabIndex = 9;
            this.button1.Text = "Lịch Sử Giao Dịch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_QlyDSLOP
            // 
            this.btn_QlyDSLOP.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_QlyDSLOP.Location = new System.Drawing.Point(1032, 0);
            this.btn_QlyDSLOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QlyDSLOP.Name = "btn_QlyDSLOP";
            this.btn_QlyDSLOP.Size = new System.Drawing.Size(129, 62);
            this.btn_QlyDSLOP.TabIndex = 8;
            this.btn_QlyDSLOP.Text = "Danh Sách Lớp Đã Đăng Ký Dạy";
            this.btn_QlyDSLOP.UseVisualStyleBackColor = true;
            this.btn_QlyDSLOP.Click += new System.EventHandler(this.btn_QlyDSLOP_Click);
            // 
            // btn_QlyPhuHuynh
            // 
            this.btn_QlyPhuHuynh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_QlyPhuHuynh.Location = new System.Drawing.Point(903, 0);
            this.btn_QlyPhuHuynh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QlyPhuHuynh.Name = "btn_QlyPhuHuynh";
            this.btn_QlyPhuHuynh.Size = new System.Drawing.Size(129, 62);
            this.btn_QlyPhuHuynh.TabIndex = 7;
            this.btn_QlyPhuHuynh.Text = "Quản Lý Phụ Huynh";
            this.btn_QlyPhuHuynh.UseVisualStyleBackColor = true;
            this.btn_QlyPhuHuynh.Click += new System.EventHandler(this.btn_QlyPhuHuynh_Click);
            // 
            // btn_QlyGiaSu
            // 
            this.btn_QlyGiaSu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_QlyGiaSu.Location = new System.Drawing.Point(774, 0);
            this.btn_QlyGiaSu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QlyGiaSu.Name = "btn_QlyGiaSu";
            this.btn_QlyGiaSu.Size = new System.Drawing.Size(129, 62);
            this.btn_QlyGiaSu.TabIndex = 6;
            this.btn_QlyGiaSu.Text = "Quản Lý Gia Sư";
            this.btn_QlyGiaSu.UseVisualStyleBackColor = true;
            this.btn_QlyGiaSu.Click += new System.EventHandler(this.btn_QlyGiaSu_Click);
            // 
            // btn_QlyLop
            // 
            this.btn_QlyLop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_QlyLop.Location = new System.Drawing.Point(645, 0);
            this.btn_QlyLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QlyLop.Name = "btn_QlyLop";
            this.btn_QlyLop.Size = new System.Drawing.Size(129, 62);
            this.btn_QlyLop.TabIndex = 5;
            this.btn_QlyLop.Text = "Quản Lý Lớp";
            this.btn_QlyLop.UseVisualStyleBackColor = true;
            this.btn_QlyLop.Click += new System.EventHandler(this.btn_QlyLop_Click);
            // 
            // btn_GiaSu
            // 
            this.btn_GiaSu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_GiaSu.Location = new System.Drawing.Point(516, 0);
            this.btn_GiaSu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GiaSu.Name = "btn_GiaSu";
            this.btn_GiaSu.Size = new System.Drawing.Size(129, 62);
            this.btn_GiaSu.TabIndex = 2;
            this.btn_GiaSu.Text = "Gia Sư";
            this.btn_GiaSu.UseVisualStyleBackColor = true;
            this.btn_GiaSu.Click += new System.EventHandler(this.btn_GiaSu_Click);
            // 
            // btn_LienHe
            // 
            this.btn_LienHe.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_LienHe.Location = new System.Drawing.Point(387, 0);
            this.btn_LienHe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LienHe.Name = "btn_LienHe";
            this.btn_LienHe.Size = new System.Drawing.Size(129, 62);
            this.btn_LienHe.TabIndex = 4;
            this.btn_LienHe.Text = "Liên Hệ";
            this.btn_LienHe.UseVisualStyleBackColor = true;
            this.btn_LienHe.Click += new System.EventHandler(this.btn_LienHe_Click);
            // 
            // btn_TuyenDung
            // 
            this.btn_TuyenDung.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_TuyenDung.Location = new System.Drawing.Point(258, 0);
            this.btn_TuyenDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TuyenDung.Name = "btn_TuyenDung";
            this.btn_TuyenDung.Size = new System.Drawing.Size(129, 62);
            this.btn_TuyenDung.TabIndex = 4;
            this.btn_TuyenDung.Text = "Tuyển Dụng";
            this.btn_TuyenDung.UseVisualStyleBackColor = true;
            this.btn_TuyenDung.Click += new System.EventHandler(this.btn_TuyenDung_Click);
            // 
            // btn_LopMoi
            // 
            this.btn_LopMoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_LopMoi.Location = new System.Drawing.Point(129, 0);
            this.btn_LopMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LopMoi.Name = "btn_LopMoi";
            this.btn_LopMoi.Size = new System.Drawing.Size(129, 62);
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
            this.btnTrangchu.Size = new System.Drawing.Size(129, 62);
            this.btnTrangchu.TabIndex = 0;
            this.btnTrangchu.Text = "Trang Chủ";
            this.btnTrangchu.UseVisualStyleBackColor = true;
            this.btnTrangchu.Click += new System.EventHandler(this.btnTrangchu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_TrangChu1);
            this.panel2.Controls.Add(this.uC_GiaSu1);
            this.panel2.Controls.Add(this.uC_PhuHuynh1);
            this.panel2.Controls.Add(this.uC_LopMoi1);
            this.panel2.Controls.Add(this.uC_TuyenDung1);
            this.panel2.Controls.Add(this.uC_LienHe1);
            this.panel2.Controls.Add(this.uC_QuanLyLop1);
            this.panel2.Controls.Add(this.uC_QuanLyGiaSu1);
            this.panel2.Controls.Add(this.uC_QuanLyPhuHuynh1);
            this.panel2.Controls.Add(this.uC_DanhSachLopDaDangKy1);
            this.panel2.Location = new System.Drawing.Point(12, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1309, 533);
            this.panel2.TabIndex = 1;
            // 
            // uC_TrangChu1
            // 
            this.uC_TrangChu1.BackColor = System.Drawing.Color.AliceBlue;
            this.uC_TrangChu1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uC_TrangChu1.Location = new System.Drawing.Point(-3, 1);
            this.uC_TrangChu1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_TrangChu1.Name = "uC_TrangChu1";
            this.uC_TrangChu1.Size = new System.Drawing.Size(1309, 533);
            this.uC_TrangChu1.TabIndex = 2;
            // 
            // uC_GiaSu1
            // 
            this.uC_GiaSu1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_GiaSu1.Location = new System.Drawing.Point(-3, 2);
            this.uC_GiaSu1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_GiaSu1.Name = "uC_GiaSu1";
            this.uC_GiaSu1.Size = new System.Drawing.Size(1309, 533);
            this.uC_GiaSu1.TabIndex = 0;
            // 
            // uC_PhuHuynh1
            // 
            this.uC_PhuHuynh1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_PhuHuynh1.Location = new System.Drawing.Point(-3, 2);
            this.uC_PhuHuynh1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_PhuHuynh1.Name = "uC_PhuHuynh1";
            this.uC_PhuHuynh1.Size = new System.Drawing.Size(1309, 533);
            this.uC_PhuHuynh1.TabIndex = 2;
            // 
            // uC_LopMoi1
            // 
            this.uC_LopMoi1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_LopMoi1.Location = new System.Drawing.Point(-3, 2);
            this.uC_LopMoi1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_LopMoi1.Name = "uC_LopMoi1";
            this.uC_LopMoi1.Size = new System.Drawing.Size(1309, 533);
            this.uC_LopMoi1.TabIndex = 2;
            // 
            // uC_TuyenDung1
            // 
            this.uC_TuyenDung1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_TuyenDung1.Location = new System.Drawing.Point(0, 2);
            this.uC_TuyenDung1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_TuyenDung1.Name = "uC_TuyenDung1";
            this.uC_TuyenDung1.Size = new System.Drawing.Size(1309, 533);
            this.uC_TuyenDung1.TabIndex = 3;
            // 
            // uC_LienHe1
            // 
            this.uC_LienHe1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_LienHe1.Location = new System.Drawing.Point(-3, -4);
            this.uC_LienHe1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_LienHe1.Name = "uC_LienHe1";
            this.uC_LienHe1.Size = new System.Drawing.Size(1309, 533);
            this.uC_LienHe1.TabIndex = 4;
            // 
            // uC_QuanLyLop1
            // 
            this.uC_QuanLyLop1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_QuanLyLop1.Location = new System.Drawing.Point(0, 2);
            this.uC_QuanLyLop1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_QuanLyLop1.Name = "uC_QuanLyLop1";
            this.uC_QuanLyLop1.Size = new System.Drawing.Size(1309, 533);
            this.uC_QuanLyLop1.TabIndex = 5;
            // 
            // uC_QuanLyGiaSu1
            // 
            this.uC_QuanLyGiaSu1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_QuanLyGiaSu1.Location = new System.Drawing.Point(-3, 1);
            this.uC_QuanLyGiaSu1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_QuanLyGiaSu1.Name = "uC_QuanLyGiaSu1";
            this.uC_QuanLyGiaSu1.Size = new System.Drawing.Size(1309, 533);
            this.uC_QuanLyGiaSu1.TabIndex = 6;
            // 
            // uC_QuanLyPhuHuynh1
            // 
            this.uC_QuanLyPhuHuynh1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_QuanLyPhuHuynh1.Location = new System.Drawing.Point(0, 2);
            this.uC_QuanLyPhuHuynh1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_QuanLyPhuHuynh1.Name = "uC_QuanLyPhuHuynh1";
            this.uC_QuanLyPhuHuynh1.Size = new System.Drawing.Size(1309, 533);
            this.uC_QuanLyPhuHuynh1.TabIndex = 7;
            // 
            // uC_DanhSachLopDaDangKy1
            // 
            this.uC_DanhSachLopDaDangKy1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_DanhSachLopDaDangKy1.Location = new System.Drawing.Point(0, 0);
            this.uC_DanhSachLopDaDangKy1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_DanhSachLopDaDangKy1.Name = "uC_DanhSachLopDaDangKy1";
            this.uC_DanhSachLopDaDangKy1.Size = new System.Drawing.Size(1309, 533);
            this.uC_DanhSachLopDaDangKy1.TabIndex = 8;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1333, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Gia Sư";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_GiaSu;
        private System.Windows.Forms.Button btn_TuyenDung;
        private System.Windows.Forms.Button btn_LopMoi;
        private System.Windows.Forms.Button btnTrangchu;
        private System.Windows.Forms.Panel panel2;
        private DoAnCuoiKy_Nhom13.UC_GiaSu uC_GiaSu1;
        private DoAnCuoiKy_Nhom13.UC_TrangChu uC_TrangChu1;
        private DoAnCuoiKy_Nhom13.UC_LichSuGiaoDich uC_PhuHuynh1;
        private src.app.views.layer.UC_LopMoi uC_LopMoi1;
        private System.Windows.Forms.Button btn_LienHe;
        private src.app.views.layer.UC_TuyenDung uC_TuyenDung1;
        private src.app.views.layer.UC_LienHe uC_LienHe1;
        private System.Windows.Forms.Button btn_QlyDSLOP;
        private System.Windows.Forms.Button btn_QlyPhuHuynh;
        private System.Windows.Forms.Button btn_QlyGiaSu;
        private System.Windows.Forms.Button btn_QlyLop;
        private src.app.views.layer.UC_QuanLyLop uC_QuanLyLop1;
        private src.app.views.layer.UC_QuanLyGiaSu uC_QuanLyGiaSu1;
        private src.app.views.layer.UC_QuanLyPhuHuynh uC_QuanLyPhuHuynh1;
        private src.app.views.layer.UC_DanhSachLopDaDangKy uC_DanhSachLopDaDangKy1;
        private System.Windows.Forms.Button button1;
    }
}

