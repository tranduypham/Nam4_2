namespace Design_Dashboard_Modern
{
    partial class Management_Account
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management_Account));
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.grAccount = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hovaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnNewAccount = new System.Windows.Forms.Button();
            this.btnDeleteAcount = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkOnlyFemale = new System.Windows.Forms.CheckBox();
            this.checkTen = new System.Windows.Forms.CheckBox();
            this.checkOnlyMale = new System.Windows.Forms.CheckBox();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnLockAccount = new System.Windows.Forms.Button();
            this.btnResetAccount = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tbChucVu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.tbSoNgayNghi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.tbTrangThai = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.tbHocHam = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.tbDaNghi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.tbTaiKhoan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.tbUpdate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.picAvatar = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grAccount)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbKhoa
            // 
            this.cbKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(17, 11);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(444, 25);
            this.cbKhoa.TabIndex = 8;
            this.cbKhoa.Text = "-Khoa -";
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // grAccount
            // 
            this.grAccount.AllowUserToAddRows = false;
            this.grAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.Hovaten,
            this.MaGV,
            this.Chucvu});
            this.grAccount.Location = new System.Drawing.Point(17, 47);
            this.grAccount.Name = "grAccount";
            this.grAccount.RowHeadersVisible = false;
            this.grAccount.RowHeadersWidth = 51;
            this.grAccount.RowTemplate.Height = 24;
            this.grAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grAccount.Size = new System.Drawing.Size(656, 736);
            this.grAccount.TabIndex = 28;
            this.grAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAccount_CellClick);
            // 
            // stt
            // 
            this.stt.FillWeight = 43.18707F;
            this.stt.HeaderText = "Stt";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            // 
            // Hovaten
            // 
            this.Hovaten.FillWeight = 155.3097F;
            this.Hovaten.HeaderText = "Họ và tên";
            this.Hovaten.MinimumWidth = 6;
            this.Hovaten.Name = "Hovaten";
            // 
            // MaGV
            // 
            this.MaGV.FillWeight = 108.5678F;
            this.MaGV.HeaderText = "Mã giảng viên";
            this.MaGV.MinimumWidth = 6;
            this.MaGV.Name = "MaGV";
            // 
            // Chucvu
            // 
            this.Chucvu.FillWeight = 101.6186F;
            this.Chucvu.HeaderText = "Chức vụ";
            this.Chucvu.MinimumWidth = 6;
            this.Chucvu.Name = "Chucvu";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(598, 8);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 20);
            this.btnTimKiem.TabIndex = 29;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewAccount.Location = new System.Drawing.Point(498, 12);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(75, 23);
            this.btnNewAccount.TabIndex = 30;
            this.btnNewAccount.Text = "Tạo mới";
            this.btnNewAccount.UseVisualStyleBackColor = true;
            this.btnNewAccount.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDeleteAcount
            // 
            this.btnDeleteAcount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAcount.Location = new System.Drawing.Point(598, 11);
            this.btnDeleteAcount.Name = "btnDeleteAcount";
            this.btnDeleteAcount.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAcount.TabIndex = 31;
            this.btnDeleteAcount.Text = "Xóa";
            this.btnDeleteAcount.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.checkOnlyFemale);
            this.panel1.Controls.Add(this.checkTen);
            this.panel1.Controls.Add(this.checkOnlyMale);
            this.panel1.Controls.Add(this.tbTimKiem);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Location = new System.Drawing.Point(2, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 56);
            this.panel1.TabIndex = 32;
            // 
            // checkOnlyFemale
            // 
            this.checkOnlyFemale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkOnlyFemale.AutoSize = true;
            this.checkOnlyFemale.Location = new System.Drawing.Point(219, 34);
            this.checkOnlyFemale.Margin = new System.Windows.Forms.Padding(2);
            this.checkOnlyFemale.Name = "checkOnlyFemale";
            this.checkOnlyFemale.Size = new System.Drawing.Size(58, 17);
            this.checkOnlyFemale.TabIndex = 33;
            this.checkOnlyFemale.Text = "Chỉ Nữ";
            this.checkOnlyFemale.UseVisualStyleBackColor = true;
            this.checkOnlyFemale.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkTen
            // 
            this.checkTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkTen.AutoSize = true;
            this.checkTen.Location = new System.Drawing.Point(17, 34);
            this.checkTen.Margin = new System.Windows.Forms.Padding(2);
            this.checkTen.Name = "checkTen";
            this.checkTen.Size = new System.Drawing.Size(69, 17);
            this.checkTen.TabIndex = 32;
            this.checkTen.Text = "Theo tên";
            this.checkTen.UseVisualStyleBackColor = true;
            // 
            // checkOnlyMale
            // 
            this.checkOnlyMale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkOnlyMale.AutoSize = true;
            this.checkOnlyMale.Location = new System.Drawing.Point(123, 34);
            this.checkOnlyMale.Margin = new System.Windows.Forms.Padding(2);
            this.checkOnlyMale.Name = "checkOnlyMale";
            this.checkOnlyMale.Size = new System.Drawing.Size(66, 17);
            this.checkOnlyMale.TabIndex = 31;
            this.checkOnlyMale.Text = "Chỉ Nam";
            this.checkOnlyMale.UseVisualStyleBackColor = true;
            this.checkOnlyMale.CheckedChanged += new System.EventHandler(this.checkOnlyMale_CheckedChanged);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTimKiem.Location = new System.Drawing.Point(17, 8);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(556, 20);
            this.tbTimKiem.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.cbKhoa);
            this.panel2.Controls.Add(this.grAccount);
            this.panel2.Controls.Add(this.btnDeleteAcount);
            this.panel2.Controls.Add(this.btnNewAccount);
            this.panel2.Location = new System.Drawing.Point(2, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(691, 799);
            this.panel2.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel12);
            this.panel3.Controls.Add(this.picAvatar);
            this.panel3.Location = new System.Drawing.Point(715, 11);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 468);
            this.panel3.TabIndex = 34;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel6.Controls.Add(this.btnUpdateAccount);
            this.panel6.Controls.Add(this.btnLockAccount);
            this.panel6.Controls.Add(this.btnResetAccount);
            this.panel6.Location = new System.Drawing.Point(7, 394);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(406, 54);
            this.panel6.TabIndex = 37;
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdateAccount.Location = new System.Drawing.Point(267, 3);
            this.btnUpdateAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(125, 42);
            this.btnUpdateAccount.TabIndex = 13;
            this.btnUpdateAccount.Text = "Update";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            // 
            // btnLockAccount
            // 
            this.btnLockAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLockAccount.Location = new System.Drawing.Point(133, 3);
            this.btnLockAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnLockAccount.Name = "btnLockAccount";
            this.btnLockAccount.Size = new System.Drawing.Size(126, 42);
            this.btnLockAccount.TabIndex = 12;
            this.btnLockAccount.Text = "Lock Account";
            this.btnLockAccount.UseVisualStyleBackColor = true;
            this.btnLockAccount.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnResetAccount
            // 
            this.btnResetAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnResetAccount.Location = new System.Drawing.Point(12, 3);
            this.btnResetAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetAccount.Name = "btnResetAccount";
            this.btnResetAccount.Size = new System.Drawing.Size(114, 42);
            this.btnResetAccount.TabIndex = 11;
            this.btnResetAccount.Text = "Reset Account";
            this.btnResetAccount.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ảnh đại diện";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel11);
            this.panel5.Controls.Add(this.panel14);
            this.panel5.Controls.Add(this.panel15);
            this.panel5.Controls.Add(this.panel16);
            this.panel5.Controls.Add(this.panel17);
            this.panel5.Location = new System.Drawing.Point(7, 215);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(406, 163);
            this.panel5.TabIndex = 36;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tbMaNV);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(5, 12);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(199, 34);
            this.panel8.TabIndex = 3;
            // 
            // tbMaNV
            // 
            this.tbMaNV.Location = new System.Drawing.Point(76, 5);
            this.tbMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.ReadOnly = true;
            this.tbMaNV.Size = new System.Drawing.Size(120, 20);
            this.tbMaNV.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã giảng viên";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.tbHoTen);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Location = new System.Drawing.Point(5, 45);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(199, 31);
            this.panel9.TabIndex = 4;
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(76, 8);
            this.tbHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.ReadOnly = true;
            this.tbHoTen.Size = new System.Drawing.Size(120, 20);
            this.tbHoTen.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Họ và tên";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.tbChucVu);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Location = new System.Drawing.Point(5, 79);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(199, 30);
            this.panel10.TabIndex = 5;
            // 
            // tbChucVu
            // 
            this.tbChucVu.Location = new System.Drawing.Point(76, 8);
            this.tbChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.tbChucVu.Name = "tbChucVu";
            this.tbChucVu.ReadOnly = true;
            this.tbChucVu.Size = new System.Drawing.Size(120, 20);
            this.tbChucVu.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Chức vụ";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.tbSoNgayNghi);
            this.panel11.Controls.Add(this.label9);
            this.panel11.Location = new System.Drawing.Point(5, 114);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(199, 36);
            this.panel11.TabIndex = 6;
            // 
            // tbSoNgayNghi
            // 
            this.tbSoNgayNghi.Location = new System.Drawing.Point(76, 8);
            this.tbSoNgayNghi.Margin = new System.Windows.Forms.Padding(2);
            this.tbSoNgayNghi.Name = "tbSoNgayNghi";
            this.tbSoNgayNghi.ReadOnly = true;
            this.tbSoNgayNghi.Size = new System.Drawing.Size(120, 20);
            this.tbSoNgayNghi.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 8);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Được nghỉ";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.tbTrangThai);
            this.panel14.Controls.Add(this.label11);
            this.panel14.Location = new System.Drawing.Point(206, 45);
            this.panel14.Margin = new System.Windows.Forms.Padding(2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(189, 31);
            this.panel14.TabIndex = 7;
            // 
            // tbTrangThai
            // 
            this.tbTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTrangThai.Location = new System.Drawing.Point(61, 6);
            this.tbTrangThai.Margin = new System.Windows.Forms.Padding(2);
            this.tbTrangThai.Name = "tbTrangThai";
            this.tbTrangThai.ReadOnly = true;
            this.tbTrangThai.Size = new System.Drawing.Size(120, 20);
            this.tbTrangThai.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 8);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Trạng thái";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.tbHocHam);
            this.panel15.Controls.Add(this.label12);
            this.panel15.Location = new System.Drawing.Point(206, 79);
            this.panel15.Margin = new System.Windows.Forms.Padding(2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(189, 35);
            this.panel15.TabIndex = 8;
            // 
            // tbHocHam
            // 
            this.tbHocHam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHocHam.Location = new System.Drawing.Point(61, 8);
            this.tbHocHam.Margin = new System.Windows.Forms.Padding(2);
            this.tbHocHam.Name = "tbHocHam";
            this.tbHocHam.ReadOnly = true;
            this.tbHocHam.Size = new System.Drawing.Size(120, 20);
            this.tbHocHam.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 8);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Học hàm";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.tbDaNghi);
            this.panel16.Controls.Add(this.label13);
            this.panel16.Location = new System.Drawing.Point(206, 12);
            this.panel16.Margin = new System.Windows.Forms.Padding(2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(189, 34);
            this.panel16.TabIndex = 9;
            // 
            // tbDaNghi
            // 
            this.tbDaNghi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDaNghi.Location = new System.Drawing.Point(61, 6);
            this.tbDaNghi.Margin = new System.Windows.Forms.Padding(2);
            this.tbDaNghi.Name = "tbDaNghi";
            this.tbDaNghi.ReadOnly = true;
            this.tbDaNghi.Size = new System.Drawing.Size(120, 20);
            this.tbDaNghi.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 8);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Đã nghỉ";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.tbTaiKhoan);
            this.panel17.Controls.Add(this.label14);
            this.panel17.Location = new System.Drawing.Point(206, 112);
            this.panel17.Margin = new System.Windows.Forms.Padding(2);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(189, 37);
            this.panel17.TabIndex = 10;
            // 
            // tbTaiKhoan
            // 
            this.tbTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTaiKhoan.Location = new System.Drawing.Point(61, 8);
            this.tbTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.tbTaiKhoan.Name = "tbTaiKhoan";
            this.tbTaiKhoan.ReadOnly = true;
            this.tbTaiKhoan.Size = new System.Drawing.Size(120, 20);
            this.tbTaiKhoan.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 8);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Tài khoản";
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.Controls.Add(this.tbUpdate);
            this.panel12.Controls.Add(this.label10);
            this.panel12.Location = new System.Drawing.Point(7, 9);
            this.panel12.Margin = new System.Windows.Forms.Padding(2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(408, 33);
            this.panel12.TabIndex = 35;
            // 
            // tbUpdate
            // 
            this.tbUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUpdate.Location = new System.Drawing.Point(98, 6);
            this.tbUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.tbUpdate.Name = "tbUpdate";
            this.tbUpdate.ReadOnly = true;
            this.tbUpdate.Size = new System.Drawing.Size(295, 20);
            this.tbUpdate.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 8);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Lần cuối cập nhật";
            // 
            // picAvatar
            // 
            this.picAvatar.AllowFocused = false;
            this.picAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picAvatar.BorderRadius = 50;
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.IsCircle = true;
            this.picAvatar.Location = new System.Drawing.Point(140, 47);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(150, 150);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 14;
            this.picAvatar.TabStop = false;
            this.picAvatar.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.picAvatar.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(9, 11);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(702, 869);
            this.panel4.TabIndex = 35;
            // 
            // Management_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1145, 890);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Management_Account";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.grAccount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.DataGridView grAccount;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnDeleteAcount;
        private System.Windows.Forms.Button btnNewAccount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnLockAccount;
        private System.Windows.Forms.Button btnResetAccount;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox tbTaiKhoan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TextBox tbDaNghi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox tbHocHam;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox tbTrangThai;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox tbSoNgayNghi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox tbChucVu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox tbMaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox tbUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkTen;
        private System.Windows.Forms.CheckBox checkOnlyMale;
        private Bunifu.UI.WinForms.BunifuPictureBox picAvatar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox checkOnlyFemale;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hovaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chucvu;
    }
}