namespace DoAnCuoiKy_Nhom13
{
    partial class UC_LichSuGiaoDich
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
            this.btn_TimLSGD = new System.Windows.Forms.Button();
            this.cbb_TimTheoLSGD = new System.Windows.Forms.ComboBox();
            this.tb_TimKiemLSGD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLICHSUGIAODICH = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.lbTo = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.tbMonHoc = new System.Windows.Forms.TextBox();
            this.tbPhanQuyen = new System.Windows.Forms.TextBox();
            this.tbHinhThuc = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbSoBuoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSDTph = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLICHSUGIAODICH)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_TimLSGD
            // 
            this.btn_TimLSGD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimLSGD.Location = new System.Drawing.Point(906, 19);
            this.btn_TimLSGD.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TimLSGD.Name = "btn_TimLSGD";
            this.btn_TimLSGD.Size = new System.Drawing.Size(56, 27);
            this.btn_TimLSGD.TabIndex = 22;
            this.btn_TimLSGD.Text = " Tìm";
            this.btn_TimLSGD.UseVisualStyleBackColor = true;
            this.btn_TimLSGD.Click += new System.EventHandler(this.btn_TimLSGD_Click);
            // 
            // cbb_TimTheoLSGD
            // 
            this.cbb_TimTheoLSGD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TimTheoLSGD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TimTheoLSGD.FormattingEnabled = true;
            this.cbb_TimTheoLSGD.Items.AddRange(new object[] {
            "Giao dịch ID",
            "Số Tiền",
            "Thời Gian GD",
            "Tất Cả"});
            this.cbb_TimTheoLSGD.Location = new System.Drawing.Point(495, 20);
            this.cbb_TimTheoLSGD.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_TimTheoLSGD.Name = "cbb_TimTheoLSGD";
            this.cbb_TimTheoLSGD.Size = new System.Drawing.Size(145, 28);
            this.cbb_TimTheoLSGD.TabIndex = 20;
            this.cbb_TimTheoLSGD.SelectedIndexChanged += new System.EventHandler(this.cbb_TimTheoLSGD_SelectedIndexChanged);
            // 
            // tb_TimKiemLSGD
            // 
            this.tb_TimKiemLSGD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimKiemLSGD.Location = new System.Drawing.Point(644, 20);
            this.tb_TimKiemLSGD.Margin = new System.Windows.Forms.Padding(2);
            this.tb_TimKiemLSGD.Name = "tb_TimKiemLSGD";
            this.tb_TimKiemLSGD.Size = new System.Drawing.Size(193, 26);
            this.tb_TimKiemLSGD.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tìm Theo :";
            // 
            // dgvLICHSUGIAODICH
            // 
            this.dgvLICHSUGIAODICH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLICHSUGIAODICH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLICHSUGIAODICH.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLICHSUGIAODICH.Location = new System.Drawing.Point(12, 50);
            this.dgvLICHSUGIAODICH.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLICHSUGIAODICH.Name = "dgvLICHSUGIAODICH";
            this.dgvLICHSUGIAODICH.RowHeadersWidth = 51;
            this.dgvLICHSUGIAODICH.RowTemplate.Height = 24;
            this.dgvLICHSUGIAODICH.Size = new System.Drawing.Size(482, 368);
            this.dgvLICHSUGIAODICH.TabIndex = 17;
            this.dgvLICHSUGIAODICH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLICHSUGIAODICH_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 26);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "LỊCH SỬ GIAO DỊCH";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrom.Location = new System.Drawing.Point(644, 24);
            this.lbFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(52, 17);
            this.lbFrom.TabIndex = 23;
            this.lbFrom.Text = "FROM:";
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTo.Location = new System.Drawing.Point(780, 24);
            this.lbTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(36, 17);
            this.lbTo.TabIndex = 24;
            this.lbTo.Text = " TO:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(695, 23);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(77, 20);
            this.dtpFrom.TabIndex = 25;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(817, 23);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(77, 20);
            this.dtpTo.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tbMonHoc);
            this.panel1.Controls.Add(this.tbPhanQuyen);
            this.panel1.Controls.Add(this.tbHinhThuc);
            this.panel1.Controls.Add(this.tbDiaChi);
            this.panel1.Controls.Add(this.tbSoBuoi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.tbUser);
            this.panel1.Controls.Add(this.tbLop);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbSDTph);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.label45);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label43);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.label42);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label41);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Location = new System.Drawing.Point(499, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 368);
            this.panel1.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(3, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(460, 2);
            this.label11.TabIndex = 140;
            // 
            // tbMonHoc
            // 
            this.tbMonHoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMonHoc.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbMonHoc.Location = new System.Drawing.Point(140, 130);
            this.tbMonHoc.Name = "tbMonHoc";
            this.tbMonHoc.Size = new System.Drawing.Size(322, 20);
            this.tbMonHoc.TabIndex = 139;
            // 
            // tbPhanQuyen
            // 
            this.tbPhanQuyen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPhanQuyen.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbPhanQuyen.Location = new System.Drawing.Point(288, 14);
            this.tbPhanQuyen.Name = "tbPhanQuyen";
            this.tbPhanQuyen.Size = new System.Drawing.Size(161, 20);
            this.tbPhanQuyen.TabIndex = 63;
            // 
            // tbHinhThuc
            // 
            this.tbHinhThuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHinhThuc.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbHinhThuc.Location = new System.Drawing.Point(140, 330);
            this.tbHinhThuc.Name = "tbHinhThuc";
            this.tbHinhThuc.Size = new System.Drawing.Size(322, 20);
            this.tbHinhThuc.TabIndex = 138;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDiaChi.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbDiaChi.Location = new System.Drawing.Point(140, 290);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(322, 20);
            this.tbDiaChi.TabIndex = 137;
            // 
            // tbSoBuoi
            // 
            this.tbSoBuoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSoBuoi.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbSoBuoi.Location = new System.Drawing.Point(140, 210);
            this.tbSoBuoi.Name = "tbSoBuoi";
            this.tbSoBuoi.Size = new System.Drawing.Size(322, 20);
            this.tbSoBuoi.TabIndex = 116;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(285, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 1);
            this.label5.TabIndex = 60;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(126, 330);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(15, 19);
            this.label33.TabIndex = 136;
            this.label33.Text = ":";
            // 
            // tbUser
            // 
            this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUser.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbUser.Location = new System.Drawing.Point(60, 14);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(168, 20);
            this.tbUser.TabIndex = 59;
            // 
            // tbLop
            // 
            this.tbLop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLop.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbLop.Location = new System.Drawing.Point(140, 170);
            this.tbLop.Name = "tbLop";
            this.tbLop.Size = new System.Drawing.Size(322, 20);
            this.tbLop.TabIndex = 117;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 19);
            this.label3.TabIndex = 58;
            this.label3.Text = ":";
            // 
            // tbSDTph
            // 
            this.tbSDTph.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSDTph.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbSDTph.Location = new System.Drawing.Point(140, 246);
            this.tbSDTph.Name = "tbSDTph";
            this.tbSDTph.Size = new System.Drawing.Size(322, 20);
            this.tbSDTph.TabIndex = 118;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 56;
            this.label4.Text = "User";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(126, 290);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(15, 19);
            this.label32.TabIndex = 135;
            this.label32.Text = ":";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(7, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 1);
            this.label6.TabIndex = 57;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(126, 250);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 19);
            this.label15.TabIndex = 134;
            this.label15.Text = ":";
            // 
            // tbEmail
            // 
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbEmail.Location = new System.Drawing.Point(92, 56);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(365, 20);
            this.tbEmail.TabIndex = 55;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(126, 210);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 19);
            this.label16.TabIndex = 133;
            this.label16.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 19);
            this.label8.TabIndex = 54;
            this.label8.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(126, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 19);
            this.label10.TabIndex = 132;
            this.label10.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 19);
            this.label12.TabIndex = 52;
            this.label12.Text = "Email";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(126, 130);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 19);
            this.label18.TabIndex = 131;
            this.label18.Text = ":";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Silver;
            this.label17.Location = new System.Drawing.Point(7, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(450, 1);
            this.label17.TabIndex = 53;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(6, 330);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(115, 19);
            this.label26.TabIndex = 129;
            this.label26.Text = "Hình Thức Dạy";
            // 
            // label45
            // 
            this.label45.BackColor = System.Drawing.Color.Silver;
            this.label45.Location = new System.Drawing.Point(7, 150);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(450, 1);
            this.label45.TabIndex = 119;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(6, 130);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(71, 19);
            this.label27.TabIndex = 128;
            this.label27.Text = "Môn Học";
            // 
            // label43
            // 
            this.label43.BackColor = System.Drawing.Color.Silver;
            this.label43.Location = new System.Drawing.Point(7, 190);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(450, 1);
            this.label43.TabIndex = 123;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(6, 290);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(60, 19);
            this.label28.TabIndex = 130;
            this.label28.Text = "Địa Chỉ";
            // 
            // label42
            // 
            this.label42.BackColor = System.Drawing.Color.Silver;
            this.label42.Location = new System.Drawing.Point(7, 310);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(450, 1);
            this.label42.TabIndex = 122;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(6, 210);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(63, 19);
            this.label29.TabIndex = 125;
            this.label29.Text = "Số Buổi";
            // 
            // label41
            // 
            this.label41.BackColor = System.Drawing.Color.Silver;
            this.label41.Location = new System.Drawing.Point(7, 350);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(450, 1);
            this.label41.TabIndex = 121;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(6, 170);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(35, 19);
            this.label30.TabIndex = 126;
            this.label30.Text = "Lớp";
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Silver;
            this.label23.Location = new System.Drawing.Point(7, 230);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(450, 1);
            this.label23.TabIndex = 124;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(6, 250);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(39, 19);
            this.label31.TabIndex = 127;
            this.label31.Text = "SĐT";
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Silver;
            this.label24.Location = new System.Drawing.Point(7, 270);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(450, 1);
            this.label24.TabIndex = 120;
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(522, 72);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.Size = new System.Drawing.Size(438, 57);
            this.dgvAccount.TabIndex = 28;
            // 
            // dgvLop
            // 
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Location = new System.Drawing.Point(522, 150);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.Size = new System.Drawing.Size(438, 57);
            this.dgvLop.TabIndex = 29;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_LichSuGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.btn_TimLSGD);
            this.Controls.Add(this.cbb_TimTheoLSGD);
            this.Controls.Add(this.tb_TimKiemLSGD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLICHSUGIAODICH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.dgvLop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_LichSuGiaoDich";
            this.Size = new System.Drawing.Size(982, 433);
            this.Load += new System.EventHandler(this.UC_LichSuGiaoDich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLICHSUGIAODICH)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TimLSGD;
        private System.Windows.Forms.ComboBox cbb_TimTheoLSGD;
        private System.Windows.Forms.TextBox tb_TimKiemLSGD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLICHSUGIAODICH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbMonHoc;
        private System.Windows.Forms.TextBox tbPhanQuyen;
        private System.Windows.Forms.TextBox tbHinhThuc;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbSoBuoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSDTph;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Timer timer1;
    }
}
