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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerParent = new System.Windows.Forms.ToolStripMenuItem();
            this.registerTutor = new System.Windows.Forms.ToolStripMenuItem();
            this.rb_Admin = new System.Windows.Forms.RadioButton();
            this.rb_PhuHuynh = new System.Windows.Forms.RadioButton();
            this.rb_GiaSu = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 42);
            this.label1.TabIndex = 18;
            this.label1.Text = "Đăng Nhập";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(347, 274);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(100, 28);
            this.btn_Login.TabIndex = 14;
            this.btn_Login.Text = "Đăng Nhập";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click_1);
            // 
            // tb_Pass
            // 
            this.tb_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Pass.Location = new System.Drawing.Point(137, 177);
            this.tb_Pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Pass.Name = "tb_Pass";
            this.tb_Pass.Size = new System.Drawing.Size(308, 37);
            this.tb_Pass.TabIndex = 11;
            // 
            // tb_user
            // 
            this.tb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_user.Location = new System.Drawing.Point(137, 113);
            this.tb_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(308, 37);
            this.tb_user.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(587, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerParent,
            this.registerTutor});
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng ký";
            // 
            // registerParent
            // 
            this.registerParent.Name = "registerParent";
            this.registerParent.Size = new System.Drawing.Size(247, 26);
            this.registerParent.Text = "Đăng ký làm phụ huynh";
            // 
            // registerTutor
            // 
            this.registerTutor.Name = "registerTutor";
            this.registerTutor.Size = new System.Drawing.Size(247, 26);
            this.registerTutor.Text = "Đăng ký làm gia sư";
            // 
            // rb_Admin
            // 
            this.rb_Admin.AutoSize = true;
            this.rb_Admin.Location = new System.Drawing.Point(137, 234);
            this.rb_Admin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_Admin.Name = "rb_Admin";
            this.rb_Admin.Size = new System.Drawing.Size(66, 20);
            this.rb_Admin.TabIndex = 20;
            this.rb_Admin.TabStop = true;
            this.rb_Admin.Text = "Admin";
            this.rb_Admin.UseVisualStyleBackColor = true;
            // 
            // rb_PhuHuynh
            // 
            this.rb_PhuHuynh.AutoSize = true;
            this.rb_PhuHuynh.Location = new System.Drawing.Point(241, 234);
            this.rb_PhuHuynh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_PhuHuynh.Name = "rb_PhuHuynh";
            this.rb_PhuHuynh.Size = new System.Drawing.Size(92, 20);
            this.rb_PhuHuynh.TabIndex = 20;
            this.rb_PhuHuynh.TabStop = true;
            this.rb_PhuHuynh.Text = "Phụ Huynh";
            this.rb_PhuHuynh.UseVisualStyleBackColor = true;
            // 
            // rb_GiaSu
            // 
            this.rb_GiaSu.AutoSize = true;
            this.rb_GiaSu.Location = new System.Drawing.Point(371, 234);
            this.rb_GiaSu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_GiaSu.Name = "rb_GiaSu";
            this.rb_GiaSu.Size = new System.Drawing.Size(68, 20);
            this.rb_GiaSu.TabIndex = 20;
            this.rb_GiaSu.TabStop = true;
            this.rb_GiaSu.Text = "Gia Sư";
            this.rb_GiaSu.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 391);
            this.Controls.Add(this.rb_GiaSu);
            this.Controls.Add(this.rb_PhuHuynh);
            this.Controls.Add(this.rb_Admin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Pass);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox tb_Pass;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerParent;
        private System.Windows.Forms.ToolStripMenuItem registerTutor;
        private System.Windows.Forms.RadioButton rb_Admin;
        private System.Windows.Forms.RadioButton rb_PhuHuynh;
        private System.Windows.Forms.RadioButton rb_GiaSu;
    }
}