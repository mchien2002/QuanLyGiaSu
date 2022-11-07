namespace QuanLyGiaSu.src.views.layer.admin
{
    partial class UC_QLyLopHoc
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
            this.dgvQLyLopHoc = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ThemLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.SuaLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.XoaLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvQLyMonHoc = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ThemMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.SuaMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.XoaMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLyLopHoc)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLyMonHoc)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQLyLopHoc
            // 
            this.dgvQLyLopHoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvQLyLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLyLopHoc.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvQLyLopHoc.Location = new System.Drawing.Point(211, 59);
            this.dgvQLyLopHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvQLyLopHoc.Name = "dgvQLyLopHoc";
            this.dgvQLyLopHoc.RowHeadersWidth = 51;
            this.dgvQLyLopHoc.RowTemplate.Height = 24;
            this.dgvQLyLopHoc.Size = new System.Drawing.Size(403, 453);
            this.dgvQLyLopHoc.TabIndex = 26;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemLopHoc,
            this.SuaLopHoc,
            this.XoaLopHoc});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 104);
            // 
            // ThemLopHoc
            // 
            this.ThemLopHoc.Name = "ThemLopHoc";
            this.ThemLopHoc.Size = new System.Drawing.Size(210, 24);
            this.ThemLopHoc.Text = "Thêm Lớp Học";
            this.ThemLopHoc.Click += new System.EventHandler(this.ThemLopHoc_Click);
            // 
            // SuaLopHoc
            // 
            this.SuaLopHoc.Name = "SuaLopHoc";
            this.SuaLopHoc.Size = new System.Drawing.Size(210, 24);
            this.SuaLopHoc.Text = "Sửa Lớp Học";
            this.SuaLopHoc.Click += new System.EventHandler(this.SuaLopHoc_Click);
            // 
            // XoaLopHoc
            // 
            this.XoaLopHoc.Name = "XoaLopHoc";
            this.XoaLopHoc.Size = new System.Drawing.Size(210, 24);
            this.XoaLopHoc.Text = "Xóa Lớp Học";
            this.XoaLopHoc.Click += new System.EventHandler(this.XoaLopHoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 38);
            this.label1.TabIndex = 25;
            this.label1.Text = "QUẢN LÝ LỚP HỌC VÀ MÔN HỌC";
            // 
            // dgvQLyMonHoc
            // 
            this.dgvQLyMonHoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvQLyMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLyMonHoc.ContextMenuStrip = this.contextMenuStrip2;
            this.dgvQLyMonHoc.Location = new System.Drawing.Point(680, 59);
            this.dgvQLyMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvQLyMonHoc.Name = "dgvQLyMonHoc";
            this.dgvQLyMonHoc.RowHeadersWidth = 51;
            this.dgvQLyMonHoc.RowTemplate.Height = 24;
            this.dgvQLyMonHoc.Size = new System.Drawing.Size(403, 453);
            this.dgvQLyMonHoc.TabIndex = 26;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemMonHoc,
            this.SuaMonHoc,
            this.XoaMonHoc});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(181, 76);
            // 
            // ThemMonHoc
            // 
            this.ThemMonHoc.Name = "ThemMonHoc";
            this.ThemMonHoc.Size = new System.Drawing.Size(180, 24);
            this.ThemMonHoc.Text = "Thêm Môn Học";
            this.ThemMonHoc.Click += new System.EventHandler(this.ThemMonHoc_Click);
            // 
            // SuaMonHoc
            // 
            this.SuaMonHoc.Name = "SuaMonHoc";
            this.SuaMonHoc.Size = new System.Drawing.Size(180, 24);
            this.SuaMonHoc.Text = "Sửa Môn Học";
            this.SuaMonHoc.Click += new System.EventHandler(this.SuaMonHoc_Click);
            // 
            // XoaMonHoc
            // 
            this.XoaMonHoc.Name = "XoaMonHoc";
            this.XoaMonHoc.Size = new System.Drawing.Size(180, 24);
            this.XoaMonHoc.Text = "Xóa Môn Học";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(128, 28);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // UC_QLyLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ContextMenuStrip = this.contextMenuStrip3;
            this.Controls.Add(this.dgvQLyMonHoc);
            this.Controls.Add(this.dgvQLyLopHoc);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_QLyLopHoc";
            this.Size = new System.Drawing.Size(1309, 533);
            this.Load += new System.EventHandler(this.UC_QLyLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLyLopHoc)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLyMonHoc)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQLyLopHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvQLyMonHoc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ThemLopHoc;
        private System.Windows.Forms.ToolStripMenuItem SuaLopHoc;
        private System.Windows.Forms.ToolStripMenuItem XoaLopHoc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ThemMonHoc;
        private System.Windows.Forms.ToolStripMenuItem SuaMonHoc;
        private System.Windows.Forms.ToolStripMenuItem XoaMonHoc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}
