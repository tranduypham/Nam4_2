using Design_Dashboard_Modern.DTO;
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
    public partial class fFixInfo : Form
    {
        private string idGiangvien;

        public string IdGiangvien { get => idGiangvien; set => idGiangvien = value; }

        public fFixInfo(string idgiangvien)
        {
            InitializeComponent();
            this.IdGiangvien = idgiangvien;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            tbOldPass.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            tbNewPass.SelectAll();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            tbResetNewPass.SelectAll();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txResetNewPass_TextChanged(object sender, EventArgs e)
        {
            if(tbResetNewPass.Text != tbNewPass.Text)
            {
                lableKhongKhop.Visible = true;
            }
            else
            {
                lableKhongKhop.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] userbyte = System.Text.ASCIIEncoding.ASCII.GetBytes(IdGiangvien);
            byte[] oPassbyte = System.Text.ASCIIEncoding.ASCII.GetBytes(tbOldPass.Text);
            byte[] nPassbyte = System.Text.ASCIIEncoding.ASCII.GetBytes(tbNewPass.Text);
            ChangePassword cPass = new ChangePassword();
            cPass.IdgiangVien = System.Convert.ToBase64String(userbyte);
            cPass.oPass = System.Convert.ToBase64String(oPassbyte);
            cPass.nPass = System.Convert.ToBase64String(nPassbyte);
            string response = DataProvider.Instance.PostData("https://localhost:5001/api/GiangVien/ChangePassword", JsonConvert.SerializeObject(cPass));
            MessageBox.Show(response);

        }
    }
}
