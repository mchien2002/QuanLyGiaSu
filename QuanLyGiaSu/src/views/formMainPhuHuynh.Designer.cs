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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMainPhuHuynh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_DanhSachMoLop = new System.Windows.Forms.Button();
            this.btnLichSuGiaoDich = new System.Windows.Forms.Button();
            this.btn_ThongTinhPhuHuynh = new System.Windows.Forms.Button();
            this.btn_DanhSachLopMoi = new System.Windows.Forms.Button();
            this.btnTrangchu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbSoDu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uC_DanhSachMoLop1 = new QuanLyGiaSu.src.app.views.layer.UC_DanhSachLopDaMo();
            this.uC_TrangChu1 = new DoAnCuoiKy_Nhom13.UC_TrangChu();
            this.uC_LienHe1 = new QuanLyGiaSu.src.app.views.layer.UC_LienHe();
            this.uC_ThongTinPhuHuynh1 = new QuanLyGiaSu.src.app.views.layer.UC_ThongTinPhuHuynh();
            this.uC_LSGD_PH1 = new QuanLyGiaSu.src.app.views.layer.UC_LichSuGiaoDichPhuHuynh_GiaSu();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.uC_LopMoiChoPhuHuynh1 = new QuanLyGiaSu.src.app.views.layer.UC_LopMoiChoPhuHuynh();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_DanhSachMoLop);
            this.panel1.Controls.Add(this.btnLichSuGiaoDich);
            this.panel1.Controls.Add(this.btn_ThongTinhPhuHuynh);
            this.panel1.Controls.Add(this.btn_DanhSachLopMoi);
            this.panel1.Controls.Add(this.btnTrangchu);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 62);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_DanhSachMoLop
            // 
            this.btn_DanhSachMoLop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_DanhSachMoLop.Location = new System.Drawing.Point(884, 0);
            this.btn_DanhSachMoLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DanhSachMoLop.Name = "btn_DanhSachMoLop";
            this.btn_DanhSachMoLop.Size = new System.Drawing.Size(225, 62);
            this.btn_DanhSachMoLop.TabIndex = 10;
            this.btn_DanhSachMoLop.Text = "Danh Sách Lớp Đã Mở";
            this.btn_DanhSachMoLop.UseVisualStyleBackColor = true;
            this.btn_DanhSachMoLop.Click += new System.EventHandler(this.btn_DanhSachMoLop_Click);
            // 
            // btnLichSuGiaoDich
            // 
            this.btnLichSuGiaoDich.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLichSuGiaoDich.Location = new System.Drawing.Point(663, 0);
            this.btnLichSuGiaoDich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLichSuGiaoDich.Name = "btnLichSuGiaoDich";
            this.btnLichSuGiaoDich.Size = new System.Drawing.Size(221, 62);
            this.btnLichSuGiaoDich.TabIndex = 9;
            this.btnLichSuGiaoDich.Text = "Lịch Sử Giao Dịch";
            this.btnLichSuGiaoDich.UseVisualStyleBackColor = true;
            this.btnLichSuGiaoDich.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ThongTinhPhuHuynh
            // 
            this.btn_ThongTinhPhuHuynh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_ThongTinhPhuHuynh.Location = new System.Drawing.Point(442, 0);
            this.btn_ThongTinhPhuHuynh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ThongTinhPhuHuynh.Name = "btn_ThongTinhPhuHuynh";
            this.btn_ThongTinhPhuHuynh.Size = new System.Drawing.Size(221, 62);
            this.btn_ThongTinhPhuHuynh.TabIndex = 2;
            this.btn_ThongTinhPhuHuynh.Text = "Thông Tin Phụ Huynh";
            this.btn_ThongTinhPhuHuynh.UseVisualStyleBackColor = true;
            this.btn_ThongTinhPhuHuynh.Click += new System.EventHandler(this.btn_ThongTinhPhuHuynh_Click);
            // 
            // btn_DanhSachLopMoi
            // 
            this.btn_DanhSachLopMoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_DanhSachLopMoi.Location = new System.Drawing.Point(221, 0);
            this.btn_DanhSachLopMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DanhSachLopMoi.Name = "btn_DanhSachLopMoi";
            this.btn_DanhSachLopMoi.Size = new System.Drawing.Size(221, 62);
            this.btn_DanhSachLopMoi.TabIndex = 3;
            this.btn_DanhSachLopMoi.Text = "Danh Sách Lớp Mới";
            this.btn_DanhSachLopMoi.UseVisualStyleBackColor = true;
            this.btn_DanhSachLopMoi.Click += new System.EventHandler(this.btn_LopMoi_Click);
            // 
            // btnTrangchu
            // 
            this.btnTrangchu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTrangchu.Location = new System.Drawing.Point(0, 0);
            this.btnTrangchu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrangchu.Name = "btnTrangchu";
            this.btnTrangchu.Size = new System.Drawing.Size(221, 62);
            this.btnTrangchu.TabIndex = 0;
            this.btnTrangchu.Text = "Trang Chủ";
            this.btnTrangchu.UseVisualStyleBackColor = true;
            this.btnTrangchu.Click += new System.EventHandler(this.btnTrangchu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lbSoDu);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1132, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 62);
            this.panel2.TabIndex = 11;
            this.toolTip1.SetToolTip(this.panel2, "Click Để Nạp Tiền");
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // lbSoDu
            // 
            this.lbSoDu.AutoSize = true;
            this.lbSoDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoDu.Location = new System.Drawing.Point(64, 21);
            this.lbSoDu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoDu.Name = "lbSoDu";
            this.lbSoDu.Size = new System.Drawing.Size(80, 20);
            this.lbSoDu.TabIndex = 0;
            this.lbSoDu.Text = "1.000.000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Dư :";
            // 
            // uC_DanhSachMoLop1
            // 
            this.uC_DanhSachMoLop1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_DanhSachMoLop1.Location = new System.Drawing.Point(16, 82);
            this.uC_DanhSachMoLop1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_DanhSachMoLop1.Name = "uC_DanhSachMoLop1";
            this.uC_DanhSachMoLop1.Size = new System.Drawing.Size(1309, 533);
            this.uC_DanhSachMoLop1.TabIndex = 13;
            // 
            // uC_TrangChu1
            // 
            this.uC_TrangChu1.AutoScroll = true;
            this.uC_TrangChu1.BackColor = System.Drawing.Color.AliceBlue;
            this.uC_TrangChu1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uC_TrangChu1.Location = new System.Drawing.Point(16, 82);
            this.uC_TrangChu1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_TrangChu1.Name = "uC_TrangChu1";
            this.uC_TrangChu1.Size = new System.Drawing.Size(1309, 533);
            this.uC_TrangChu1.TabIndex = 5;
            // 
            // uC_LienHe1
            // 
            this.uC_LienHe1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_LienHe1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
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
            // uC_LSGD_PH1
            // 
            this.uC_LSGD_PH1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_LSGD_PH1.Location = new System.Drawing.Point(16, 82);
            this.uC_LSGD_PH1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uC_LSGD_PH1.Name = "uC_LSGD_PH1";
            this.uC_LSGD_PH1.Size = new System.Drawing.Size(1309, 533);
            this.uC_LSGD_PH1.TabIndex = 14;
            // 
            // uC_LopMoiChoPhuHuynh1
            // 
            this.uC_LopMoiChoPhuHuynh1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_LopMoiChoPhuHuynh1.Location = new System.Drawing.Point(16, 82);
            this.uC_LopMoiChoPhuHuynh1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uC_LopMoiChoPhuHuynh1.Name = "uC_LopMoiChoPhuHuynh1";
            this.uC_LopMoiChoPhuHuynh1.Size = new System.Drawing.Size(1309, 533);
            this.uC_LopMoiChoPhuHuynh1.TabIndex = 15;
            // 
            // formMainPhuHuynh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uC_TrangChu1);
            this.Controls.Add(this.uC_LopMoiChoPhuHuynh1);
            this.Controls.Add(this.uC_LienHe1);
            this.Controls.Add(this.uC_ThongTinPhuHuynh1);
            this.Controls.Add(this.uC_LSGD_PH1);
            this.Controls.Add(this.uC_DanhSachMoLop1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formMainPhuHuynh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trung Tâm Gia Sư Anh Em";
            this.Load += new System.EventHandler(this.formMainPhuHuynh_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLichSuGiaoDich;
        private System.Windows.Forms.Button btn_ThongTinhPhuHuynh;
        private System.Windows.Forms.Button btn_DanhSachLopMoi;
        private System.Windows.Forms.Button btnTrangchu;
        private DoAnCuoiKy_Nhom13.UC_TrangChu uC_TrangChu1;
        private src.app.views.layer.UC_LienHe uC_LienHe1;
        private src.app.views.layer.UC_ThongTinPhuHuynh uC_ThongTinPhuHuynh1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbSoDu;
        private System.Windows.Forms.Label label1;
        private src.app.views.layer.UC_LopMoiChoPhuHuynh uC_LopMoi21;
        private System.Windows.Forms.Button btn_DanhSachMoLop;
        private src.app.views.layer.UC_DanhSachLopDaMo uC_DanhSachMoLop1;
        private src.app.views.layer.UC_LichSuGiaoDichPhuHuynh_GiaSu uC_LSGD_PH1;
        private System.Windows.Forms.ToolTip toolTip1;
        private src.app.views.layer.UC_LopMoiChoPhuHuynh uC_LopMoiChoPhuHuynh1;
    }
}