using Design_Dashboard_Modern.DTO;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;
using HttpMethod = xNet.HttpMethod;
//using Test2;

namespace Design_Dashboard_Modern
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            
        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Tên đăng nhập")
            {
                tbUsername.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                tbUsername.Text = "Tên đăng nhập";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Mật khẩu")
            {
                tbPassword.Text = "";
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.UseSystemPasswordChar = false;
                tbPassword.Text = "Mật khẩu";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if(tbPassword.UseSystemPasswordChar == false)
            {
                this.pictureBox7.Load("invisible_blue.png");
                //if(tbPassword.Text == "Password")
                //{
                //    tbPassword.UseSystemPasswordChar = false;
                //}
                //else
                //{
                    tbPassword.UseSystemPasswordChar = true;
                //}

            }
            else
            {
                this.pictureBox7.Load("view_blue.png");
                tbPassword.UseSystemPasswordChar = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fReAccount f = new fReAccount();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] userbyte = System.Text.ASCIIEncoding.ASCII.GetBytes(tbUsername.Text);
            byte[] passbyte = System.Text.ASCIIEncoding.ASCII.GetBytes(tbPassword.Text);
            Login log = new Login();
            log.IdgiangVien= System.Convert.ToBase64String(userbyte);
            log.Pass = System.Convert.ToBase64String(passbyte);
            string responses = DataProvider.Instance.PostData("https://localhost:5001/api/Login", JsonConvert.SerializeObject(log));
            
            if (responses== "false")
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            }
            else
            {
                FormChinh f = new FormChinh(responses.ToString());
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
