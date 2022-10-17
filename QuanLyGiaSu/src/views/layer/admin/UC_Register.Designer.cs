namespace QuanLyGiaSu.src.app.views.layer
{
    partial class UC_Register
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
            this.tb_Pass1 = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_Pass2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_GiaSu
            // 
            this.cb_GiaSu.AutoSize = true;
            this.cb_GiaSu.Location = new System.Drawing.Point(255, 229);
            this.cb_GiaSu.Name = "cb_GiaSu";
            this.cb_GiaSu.Size = new System.Drawing.Size(58, 17);
            this.cb_GiaSu.TabIndex = 14;
            this.cb_GiaSu.Text = "Gia Sư";
            this.cb_GiaSu.UseVisualStyleBackColor = true;
            // 
            // cb_PhuHuynh
            // 
            this.cb_PhuHuynh.AutoSize = true;
            this.cb_PhuHuynh.Location = new System.Drawing.Point(127, 229);
            this.cb_PhuHuynh.Name = "cb_PhuHuynh";
            this.cb_PhuHuynh.Size = new System.Drawing.Size(79, 17);
            this.cb_PhuHuynh.TabIndex = 15;
            this.cb_PhuHuynh.Text = "Phụ Huynh";
            this.cb_PhuHuynh.UseVisualStyleBackColor = true;
            // 
            // tb_Pass1
            // 
            this.tb_Pass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Pass1.Location = new System.Drawing.Point(107, 122);
            this.tb_Pass1.Name = "tb_Pass1";
            this.tb_Pass1.Size = new System.Drawing.Size(232, 31);
            this.tb_Pass1.TabIndex = 10;
            this.tb_Pass1.TextChanged += new System.EventHandler(this.tb_Pass_TextChanged);
            // 
            // tb_user
            // 
            this.tb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_user.Location = new System.Drawing.Point(107, 70);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(232, 31);
            this.tb_user.TabIndex = 11;
            // 
            // tb_Pass2
            // 
            this.tb_Pass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Pass2.Location = new System.Drawing.Point(107, 176);
            this.tb_Pass2.Name = "tb_Pass2";
            this.tb_Pass2.Size = new System.Drawing.Size(232, 31);
            this.tb_Pass2.TabIndex = 10;
            this.tb_Pass2.TextChanged += new System.EventHandler(this.tb_Pass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 33);
            this.label1.TabIndex = 16;
            this.label1.Text = "Register";
            // 
            // UC_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_GiaSu);
            this.Controls.Add(this.cb_PhuHuynh);
            this.Controls.Add(this.tb_Pass2);
            this.Controls.Add(this.tb_Pass1);
            this.Controls.Add(this.tb_user);
            this.Name = "UC_Register";
            this.Size = new System.Drawing.Size(445, 322);
            this.Load += new System.EventHandler(this.UC_Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_GiaSu;
        private System.Windows.Forms.CheckBox cb_PhuHuynh;
        private System.Windows.Forms.TextBox tb_Pass1;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_Pass2;
        private System.Windows.Forms.Label label1;
    }
}
