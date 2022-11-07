namespace DoAnCuoiKy_Nhom13
{
    partial class UC_TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_TrangChu));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ptbLienHe = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTuyenDung = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLienHe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ptbLienHe, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbTuyenDung, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.65487F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.34513F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 258F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1303, 1497);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ptbLienHe
            // 
            this.ptbLienHe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbLienHe.Image = global::QuanLyGiaSu.Properties.Resources.banner_trungtamgiasu;
            this.ptbLienHe.Location = new System.Drawing.Point(3, 3);
            this.ptbLienHe.Name = "ptbLienHe";
            this.ptbLienHe.Size = new System.Drawing.Size(1297, 274);
            this.ptbLienHe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLienHe.TabIndex = 0;
            this.ptbLienHe.TabStop = false;
            this.ptbLienHe.Click += new System.EventHandler(this.ptbLienHe_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QuanLyGiaSu.Properties.Resources.trung_tâm;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1297, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbTuyenDung
            // 
            this.lbTuyenDung.AutoSize = true;
            this.lbTuyenDung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTuyenDung.Location = new System.Drawing.Point(3, 280);
            this.lbTuyenDung.Name = "lbTuyenDung";
            this.lbTuyenDung.Size = new System.Drawing.Size(1297, 958);
            this.lbTuyenDung.TabIndex = 2;
            this.lbTuyenDung.Text = resources.GetString("lbTuyenDung.Text");
            // 
            // UC_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_TrangChu";
            this.Size = new System.Drawing.Size(1309, 3000);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLienHe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox ptbLienHe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTuyenDung;
    }
}
