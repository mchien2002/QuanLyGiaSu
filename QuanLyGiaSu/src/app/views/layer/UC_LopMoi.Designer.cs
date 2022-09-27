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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoBuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YeuCau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "LỚP MỚI GIA SƯ ACB";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSo,
            this.Lop,
            this.MonHoc,
            this.DiaChi,
            this.SoBuoi,
            this.ThoiGian,
            this.Luong,
            this.YeuCau});
            this.dataGridView1.Location = new System.Drawing.Point(15, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1278, 453);
            this.dataGridView1.TabIndex = 1;
            // 
            // MaSo
            // 
            this.MaSo.HeaderText = "Mã Số";
            this.MaSo.MinimumWidth = 6;
            this.MaSo.Name = "MaSo";
            this.MaSo.Width = 75;
            // 
            // Lop
            // 
            this.Lop.HeaderText = "Lớp";
            this.Lop.MinimumWidth = 6;
            this.Lop.Name = "Lop";
            this.Lop.Width = 125;
            // 
            // MonHoc
            // 
            this.MonHoc.HeaderText = "Môn Học";
            this.MonHoc.MinimumWidth = 6;
            this.MonHoc.Name = "MonHoc";
            this.MonHoc.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 350;
            // 
            // SoBuoi
            // 
            this.SoBuoi.HeaderText = "Số Buổi";
            this.SoBuoi.MinimumWidth = 6;
            this.SoBuoi.Name = "SoBuoi";
            // 
            // ThoiGian
            // 
            this.ThoiGian.HeaderText = "Thời Gian";
            this.ThoiGian.MinimumWidth = 6;
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.Width = 180;
            // 
            // Luong
            // 
            this.Luong.HeaderText = "Lương";
            this.Luong.MinimumWidth = 6;
            this.Luong.Name = "Luong";
            this.Luong.Width = 150;
            // 
            // YeuCau
            // 
            this.YeuCau.HeaderText = "Yêu Cầu";
            this.YeuCau.MinimumWidth = 6;
            this.YeuCau.Name = "YeuCau";
            this.YeuCau.Width = 125;
            // 
            // UC_LopMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "UC_LopMoi";
            this.Size = new System.Drawing.Size(1310, 533);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoBuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn YeuCau;
    }
}
