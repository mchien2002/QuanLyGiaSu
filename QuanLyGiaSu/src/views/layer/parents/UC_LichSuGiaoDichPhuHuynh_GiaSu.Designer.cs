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
            this.components = new System.ComponentModel.Container();
            this.btn_LichSuNap = new System.Windows.Forms.Button();
            this.dgvLICHSUGIAODICH = new System.Windows.Forms.DataGridView();
            this.lbText = new System.Windows.Forms.Label();
            this.dgvLICHSUNAPTIEN = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLICHSUGIAODICH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLICHSUNAPTIEN)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_LichSuNap
            // 
            this.btn_LichSuNap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LichSuNap.Location = new System.Drawing.Point(897, 26);
            this.btn_LichSuNap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LichSuNap.Name = "btn_LichSuNap";
            this.btn_LichSuNap.Size = new System.Drawing.Size(295, 33);
            this.btn_LichSuNap.TabIndex = 29;
            this.btn_LichSuNap.Text = "Xem Lịch Sử Nạp Tiền";
            this.btn_LichSuNap.UseVisualStyleBackColor = true;
            this.btn_LichSuNap.Click += new System.EventHandler(this.btn_LichSuNap_Click);
            // 
            // dgvLICHSUGIAODICH
            // 
            this.dgvLICHSUGIAODICH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLICHSUGIAODICH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLICHSUGIAODICH.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLICHSUGIAODICH.Location = new System.Drawing.Point(16, 62);
            this.dgvLICHSUGIAODICH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLICHSUGIAODICH.Name = "dgvLICHSUGIAODICH";
            this.dgvLICHSUGIAODICH.RowHeadersWidth = 51;
            this.dgvLICHSUGIAODICH.RowTemplate.Height = 24;
            this.dgvLICHSUGIAODICH.Size = new System.Drawing.Size(1277, 453);
            this.dgvLICHSUGIAODICH.TabIndex = 24;
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.Location = new System.Drawing.Point(28, 18);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(326, 38);
            this.lbText.TabIndex = 23;
            this.lbText.Text = "LỊCH SỬ GIAO DỊCH";
            // 
            // dgvLICHSUNAPTIEN
            // 
            this.dgvLICHSUNAPTIEN.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLICHSUNAPTIEN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLICHSUNAPTIEN.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLICHSUNAPTIEN.Location = new System.Drawing.Point(16, 62);
            this.dgvLICHSUNAPTIEN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLICHSUNAPTIEN.Name = "dgvLICHSUNAPTIEN";
            this.dgvLICHSUNAPTIEN.RowHeadersWidth = 51;
            this.dgvLICHSUNAPTIEN.RowTemplate.Height = 24;
            this.dgvLICHSUNAPTIEN.Size = new System.Drawing.Size(1277, 453);
            this.dgvLICHSUNAPTIEN.TabIndex = 30;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // UC_LichSuGiaoDichPhuHuynh_GiaSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.dgvLICHSUNAPTIEN);
            this.Controls.Add(this.btn_LichSuNap);
            this.Controls.Add(this.dgvLICHSUGIAODICH);
            this.Controls.Add(this.lbText);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_LichSuGiaoDichPhuHuynh_GiaSu";
            this.Size = new System.Drawing.Size(1309, 533);
            this.Load += new System.EventHandler(this.UC_LichSuGiaoDichPhuHuynh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLICHSUGIAODICH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLICHSUNAPTIEN)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LichSuNap;
        private System.Windows.Forms.DataGridView dgvLICHSUGIAODICH;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.DataGridView dgvLICHSUNAPTIEN;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}
