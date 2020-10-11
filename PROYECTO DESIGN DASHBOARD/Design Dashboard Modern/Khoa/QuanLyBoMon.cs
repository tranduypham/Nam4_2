using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Dashboard_Modern
{
    public partial class QuanLyBoMon : Form
    {
        public QuanLyBoMon()
        {
            InitializeComponent();
        }
        private void Blur_Background(Form f)
        {
            Form black = new Form();
            black.StartPosition = FormStartPosition.Manual;
            black.ShowInTaskbar = false;
            black.BackColor = Color.Black;
            black.Opacity = 0.5;
            black.Location = this.Location;
            black.WindowState = FormWindowState.Maximized;
            black.FormBorderStyle = FormBorderStyle.None;
            black.TopMost = true;
            black.Show();

            f.Owner = black;
            f.TopMost = true;
            f.ShowDialog();
            black.Dispose();
        }
        private void btnChinhSuaBoMon_Click(object sender, EventArgs e)
        {
            ThemBoMon f = new ThemBoMon();
            //f.ShowDialog();
            Blur_Background(f);
        }
        string idGiangVien;
        string idMon;

        private void btnLuu_Click(object sender, EventArgs e)
        {
            tbMaNV.Enabled = false;
            tbChucVu.Enabled = false;
            tbHocHam.Enabled = false;
            tbHoTen.Enabled = false;
            tbTaiKhoan.Enabled = false;
            btnCapNhat.Visible = true;
            btnLuu.Visible = false;
            label5.Visible = true;
            linkLabel1.Visible = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            

            tbMaNV.Enabled = true;
            tbChucVu.Enabled = true;
            tbHocHam.Enabled = true;
            tbHoTen.Enabled = true;
            tbTaiKhoan.Enabled = true;
            btnCapNhat.Visible = false;
            btnLuu.Visible = true;
            label5.Visible = false;
            linkLabel1.Visible = true;
        }

        private void QuanLyBoMon_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idMon = dataGridView1.Rows[e.RowIndex].Cells["maMon"].Value.ToString().Trim();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DDuwa id giang vieen vaof ddaay
            QuanLyMonHoc f = new QuanLyMonHoc("GV001");
            Blur_Background(f);
        }
    }
}
