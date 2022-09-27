
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
            this.btn_GiaSu = new System.Windows.Forms.Button();
            this.btn_TuyenDung = new System.Windows.Forms.Button();
            this.btn_LopMoi = new System.Windows.Forms.Button();
            this.btnPhuhuynh = new System.Windows.Forms.Button();
            this.btnTrangchu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_LienHe = new System.Windows.Forms.Button();
            this.uC_TrangChu1 = new DoAnCuoiKy_Nhom13.UC_TrangChu();
            this.uC_GiaSu1 = new DoAnCuoiKy_Nhom13.UC_GiaSu();
            this.uC_PhuHuynh1 = new DoAnCuoiKy_Nhom13.UC_PhuHuynh();
            this.uC_LopMoi1 = new QuanLyGiaSu.src.app.views.layer.UC_LopMoi();
            this.uC_TuyenDung1 = new QuanLyGiaSu.src.app.views.layer.UC_TuyenDung();
            this.uC_LienHe1 = new QuanLyGiaSu.src.app.views.layer.UC_LienHe();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_GiaSu);
            this.panel1.Controls.Add(this.btn_LienHe);
            this.panel1.Controls.Add(this.btn_TuyenDung);
            this.panel1.Controls.Add(this.btn_LopMoi);
            this.panel1.Controls.Add(this.btnPhuhuynh);
            this.panel1.Controls.Add(this.btnTrangchu);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 62);
            this.panel1.TabIndex = 0;
            // 
            // btn_GiaSu
            // 
            this.btn_GiaSu.Location = new System.Drawing.Point(339, 12);
            this.btn_GiaSu.Name = "btn_GiaSu";
            this.btn_GiaSu.Size = new System.Drawing.Size(107, 37);
            this.btn_GiaSu.TabIndex = 2;
            this.btn_GiaSu.Text = "Gia Sư";
            this.btn_GiaSu.UseVisualStyleBackColor = true;
            this.btn_GiaSu.Click += new System.EventHandler(this.btn_GiaSu_Click);
            // 
            // btn_TuyenDung
            // 
            this.btn_TuyenDung.Location = new System.Drawing.Point(639, 12);
            this.btn_TuyenDung.Name = "btn_TuyenDung";
            this.btn_TuyenDung.Size = new System.Drawing.Size(107, 37);
            this.btn_TuyenDung.TabIndex = 4;
            this.btn_TuyenDung.Text = "Tuyển Dụng";
            this.btn_TuyenDung.UseVisualStyleBackColor = true;
            this.btn_TuyenDung.Click += new System.EventHandler(this.btn_TuyenDung_Click);
            // 
            // btn_LopMoi
            // 
            this.btn_LopMoi.Location = new System.Drawing.Point(486, 12);
            this.btn_LopMoi.Name = "btn_LopMoi";
            this.btn_LopMoi.Size = new System.Drawing.Size(107, 37);
            this.btn_LopMoi.TabIndex = 3;
            this.btn_LopMoi.Text = "Lớp Mới";
            this.btn_LopMoi.UseVisualStyleBackColor = true;
            this.btn_LopMoi.Click += new System.EventHandler(this.btn_LopMoi_Click);
            // 
            // btnPhuhuynh
            // 
            this.btnPhuhuynh.Location = new System.Drawing.Point(174, 12);
            this.btnPhuhuynh.Name = "btnPhuhuynh";
            this.btnPhuhuynh.Size = new System.Drawing.Size(107, 37);
            this.btnPhuhuynh.TabIndex = 1;
            this.btnPhuhuynh.Text = "Phụ Huynh";
            this.btnPhuhuynh.UseVisualStyleBackColor = true;
            this.btnPhuhuynh.Click += new System.EventHandler(this.btnPhuhuynh_Click);
            // 
            // btnTrangchu
            // 
            this.btnTrangchu.Location = new System.Drawing.Point(21, 12);
            this.btnTrangchu.Name = "btnTrangchu";
            this.btnTrangchu.Size = new System.Drawing.Size(107, 37);
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
            this.panel2.Location = new System.Drawing.Point(12, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1310, 533);
            this.panel2.TabIndex = 1;
            // 
            // btn_LienHe
            // 
            this.btn_LienHe.Location = new System.Drawing.Point(774, 12);
            this.btn_LienHe.Name = "btn_LienHe";
            this.btn_LienHe.Size = new System.Drawing.Size(107, 37);
            this.btn_LienHe.TabIndex = 4;
            this.btn_LienHe.Text = "Liên Hệ";
            this.btn_LienHe.UseVisualStyleBackColor = true;
            this.btn_LienHe.Click += new System.EventHandler(this.btn_LienHe_Click);
            // 
            // uC_TrangChu1
            // 
            this.uC_TrangChu1.BackColor = System.Drawing.Color.AliceBlue;
            this.uC_TrangChu1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uC_TrangChu1.Location = new System.Drawing.Point(-3, 1);
            this.uC_TrangChu1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_TrangChu1.Name = "uC_TrangChu1";
            this.uC_TrangChu1.Size = new System.Drawing.Size(1310, 533);
            this.uC_TrangChu1.TabIndex = 2;
            // 
            // uC_GiaSu1
            // 
            this.uC_GiaSu1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_GiaSu1.Location = new System.Drawing.Point(-2, 2);
            this.uC_GiaSu1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_GiaSu1.Name = "uC_GiaSu1";
            this.uC_GiaSu1.Size = new System.Drawing.Size(1310, 533);
            this.uC_GiaSu1.TabIndex = 0;
            // 
            // uC_PhuHuynh1
            // 
            this.uC_PhuHuynh1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_PhuHuynh1.Location = new System.Drawing.Point(-2, 2);
            this.uC_PhuHuynh1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_PhuHuynh1.Name = "uC_PhuHuynh1";
            this.uC_PhuHuynh1.Size = new System.Drawing.Size(1310, 533);
            this.uC_PhuHuynh1.TabIndex = 2;
            // 
            // uC_LopMoi1
            // 
            this.uC_LopMoi1.Location = new System.Drawing.Point(-3, 3);
            this.uC_LopMoi1.Name = "uC_LopMoi1";
            this.uC_LopMoi1.Size = new System.Drawing.Size(1310, 533);
            this.uC_LopMoi1.TabIndex = 2;
            // 
            // uC_TuyenDung1
            // 
            this.uC_TuyenDung1.Location = new System.Drawing.Point(0, 3);
            this.uC_TuyenDung1.Name = "uC_TuyenDung1";
            this.uC_TuyenDung1.Size = new System.Drawing.Size(1310, 533);
            this.uC_TuyenDung1.TabIndex = 3;
            // 
            // uC_LienHe1
            // 
            this.uC_LienHe1.Location = new System.Drawing.Point(-3, -4);
            this.uC_LienHe1.Name = "uC_LienHe1";
            this.uC_LienHe1.Size = new System.Drawing.Size(1310, 533);
            this.uC_LienHe1.TabIndex = 4;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "formMain";
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
        private System.Windows.Forms.Button btnPhuhuynh;
        private System.Windows.Forms.Button btnTrangchu;
        private System.Windows.Forms.Panel panel2;
        private DoAnCuoiKy_Nhom13.UC_GiaSu uC_GiaSu1;
        private DoAnCuoiKy_Nhom13.UC_TrangChu uC_TrangChu1;
        private DoAnCuoiKy_Nhom13.UC_PhuHuynh uC_PhuHuynh1;
        private src.app.views.layer.UC_LopMoi uC_LopMoi1;
        private System.Windows.Forms.Button btn_LienHe;
        private src.app.views.layer.UC_TuyenDung uC_TuyenDung1;
        private src.app.views.layer.UC_LienHe uC_LienHe1;
    }
}

