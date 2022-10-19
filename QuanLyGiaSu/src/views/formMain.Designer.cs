
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLichSuNapTien = new System.Windows.Forms.Button();
            this.btnQuanLyLopVaMon = new System.Windows.Forms.Button();
            this.btnLichSuGiaoDich = new System.Windows.Forms.Button();
            this.btn_QlyDSLOP = new System.Windows.Forms.Button();
            this.btn_QuanLyPhuHuynh = new System.Windows.Forms.Button();
            this.btn_QuanLyGiaSu = new System.Windows.Forms.Button();
            this.btn_QuanLyLopMoi = new System.Windows.Forms.Button();
            this.btnTrangchu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_TrangChu1 = new DoAnCuoiKy_Nhom13.UC_TrangChu();
            this.uC_GiaSu1 = new DoAnCuoiKy_Nhom13.UC_GiaSu();
            this.uC_QuanLyLop1 = new QuanLyGiaSu.src.app.views.layer.UC_QuanLyLop();
            this.uC_QuanLyGiaSu1 = new QuanLyGiaSu.src.app.views.layer.UC_QuanLyGiaSu();
            this.uC_QuanLyPhuHuynh1 = new QuanLyGiaSu.src.app.views.layer.UC_QuanLyPhuHuynh();
            this.uC_LichSuGiaoDich1 = new DoAnCuoiKy_Nhom13.UC_LichSuGiaoDich();
            this.uC_QuanLyDanhSachDangKyDay1 = new QuanLyGiaSu.src.views.layer.admin.UC_QuanLyDanhSachDangKyDay();
            this.uC_QLyLopHoc1 = new QuanLyGiaSu.src.views.layer.admin.UC_QLyLopHoc();
            this.uC_QLyLichSuNap1 = new QuanLyGiaSu.src.views.layer.admin.UC_QLyLichSuNap();
            this.uC_ThongKe1 = new QuanLyGiaSu.src.views.layer.admin.UC_ThongKe();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnLichSuNapTien);
            this.panel1.Controls.Add(this.btnQuanLyLopVaMon);
            this.panel1.Controls.Add(this.btnLichSuGiaoDich);
            this.panel1.Controls.Add(this.btn_QlyDSLOP);
            this.panel1.Controls.Add(this.btn_QuanLyPhuHuynh);
            this.panel1.Controls.Add(this.btn_QuanLyGiaSu);
            this.panel1.Controls.Add(this.btn_QuanLyLopMoi);
            this.panel1.Controls.Add(this.btnTrangchu);
            this.panel1.Location = new System.Drawing.Point(11, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 50);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(860, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 50);
            this.button1.TabIndex = 13;
            this.button1.Text = "Thống Kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLichSuNapTien
            // 
            this.btnLichSuNapTien.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLichSuNapTien.Location = new System.Drawing.Point(745, 0);
            this.btnLichSuNapTien.Margin = new System.Windows.Forms.Padding(2);
            this.btnLichSuNapTien.Name = "btnLichSuNapTien";
            this.btnLichSuNapTien.Size = new System.Drawing.Size(115, 50);
            this.btnLichSuNapTien.TabIndex = 12;
            this.btnLichSuNapTien.Text = "Lịch Sử Nạp Tiền";
            this.btnLichSuNapTien.UseVisualStyleBackColor = true;
            this.btnLichSuNapTien.Click += new System.EventHandler(this.btnLichSuNapTien_Click);
            // 
            // btnQuanLyLopVaMon
            // 
            this.btnQuanLyLopVaMon.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQuanLyLopVaMon.Location = new System.Drawing.Point(630, 0);
            this.btnQuanLyLopVaMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuanLyLopVaMon.Name = "btnQuanLyLopVaMon";
            this.btnQuanLyLopVaMon.Size = new System.Drawing.Size(115, 50);
            this.btnQuanLyLopVaMon.TabIndex = 10;
            this.btnQuanLyLopVaMon.Text = "Quản Lý Lớp Học";
            this.btnQuanLyLopVaMon.UseVisualStyleBackColor = true;
            this.btnQuanLyLopVaMon.Click += new System.EventHandler(this.btnQuanLyLopVaMon_Click);
            // 
            // btnLichSuGiaoDich
            // 
            this.btnLichSuGiaoDich.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLichSuGiaoDich.Location = new System.Drawing.Point(515, 0);
            this.btnLichSuGiaoDich.Margin = new System.Windows.Forms.Padding(2);
            this.btnLichSuGiaoDich.Name = "btnLichSuGiaoDich";
            this.btnLichSuGiaoDich.Size = new System.Drawing.Size(115, 50);
            this.btnLichSuGiaoDich.TabIndex = 9;
            this.btnLichSuGiaoDich.Text = "Lịch Sử Giao Dịch";
            this.btnLichSuGiaoDich.UseVisualStyleBackColor = true;
            this.btnLichSuGiaoDich.Click += new System.EventHandler(this.btnLichSuGiaoDich_Click);
            // 
            // btn_QlyDSLOP
            // 
            this.btn_QlyDSLOP.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_QlyDSLOP.Location = new System.Drawing.Point(400, 0);
            this.btn_QlyDSLOP.Margin = new System.Windows.Forms.Padding(2);
            this.btn_QlyDSLOP.Name = "btn_QlyDSLOP";
            this.btn_QlyDSLOP.Size = new System.Drawing.Size(115, 50);
            this.btn_QlyDSLOP.TabIndex = 8;
            this.btn_QlyDSLOP.Text = "Quản Lý Danh Sách Đăng Ký Dạy";
            this.btn_QlyDSLOP.UseVisualStyleBackColor = true;
            this.btn_QlyDSLOP.Click += new System.EventHandler(this.btn_QlyDSLOP_Click);
            // 
            // btn_QuanLyPhuHuynh
            // 
            this.btn_QuanLyPhuHuynh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_QuanLyPhuHuynh.Location = new System.Drawing.Point(300, 0);
            this.btn_QuanLyPhuHuynh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_QuanLyPhuHuynh.Name = "btn_QuanLyPhuHuynh";
            this.btn_QuanLyPhuHuynh.Size = new System.Drawing.Size(100, 50);
            this.btn_QuanLyPhuHuynh.TabIndex = 7;
            this.btn_QuanLyPhuHuynh.Text = "Quản Lý Phụ Huynh";
            this.btn_QuanLyPhuHuynh.UseVisualStyleBackColor = true;
            this.btn_QuanLyPhuHuynh.Click += new System.EventHandler(this.btn_QlyPhuHuynh_Click);
            // 
            // btn_QuanLyGiaSu
            // 
            this.btn_QuanLyGiaSu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_QuanLyGiaSu.Location = new System.Drawing.Point(200, 0);
            this.btn_QuanLyGiaSu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_QuanLyGiaSu.Name = "btn_QuanLyGiaSu";
            this.btn_QuanLyGiaSu.Size = new System.Drawing.Size(100, 50);
            this.btn_QuanLyGiaSu.TabIndex = 6;
            this.btn_QuanLyGiaSu.Text = "Quản Lý Gia Sư";
            this.btn_QuanLyGiaSu.UseVisualStyleBackColor = true;
            this.btn_QuanLyGiaSu.Click += new System.EventHandler(this.btn_QlyGiaSu_Click);
            // 
            // btn_QuanLyLopMoi
            // 
            this.btn_QuanLyLopMoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_QuanLyLopMoi.Location = new System.Drawing.Point(100, 0);
            this.btn_QuanLyLopMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_QuanLyLopMoi.Name = "btn_QuanLyLopMoi";
            this.btn_QuanLyLopMoi.Size = new System.Drawing.Size(100, 50);
            this.btn_QuanLyLopMoi.TabIndex = 3;
            this.btn_QuanLyLopMoi.Text = "Quản lý lớp mới";
            this.btn_QuanLyLopMoi.UseVisualStyleBackColor = true;
            this.btn_QuanLyLopMoi.Click += new System.EventHandler(this.btn_QlyLop_Click);
            // 
            // btnTrangchu
            // 
            this.btnTrangchu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTrangchu.Location = new System.Drawing.Point(0, 0);
            this.btnTrangchu.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrangchu.Name = "btnTrangchu";
            this.btnTrangchu.Size = new System.Drawing.Size(100, 50);
            this.btnTrangchu.TabIndex = 0;
            this.btnTrangchu.Text = "Trang Chủ";
            this.btnTrangchu.UseVisualStyleBackColor = true;
            this.btnTrangchu.Click += new System.EventHandler(this.btnTrangchu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_TrangChu1);
            this.panel2.Controls.Add(this.uC_GiaSu1);
            this.panel2.Controls.Add(this.uC_QuanLyLop1);
            this.panel2.Controls.Add(this.uC_QuanLyGiaSu1);
            this.panel2.Controls.Add(this.uC_QuanLyPhuHuynh1);
            this.panel2.Controls.Add(this.uC_LichSuGiaoDich1);
            this.panel2.Controls.Add(this.uC_QuanLyDanhSachDangKyDay1);
            this.panel2.Controls.Add(this.uC_QLyLopHoc1);
            this.panel2.Controls.Add(this.uC_QLyLichSuNap1);
            this.panel2.Controls.Add(this.uC_ThongKe1);
            this.panel2.Location = new System.Drawing.Point(9, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 433);
            this.panel2.TabIndex = 1;
            // 
            // uC_TrangChu1
            // 
            this.uC_TrangChu1.AutoScroll = true;
            this.uC_TrangChu1.BackColor = System.Drawing.Color.White;
            this.uC_TrangChu1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uC_TrangChu1.Location = new System.Drawing.Point(-2, 1);
            this.uC_TrangChu1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uC_TrangChu1.Name = "uC_TrangChu1";
            this.uC_TrangChu1.Size = new System.Drawing.Size(982, 433);
            this.uC_TrangChu1.TabIndex = 2;
            // 
            // uC_GiaSu1
            // 
            this.uC_GiaSu1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_GiaSu1.Location = new System.Drawing.Point(-2, 2);
            this.uC_GiaSu1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_GiaSu1.Name = "uC_GiaSu1";
            this.uC_GiaSu1.Size = new System.Drawing.Size(982, 433);
            this.uC_GiaSu1.TabIndex = 0;
            // 
            // uC_QuanLyLop1
            // 
            this.uC_QuanLyLop1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_QuanLyLop1.Location = new System.Drawing.Point(0, 2);
            this.uC_QuanLyLop1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_QuanLyLop1.Name = "uC_QuanLyLop1";
            this.uC_QuanLyLop1.Size = new System.Drawing.Size(982, 433);
            this.uC_QuanLyLop1.TabIndex = 5;
            // 
            // uC_QuanLyGiaSu1
            // 
            this.uC_QuanLyGiaSu1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_QuanLyGiaSu1.Location = new System.Drawing.Point(-2, 1);
            this.uC_QuanLyGiaSu1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_QuanLyGiaSu1.Name = "uC_QuanLyGiaSu1";
            this.uC_QuanLyGiaSu1.Size = new System.Drawing.Size(982, 433);
            this.uC_QuanLyGiaSu1.TabIndex = 6;
            // 
            // uC_QuanLyPhuHuynh1
            // 
            this.uC_QuanLyPhuHuynh1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_QuanLyPhuHuynh1.Location = new System.Drawing.Point(0, 2);
            this.uC_QuanLyPhuHuynh1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_QuanLyPhuHuynh1.Name = "uC_QuanLyPhuHuynh1";
            this.uC_QuanLyPhuHuynh1.Size = new System.Drawing.Size(982, 433);
            this.uC_QuanLyPhuHuynh1.TabIndex = 7;
            // 
            // uC_LichSuGiaoDich1
            // 
            this.uC_LichSuGiaoDich1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_LichSuGiaoDich1.Location = new System.Drawing.Point(2, 2);
            this.uC_LichSuGiaoDich1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uC_LichSuGiaoDich1.Name = "uC_LichSuGiaoDich1";
            this.uC_LichSuGiaoDich1.Size = new System.Drawing.Size(977, 433);
            this.uC_LichSuGiaoDich1.TabIndex = 9;
            // 
            // uC_QuanLyDanhSachDangKyDay1
            // 
            this.uC_QuanLyDanhSachDangKyDay1.BackColor = System.Drawing.Color.White;
            this.uC_QuanLyDanhSachDangKyDay1.Location = new System.Drawing.Point(2, 2);
            this.uC_QuanLyDanhSachDangKyDay1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uC_QuanLyDanhSachDangKyDay1.Name = "uC_QuanLyDanhSachDangKyDay1";
            this.uC_QuanLyDanhSachDangKyDay1.Size = new System.Drawing.Size(982, 433);
            this.uC_QuanLyDanhSachDangKyDay1.TabIndex = 10;
            // 
            // uC_QLyLopHoc1
            // 
            this.uC_QLyLopHoc1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_QLyLopHoc1.Location = new System.Drawing.Point(-2, 1);
            this.uC_QLyLopHoc1.Name = "uC_QLyLopHoc1";
            this.uC_QLyLopHoc1.Size = new System.Drawing.Size(982, 433);
            this.uC_QLyLopHoc1.TabIndex = 11;
            // 
            // uC_QLyLichSuNap1
            // 
            this.uC_QLyLichSuNap1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_QLyLichSuNap1.Location = new System.Drawing.Point(-2, 1);
            this.uC_QLyLichSuNap1.Name = "uC_QLyLichSuNap1";
            this.uC_QLyLichSuNap1.Size = new System.Drawing.Size(982, 433);
            this.uC_QLyLichSuNap1.TabIndex = 12;
            // 
            // uC_ThongKe1
            // 
            this.uC_ThongKe1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_ThongKe1.Location = new System.Drawing.Point(-2, 1);
            this.uC_ThongKe1.Name = "uC_ThongKe1";
            this.uC_ThongKe1.Size = new System.Drawing.Size(982, 433);
            this.uC_ThongKe1.TabIndex = 13;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1000, 508);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Trung Tâm Gia Sư Anh Em";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTrangchu;
        private System.Windows.Forms.Panel panel2;
        private DoAnCuoiKy_Nhom13.UC_GiaSu uC_GiaSu1;
        private DoAnCuoiKy_Nhom13.UC_TrangChu uC_TrangChu1;
        private System.Windows.Forms.Button btn_QlyDSLOP;
        private System.Windows.Forms.Button btn_QuanLyPhuHuynh;
        private System.Windows.Forms.Button btn_QuanLyGiaSu;
        private src.app.views.layer.UC_QuanLyLop uC_QuanLyLop1;
        private src.app.views.layer.UC_QuanLyGiaSu uC_QuanLyGiaSu1;
        private src.app.views.layer.UC_QuanLyPhuHuynh uC_QuanLyPhuHuynh1;
        private System.Windows.Forms.Button btnLichSuGiaoDich;
        private System.Windows.Forms.Button btn_QuanLyLopMoi;
        private DoAnCuoiKy_Nhom13.UC_LichSuGiaoDich uC_LichSuGiaoDich1;
        private src.views.layer.admin.UC_QuanLyDanhSachDangKyDay uC_QuanLyDanhSachDangKyDay1;
        private System.Windows.Forms.Button btnLichSuNapTien;
        private System.Windows.Forms.Button btnQuanLyLopVaMon;
        private src.views.layer.admin.UC_QLyLopHoc uC_QLyLopHoc1;
        private src.views.layer.admin.UC_QLyLichSuNap uC_QLyLichSuNap1;
        private System.Windows.Forms.Button button1;
        private src.views.layer.admin.UC_ThongKe uC_ThongKe1;
    }
}

