namespace QuanLyGiaSu.src.app.views.layer
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
            this.btn_Tim = new System.Windows.Forms.Button();
            this.cbb_TimKiem = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SuaThongTinGiaSu,
            this.XoaGiaSu,
            this.ThemGiaSu});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(221, 76);
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
            // btn_Tim
            // 
            this.btn_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.Location = new System.Drawing.Point(1145, 20);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(75, 33);
            this.btn_Tim.TabIndex = 15;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            // 
            // cbb_TimKiem
            // 
            this.cbb_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TimKiem.FormattingEnabled = true;
            this.cbb_TimKiem.Location = new System.Drawing.Point(883, 20);
            this.cbb_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_TimKiem.Name = "cbb_TimKiem";
            this.cbb_TimKiem.Size = new System.Drawing.Size(256, 33);
            this.cbb_TimKiem.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã Gia Sư",
            "Tên Gia Sư",
            "Account ID",
            "Môn Dạy",
            "Lớp Dạy"});
            this.comboBox1.Location = new System.Drawing.Point(672, 17);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 33);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimKiem.Location = new System.Drawing.Point(883, 20);
            this.tb_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(256, 30);
            this.tb_TimKiem.TabIndex = 12;
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
            // UC_QuanLyGiaSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.cbb_TimKiem);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tb_TimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvQuanLyGiaSu);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.ComboBox cbb_TimKiem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.Label label2;
    }
}
