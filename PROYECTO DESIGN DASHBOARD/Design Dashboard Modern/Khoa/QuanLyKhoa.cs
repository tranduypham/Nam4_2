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
using xNet;

namespace Design_Dashboard_Modern
{
    public partial class QuanLyKhoa : Form
    {
        List<BoMon> bm;
        List<Khoa> listkhoa;
        public QuanLyKhoa()
        {
            InitializeComponent();
            LoadKhoa();
            LoadGVKhoa();
        }

        void LoadKhoa()
        {
            string json = DataProvider.Instance.GetData("https://localhost:5001/api/Khoa");
            listkhoa = JsonConvert.DeserializeObject<List<Khoa>>(json);
            for (int i = 0; i < listkhoa.Count; i++)
            {
                cbKhoa.Items.Add(listkhoa[i].TenKhoa);
            }
        }

        void LoadGVKhoa()
        {
            grKhoa.Rows.Clear();
            grKhoa.Refresh();

            string respons = DataProvider.Instance.GetData("https://localhost:5001/api/Khoa/GetInforKhoa");
            bm = JsonConvert.DeserializeObject<List<BoMon>>(respons);
            for (int i = 0; i < bm.Count; i++)
            {
                grKhoa.Rows.Add(bm[i].IdboMon, bm[i].TenBoMon, bm[i].MonHoc.Count, bm[i].GiangVien.Count);
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
        string idKhoa;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string respons = DataProvider.Instance.GetData("https://localhost:5001/api/Khoa/GetTruongKhoa/" + bm[e.RowIndex].Idkhoa);
            UserInfor gv = JsonConvert.DeserializeObject<UserInfor>(respons);
            if (gv != null)
            {
                tbMaNV.Text = gv.IdgiangVien;
                tbHoTen.Text = gv.TenGiangVien;
                tbChucVu.Text = gv.TenChucVu;
                tbHocHam.Text = gv.HocHamHocVi;
            }
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

        private void btnXoaKhoa_Click(object sender, EventArgs e)
        {
            EditKhoa f = new EditKhoa();
            //f.ShowDialog();
            Blur_Background(f);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg file (*.jpg)|*.jpg|png file |*.png| all file (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    bunifuPictureBox1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra, xin hãy thử lại sau", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Hello");
            //Sự kiện bấm vào một dòng nào đó trong Datagridview từ đó lấy ID khoa
            QuanLyBoMon f = new QuanLyBoMon();
            //f.Show();
            Blur_Background(f);
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            grKhoa.Rows.Clear();
            grKhoa.Refresh();
            string idkhoa = listkhoa[cbKhoa.SelectedIndex].Idkhoa;
            string respons=  DataProvider.Instance.GetData("https://localhost:5001/api/Khoa/GetInforKhoa/"+ idkhoa);
            List<BoMon> bm = JsonConvert.DeserializeObject<List<BoMon>>(respons);          
            for(int i = 0; i<bm.Count; i++)
            {
                grKhoa.Rows.Add(bm[i].IdboMon, bm[i].TenBoMon, bm[i].MonHoc.Count, bm[i].GiangVien.Count);
            }
            respons = DataProvider.Instance.GetData("https://localhost:5001/api/Khoa/GetTruongKhoa/" + idkhoa);
            UserInfor gv = JsonConvert.DeserializeObject<UserInfor>(respons);
            if(gv!=null)
            {
                tbMaNV.Text = gv.IdgiangVien;
                tbHoTen.Text = gv.TenGiangVien;
                tbChucVu.Text = gv.TenChucVu;
                tbHocHam.Text = gv.HocHamHocVi;
            }
        }

        private void QuanLyKhoa_Load(object sender, EventArgs e)
        {

        }
    }
}
