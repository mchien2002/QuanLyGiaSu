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
            this.lbTenTaiKhoan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNapTien = new System.Windows.Forms.Button();
            this.tbNapTien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTenTaiKhoan
            // 
            this.lbTenTaiKhoan.AutoSize = true;
            this.lbTenTaiKhoan.Location = new System.Drawing.Point(224, 36);
            this.lbTenTaiKhoan.Name = "lbTenTaiKhoan";
            this.lbTenTaiKhoan.Size = new System.Drawing.Size(44, 16);
            this.lbTenTaiKhoan.TabIndex = 0;
            this.lbTenTaiKhoan.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nạp tiền cho tài khoản: ";
            // 
            // btnNapTien
            // 
            this.btnNapTien.Location = new System.Drawing.Point(38, 136);
            this.btnNapTien.Name = "btnNapTien";
            this.btnNapTien.Size = new System.Drawing.Size(75, 23);
            this.btnNapTien.TabIndex = 2;
            this.btnNapTien.Text = "Nạp Tiền";
            this.btnNapTien.UseVisualStyleBackColor = true;
            this.btnNapTien.Click += new System.EventHandler(this.btnNapTien_Click);
            // 
            // tbNapTien
            // 
            this.tbNapTien.Location = new System.Drawing.Point(38, 89);
            this.tbNapTien.Name = "tbNapTien";
            this.tbNapTien.Size = new System.Drawing.Size(100, 22);
            this.tbNapTien.TabIndex = 3;
            this.tbNapTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNapTien_KeyPress);
            // 
            // NapTienAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbNapTien);
            this.Controls.Add(this.btnNapTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTenTaiKhoan);
            this.Name = "NapTienAdmin";
            this.Text = "NapTienAdmin";
            this.Load += new System.EventHandler(this.NapTienAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNapTien;
        private System.Windows.Forms.TextBox tbNapTien;
    }
}