namespace Design_Dashboard_Modern
{
    partial class ThemBoMon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.maBoMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenBoMon = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.slgMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slgGiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaKhoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maBoMon,
            this.tenBoMon,
            this.slgMon,
            this.slgGiangVien});
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.Silver;
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(718, 426);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // maBoMon
            // 
            this.maBoMon.HeaderText = "Mã Bộ Môn";
            this.maBoMon.Name = "maBoMon";
            this.maBoMon.ReadOnly = true;
            // 
            // tenBoMon
            // 
            this.tenBoMon.HeaderText = "Tên Bộ Môn";
            this.tenBoMon.Name = "tenBoMon";
            this.tenBoMon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tenBoMon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // slgMon
            // 
            this.slgMon.HeaderText = "Số Lượng Môn";
            this.slgMon.Name = "slgMon";
            // 
            // slgGiangVien
            // 
            this.slgGiangVien.HeaderText = "Số lượng giảng viên";
            this.slgGiangVien.Name = "slgGiangVien";
            // 
            // btnXoaKhoa
            // 
            this.btnXoaKhoa.Active = false;
            this.btnXoaKhoa.Activecolor = System.Drawing.Color.DimGray;
            this.btnXoaKhoa.BackColor = System.Drawing.Color.Gray;
            this.btnXoaKhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaKhoa.BorderRadius = 0;
            this.btnXoaKhoa.ButtonText = "Thoát";
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
            this.btnXoaKhoa.Location = new System.Drawing.Point(747, 12);
            this.btnXoaKhoa.Name = "btnXoaKhoa";
            this.btnXoaKhoa.Normalcolor = System.Drawing.Color.Gray;
            this.btnXoaKhoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnXoaKhoa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXoaKhoa.selected = false;
            this.btnXoaKhoa.Size = new System.Drawing.Size(167, 41);
            this.btnXoaKhoa.TabIndex = 42;
            this.btnXoaKhoa.Text = "Thoát";
            this.btnXoaKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoaKhoa.Textcolor = System.Drawing.Color.White;
            this.btnXoaKhoa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKhoa.Click += new System.EventHandler(this.btnXoaKhoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "https://www.youtube.com/watch?v=cQQy_IfFddg&list=PLOZyZHl-A4KwrTje4qsLc5VUyp9VPj-" +
    "S4&index=3&t=930s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Làm chức năng xóa thêm trực tiếp trên datagridview luôn?";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // ThemBoMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoaKhoa);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThemBoMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemBoMon";
            this.Load += new System.EventHandler(this.ThemBoMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
        private Bunifu.Framework.UI.BunifuFlatButton btnXoaKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBoMon;
        private System.Windows.Forms.DataGridViewComboBoxColumn tenBoMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn slgMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn slgGiangVien;
    }
}