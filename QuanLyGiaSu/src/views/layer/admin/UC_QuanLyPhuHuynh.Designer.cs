namespace QuanLyGiaSu.src.app.views.layer
{
    partial class UC_QuanLyPhuHuynh
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
            this.dgvQuanLyPhuHuynh = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuaThongTinPhuHuynh = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaPhụHuynhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThemPhuHuynh = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyPhuHuynh)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQuanLyPhuHuynh
            // 
            this.dgvQuanLyPhuHuynh.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvQuanLyPhuHuynh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyPhuHuynh.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvQuanLyPhuHuynh.Location = new System.Drawing.Point(12, 49);
            this.dgvQuanLyPhuHuynh.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQuanLyPhuHuynh.Name = "dgvQuanLyPhuHuynh";
            this.dgvQuanLyPhuHuynh.RowHeadersWidth = 51;
            this.dgvQuanLyPhuHuynh.RowTemplate.Height = 24;
            this.dgvQuanLyPhuHuynh.Size = new System.Drawing.Size(958, 368);
            this.dgvQuanLyPhuHuynh.TabIndex = 3;
            this.dgvQuanLyPhuHuynh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyPhuHuynh_CellClick);
            this.dgvQuanLyPhuHuynh.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvQuanLyPhuHuynh_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SuaThongTinPhuHuynh,
            this.xóaPhụHuynhToolStripMenuItem,
            this.ThemPhuHuynh});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(213, 70);
            // 
            // SuaThongTinPhuHuynh
            // 
            this.SuaThongTinPhuHuynh.Name = "SuaThongTinPhuHuynh";
            this.SuaThongTinPhuHuynh.Size = new System.Drawing.Size(212, 22);
            this.SuaThongTinPhuHuynh.Text = "Sửa Thông Tin Phụ Huynh";
            this.SuaThongTinPhuHuynh.Click += new System.EventHandler(this.SuaThongTinPhuHuynh_Click);
            // 
            // xóaPhụHuynhToolStripMenuItem
            // 
            this.xóaPhụHuynhToolStripMenuItem.Name = "xóaPhụHuynhToolStripMenuItem";
            this.xóaPhụHuynhToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.xóaPhụHuynhToolStripMenuItem.Text = "Xóa Phụ Huynh";
            // 
            // ThemPhuHuynh
            // 
            this.ThemPhuHuynh.Name = "ThemPhuHuynh";
            this.ThemPhuHuynh.Size = new System.Drawing.Size(212, 22);
            this.ThemPhuHuynh.Text = "Thêm Phụ Huynh";
            this.ThemPhuHuynh.Click += new System.EventHandler(this.ThemPhuHuynh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ PHỤ HUYNH";
            // 
            // btn_Tim
            // 
            this.btn_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.Location = new System.Drawing.Point(856, 15);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(56, 27);
            this.btn_Tim.TabIndex = 20;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã Phụ Huynh",
            "Tên Phụ Huynh",
            "Account ID"});
            this.comboBox1.Location = new System.Drawing.Point(493, 15);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 28);
            this.comboBox1.TabIndex = 18;
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimKiem.Location = new System.Drawing.Point(641, 15);
            this.tb_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(193, 26);
            this.tb_TimKiem.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tìm Theo :";
            // 
            // UC_QuanLyPhuHuynh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tb_TimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvQuanLyPhuHuynh);
            this.Controls.Add(this.label1);
            this.Name = "UC_QuanLyPhuHuynh";
            this.Size = new System.Drawing.Size(982, 433);
            this.Load += new System.EventHandler(this.UC_QuanLyPhuHuynh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyPhuHuynh)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuanLyPhuHuynh;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SuaThongTinPhuHuynh;
        private System.Windows.Forms.ToolStripMenuItem xóaPhụHuynhToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem ThemPhuHuynh;
    }
}
