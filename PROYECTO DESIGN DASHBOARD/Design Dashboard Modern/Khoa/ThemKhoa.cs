using Design_Dashboard_Modern.Models;
using Newtonsoft.Json;
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
    public partial class ThemKhoa : Form
    {
        public ThemKhoa()
        {
            InitializeComponent();
           
        }

        private void ThemKhoa_Load(object sender, EventArgs e)
        {

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
        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thêm khoa vào không ?","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Khoa khoa = new Khoa();
                khoa.Idkhoa = tbMaKhoa.Text;
                khoa.TenKhoa = tbTenKhoa.Text;
                string respons = DataProvider.Instance.PostData("https://localhost:5001/api/Khoa/ThemKhoa", JsonConvert.SerializeObject(khoa));
                if(respons.Equals("true"))
                {
                    MessageBox.Show("Thêm khoa thành công");
                }
                else
                {
                    MessageBox.Show("Khoa đã tồn tại");
                }








                //ThemBoMon f = new ThemBoMon();
                //f.ShowDialog();
                //Blur_Background(f);
            }
            else
            {
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
