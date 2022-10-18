namespace QuanLyGiaSu.src.views.layer.admin
{
    partial class UC_QLyLichSuNap
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
            this.btn_Tim = new System.Windows.Forms.Button();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvQLyLichSuNap = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLyLichSuNap)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Tim
            // 
            this.btn_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.Location = new System.Drawing.Point(859, 17);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(56, 27);
            this.btn_Tim.TabIndex = 22;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimKiem.Location = new System.Drawing.Point(662, 17);
            this.tb_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(193, 26);
            this.tb_TimKiem.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tìm Theo :";
            // 
            // dgvQLyLichSuNap
            // 
            this.dgvQLyLichSuNap.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvQLyLichSuNap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLyLichSuNap.Location = new System.Drawing.Point(12, 50);
            this.dgvQLyLichSuNap.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQLyLichSuNap.Name = "dgvQLyLichSuNap";
            this.dgvQLyLichSuNap.RowHeadersWidth = 51;
            this.dgvQLyLichSuNap.RowTemplate.Height = 24;
            this.dgvQLyLichSuNap.Size = new System.Drawing.Size(958, 368);
            this.dgvQLyLichSuNap.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "QUẢN LÝ LỊCH SỬ NẠP";
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "ID Giao Dịch",
            "ID Account"});
            this.cbbTimKiem.Location = new System.Drawing.Point(504, 15);
            this.cbbTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(145, 28);
            this.cbbTimKiem.TabIndex = 20;
            // 
            // UC_QLyLichSuNap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.cbbTimKiem);
            this.Controls.Add(this.tb_TimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvQLyLichSuNap);
            this.Controls.Add(this.label1);
            this.Name = "UC_QLyLichSuNap";
            this.Size = new System.Drawing.Size(982, 433);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLyLichSuNap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvQLyLichSuNap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTimKiem;
    }
}
