namespace QuanLyGiaSu.src.views.layer.admin
{
    partial class ThemSuaMon
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
            this.tbMon = new System.Windows.Forms.TextBox();
            this.lbText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbMon
            // 
            this.tbMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMon.Location = new System.Drawing.Point(152, 54);
            this.tbMon.Name = "tbMon";
            this.tbMon.Size = new System.Drawing.Size(187, 26);
            this.tbMon.TabIndex = 3;
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.Location = new System.Drawing.Point(35, 60);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(51, 20);
            this.lbText.TabIndex = 2;
            this.lbText.Text = "label1";
            // 
            // ThemSuaMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 135);
            this.Controls.Add(this.tbMon);
            this.Controls.Add(this.lbText);
            this.Name = "ThemSuaMon";
            this.Text = "ThemSuaMon";
            this.Load += new System.EventHandler(this.ThemSuaMon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMon;
        private System.Windows.Forms.Label lbText;
    }
}