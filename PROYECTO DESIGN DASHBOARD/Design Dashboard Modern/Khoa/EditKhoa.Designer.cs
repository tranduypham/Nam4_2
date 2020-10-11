namespace Design_Dashboard_Modern
{
    partial class EditKhoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThemKhoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnXoaKhoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSuaKhoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.grKhoa = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.maKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTruongKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTruongKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btRefesh = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnExit
            // 
            this.btnExit.Active = false;
            this.btnExit.Activecolor = System.Drawing.Color.DimGray;
            this.btnExit.BackColor = System.Drawing.Color.Gray;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderRadius = 0;
            this.btnExit.ButtonText = "Thoát";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledColor = System.Drawing.Color.Gray;
            this.btnExit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExit.Iconimage = null;
            this.btnExit.Iconimage_right = null;
            this.btnExit.Iconimage_right_Selected = null;
            this.btnExit.Iconimage_Selected = null;
            this.btnExit.IconMarginLeft = 0;
            this.btnExit.IconMarginRight = 0;
            this.btnExit.IconRightVisible = true;
            this.btnExit.IconRightZoom = 0D;
            this.btnExit.IconVisible = true;
            this.btnExit.IconZoom = 90D;
            this.btnExit.IsTab = false;
            this.btnExit.Location = new System.Drawing.Point(25, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.Color.Gray;
            this.btnExit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnExit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExit.selected = false;
            this.btnExit.Size = new System.Drawing.Size(120, 41);
            this.btnExit.TabIndex = 39;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Textcolor = System.Drawing.Color.White;
            this.btnExit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 82);
            this.panel2.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btRefesh);
            this.panel1.Controls.Add(this.btnThemKhoa);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnXoaKhoa);
            this.panel1.Controls.Add(this.btnSuaKhoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(487, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 516);
            this.panel1.TabIndex = 39;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnThemKhoa
            // 
            this.btnThemKhoa.Active = false;
            this.btnThemKhoa.Activecolor = System.Drawing.Color.DimGray;
            this.btnThemKhoa.BackColor = System.Drawing.Color.Gray;
            this.btnThemKhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemKhoa.BorderRadius = 0;
            this.btnThemKhoa.ButtonText = "Thêm khoa";
            this.btnThemKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemKhoa.DisabledColor = System.Drawing.Color.Gray;
            this.btnThemKhoa.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThemKhoa.Iconimage = null;
            this.btnThemKhoa.Iconimage_right = null;
            this.btnThemKhoa.Iconimage_right_Selected = null;
            this.btnThemKhoa.Iconimage_Selected = null;
            this.btnThemKhoa.IconMarginLeft = 0;
            this.btnThemKhoa.IconMarginRight = 0;
            this.btnThemKhoa.IconRightVisible = true;
            this.btnThemKhoa.IconRightZoom = 0D;
            this.btnThemKhoa.IconVisible = true;
            this.btnThemKhoa.IconZoom = 90D;
            this.btnThemKhoa.IsTab = false;
            this.btnThemKhoa.Location = new System.Drawing.Point(21, 12);
            this.btnThemKhoa.Name = "btnThemKhoa";
            this.btnThemKhoa.Normalcolor = System.Drawing.Color.Gray;
            this.btnThemKhoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnThemKhoa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThemKhoa.selected = false;
            this.btnThemKhoa.Size = new System.Drawing.Size(120, 41);
            this.btnThemKhoa.TabIndex = 40;
            this.btnThemKhoa.Text = "Thêm khoa";
            this.btnThemKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThemKhoa.Textcolor = System.Drawing.Color.White;
            this.btnThemKhoa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhoa.Click += new System.EventHandler(this.btnThemKhoa_Click_1);
            // 
            // btnXoaKhoa
            // 
            this.btnXoaKhoa.Active = false;
            this.btnXoaKhoa.Activecolor = System.Drawing.Color.DimGray;
            this.btnXoaKhoa.BackColor = System.Drawing.Color.Gray;
            this.btnXoaKhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaKhoa.BorderRadius = 0;
            this.btnXoaKhoa.ButtonText = "Xóa khoa";
            this.btnXoaKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaKhoa.DisabledColor = System.Drawing.Color.Gray;
            this.btnXoaKhoa.Iconcolor = System.Drawing.Color.Transparent;
            this.btnXoaKhoa.Iconimage = null;
            this.btnXoaKhoa.Iconimage_right = null;
            this.btnXoaKhoa.Iconimage_right_Selected = null;
            this.btnXoaKhoa.Iconimage_Selected = null;
            this.btnXoaKhoa.IconMarginLeft = 0;
            this.btnXoaKhoa.IconMarginRight = 0;
            this.btnXoaKhoa.IconRightVisible = true;
            this.btnXoaKhoa.IconRightZoom = 0D;
            this.btnXoaKhoa.IconVisible = true;
            this.btnXoaKhoa.IconZoom = 90D;
            this.btnXoaKhoa.IsTab = false;
            this.btnXoaKhoa.Location = new System.Drawing.Point(21, 173);
            this.btnXoaKhoa.Name = "btnXoaKhoa";
            this.btnXoaKhoa.Normalcolor = System.Drawing.Color.Gray;
            this.btnXoaKhoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnXoaKhoa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXoaKhoa.selected = false;
            this.btnXoaKhoa.Size = new System.Drawing.Size(120, 41);
            this.btnXoaKhoa.TabIndex = 38;
            this.btnXoaKhoa.Text = "Xóa khoa";
            this.btnXoaKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoaKhoa.Textcolor = System.Drawing.Color.White;
            this.btnXoaKhoa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKhoa.Click += new System.EventHandler(this.btnXoaKhoa_Click);
            // 
            // btnSuaKhoa
            // 
            this.btnSuaKhoa.Active = false;
            this.btnSuaKhoa.Activecolor = System.Drawing.Color.DimGray;
            this.btnSuaKhoa.BackColor = System.Drawing.Color.Gray;
            this.btnSuaKhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaKhoa.BorderRadius = 0;
            this.btnSuaKhoa.ButtonText = "Sửa khoa";
            this.btnSuaKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaKhoa.DisabledColor = System.Drawing.Color.Gray;
            this.btnSuaKhoa.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSuaKhoa.Iconimage = null;
            this.btnSuaKhoa.Iconimage_right = null;
            this.btnSuaKhoa.Iconimage_right_Selected = null;
            this.btnSuaKhoa.Iconimage_Selected = null;
            this.btnSuaKhoa.IconMarginLeft = 0;
            this.btnSuaKhoa.IconMarginRight = 0;
            this.btnSuaKhoa.IconRightVisible = true;
            this.btnSuaKhoa.IconRightZoom = 0D;
            this.btnSuaKhoa.IconVisible = true;
            this.btnSuaKhoa.IconZoom = 90D;
            this.btnSuaKhoa.IsTab = false;
            this.btnSuaKhoa.Location = new System.Drawing.Point(21, 89);
            this.btnSuaKhoa.Name = "btnSuaKhoa";
            this.btnSuaKhoa.Normalcolor = System.Drawing.Color.Gray;
            this.btnSuaKhoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSuaKhoa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSuaKhoa.selected = false;
            this.btnSuaKhoa.Size = new System.Drawing.Size(120, 41);
            this.btnSuaKhoa.TabIndex = 38;
            this.btnSuaKhoa.Text = "Sửa khoa";
            this.btnSuaKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSuaKhoa.Textcolor = System.Drawing.Color.White;
            this.btnSuaKhoa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaKhoa.Click += new System.EventHandler(this.btnSuaKhoa_Click);
            // 
            // grKhoa
            // 
            this.grKhoa.AllowUserToAddRows = false;
            this.grKhoa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grKhoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grKhoa.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grKhoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grKhoa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grKhoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKhoa,
            this.ten_Khoa,
            this.maTruongKhoa,
            this.tenTruongKhoa});
            this.grKhoa.DoubleBuffered = true;
            this.grKhoa.EnableHeadersVisualStyles = false;
            this.grKhoa.HeaderBgColor = System.Drawing.Color.Silver;
            this.grKhoa.HeaderForeColor = System.Drawing.Color.Black;
            this.grKhoa.Location = new System.Drawing.Point(3, 12);
            this.grKhoa.Name = "grKhoa";
            this.grKhoa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grKhoa.RowHeadersVisible = false;
            this.grKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grKhoa.Size = new System.Drawing.Size(478, 492);
            this.grKhoa.TabIndex = 40;
            this.grKhoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.grKhoa.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            // 
            // maKhoa
            // 
            this.maKhoa.FillWeight = 106.599F;
            this.maKhoa.HeaderText = "Mã Khoa";
            this.maKhoa.Name = "maKhoa";
            // 
            // ten_Khoa
            // 
            this.ten_Khoa.FillWeight = 96.70051F;
            this.ten_Khoa.HeaderText = "Tên Khoa";
            this.ten_Khoa.Name = "ten_Khoa";
            // 
            // maTruongKhoa
            // 
            this.maTruongKhoa.FillWeight = 96.70051F;
            this.maTruongKhoa.HeaderText = "Mã trưởng khoa";
            this.maTruongKhoa.Name = "maTruongKhoa";
            // 
            // tenTruongKhoa
            // 
            this.tenTruongKhoa.HeaderText = "Tên Trưởng Khoa";
            this.tenTruongKhoa.Name = "tenTruongKhoa";
            this.tenTruongKhoa.Visible = false;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // btRefesh
            // 
            this.btRefesh.Location = new System.Drawing.Point(41, 302);
            this.btRefesh.Name = "btRefesh";
            this.btRefesh.Size = new System.Drawing.Size(75, 23);
            this.btRefesh.TabIndex = 41;
            this.btRefesh.Text = "Refesh";
            this.btRefesh.UseVisualStyleBackColor = true;
            this.btRefesh.Click += new System.EventHandler(this.btRefesh_Click);
            // 
            // EditKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 516);
            this.Controls.Add(this.grKhoa);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemKhoa";
            this.Load += new System.EventHandler(this.EditKhoa_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grKhoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnThemKhoa;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnXoaKhoa;
        private Bunifu.Framework.UI.BunifuFlatButton btnSuaKhoa;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocHamTruongKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTruongKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTruongKhoa;
        private System.Windows.Forms.Button btRefesh;
    }
}