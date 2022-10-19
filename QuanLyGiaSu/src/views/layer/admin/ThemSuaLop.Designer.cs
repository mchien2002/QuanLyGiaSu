namespace QuanLyGiaSu.src.views.layer.admin
{
    partial class ThemSuaLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemSuaLop));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLop = new System.Windows.Forms.TextBox();
            this.lbText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(185, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 19);
            this.label1.TabIndex = 75;
            this.label1.Text = ":";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(24, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 2);
            this.label5.TabIndex = 74;
            // 
            // tbLop
            // 
            this.tbLop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLop.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbLop.Location = new System.Drawing.Point(227, 55);
            this.tbLop.Name = "tbLop";
            this.tbLop.Size = new System.Drawing.Size(187, 20);
            this.tbLop.TabIndex = 73;
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbText.Location = new System.Drawing.Point(47, 56);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(51, 19);
            this.lbText.TabIndex = 72;
            this.lbText.Text = "label1";
            // 
            // ThemSuaLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(439, 135);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbLop);
            this.Controls.Add(this.lbText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThemSuaLop";
            this.Text = "Lớp Học";
            this.Load += new System.EventHandler(this.ThemSuaLop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLop;
        private System.Windows.Forms.Label lbText;
    }
}