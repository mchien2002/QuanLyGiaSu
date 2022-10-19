namespace QuanLyGiaSu.src.views.layer.admin
{
    partial class NapTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NapTien));
            this.label1 = new System.Windows.Forms.Label();
            this.cbbLoaiNap = new System.Windows.Forms.ComboBox();
            this.lbSTK = new System.Windows.Forms.Label();
            this.lbCTK = new System.Windows.Forms.Label();
            this.lbNoidung = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.ptbQRMomo = new System.Windows.Forms.PictureBox();
            this.ptbQRVietCom = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQRMomo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQRVietCom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Phương Thức Nạp :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbbLoaiNap
            // 
            this.cbbLoaiNap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiNap.FormattingEnabled = true;
            this.cbbLoaiNap.Items.AddRange(new object[] {
            "Momo",
            "Vietcombank"});
            this.cbbLoaiNap.Location = new System.Drawing.Point(229, 25);
            this.cbbLoaiNap.Name = "cbbLoaiNap";
            this.cbbLoaiNap.Size = new System.Drawing.Size(121, 28);
            this.cbbLoaiNap.TabIndex = 1;
            this.cbbLoaiNap.TextChanged += new System.EventHandler(this.cbbLoaiNap_TextChanged);
            // 
            // lbSTK
            // 
            this.lbSTK.AutoSize = true;
            this.lbSTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSTK.Location = new System.Drawing.Point(93, 80);
            this.lbSTK.Name = "lbSTK";
            this.lbSTK.Size = new System.Drawing.Size(39, 20);
            this.lbSTK.TabIndex = 0;
            this.lbSTK.Text = "STK";
            this.lbSTK.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbCTK
            // 
            this.lbCTK.AutoSize = true;
            this.lbCTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCTK.Location = new System.Drawing.Point(93, 120);
            this.lbCTK.Name = "lbCTK";
            this.lbCTK.Size = new System.Drawing.Size(39, 20);
            this.lbCTK.TabIndex = 0;
            this.lbCTK.Text = "CTK";
            this.lbCTK.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbNoidung
            // 
            this.lbNoidung.AutoSize = true;
            this.lbNoidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoidung.Location = new System.Drawing.Point(37, 174);
            this.lbNoidung.Name = "lbNoidung";
            this.lbNoidung.Size = new System.Drawing.Size(80, 20);
            this.lbNoidung.TabIndex = 0;
            this.lbNoidung.Text = "Nội dung :";
            this.lbNoidung.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(138, 174);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(43, 20);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "User";
            this.lbUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // ptbQRMomo
            // 
            this.ptbQRMomo.Image = global::QuanLyGiaSu.Properties.Resources.momo1;
            this.ptbQRMomo.Location = new System.Drawing.Point(432, 25);
            this.ptbQRMomo.Name = "ptbQRMomo";
            this.ptbQRMomo.Size = new System.Drawing.Size(200, 200);
            this.ptbQRMomo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbQRMomo.TabIndex = 3;
            this.ptbQRMomo.TabStop = false;
            // 
            // ptbQRVietCom
            // 
            this.ptbQRVietCom.Image = global::QuanLyGiaSu.Properties.Resources.vietcom;
            this.ptbQRVietCom.Location = new System.Drawing.Point(432, 25);
            this.ptbQRVietCom.Name = "ptbQRVietCom";
            this.ptbQRVietCom.Size = new System.Drawing.Size(200, 200);
            this.ptbQRVietCom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbQRVietCom.TabIndex = 2;
            this.ptbQRVietCom.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(391, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(4, 235);
            this.label3.TabIndex = 42;
            // 
            // NapTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(674, 264);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ptbQRMomo);
            this.Controls.Add(this.ptbQRVietCom);
            this.Controls.Add(this.cbbLoaiNap);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbNoidung);
            this.Controls.Add(this.lbCTK);
            this.Controls.Add(this.lbSTK);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NapTien";
            this.Text = "Nạp Tiền Vào Tài Khoản";
            this.Load += new System.EventHandler(this.NapTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbQRMomo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQRVietCom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbLoaiNap;
        private System.Windows.Forms.Label lbSTK;
        private System.Windows.Forms.Label lbCTK;
        private System.Windows.Forms.Label lbNoidung;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.PictureBox ptbQRVietCom;
        private System.Windows.Forms.PictureBox ptbQRMomo;
        private System.Windows.Forms.Label label3;
    }
}