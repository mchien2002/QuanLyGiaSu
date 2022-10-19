namespace QuanLyGiaSu.src.app.views.layer
{
    partial class UC_LichSuGiaoDichPhuHuynh_GiaSu
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
            this.btn_LichSuNap = new System.Windows.Forms.Button();
            this.dgvLICHSUGIAODICH = new System.Windows.Forms.DataGridView();
            this.lbText = new System.Windows.Forms.Label();
            this.dgvLICHSUNAPTIEN = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLICHSUGIAODICH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLICHSUNAPTIEN)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_LichSuNap
            // 
            this.btn_LichSuNap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LichSuNap.Location = new System.Drawing.Point(673, 21);
            this.btn_LichSuNap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_LichSuNap.Name = "btn_LichSuNap";
            this.btn_LichSuNap.Size = new System.Drawing.Size(221, 27);
            this.btn_LichSuNap.TabIndex = 29;
            this.btn_LichSuNap.Text = "Xem Lịch Sử Nạp Tiền";
            this.btn_LichSuNap.UseVisualStyleBackColor = true;
            this.btn_LichSuNap.Click += new System.EventHandler(this.btn_LichSuNap_Click);
            // 
            // dgvLICHSUGIAODICH
            // 
            this.dgvLICHSUGIAODICH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLICHSUGIAODICH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLICHSUGIAODICH.Location = new System.Drawing.Point(12, 50);
            this.dgvLICHSUGIAODICH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLICHSUGIAODICH.Name = "dgvLICHSUGIAODICH";
            this.dgvLICHSUGIAODICH.RowHeadersWidth = 51;
            this.dgvLICHSUGIAODICH.RowTemplate.Height = 24;
            this.dgvLICHSUGIAODICH.Size = new System.Drawing.Size(958, 368);
            this.dgvLICHSUGIAODICH.TabIndex = 24;
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.Location = new System.Drawing.Point(21, 15);
            this.lbText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(272, 31);
            this.lbText.TabIndex = 23;
            this.lbText.Text = "LỊCH SỬ GIAO DỊCH";
            // 
            // dgvLICHSUNAPTIEN
            // 
            this.dgvLICHSUNAPTIEN.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLICHSUNAPTIEN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLICHSUNAPTIEN.Location = new System.Drawing.Point(12, 50);
            this.dgvLICHSUNAPTIEN.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLICHSUNAPTIEN.Name = "dgvLICHSUNAPTIEN";
            this.dgvLICHSUNAPTIEN.RowHeadersWidth = 51;
            this.dgvLICHSUNAPTIEN.RowTemplate.Height = 24;
            this.dgvLICHSUNAPTIEN.Size = new System.Drawing.Size(958, 368);
            this.dgvLICHSUNAPTIEN.TabIndex = 30;
            // 
            // UC_LichSuGiaoDichPhuHuynh_GiaSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.dgvLICHSUNAPTIEN);
            this.Controls.Add(this.btn_LichSuNap);
            this.Controls.Add(this.dgvLICHSUGIAODICH);
            this.Controls.Add(this.lbText);
            this.Name = "UC_LichSuGiaoDichPhuHuynh_GiaSu";
            this.Size = new System.Drawing.Size(982, 433);
            this.Load += new System.EventHandler(this.UC_LichSuGiaoDichPhuHuynh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLICHSUGIAODICH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLICHSUNAPTIEN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LichSuNap;
        private System.Windows.Forms.DataGridView dgvLICHSUGIAODICH;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.DataGridView dgvLICHSUNAPTIEN;
    }
}
