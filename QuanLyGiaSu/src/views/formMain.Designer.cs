
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnLichSuGiaoDich);
            this.panel1.Controls.Add(this.btn_QlyDSLOP);
            this.panel1.Controls.Add(this.btn_QuanLyPhuHuynh);
            this.panel1.Controls.Add(this.btn_QuanLyGiaSu);
            this.panel1.Controls.Add(this.btn_QuanLyLopMoi);
            this.panel1.Controls.Add(this.btnTrangchu);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 62);
            this.panel1.TabIndex = 0;
            // 
            // btnLichSuGiaoDich
            // 
            this.btnLichSuGiaoDich.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLichSuGiaoDich.Location = new System.Drawing.Point(746, 0);
            this.btnLichSuGiaoDich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLichSuGiaoDich.Name = "btnLichSuGiaoDich";
            this.btnLichSuGiaoDich.Size = new System.Drawing.Size(141, 62);
            this.btnLichSuGiaoDich.TabIndex = 9;
            this.btnLichSuGiaoDich.Text = "Lịch Sử Giao Dịch";
            this.btnLichSuGiaoDich.UseVisualStyleBackColor = true;
            this.btnLichSuGiaoDich.Click += new System.EventHandler(this.btnLichSuGiaoDich_Click);
            // 
            // btn_QlyDSLOP
            // 
            this.btn_QlyDSLOP.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_QlyDSLOP.Location = new System.Drawing.Point(580, 0);
            this.btn_QlyDSLOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QlyDSLOP.Name = "btn_QlyDSLOP";
            this.btn_QlyDSLOP.Size = new System.Drawing.Size(166, 62);
            this.btn_QlyDSLOP.TabIndex = 8;
            this.btn_QlyDSLOP.Text = "Quản Lý Danh Sách Đăng Ký Dạy";
            this.btn_QlyDSLOP.UseVisualStyleBackColor = true;
            this.btn_QlyDSLOP.Click += new System.EventHandler(this.btn_QlyDSLOP_Click);
            // 
            // btn_QuanLyPhuHuynh
            // 
            this.btn_QuanLyPhuHuynh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_QuanLyPhuHuynh.Location = new System.Drawing.Point(435, 0);
            this.btn_QuanLyPhuHuynh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QuanLyPhuHuynh.Name = "btn_QuanLyPhuHuynh";
            this.btn_QuanLyPhuHuynh.Size = new System.Drawing.Size(145, 62);
            this.btn_QuanLyPhuHuynh.TabIndex = 7;
            this.btn_QuanLyPhuHuynh.Text = "Quản Lý Phụ Huynh";
            this.btn_QuanLyPhuHuynh.UseVisualStyleBackColor = true;
            this.btn_QuanLyPhuHuynh.Click += new System.EventHandler(this.btn_QlyPhuHuynh_Click);
            // 
            // btn_QuanLyGiaSu
            // 
            this.btn_QuanLyGiaSu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_QuanLyGiaSu.Location = new System.Drawing.Point(290, 0);
            this.btn_QuanLyGiaSu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QuanLyGiaSu.Name = "btn_QuanLyGiaSu";
            this.btn_QuanLyGiaSu.Size = new System.Drawing.Size(145, 62);
            this.btn_QuanLyGiaSu.TabIndex = 6;
            this.btn_QuanLyGiaSu.Text = "Quản Lý Gia Sư";
            this.btn_QuanLyGiaSu.UseVisualStyleBackColor = true;
            this.btn_QuanLyGiaSu.Click += new System.EventHandler(this.btn_QlyGiaSu_Click);
            // 
            // btn_QuanLyLopMoi
            // 
            this.btn_QuanLyLopMoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_QuanLyLopMoi.Location = new System.Drawing.Point(145, 0);
            this.btn_QuanLyLopMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QuanLyLopMoi.Name = "btn_QuanLyLopMoi";
            this.btn_QuanLyLopMoi.Size = new System.Drawing.Size(145, 62);
            this.btn_QuanLyLopMoi.TabIndex = 3;
            this.btn_QuanLyLopMoi.Text = "Quản lý lớp mới";
            this.btn_QuanLyLopMoi.UseVisualStyleBackColor = true;
            this.btn_QuanLyLopMoi.Click += new System.EventHandler(this.btn_QlyLop_Click);
            // 
            // btnTrangchu
            // 
            this.btnTrangchu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTrangchu.Location = new System.Drawing.Point(0, 0);
            this.btnTrangchu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrangchu.Name = "btnTrangchu";
            this.btnTrangchu.Size = new System.Drawing.Size(145, 62);
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
            this.panel2.Location = new System.Drawing.Point(12, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1309, 533);
            this.panel2.TabIndex = 1;
            // 
            // uC_TrangChu1
            // 
            this.uC_TrangChu1.AutoScroll = true;
            this.uC_TrangChu1.BackColor = System.Drawing.Color.White;
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
            // uC_LichSuGiaoDich1
            // 
            this.uC_LichSuGiaoDich1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_LichSuGiaoDich1.Location = new System.Drawing.Point(3, 2);
            this.uC_LichSuGiaoDich1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_LichSuGiaoDich1.Name = "uC_LichSuGiaoDich1";
            this.uC_LichSuGiaoDich1.Size = new System.Drawing.Size(1303, 533);
            this.uC_LichSuGiaoDich1.TabIndex = 9;
            // 
            // uC_QuanLyDanhSachDangKyDay1
            // 
            this.uC_QuanLyDanhSachDangKyDay1.BackColor = System.Drawing.Color.White;
            this.uC_QuanLyDanhSachDangKyDay1.Location = new System.Drawing.Point(3, 3);
            this.uC_QuanLyDanhSachDangKyDay1.Name = "uC_QuanLyDanhSachDangKyDay1";
            this.uC_QuanLyDanhSachDangKyDay1.Size = new System.Drawing.Size(1309, 533);
            this.uC_QuanLyDanhSachDangKyDay1.TabIndex = 10;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1333, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Gia Sư";
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
    }
}

