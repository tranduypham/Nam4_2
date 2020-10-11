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
    public partial class fReAccount : Form
    {
        public fReAccount()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (tbEmail.Text == "Email")
            {
                tbEmail.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                tbEmail.Text = "Email";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (tbPhone.Text == "Phone")
            {
                tbPhone.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (tbPhone.Text == "")
            {
                tbPhone.Text = "Phone";
            }
        }

        private void fReAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnSendResetPass_Click(object sender, EventArgs e)
        {

        }
    }
}
