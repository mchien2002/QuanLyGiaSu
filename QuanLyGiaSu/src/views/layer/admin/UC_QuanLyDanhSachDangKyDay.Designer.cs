namespace QuanLyGiaSu.src.views.layer.admin
{
    partial class UC_QuanLyDanhSachDangKyDay
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
            this.dgvDSDKD = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDKD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSDKD
            // 
            this.dgvDSDKD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSDKD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDKD.Location = new System.Drawing.Point(16, 61);
            this.dgvDSDKD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSDKD.Name = "dgvDSDKD";
            this.dgvDSDKD.RowHeadersWidth = 51;
            this.dgvDSDKD.RowTemplate.Height = 24;
            this.dgvDSDKD.Size = new System.Drawing.Size(1277, 453);
            this.dgvDSDKD.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "DANH SÁCH LỚP ĐÃ ĐĂNG KÝ DẠY";
            // 
            // UC_QuanLyDanhSachDangKyDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvDSDKD);
            this.Controls.Add(this.label1);
            this.Name = "UC_QuanLyDanhSachDangKyDay";
            this.Size = new System.Drawing.Size(1309, 533);
            this.Load += new System.EventHandler(this.UC_QuanLyDanhSachDangKyDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDKD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSDKD;
        private System.Windows.Forms.Label label1;
    }
}
