namespace QuanLyGiaSu.src.app.views.layer
{
    partial class UC_Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_GiaSu = new System.Windows.Forms.CheckBox();
            this.cb_PhuHuynh = new System.Windows.Forms.CheckBox();
            this.cb_Admin = new System.Windows.Forms.CheckBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.tb_Pass = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_GiaSu
            // 
            this.cb_GiaSu.AutoSize = true;
            this.cb_GiaSu.Location = new System.Drawing.Point(281, 199);
            this.cb_GiaSu.Name = "cb_GiaSu";
            this.cb_GiaSu.Size = new System.Drawing.Size(58, 17);
            this.cb_GiaSu.TabIndex = 7;
            this.cb_GiaSu.Text = "Gia Sư";
            this.cb_GiaSu.UseVisualStyleBackColor = true;
            // 
            // cb_PhuHuynh
            // 
            this.cb_PhuHuynh.AutoSize = true;
            this.cb_PhuHuynh.Location = new System.Drawing.Point(186, 199);
            this.cb_PhuHuynh.Name = "cb_PhuHuynh";
            this.cb_PhuHuynh.Size = new System.Drawing.Size(79, 17);
            this.cb_PhuHuynh.TabIndex = 8;
            this.cb_PhuHuynh.Text = "Phụ Huynh";
            this.cb_PhuHuynh.UseVisualStyleBackColor = true;
            // 
            // cb_Admin
            // 
            this.cb_Admin.AutoSize = true;
            this.cb_Admin.Location = new System.Drawing.Point(107, 199);
            this.cb_Admin.Name = "cb_Admin";
            this.cb_Admin.Size = new System.Drawing.Size(55, 17);
            this.cb_Admin.TabIndex = 9;
            this.cb_Admin.Text = "Admin";
            this.cb_Admin.UseVisualStyleBackColor = true;
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(264, 231);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(75, 23);
            this.btn_Register.TabIndex = 5;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(107, 231);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            // 
            // tb_Pass
            // 
            this.tb_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Pass.Location = new System.Drawing.Point(107, 152);
            this.tb_Pass.Name = "tb_Pass";
            this.tb_Pass.Size = new System.Drawing.Size(232, 31);
            this.tb_Pass.TabIndex = 3;
            // 
            // tb_user
            // 
            this.tb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_user.Location = new System.Drawing.Point(107, 100);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(232, 31);
            this.tb_user.TabIndex = 4;
            this.tb_user.TextChanged += new System.EventHandler(this.tb_user_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Login";
            // 
            // UC_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_GiaSu);
            this.Controls.Add(this.cb_PhuHuynh);
            this.Controls.Add(this.cb_Admin);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Pass);
            this.Controls.Add(this.tb_user);
            this.Name = "UC_Login";
            this.Size = new System.Drawing.Size(445, 322);
            this.Load += new System.EventHandler(this.UC_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_GiaSu;
        private System.Windows.Forms.CheckBox cb_PhuHuynh;
        private System.Windows.Forms.CheckBox cb_Admin;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox tb_Pass;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label label1;
    }
}
