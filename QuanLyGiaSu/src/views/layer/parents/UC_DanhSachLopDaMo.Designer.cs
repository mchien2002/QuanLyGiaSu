namespace QuanLyGiaSu.src.app.views.layer
{
    partial class UC_DanhSachLopDaMo
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
            this.cbb_TimKiem = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDANHSACHMOLOP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDANHSACHMOLOP)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Tim
            // 
            this.btn_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.Location = new System.Drawing.Point(1156, 18);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(75, 33);
            this.btn_Tim.TabIndex = 22;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            // 
            // cbb_TimKiem
            // 
            this.cbb_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TimKiem.FormattingEnabled = true;
            this.cbb_TimKiem.Location = new System.Drawing.Point(869, 18);
            this.cbb_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_TimKiem.Name = "cbb_TimKiem";
            this.cbb_TimKiem.Size = new System.Drawing.Size(256, 33);
            this.cbb_TimKiem.TabIndex = 21;
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
            this.comboBox1.Location = new System.Drawing.Point(672, 18);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 33);
            this.comboBox1.TabIndex = 20;
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimKiem.Location = new System.Drawing.Point(869, 19);
            this.tb_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(256, 30);
            this.tb_TimKiem.TabIndex = 19;
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
            // dgvDANHSACHMOLOP
            // 
            this.dgvDANHSACHMOLOP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDANHSACHMOLOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDANHSACHMOLOP.Location = new System.Drawing.Point(16, 61);
            this.dgvDANHSACHMOLOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDANHSACHMOLOP.Name = "dgvDANHSACHMOLOP";
            this.dgvDANHSACHMOLOP.RowHeadersWidth = 51;
            this.dgvDANHSACHMOLOP.RowTemplate.Height = 24;
            this.dgvDANHSACHMOLOP.Size = new System.Drawing.Size(1277, 453);
            this.dgvDANHSACHMOLOP.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "DANH SÁCH LỚP ĐÃ MỞ";
            // 
            // UC_DanhSachMoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.cbb_TimKiem);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tb_TimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDANHSACHMOLOP);
            this.Controls.Add(this.label1);
            this.Name = "UC_DanhSachMoLop";
            this.Size = new System.Drawing.Size(1309, 533);
            this.Load += new System.EventHandler(this.UC_DanhSachMoLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDANHSACHMOLOP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.ComboBox cbb_TimKiem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDANHSACHMOLOP;
        private System.Windows.Forms.Label label1;
    }
}
