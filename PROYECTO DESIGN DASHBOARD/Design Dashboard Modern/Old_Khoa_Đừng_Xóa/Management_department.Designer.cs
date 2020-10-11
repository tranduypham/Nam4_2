namespace Design_Dashboard_Modern
{
    partial class Management_department
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management_department));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.dataGridViewGiangVien = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duocNghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daNghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocHam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hovaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaKhoa = new System.Windows.Forms.Button();
            this.btnNewKhoa = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picAvatar = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.dataGridViewKhoa = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbMaGiangVien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.tbHocHam = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.tbTaiKhoan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.tbTruongKhoa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiangVien)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoa)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.cbKhoa);
            this.panel2.Controls.Add(this.dataGridViewGiangVien);
            this.panel2.Controls.Add(this.btnXoaKhoa);
            this.panel2.Controls.Add(this.btnNewKhoa);
            this.panel2.Location = new System.Drawing.Point(12, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 563);
            this.panel2.TabIndex = 34;
            // 
            // cbKhoa
            // 
            this.cbKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Items.AddRange(new object[] {
            "KHOA AN TOÀN THÔNG TIN",
            "KHOA CÔNG NGHỆ THÔNG TIN",
            "KHOA ĐIỆN TỬ VIỄN THÔNG"});
            this.cbKhoa.Location = new System.Drawing.Point(17, 11);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(223, 25);
            this.cbKhoa.TabIndex = 8;
            this.cbKhoa.Text = "-Khoa -";
            // 
            // dataGridViewGiangVien
            // 
            this.dataGridViewGiangVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGiangVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGiangVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.date,
            this.duocNghi,
            this.daNghi,
            this.trangThai,
            this.hocHam,
            this.taiKhoan,
            this.Hovaten,
            this.MaGV,
            this.Chucvu});
            this.dataGridViewGiangVien.Location = new System.Drawing.Point(17, 47);
            this.dataGridViewGiangVien.Name = "dataGridViewGiangVien";
            this.dataGridViewGiangVien.RowHeadersVisible = false;
            this.dataGridViewGiangVien.RowHeadersWidth = 51;
            this.dataGridViewGiangVien.RowTemplate.Height = 24;
            this.dataGridViewGiangVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGiangVien.Size = new System.Drawing.Size(435, 500);
            this.dataGridViewGiangVien.TabIndex = 28;
            // 
            // stt
            // 
            this.stt.FillWeight = 43.18707F;
            this.stt.HeaderText = "Stt";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            // 
            // date
            // 
            this.date.HeaderText = "date";
            this.date.Name = "date";
            this.date.Visible = false;
            // 
            // duocNghi
            // 
            this.duocNghi.HeaderText = "duocNghi";
            this.duocNghi.Name = "duocNghi";
            this.duocNghi.Visible = false;
            // 
            // daNghi
            // 
            this.daNghi.HeaderText = "daNghi";
            this.daNghi.Name = "daNghi";
            this.daNghi.Visible = false;
            // 
            // trangThai
            // 
            this.trangThai.HeaderText = "trangThai";
            this.trangThai.Name = "trangThai";
            this.trangThai.Visible = false;
            // 
            // hocHam
            // 
            this.hocHam.HeaderText = "hocHam";
            this.hocHam.Name = "hocHam";
            this.hocHam.Visible = false;
            // 
            // taiKhoan
            // 
            this.taiKhoan.HeaderText = "taiKhoan";
            this.taiKhoan.Name = "taiKhoan";
            this.taiKhoan.Visible = false;
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
            // btnXoaKhoa
            // 
            this.btnXoaKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaKhoa.Location = new System.Drawing.Point(377, 11);
            this.btnXoaKhoa.Name = "btnXoaKhoa";
            this.btnXoaKhoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoaKhoa.TabIndex = 31;
            this.btnXoaKhoa.Text = "Xóa";
            this.btnXoaKhoa.UseVisualStyleBackColor = true;
            // 
            // btnNewKhoa
            // 
            this.btnNewKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewKhoa.Location = new System.Drawing.Point(277, 12);
            this.btnNewKhoa.Name = "btnNewKhoa";
            this.btnNewKhoa.Size = new System.Drawing.Size(75, 23);
            this.btnNewKhoa.TabIndex = 30;
            this.btnNewKhoa.Text = "Tạo mới";
            this.btnNewKhoa.UseVisualStyleBackColor = true;
            this.btnNewKhoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.picAvatar);
            this.panel3.Controls.Add(this.dataGridViewKhoa);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel12);
            this.panel3.Location = new System.Drawing.Point(487, 34);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(431, 563);
            this.panel3.TabIndex = 35;
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
            this.picAvatar.Location = new System.Drawing.Point(147, 40);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(145, 145);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 38;
            this.picAvatar.TabStop = false;
            this.picAvatar.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // dataGridViewKhoa
            // 
            this.dataGridViewKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridViewKhoa.Location = new System.Drawing.Point(7, 279);
            this.dataGridViewKhoa.Name = "dataGridViewKhoa";
            this.dataGridViewKhoa.RowHeadersVisible = false;
            this.dataGridViewKhoa.RowHeadersWidth = 51;
            this.dataGridViewKhoa.RowTemplate.Height = 24;
            this.dataGridViewKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKhoa.Size = new System.Drawing.Size(406, 268);
            this.dataGridViewKhoa.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 43.18707F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Stt";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.FillWeight = 155.3097F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Bộ môn";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.FillWeight = 108.5678F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Mã bộ môn";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.FillWeight = 101.6186F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Mô tả";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel15);
            this.panel5.Controls.Add(this.panel17);
            this.panel5.Location = new System.Drawing.Point(7, 191);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(406, 82);
            this.panel5.TabIndex = 36;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tbMaGiangVien);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(5, 12);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(199, 34);
            this.panel8.TabIndex = 3;
            // 
            // tbMaGiangVien
            // 
            this.tbMaGiangVien.Location = new System.Drawing.Point(78, 9);
            this.tbMaGiangVien.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaGiangVien.Name = "tbMaGiangVien";
            this.tbMaGiangVien.ReadOnly = true;
            this.tbMaGiangVien.Size = new System.Drawing.Size(120, 20);
            this.tbMaGiangVien.TabIndex = 2;
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
            this.panel9.Size = new System.Drawing.Size(199, 34);
            this.panel9.TabIndex = 4;
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(78, 8);
            this.tbHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.ReadOnly = true;
            this.tbHoTen.Size = new System.Drawing.Size(119, 20);
            this.tbHoTen.TabIndex = 2;
            this.tbHoTen.TextChanged += new System.EventHandler(this.txHoTen_TextChanged);
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
            // panel15
            // 
            this.panel15.Controls.Add(this.tbHocHam);
            this.panel15.Controls.Add(this.label12);
            this.panel15.Location = new System.Drawing.Point(204, 12);
            this.panel15.Margin = new System.Windows.Forms.Padding(2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(189, 34);
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
            // panel17
            // 
            this.panel17.Controls.Add(this.tbTaiKhoan);
            this.panel17.Controls.Add(this.label14);
            this.panel17.Location = new System.Drawing.Point(204, 44);
            this.panel17.Margin = new System.Windows.Forms.Padding(2);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(189, 35);
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
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.Controls.Add(this.tbTruongKhoa);
            this.panel12.Controls.Add(this.label10);
            this.panel12.Location = new System.Drawing.Point(7, 9);
            this.panel12.Margin = new System.Windows.Forms.Padding(2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(406, 33);
            this.panel12.TabIndex = 35;
            // 
            // tbTruongKhoa
            // 
            this.tbTruongKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTruongKhoa.Location = new System.Drawing.Point(98, 6);
            this.tbTruongKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.tbTruongKhoa.Name = "tbTruongKhoa";
            this.tbTruongKhoa.ReadOnly = true;
            this.tbTruongKhoa.Size = new System.Drawing.Size(293, 20);
            this.tbTruongKhoa.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 8);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Trưởng khoa";
            // 
            // Management_department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 609);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Management_department";
            this.Text = "Form2";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiangVien)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoa)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.DataGridView dataGridViewGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn duocNghi;
        private System.Windows.Forms.DataGridViewTextBoxColumn daNghi;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocHam;
        private System.Windows.Forms.DataGridViewTextBoxColumn taiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hovaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chucvu;
        private System.Windows.Forms.Button btnXoaKhoa;
        private System.Windows.Forms.Button btnNewKhoa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox tbMaGiangVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox tbHocHam;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox tbTaiKhoan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox tbTruongKhoa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private Bunifu.UI.WinForms.BunifuPictureBox picAvatar;
    }
}