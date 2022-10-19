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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemSuaMon));
            this.tbMon = new System.Windows.Forms.TextBox();
            this.lbText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbMon
            // 
            this.tbMon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMon.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbMon.Location = new System.Drawing.Point(215, 59);
            this.tbMon.Name = "tbMon";
            this.tbMon.Size = new System.Drawing.Size(187, 20);
            this.tbMon.TabIndex = 3;
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbText.Location = new System.Drawing.Point(35, 60);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(51, 19);
            this.lbText.TabIndex = 2;
            this.lbText.Text = "label1";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(12, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 2);
            this.label5.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(173, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 19);
            this.label1.TabIndex = 71;
            this.label1.Text = ":";
            // 
            // ThemSuaMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(439, 135);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMon);
            this.Controls.Add(this.lbText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThemSuaMon";
            this.Text = "Môn Học";
            this.Load += new System.EventHandler(this.ThemSuaMon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMon;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}