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
            this.lbText = new System.Windows.Forms.Label();
            this.tbLop = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.Location = new System.Drawing.Point(30, 53);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(51, 20);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "label1";
            // 
            // tbLop
            // 
            this.tbLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLop.Location = new System.Drawing.Point(147, 47);
            this.tbLop.Name = "tbLop";
            this.tbLop.Size = new System.Drawing.Size(187, 26);
            this.tbLop.TabIndex = 1;
            // 
            // ThemSuaLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 135);
            this.Controls.Add(this.tbLop);
            this.Controls.Add(this.lbText);
            this.Name = "ThemSuaLop";
            this.Text = "ThemSuaLop";
            this.Load += new System.EventHandler(this.ThemSuaLop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.TextBox tbLop;
    }
}