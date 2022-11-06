namespace DoAnCuoiKy_Nhom13
{
    partial class UC_LichSuGiaoDich
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
            this.btn_TimLSGD = new System.Windows.Forms.Button();
            this.cbb_TimTheoLSGD = new System.Windows.Forms.ComboBox();
            this.tb_TimKiemLSGD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLICHSUGIAODICH = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.lbTo = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLICHSUGIAODICH)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_TimLSGD
            // 
            this.btn_TimLSGD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimLSGD.Location = new System.Drawing.Point(1208, 23);
            this.btn_TimLSGD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimLSGD.Name = "btn_TimLSGD";
            this.btn_TimLSGD.Size = new System.Drawing.Size(75, 33);
            this.btn_TimLSGD.TabIndex = 22;
            this.btn_TimLSGD.Text = " Tìm";
            this.btn_TimLSGD.UseVisualStyleBackColor = true;
            this.btn_TimLSGD.Click += new System.EventHandler(this.btn_TimLSGD_Click);
            // 
            // cbb_TimTheoLSGD
            // 
            this.cbb_TimTheoLSGD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TimTheoLSGD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TimTheoLSGD.FormattingEnabled = true;
            this.cbb_TimTheoLSGD.Items.AddRange(new object[] {
            "Giao dịch ID",
            "Số Tiền",
            "Thời Gian GD",
            "Tất Cả"});
            this.cbb_TimTheoLSGD.Location = new System.Drawing.Point(660, 25);
            this.cbb_TimTheoLSGD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_TimTheoLSGD.Name = "cbb_TimTheoLSGD";
            this.cbb_TimTheoLSGD.Size = new System.Drawing.Size(192, 33);
            this.cbb_TimTheoLSGD.TabIndex = 20;
            this.cbb_TimTheoLSGD.SelectedIndexChanged += new System.EventHandler(this.cbb_TimTheoLSGD_SelectedIndexChanged);
            // 
            // tb_TimKiemLSGD
            // 
            this.tb_TimKiemLSGD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimKiemLSGD.Location = new System.Drawing.Point(859, 25);
            this.tb_TimKiemLSGD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TimKiemLSGD.Name = "tb_TimKiemLSGD";
            this.tb_TimKiemLSGD.Size = new System.Drawing.Size(256, 30);
            this.tb_TimKiemLSGD.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(547, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tìm Theo :";
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
            this.dgvLICHSUGIAODICH.TabIndex = 17;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 28);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "LỊCH SỬ GIAO DỊCH";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrom.Location = new System.Drawing.Point(858, 30);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(63, 20);
            this.lbFrom.TabIndex = 23;
            this.lbFrom.Text = "FROM:";
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTo.Location = new System.Drawing.Point(1040, 30);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(42, 20);
            this.lbTo.TabIndex = 24;
            this.lbTo.Text = " TO:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(927, 28);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(101, 22);
            this.dtpFrom.TabIndex = 25;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(1089, 28);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(101, 22);
            this.dtpTo.TabIndex = 26;
            // 
            // UC_LichSuGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.btn_TimLSGD);
            this.Controls.Add(this.cbb_TimTheoLSGD);
            this.Controls.Add(this.tb_TimKiemLSGD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLICHSUGIAODICH);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_LichSuGiaoDich";
            this.Size = new System.Drawing.Size(1309, 533);
            this.Load += new System.EventHandler(this.UC_LichSuGiaoDich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLICHSUGIAODICH)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TimLSGD;
        private System.Windows.Forms.ComboBox cbb_TimTheoLSGD;
        private System.Windows.Forms.TextBox tb_TimKiemLSGD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLICHSUGIAODICH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
    }
}
