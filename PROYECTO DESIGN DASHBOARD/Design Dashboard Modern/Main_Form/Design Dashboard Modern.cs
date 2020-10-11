using Design_Dashboard_Modern;
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
    public partial class FormChinh : Form
    {
        private string jsonInfor;
        private string auth;
        public string JsonInfor { get => jsonInfor; set => jsonInfor = value; }

        public FormChinh()
        {
            InitializeComponent();
        }
        public FormChinh(string jsonInfor)
        {
                     
            InitializeComponent();
            this.JsonInfor = jsonInfor;
            LoadData();
        }

        void LoadData()
        {
            GiangVien gv = JsonConvert.DeserializeObject<GiangVien>(JsonInfor);
            lbName.Text = gv.TenGiangVien;
        }


        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.DialogResult = DialogResult.Cancel;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if(Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = LineaSidebar1.Width = 52;
                AnimacionSidebar.Show(Sidebar);
                
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 270;
                SidebarWrapper.Width = 300;
                LineaSidebar.Width = LineaSidebar1.Width = 252;
                AnimacionSidebarBack.Show(Sidebar);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            indicator.Height = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Height;
            indicator.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            //panel4.Controls.Clear();
            //Management_Account account = new Management_Account();
            //account.TopLevel = false;
            //panel4.Controls.Add(account);
            //account.Dock = DockStyle.Fill;
            //account.Show();
            PanelChart.Controls.Clear();
            fInfor f = new fInfor(JsonInfor);           
            f.TopLevel = false;
            PanelChart.Controls.Add(f);
            //f.StartPosition = FormStartPosition.CenterParent;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            //f.Anchor = (AnchorStyles.Top & AnchorStyles.Left & AnchorStyles.Right & AnchorStyles.Bottom);
            f.Show();


        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            indicator.Height = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Height;
            indicator.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            PanelChart.Controls.Clear();
            Confirm_Report f = new Confirm_Report();
            f.TopLevel = false;
            PanelChart.Controls.Add(f);
            //f.StartPosition = FormStartPosition.CenterParent;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            //f.Anchor = (AnchorStyles.Top & AnchorStyles.Left & AnchorStyles.Right & AnchorStyles.Bottom);
            f.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            indicator.Height = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Height;
            indicator.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            PanelChart.Controls.Clear();
            PanelChart.AutoScroll = true;
            FormBaoCao f = new FormBaoCao();
            //Report f = new Report(JsonInfor);
            f.TopLevel = false;
            PanelChart.Controls.Add(f);
            //f.StartPosition = FormStartPosition.CenterParent;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            //f.Anchor = (AnchorStyles.Top & AnchorStyles.Left & AnchorStyles.Right & AnchorStyles.Bottom);
            f.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            indicator.Height = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Height;
            indicator.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            PanelChart.Controls.Clear();
            PanelChart.AutoScroll = true;
            Management_Account f = new Management_Account();
            f.TopLevel = false;
            PanelChart.Controls.Add(f);
            //f.StartPosition = FormStartPosition.CenterParent;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            //f.Anchor = (AnchorStyles.Top & AnchorStyles.Left & AnchorStyles.Right & AnchorStyles.Bottom);
            f.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            indicator.Height = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Height;
            indicator.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            PanelChart.Controls.Clear();
            PanelChart.AutoScroll = true;

            QuanLyKhoa f = new QuanLyKhoa();
            f.TopLevel = false;
            PanelChart.Controls.Add(f);
            //f.StartPosition = FormStartPosition.CenterParent;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            //f.Anchor = (AnchorStyles.Top & AnchorStyles.Left & AnchorStyles.Right & AnchorStyles.Bottom);
            f.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
        }

        private void indicator_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            indicator.Height = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Height;
            indicator.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            this.Close();
        }
    }
}
