namespace QuanLyGiaSu.src.app.views.layer
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.tb_Pass = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.rb_Admin = new System.Windows.Forms.RadioButton();
            this.rb_PhuHuynh = new System.Windows.Forms.RadioButton();
            this.rb_GiaSu = new System.Windows.Forms.RadioButton();
            this.btnDangKyGiaSu = new System.Windows.Forms.Button();
            this.btnDangKyPhuHuynh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Login";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(373, 279);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 14;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click_1);
            // 
            // tb_Pass
            // 
            this.tb_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Pass.Location = new System.Drawing.Point(373, 195);
            this.tb_Pass.Name = "tb_Pass";
            this.tb_Pass.Size = new System.Drawing.Size(232, 31);
            this.tb_Pass.TabIndex = 11;
            // 
            // tb_user
            // 
            this.tb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_user.Location = new System.Drawing.Point(373, 143);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(232, 31);
            this.tb_user.TabIndex = 12;
            // 
            // rb_Admin
            // 
            this.rb_Admin.AutoSize = true;
            this.rb_Admin.Location = new System.Drawing.Point(373, 241);
            this.rb_Admin.Name = "rb_Admin";
            this.rb_Admin.Size = new System.Drawing.Size(54, 17);
            this.rb_Admin.TabIndex = 20;
            this.rb_Admin.TabStop = true;
            this.rb_Admin.Text = "Admin";
            this.rb_Admin.UseVisualStyleBackColor = true;
            // 
            // rb_PhuHuynh
            // 
            this.rb_PhuHuynh.AutoSize = true;
            this.rb_PhuHuynh.Location = new System.Drawing.Point(451, 241);
            this.rb_PhuHuynh.Name = "rb_PhuHuynh";
            this.rb_PhuHuynh.Size = new System.Drawing.Size(78, 17);
            this.rb_PhuHuynh.TabIndex = 20;
            this.rb_PhuHuynh.TabStop = true;
            this.rb_PhuHuynh.Text = "Phụ Huynh";
            this.rb_PhuHuynh.UseVisualStyleBackColor = true;
            // 
            // rb_GiaSu
            // 
            this.rb_GiaSu.AutoSize = true;
            this.rb_GiaSu.Location = new System.Drawing.Point(548, 241);
            this.rb_GiaSu.Name = "rb_GiaSu";
            this.rb_GiaSu.Size = new System.Drawing.Size(57, 17);
            this.rb_GiaSu.TabIndex = 20;
            this.rb_GiaSu.TabStop = true;
            this.rb_GiaSu.Text = "Gia Sư";
            this.rb_GiaSu.UseVisualStyleBackColor = true;
            // 
            // btnDangKyGiaSu
            // 
            this.btnDangKyGiaSu.Location = new System.Drawing.Point(351, 344);
            this.btnDangKyGiaSu.Name = "btnDangKyGiaSu";
            this.btnDangKyGiaSu.Size = new System.Drawing.Size(151, 23);
            this.btnDangKyGiaSu.TabIndex = 21;
            this.btnDangKyGiaSu.Text = "Đăng Ký Tài Khoản Gia Sư";
            this.btnDangKyGiaSu.UseVisualStyleBackColor = true;
            this.btnDangKyGiaSu.Click += new System.EventHandler(this.btnDangKyGiaSu_Click);
            // 
            // btnDangKyPhuHuynh
            // 
            this.btnDangKyPhuHuynh.Location = new System.Drawing.Point(521, 343);
            this.btnDangKyPhuHuynh.Name = "btnDangKyPhuHuynh";
            this.btnDangKyPhuHuynh.Size = new System.Drawing.Size(157, 24);
            this.btnDangKyPhuHuynh.TabIndex = 22;
            this.btnDangKyPhuHuynh.Text = "Đăng Ký Tài Khoản Phụ Huynh";
            this.btnDangKyPhuHuynh.UseVisualStyleBackColor = true;
            this.btnDangKyPhuHuynh.Click += new System.EventHandler(this.btnDangKyPhuHuynh_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 508);
            this.Controls.Add(this.btnDangKyPhuHuynh);
            this.Controls.Add(this.btnDangKyGiaSu);
            this.Controls.Add(this.rb_GiaSu);
            this.Controls.Add(this.rb_PhuHuynh);
            this.Controls.Add(this.rb_Admin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Pass);
            this.Controls.Add(this.tb_user);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox tb_Pass;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.RadioButton rb_Admin;
        private System.Windows.Forms.RadioButton rb_PhuHuynh;
        private System.Windows.Forms.RadioButton rb_GiaSu;
        private System.Windows.Forms.Button btnDangKyGiaSu;
        private System.Windows.Forms.Button btnDangKyPhuHuynh;
    }
}