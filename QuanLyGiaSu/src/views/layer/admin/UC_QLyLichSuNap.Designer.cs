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
            this.btn_TimLSNT = new System.Windows.Forms.Button();
            this.tb_TimKiemLSNT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvQLyLichSuNap = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_TimTheoLSNT = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLyLichSuNap)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_TimLSNT
            // 
            this.btn_TimLSNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimLSNT.Location = new System.Drawing.Point(1145, 21);
            this.btn_TimLSNT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimLSNT.Name = "btn_TimLSNT";
            this.btn_TimLSNT.Size = new System.Drawing.Size(75, 33);
            this.btn_TimLSNT.TabIndex = 22;
            this.btn_TimLSNT.Text = "Tìm";
            this.btn_TimLSNT.UseVisualStyleBackColor = true;
            this.btn_TimLSNT.Click += new System.EventHandler(this.btn_TimLSNT_Click);
            // 
            // tb_TimKiemLSNT
            // 
            this.tb_TimKiemLSNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimKiemLSNT.Location = new System.Drawing.Point(883, 21);
            this.tb_TimKiemLSNT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TimKiemLSNT.Name = "tb_TimKiemLSNT";
            this.tb_TimKiemLSNT.Size = new System.Drawing.Size(256, 30);
            this.tb_TimKiemLSNT.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(559, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tìm Theo :";
            // 
            // dgvQLyLichSuNap
            // 
            this.dgvQLyLichSuNap.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvQLyLichSuNap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLyLichSuNap.Location = new System.Drawing.Point(16, 62);
            this.dgvQLyLichSuNap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvQLyLichSuNap.Name = "dgvQLyLichSuNap";
            this.dgvQLyLichSuNap.RowHeadersWidth = 51;
            this.dgvQLyLichSuNap.RowTemplate.Height = 24;
            this.dgvQLyLichSuNap.Size = new System.Drawing.Size(1277, 453);
            this.dgvQLyLichSuNap.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "QUẢN LÝ LỊCH SỬ NẠP";
            // 
            // cbb_TimTheoLSNT
            // 
            this.cbb_TimTheoLSNT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TimTheoLSNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TimTheoLSNT.FormattingEnabled = true;
            this.cbb_TimTheoLSNT.Items.AddRange(new object[] {
            "Giao Dịch ID",
            "Account ID",
            "Tất Cả"});
            this.cbb_TimTheoLSNT.Location = new System.Drawing.Point(672, 18);
            this.cbb_TimTheoLSNT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_TimTheoLSNT.Name = "cbb_TimTheoLSNT";
            this.cbb_TimTheoLSNT.Size = new System.Drawing.Size(192, 33);
            this.cbb_TimTheoLSNT.TabIndex = 20;
            this.cbb_TimTheoLSNT.SelectedIndexChanged += new System.EventHandler(this.cbb_TimTheoLSNT_SelectedIndexChanged);
            // 
            // UC_QLyLichSuNap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btn_TimLSNT);
            this.Controls.Add(this.cbb_TimTheoLSNT);
            this.Controls.Add(this.tb_TimKiemLSNT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvQLyLichSuNap);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_QLyLichSuNap";
            this.Size = new System.Drawing.Size(1309, 533);
            this.Load += new System.EventHandler(this.UC_QLyLichSuNap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLyLichSuNap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TimLSNT;
        private System.Windows.Forms.TextBox tb_TimKiemLSNT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvQLyLichSuNap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_TimTheoLSNT;
    }
}
