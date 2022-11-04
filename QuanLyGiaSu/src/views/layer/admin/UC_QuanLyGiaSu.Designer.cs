﻿namespace QuanLyGiaSu.src.app.views.layer
{
    partial class UC_QuanLyGiaSu
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
            this.dgvQuanLyGiaSu = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuaThongTinGiaSu = new System.Windows.Forms.ToolStripMenuItem();
            this.XoaGiaSu = new System.Windows.Forms.ToolStripMenuItem();
            this.ThemGiaSu = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TimGS = new System.Windows.Forms.Button();
            this.cbb_TimTheoGS = new System.Windows.Forms.ComboBox();
            this.tb_TimKiemGS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyGiaSu)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQuanLyGiaSu
            // 
            this.dgvQuanLyGiaSu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvQuanLyGiaSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyGiaSu.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvQuanLyGiaSu.Location = new System.Drawing.Point(16, 60);
            this.dgvQuanLyGiaSu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvQuanLyGiaSu.Name = "dgvQuanLyGiaSu";
            this.dgvQuanLyGiaSu.RowHeadersWidth = 51;
            this.dgvQuanLyGiaSu.RowTemplate.Height = 24;
            this.dgvQuanLyGiaSu.Size = new System.Drawing.Size(1277, 453);
            this.dgvQuanLyGiaSu.TabIndex = 3;
            this.dgvQuanLyGiaSu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyGiaSu_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SuaThongTinGiaSu,
            this.XoaGiaSu,
            this.ThemGiaSu,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(221, 128);
            // 
            // SuaThongTinGiaSu
            // 
            this.SuaThongTinGiaSu.Name = "SuaThongTinGiaSu";
            this.SuaThongTinGiaSu.Size = new System.Drawing.Size(220, 24);
            this.SuaThongTinGiaSu.Text = "Sửa Thông Tin Gia Sư";
            this.SuaThongTinGiaSu.Click += new System.EventHandler(this.SuaThongTinGiaSu_Click);
            // 
            // XoaGiaSu
            // 
            this.XoaGiaSu.Name = "XoaGiaSu";
            this.XoaGiaSu.Size = new System.Drawing.Size(220, 24);
            this.XoaGiaSu.Text = "Xóa Gia Sư";
            this.XoaGiaSu.Click += new System.EventHandler(this.XoaGiaSu_Click);
            // 
            // ThemGiaSu
            // 
            this.ThemGiaSu.Name = "ThemGiaSu";
            this.ThemGiaSu.Size = new System.Drawing.Size(220, 24);
            this.ThemGiaSu.Text = "Thêm Gia Sư";
            this.ThemGiaSu.Click += new System.EventHandler(this.ThemGiaSu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ GIA SƯ";
            // 
            // btn_TimGS
            // 
            this.btn_TimGS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimGS.Location = new System.Drawing.Point(1145, 20);
            this.btn_TimGS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimGS.Name = "btn_TimGS";
            this.btn_TimGS.Size = new System.Drawing.Size(75, 33);
            this.btn_TimGS.TabIndex = 15;
            this.btn_TimGS.Text = "Tìm";
            this.btn_TimGS.UseVisualStyleBackColor = true;
            this.btn_TimGS.Click += new System.EventHandler(this.btn_TimGS_Click);
            // 
            // cbb_TimTheoGS
            // 
            this.cbb_TimTheoGS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TimTheoGS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TimTheoGS.FormattingEnabled = true;
            this.cbb_TimTheoGS.Items.AddRange(new object[] {
            "Mã Gia Sư",
            "Tên Gia Sư",
            "Account ID",
            "Tất Cả"});
            this.cbb_TimTheoGS.Location = new System.Drawing.Point(672, 17);
            this.cbb_TimTheoGS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_TimTheoGS.Name = "cbb_TimTheoGS";
            this.cbb_TimTheoGS.Size = new System.Drawing.Size(192, 33);
            this.cbb_TimTheoGS.TabIndex = 13;
            this.cbb_TimTheoGS.SelectedIndexChanged += new System.EventHandler(this.cbbTimTheoGS_SelectedIndexChanged);
            // 
            // tb_TimKiemGS
            // 
            this.tb_TimKiemGS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimKiemGS.Location = new System.Drawing.Point(883, 20);
            this.tb_TimKiemGS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TimKiemGS.Name = "tb_TimKiemGS";
            this.tb_TimKiemGS.Size = new System.Drawing.Size(256, 30);
            this.tb_TimKiemGS.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(559, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tìm Theo :";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // UC_QuanLyGiaSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btn_TimGS);
            this.Controls.Add(this.cbb_TimTheoGS);
            this.Controls.Add(this.tb_TimKiemGS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvQuanLyGiaSu);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_QuanLyGiaSu";
            this.Size = new System.Drawing.Size(1309, 533);
            this.Load += new System.EventHandler(this.UC_QuanLyGiaSu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyGiaSu)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuanLyGiaSu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SuaThongTinGiaSu;
        private System.Windows.Forms.ToolStripMenuItem XoaGiaSu;
        private System.Windows.Forms.ToolStripMenuItem ThemGiaSu;
        private System.Windows.Forms.Button btn_TimGS;
        private System.Windows.Forms.ComboBox cbb_TimTheoGS;
        private System.Windows.Forms.TextBox tb_TimKiemGS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}
