﻿namespace QuanLyGiaSu.src.app.views.layer
{
    partial class ThemAccount
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.tb_Pass = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.btn_text = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(263, 239);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(100, 36);
            this.btn_Them.TabIndex = 21;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // tb_Pass
            // 
            this.tb_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Pass.Location = new System.Drawing.Point(53, 162);
            this.tb_Pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Pass.Name = "tb_Pass";
            this.tb_Pass.Size = new System.Drawing.Size(308, 37);
            this.tb_Pass.TabIndex = 1;
            // 
            // tb_user
            // 
            this.tb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_user.Location = new System.Drawing.Point(53, 98);
            this.tb_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(308, 37);
            this.tb_user.TabIndex = 0;
            // 
            // btn_text
            // 
            this.btn_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_text.Location = new System.Drawing.Point(87, 31);
            this.btn_text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_text.Name = "btn_text";
            this.btn_text.Size = new System.Drawing.Size(243, 39);
            this.btn_text.TabIndex = 22;
            this.btn_text.Text = "button1";
            this.btn_text.UseVisualStyleBackColor = true;
            // 
            // ThemAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 321);
            this.Controls.Add(this.btn_text);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.tb_Pass);
            this.Controls.Add(this.tb_user);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ThemAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemAccount";
            this.Load += new System.EventHandler(this.ThemAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox tb_Pass;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Button btn_text;
    }
}