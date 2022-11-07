namespace QuanLyGiaSu.src.app.views.layer
{
    partial class UC_QuanLyLop
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
            this.dgvQuanLyLopMoi = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuaThongTinLop = new System.Windows.Forms.ToolStripMenuItem();
            this.XoaLop = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TimLM = new System.Windows.Forms.Button();
            this.cbb_TimTheoLM = new System.Windows.Forms.ComboBox();
            this.tb_TimKiemLM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyLopMoi)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQuanLyLopMoi
            // 
            this.dgvQuanLyLopMoi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvQuanLyLopMoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyLopMoi.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvQuanLyLopMoi.Location = new System.Drawing.Point(16, 60);
            this.dgvQuanLyLopMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvQuanLyLopMoi.Name = "dgvQuanLyLopMoi";
            this.dgvQuanLyLopMoi.RowHeadersWidth = 51;
            this.dgvQuanLyLopMoi.RowTemplate.Height = 24;
            this.dgvQuanLyLopMoi.Size = new System.Drawing.Size(1277, 453);
            this.dgvQuanLyLopMoi.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SuaThongTinLop,
            this.XoaLop,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(203, 76);
            // 
            // SuaThongTinLop
            // 
            this.SuaThongTinLop.Name = "SuaThongTinLop";
            this.SuaThongTinLop.Size = new System.Drawing.Size(202, 24);
            this.SuaThongTinLop.Text = "Sửa Thông Tin Lớp";
            this.SuaThongTinLop.Click += new System.EventHandler(this.SuaThongTinLop_Click);
            // 
            // XoaLop
            // 
            this.XoaLop.Name = "XoaLop";
            this.XoaLop.Size = new System.Drawing.Size(202, 24);
            this.XoaLop.Text = "Xóa Lớp";
            this.XoaLop.Click += new System.EventHandler(this.XoaLop_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ LỚP MỚI";
            // 
            // btn_TimLM
            // 
            this.btn_TimLM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimLM.Location = new System.Drawing.Point(1156, 17);
            this.btn_TimLM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimLM.Name = "btn_TimLM";
            this.btn_TimLM.Size = new System.Drawing.Size(75, 33);
            this.btn_TimLM.TabIndex = 15;
            this.btn_TimLM.Text = "Tìm";
            this.btn_TimLM.UseVisualStyleBackColor = true;
            this.btn_TimLM.Click += new System.EventHandler(this.btn_TimLM_Click);
            // 
            // cbb_TimTheoLM
            // 
            this.cbb_TimTheoLM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TimTheoLM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TimTheoLM.FormattingEnabled = true;
            this.cbb_TimTheoLM.Items.AddRange(new object[] {
            "Mã Lớp",
            "Môn Học",
            "Lớp Học",
            "Tất Cả"});
            this.cbb_TimTheoLM.Location = new System.Drawing.Point(672, 17);
            this.cbb_TimTheoLM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_TimTheoLM.Name = "cbb_TimTheoLM";
            this.cbb_TimTheoLM.Size = new System.Drawing.Size(192, 33);
            this.cbb_TimTheoLM.TabIndex = 13;
            this.cbb_TimTheoLM.SelectedIndexChanged += new System.EventHandler(this.cbb_TimTheoLM_SelectedIndexChanged);
            // 
            // tb_TimKiemLM
            // 
            this.tb_TimKiemLM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimKiemLM.Location = new System.Drawing.Point(869, 18);
            this.tb_TimKiemLM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TimKiemLM.Name = "tb_TimKiemLM";
            this.tb_TimKiemLM.Size = new System.Drawing.Size(256, 30);
            this.tb_TimKiemLM.TabIndex = 12;
            this.tb_TimKiemLM.Text = " ";
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
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_QuanLyLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btn_TimLM);
            this.Controls.Add(this.cbb_TimTheoLM);
            this.Controls.Add(this.tb_TimKiemLM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvQuanLyLopMoi);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_QuanLyLop";
            this.Size = new System.Drawing.Size(1309, 533);
            this.Load += new System.EventHandler(this.UC_QuanLyLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyLopMoi)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SuaThongTinLop;
        private System.Windows.Forms.ToolStripMenuItem XoaLop;
        private System.Windows.Forms.Button btn_TimLM;
        private System.Windows.Forms.ComboBox cbb_TimTheoLM;
        private System.Windows.Forms.TextBox tb_TimKiemLM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvQuanLyLopMoi;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}
