namespace QuanLyGiaSu
{
    partial class formMainGiaSu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMainGiaSu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLichSuGiaoDich = new System.Windows.Forms.Button();
            this.btn_QlyDSLOP = new System.Windows.Forms.Button();
            this.btn_GiaSu = new System.Windows.Forms.Button();
            this.btn_DanhSachLopMoi = new System.Windows.Forms.Button();
            this.btnTrangchu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbSoDu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uC_TrangChu1 = new DoAnCuoiKy_Nhom13.UC_TrangChu();
            this.uC_GiaSu1 = new DoAnCuoiKy_Nhom13.UC_GiaSu();
            this.uC_LichSuGiaoDichPhuHuynh_GiaSu1 = new QuanLyGiaSu.src.app.views.layer.UC_LichSuGiaoDichPhuHuynh_GiaSu();
            this.uC_DanhSachLopDaDangKyDay1 = new QuanLyGiaSu.src.views.layer.tutors.UC_DanhSachLopDaDangKyDay();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NapTien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.uC_LopMoiChoGiaSu1 = new QuanLyGiaSu.src.views.layer.tutors.UC_LopMoiChoGiaSu();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnLichSuGiaoDich);
            this.panel1.Controls.Add(this.btn_QlyDSLOP);
            this.panel1.Controls.Add(this.btn_GiaSu);
            this.panel1.Controls.Add(this.btn_DanhSachLopMoi);
            this.panel1.Controls.Add(this.btnTrangchu);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 62);
            this.panel1.TabIndex = 3;
            // 
            // btnLichSuGiaoDich
            // 
            this.btnLichSuGiaoDich.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLichSuGiaoDich.Location = new System.Drawing.Point(892, 0);
            this.btnLichSuGiaoDich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLichSuGiaoDich.Name = "btnLichSuGiaoDich";
            this.btnLichSuGiaoDich.Size = new System.Drawing.Size(217, 62);
            this.btnLichSuGiaoDich.TabIndex = 9;
            this.btnLichSuGiaoDich.Text = "Lịch Sử Giao Dịch";
            this.btnLichSuGiaoDich.UseVisualStyleBackColor = true;
            this.btnLichSuGiaoDich.Click += new System.EventHandler(this.btnLichSuGiaoDich_Click);
            // 
            // btn_QlyDSLOP
            // 
            this.btn_QlyDSLOP.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_QlyDSLOP.Location = new System.Drawing.Point(669, 0);
            this.btn_QlyDSLOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QlyDSLOP.Name = "btn_QlyDSLOP";
            this.btn_QlyDSLOP.Size = new System.Drawing.Size(223, 62);
            this.btn_QlyDSLOP.TabIndex = 8;
            this.btn_QlyDSLOP.Text = "Danh Sách Lớp Đã Đăng Ký Dạy";
            this.btn_QlyDSLOP.UseVisualStyleBackColor = true;
            this.btn_QlyDSLOP.Click += new System.EventHandler(this.btn_QlyDSLOP_Click);
            // 
            // btn_GiaSu
            // 
            this.btn_GiaSu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_GiaSu.Location = new System.Drawing.Point(446, 0);
            this.btn_GiaSu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GiaSu.Name = "btn_GiaSu";
            this.btn_GiaSu.Size = new System.Drawing.Size(223, 62);
            this.btn_GiaSu.TabIndex = 2;
            this.btn_GiaSu.Text = "Thông Tin Gia Sư";
            this.btn_GiaSu.UseVisualStyleBackColor = true;
            this.btn_GiaSu.Click += new System.EventHandler(this.btn_GiaSu_Click);
            // 
            // btn_DanhSachLopMoi
            // 
            this.btn_DanhSachLopMoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_DanhSachLopMoi.Location = new System.Drawing.Point(223, 0);
            this.btn_DanhSachLopMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DanhSachLopMoi.Name = "btn_DanhSachLopMoi";
            this.btn_DanhSachLopMoi.Size = new System.Drawing.Size(223, 62);
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
            this.btnTrangchu.Size = new System.Drawing.Size(223, 62);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 62);
            this.panel2.TabIndex = 12;
            this.toolTip1.SetToolTip(this.panel2, "Click Để Nạp Tiền");
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // lbSoDu
            // 
            this.lbSoDu.AutoSize = true;
            this.lbSoDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoDu.Location = new System.Drawing.Point(64, 20);
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
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Dư :";
            // 
            // uC_TrangChu1
            // 
            this.uC_TrangChu1.AutoScroll = true;
            this.uC_TrangChu1.BackColor = System.Drawing.Color.White;
            this.uC_TrangChu1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uC_TrangChu1.Location = new System.Drawing.Point(15, 82);
            this.uC_TrangChu1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_TrangChu1.Name = "uC_TrangChu1";
            this.uC_TrangChu1.Size = new System.Drawing.Size(1309, 533);
            this.uC_TrangChu1.TabIndex = 5;
            // 
            // uC_GiaSu1
            // 
            this.uC_GiaSu1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.uC_GiaSu1.Location = new System.Drawing.Point(15, 82);
            this.uC_GiaSu1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_GiaSu1.Name = "uC_GiaSu1";
            this.uC_GiaSu1.Size = new System.Drawing.Size(1309, 533);
            this.uC_GiaSu1.TabIndex = 9;
            // 
            // uC_LichSuGiaoDichPhuHuynh_GiaSu1
            // 
            this.uC_LichSuGiaoDichPhuHuynh_GiaSu1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_LichSuGiaoDichPhuHuynh_GiaSu1.Location = new System.Drawing.Point(15, 82);
            this.uC_LichSuGiaoDichPhuHuynh_GiaSu1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_LichSuGiaoDichPhuHuynh_GiaSu1.Name = "uC_LichSuGiaoDichPhuHuynh_GiaSu1";
            this.uC_LichSuGiaoDichPhuHuynh_GiaSu1.Size = new System.Drawing.Size(1305, 533);
            this.uC_LichSuGiaoDichPhuHuynh_GiaSu1.TabIndex = 14;
            // 
            // uC_DanhSachLopDaDangKyDay1
            // 
            this.uC_DanhSachLopDaDangKyDay1.BackColor = System.Drawing.Color.White;
            this.uC_DanhSachLopDaDangKyDay1.Location = new System.Drawing.Point(15, 82);
            this.uC_DanhSachLopDaDangKyDay1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_DanhSachLopDaDangKyDay1.Name = "uC_DanhSachLopDaDangKyDay1";
            this.uC_DanhSachLopDaDangKyDay1.Size = new System.Drawing.Size(1309, 533);
            this.uC_DanhSachLopDaDangKyDay1.TabIndex = 15;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NapTien});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 28);
            // 
            // NapTien
            // 
            this.NapTien.Name = "NapTien";
            this.NapTien.Size = new System.Drawing.Size(138, 24);
            this.NapTien.Text = "Nạp Tiền";
            // 
            // uC_LopMoiChoGiaSu1
            // 
            this.uC_LopMoiChoGiaSu1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_LopMoiChoGiaSu1.Location = new System.Drawing.Point(15, 82);
            this.uC_LopMoiChoGiaSu1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_LopMoiChoGiaSu1.Name = "uC_LopMoiChoGiaSu1";
            this.uC_LopMoiChoGiaSu1.Size = new System.Drawing.Size(1309, 533);
            this.uC_LopMoiChoGiaSu1.TabIndex = 16;
            // 
            // formMainGiaSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uC_TrangChu1);
            this.Controls.Add(this.uC_LopMoiChoGiaSu1);
            this.Controls.Add(this.uC_GiaSu1);
            this.Controls.Add(this.uC_LichSuGiaoDichPhuHuynh_GiaSu1);
            this.Controls.Add(this.uC_DanhSachLopDaDangKyDay1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formMainGiaSu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trung Tâm Gia Sư Anh Em";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMainGiaSu_FormClosing);
            this.Load += new System.EventHandler(this.formMainGiaSu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLichSuGiaoDich;
        private System.Windows.Forms.Button btn_QlyDSLOP;
        private System.Windows.Forms.Button btn_GiaSu;
        private System.Windows.Forms.Button btn_DanhSachLopMoi;
        private System.Windows.Forms.Button btnTrangchu;
        private DoAnCuoiKy_Nhom13.UC_TrangChu uC_TrangChu1;
        private DoAnCuoiKy_Nhom13.UC_GiaSu uC_GiaSu1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbSoDu;
        private System.Windows.Forms.Label label1;
        private src.app.views.layer.UC_LopMoiChoPhuHuynh uC_LopMoiChoPhuHuynh_GiaSu1;
        private src.app.views.layer.UC_LichSuGiaoDichPhuHuynh_GiaSu uC_LichSuGiaoDichPhuHuynh_GiaSu1;
        private src.views.layer.tutors.UC_DanhSachLopDaDangKyDay uC_DanhSachLopDaDangKyDay1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem NapTien;
        private System.Windows.Forms.ToolTip toolTip1;
        private src.views.layer.tutors.UC_LopMoiChoGiaSu uC_LopMoiChoGiaSu1;
    }
}