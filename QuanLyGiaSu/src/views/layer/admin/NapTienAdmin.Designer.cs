namespace QuanLyGiaSu.src.views.layer.admin
{
    partial class NapTienAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NapTienAdmin));
            this.lbTenTaiKhoan = new System.Windows.Forms.Label();
            this.btnNapTien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.lbstk2 = new System.Windows.Forms.Label();
            this.lbSTK = new System.Windows.Forms.Label();
            this.tbNapTien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTenTaiKhoan
            // 
            this.lbTenTaiKhoan.AutoSize = true;
            this.lbTenTaiKhoan.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbTenTaiKhoan.Location = new System.Drawing.Point(276, 24);
            this.lbTenTaiKhoan.Name = "lbTenTaiKhoan";
            this.lbTenTaiKhoan.Size = new System.Drawing.Size(64, 24);
            this.lbTenTaiKhoan.TabIndex = 0;
            this.lbTenTaiKhoan.Text = "label1";
            // 
            // btnNapTien
            // 
            this.btnNapTien.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnNapTien.Location = new System.Drawing.Point(397, 121);
            this.btnNapTien.Name = "btnNapTien";
            this.btnNapTien.Size = new System.Drawing.Size(99, 34);
            this.btnNapTien.TabIndex = 2;
            this.btnNapTien.Text = "Nạp Tiền";
            this.btnNapTien.UseVisualStyleBackColor = true;
            this.btnNapTien.Click += new System.EventHandler(this.btnNapTien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nạp tiền cho tài khoản :";
            // 
            // label41
            // 
            this.label41.BackColor = System.Drawing.Color.Silver;
            this.label41.Location = new System.Drawing.Point(29, 49);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(467, 1);
            this.label41.TabIndex = 147;
            // 
            // lbstk2
            // 
            this.lbstk2.BackColor = System.Drawing.Color.Silver;
            this.lbstk2.Location = new System.Drawing.Point(30, 100);
            this.lbstk2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbstk2.Name = "lbstk2";
            this.lbstk2.Size = new System.Drawing.Size(467, 1);
            this.lbstk2.TabIndex = 149;
            // 
            // lbSTK
            // 
            this.lbSTK.AutoSize = true;
            this.lbSTK.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbSTK.Location = new System.Drawing.Point(35, 75);
            this.lbSTK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSTK.Name = "lbSTK";
            this.lbSTK.Size = new System.Drawing.Size(85, 24);
            this.lbSTK.TabIndex = 148;
            this.lbSTK.Text = "Số tiền :";
            // 
            // tbNapTien
            // 
            this.tbNapTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNapTien.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbNapTien.Location = new System.Drawing.Point(121, 75);
            this.tbNapTien.Margin = new System.Windows.Forms.Padding(4);
            this.tbNapTien.Name = "tbNapTien";
            this.tbNapTien.Size = new System.Drawing.Size(368, 25);
            this.tbNapTien.TabIndex = 150;
            // 
            // NapTienAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(525, 182);
            this.Controls.Add(this.tbNapTien);
            this.Controls.Add(this.lbstk2);
            this.Controls.Add(this.lbSTK);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNapTien);
            this.Controls.Add(this.lbTenTaiKhoan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NapTienAdmin";
            this.Text = "Nạp tiền";
            this.Load += new System.EventHandler(this.NapTienAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenTaiKhoan;
        private System.Windows.Forms.Button btnNapTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label lbstk2;
        private System.Windows.Forms.Label lbSTK;
        private System.Windows.Forms.TextBox tbNapTien;
    }
}