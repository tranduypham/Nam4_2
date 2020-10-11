using Newtonsoft.Json;
using Design_Dashboard_Modern.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;
using Design_Dashboard_Modern.Models;
using System.Globalization;

namespace Design_Dashboard_Modern
{
    public partial class fInfor : Form
    {
        private string jsonInfor;
        private string idGiangVien;
        List<ChucVu> listcv;
        public string JsonInfor { get => jsonInfor; set => jsonInfor = value; }
        public string IdGiangVien { get => idGiangVien; set => idGiangVien = value; }

        public fInfor()
        {
            InitializeComponent();            
            LoadInfor();
        }

        public fInfor( string jsoninfor)
        {
            InitializeComponent();
            this.JsonInfor = jsoninfor;
            LoadInfor();
        }
        public void LoadInfor()
        {
            UserInfor inf = JsonConvert.DeserializeObject<UserInfor>(JsonInfor);
            var responses = DataProvider.Instance.GetData("https://localhost:5001/api/Giangvien/GetInforGiangVien/" + inf.IdgiangVien);
            inf = JsonConvert.DeserializeObject<UserInfor>(responses.ToString());
            tbHoTen.Text = inf.TenGiangVien;
            IdGiangVien = inf.IdgiangVien;
            tbUsername.Text = inf.IdgiangVien;
            tbEmail.Text = inf.Email;
            tbGender.Text = inf.GioiTinh;
            tbDateOfBirth.Text = inf.NgaySinh.ToString("dd/MM/yyyy");
            tbChucVu.Text = inf.TenChucVu;
            tbHocHam.Text = inf.HocHamHocVi;
            tbBoMon.Text = inf.TenBoMon;
            tbKhoa.Text = inf.TenKhoa;
            tbLuong.Text = inf.LuongThucNhan;
        }



        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            fFixInfo f = new fFixInfo(IdGiangVien);
            //f.Show();
            Blur_Background(f);
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            btnXacNhan.Visible = false;
            btnCapNhat.Visible = true;
            tbUsername.Enabled = false;
            tbGender.Enabled = false;
            tbEmail.Enabled = false;
            tbChucVu.Enabled = false;
            tbDateOfBirth.Enabled = false;
            tbLuong.Enabled = false;
            tbHocHam.Enabled = false;
            tbHoTen.Enabled = false;
            cbChucVu.Enabled = false;

            GiangVien gv = new GiangVien();
            gv.IdgiangVien = tbUsername.Text;
            gv.TenGiangVien = tbHoTen.Text;
            gv.IdchucVu = listcv[cbChucVu.SelectedIndex].IdchucVu;
            gv.Email = tbEmail.Text;
            gv.GioiTinh = tbGender.Text;
            gv.NgaySinh = DateTime.Parse(tbDateOfBirth.Text);
            gv.HocHamHocVi = tbHocHam.Text;
            gv.LuongThucNhan = tbLuong.Text;

            string DataPost = JsonConvert.SerializeObject(gv);
            string response = DataProvider.Instance.PostData("https://localhost:5001/api/GiangVien/ChangeInfor", DataPost);
            MessageBox.Show("Cập nhật thành công");
        }


        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            btnCapNhat.Visible = false;
            btnXacNhan.Visible = true;
            tbUsername.Enabled = true;
            tbGender.Enabled = true;
            tbEmail.Enabled = true;
            tbChucVu.Enabled = true;
            tbDateOfBirth.Enabled = true;
            tbLuong.Enabled = true;
            tbHocHam.Enabled = true;
            tbHoTen.Enabled = true;
            cbChucVu.Enabled = true;

            var respons = DataProvider.Instance.GetData("https://localhost:5001/api/ChucVu");
            listcv = JsonConvert.DeserializeObject<List<ChucVu>>(respons.ToString());

            for (int i = 0; i < listcv.Count; i++)
            {
                cbChucVu.Items.Add(listcv[i].TenChucVu);
            }
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

        private void textBox9_Click(object sender, EventArgs e)
        {
            tbHoTen.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            tbUsername.SelectAll();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            tbEmail.SelectAll();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            tbGender.SelectAll();
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            tbDateOfBirth.SelectAll();
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            tbChucVu.SelectAll();
        }

        private void textBox8_Click(object sender, EventArgs e)
        {

            tbHocHam.SelectAll();
        }

        private void textBox7_Click(object sender, EventArgs e)
        {

            tbLuong.SelectAll();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void fInfor_Load(object sender, EventArgs e)
        {

        }

        private void tbKhoa_TextChanged(object sender, EventArgs e)
        {
            tbKhoa.SelectAll();
        }

        private void tbBoMon_TextChanged(object sender, EventArgs e)
        {
            tbBoMon.SelectAll();
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg file (*.jpg)|*.jpg|png file |*.png| all file (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox3.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra, xin hãy thử lại sau", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
