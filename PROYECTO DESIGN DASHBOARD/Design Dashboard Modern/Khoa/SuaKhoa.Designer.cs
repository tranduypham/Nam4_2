namespace Design_Dashboard_Modern
{
    partial class SuaKhoa
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tbTenKhoa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tbMaTruongKhoa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThoatSuaKhoa = new System.Windows.Forms.Button();
            this.btnLuuSuaKhoa = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Location = new System.Drawing.Point(88, 27);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(369, 149);
            this.panel5.TabIndex = 38;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cbKhoa);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(5, 12);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(359, 35);
            this.panel8.TabIndex = 3;
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(109, 6);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(247, 21);
            this.cbKhoa.TabIndex = 2;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã khoa";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.tbTenKhoa);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Location = new System.Drawing.Point(5, 56);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(359, 35);
            this.panel9.TabIndex = 4;
            // 
            // tbTenKhoa
            // 
            this.tbTenKhoa.Location = new System.Drawing.Point(109, 5);
            this.tbTenKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.tbTenKhoa.Name = "tbTenKhoa";
            this.tbTenKhoa.Size = new System.Drawing.Size(247, 20);
            this.tbTenKhoa.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên Khoa";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.tbMaTruongKhoa);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Location = new System.Drawing.Point(5, 100);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(359, 35);
            this.panel10.TabIndex = 5;
            // 
            // tbMaTruongKhoa
            // 
            this.tbMaTruongKhoa.Enabled = false;
            this.tbMaTruongKhoa.Location = new System.Drawing.Point(109, 5);
            this.tbMaTruongKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaTruongKhoa.Name = "tbMaTruongKhoa";
            this.tbMaTruongKhoa.Size = new System.Drawing.Size(247, 20);
            this.tbMaTruongKhoa.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mã trưởng khoa";
            // 
            // btnThoatSuaKhoa
            // 
            this.btnThoatSuaKhoa.BackColor = System.Drawing.Color.Gray;
            this.btnThoatSuaKhoa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoatSuaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatSuaKhoa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThoatSuaKhoa.Location = new System.Drawing.Point(307, 198);
            this.btnThoatSuaKhoa.Name = "btnThoatSuaKhoa";
            this.btnThoatSuaKhoa.Size = new System.Drawing.Size(118, 41);
            this.btnThoatSuaKhoa.TabIndex = 39;
            this.btnThoatSuaKhoa.Text = "Thoát";
            this.btnThoatSuaKhoa.UseVisualStyleBackColor = false;
            this.btnThoatSuaKhoa.Click += new System.EventHandler(this.btnThoatSuaKhoa_Click);
            // 
            // btnLuuSuaKhoa
            // 
            this.btnLuuSuaKhoa.BackColor = System.Drawing.Color.Gray;
            this.btnLuuSuaKhoa.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLuuSuaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuSuaKhoa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLuuSuaKhoa.Location = new System.Drawing.Point(118, 198);
            this.btnLuuSuaKhoa.Name = "btnLuuSuaKhoa";
            this.btnLuuSuaKhoa.Size = new System.Drawing.Size(118, 41);
            this.btnLuuSuaKhoa.TabIndex = 40;
            this.btnLuuSuaKhoa.Text = "Lưu";
            this.btnLuuSuaKhoa.UseVisualStyleBackColor = false;
            this.btnLuuSuaKhoa.Click += new System.EventHandler(this.btnLuuSuaKhoa_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // SuaKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 270);
            this.Controls.Add(this.btnThoatSuaKhoa);
            this.Controls.Add(this.btnLuuSuaKhoa);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuaKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuaKhoa";
            this.Load += new System.EventHandler(this.SuaKhoa_Load);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox tbTenKhoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox tbMaTruongKhoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThoatSuaKhoa;
        private System.Windows.Forms.Button btnLuuSuaKhoa;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ComboBox cbKhoa;
    }
}