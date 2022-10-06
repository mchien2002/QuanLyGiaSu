namespace QuanLyGiaSu.src.app.views.layer
{
    partial class UC_LopMoi
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
            this.dgvTHONGTINLOPMOI = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DangKyDay = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.cbbSearchType = new System.Windows.Forms.ComboBox();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHONGTINLOPMOI)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTHONGTINLOPMOI
            // 
            this.dgvTHONGTINLOPMOI.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTHONGTINLOPMOI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTHONGTINLOPMOI.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTHONGTINLOPMOI.Location = new System.Drawing.Point(12, 49);
            this.dgvTHONGTINLOPMOI.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTHONGTINLOPMOI.Name = "dgvTHONGTINLOPMOI";
            this.dgvTHONGTINLOPMOI.RowHeadersWidth = 51;
            this.dgvTHONGTINLOPMOI.RowTemplate.Height = 24;
            this.dgvTHONGTINLOPMOI.Size = new System.Drawing.Size(958, 368);
            this.dgvTHONGTINLOPMOI.TabIndex = 5;
            this.dgvTHONGTINLOPMOI.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DangKyDay});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 26);
            // 
            // DangKyDay
            // 
            this.DangKyDay.Name = "DangKyDay";
            this.DangKyDay.Size = new System.Drawing.Size(161, 22);
            this.DangKyDay.Text = "Đăng ký dạy";
            this.DangKyDay.Click += new System.EventHandler(this.DangKyDay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "LỚP MỚI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tìm Theo :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimKiem.Location = new System.Drawing.Point(617, 19);
            this.tb_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(193, 26);
            this.tb_TimKiem.TabIndex = 7;
            // 
            // cbbSearchType
            // 
            this.cbbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSearchType.FormattingEnabled = true;
            this.cbbSearchType.Items.AddRange(new object[] {
            "Mã Lớp",
            "Môn Học",
            "Lớp Học"});
            this.cbbSearchType.Location = new System.Drawing.Point(469, 18);
            this.cbbSearchType.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSearchType.Name = "cbbSearchType";
            this.cbbSearchType.Size = new System.Drawing.Size(145, 28);
            this.cbbSearchType.TabIndex = 8;
            this.cbbSearchType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbbSearch
            // 
            this.cbbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Location = new System.Drawing.Point(617, 19);
            this.cbbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Size = new System.Drawing.Size(193, 28);
            this.cbbSearch.TabIndex = 9;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(832, 18);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(56, 27);
            this.btnTim.TabIndex = 10;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // UC_LopMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.cbbSearch);
            this.Controls.Add(this.cbbSearchType);
            this.Controls.Add(this.tb_TimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTHONGTINLOPMOI);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_LopMoi";
            this.Size = new System.Drawing.Size(982, 433);
            this.Load += new System.EventHandler(this.UC_LopMoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHONGTINLOPMOI)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTHONGTINLOPMOI;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DangKyDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.ComboBox cbbSearchType;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.Button btnTim;
    }
}
