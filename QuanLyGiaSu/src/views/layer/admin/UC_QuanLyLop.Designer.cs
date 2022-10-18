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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.cbb_TimKiem = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyLopMoi)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQuanLyLopMoi
            // 
            this.dgvQuanLyLopMoi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvQuanLyLopMoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyLopMoi.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvQuanLyLopMoi.Location = new System.Drawing.Point(12, 49);
            this.dgvQuanLyLopMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvQuanLyLopMoi.Name = "dgvQuanLyLopMoi";
            this.dgvQuanLyLopMoi.RowHeadersWidth = 51;
            this.dgvQuanLyLopMoi.RowTemplate.Height = 24;
            this.dgvQuanLyLopMoi.Size = new System.Drawing.Size(958, 368);
            this.dgvQuanLyLopMoi.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SuaThongTinLop,
            this.XoaLop});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // SuaThongTinLop
            // 
            this.SuaThongTinLop.Name = "SuaThongTinLop";
            this.SuaThongTinLop.Size = new System.Drawing.Size(180, 22);
            this.SuaThongTinLop.Text = "Sửa Thông Tin Lớp";
            this.SuaThongTinLop.Click += new System.EventHandler(this.SuaThongTinLop_Click);
            // 
            // XoaLop
            // 
            this.XoaLop.Name = "XoaLop";
            this.XoaLop.Size = new System.Drawing.Size(180, 22);
            this.XoaLop.Text = "Xóa Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ LỚP MỚI";
            // 
            // btn_Tim
            // 
            this.btn_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.Location = new System.Drawing.Point(867, 14);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(56, 27);
            this.btn_Tim.TabIndex = 15;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            // 
            // cbb_TimKiem
            // 
            this.cbb_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TimKiem.FormattingEnabled = true;
            this.cbb_TimKiem.Location = new System.Drawing.Point(652, 14);
            this.cbb_TimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_TimKiem.Name = "cbb_TimKiem";
            this.cbb_TimKiem.Size = new System.Drawing.Size(193, 28);
            this.cbb_TimKiem.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã Lớp",
            "Môn Học",
            "Lớp Học"});
            this.comboBox1.Location = new System.Drawing.Point(504, 14);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 28);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimKiem.Location = new System.Drawing.Point(652, 15);
            this.tb_TimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(193, 26);
            this.tb_TimKiem.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tìm Theo :";
            // 
            // UC_QuanLyLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.cbb_TimKiem);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tb_TimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvQuanLyLopMoi);
            this.Controls.Add(this.label1);
            this.Name = "UC_QuanLyLop";
            this.Size = new System.Drawing.Size(982, 433);
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
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.ComboBox cbb_TimKiem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvQuanLyLopMoi;
    }
}
