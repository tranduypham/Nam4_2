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
    public partial class Management_Account : Form
    {
        public Management_Account()
        {
            InitializeComponent();
            LoadKhoa();
            LoadGiangVien();
        }
        List<Khoa> listkhoa;
        List<UserInfor> listUser;
        void LoadKhoa()
        {
            string json = DataProvider.Instance.GetData("https://localhost:5001/api/Khoa");
            listkhoa = JsonConvert.DeserializeObject<List<Khoa>>(json);
            for (int i = 0; i < listkhoa.Count; i++)
            {
                cbKhoa.Items.Add(listkhoa[i].TenKhoa);
            }

        }

        void LoadGiangVien()
        {
            string json = DataProvider.Instance.GetData("https://localhost:5001/api/ListGiangVien");
            listUser = JsonConvert.DeserializeObject<List<UserInfor>>(json);
            for (int i = 0; i < listUser.Count; i++)
            {
                grAccount.Rows.Add(i+1, listUser[i].TenGiangVien, listUser[i].IdgiangVien, listUser[i].TenChucVu);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow dt = dataGridViewAccount.Rows[e.RowIndex];
            //tbChucVu.Text = dt.Cells["Chucvu"].Value.ToString();
            //tbUpdate.Text = dt.Cells["date"].Value.ToString();
            //tbSoNgayNghi.Text = dt.Cells["duocNghi"].Value.ToString();
            //tbDaNghi.Text = dt.Cells["daNghi"].Value.ToString();
            //tbTrangThai.Text = dt.Cells["trangThai"].Value.ToString();
            //tbHocHam.Text = dt.Cells["hocHam"].Value.ToString();
            //tbHocHam.Text = dt.Cells["taiKhoan"].Value.ToString();
            //tbHoTen.Text = dt.Cells["Hovaten"].Value.ToString();
            //tbMaNV.Text = dt.Cells["MaGV"].Value.ToString();
            //MessageBox.Show(e.RowIndex.ToString());
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

        private void button2_Click(object sender, EventArgs e)
        {
            Add_account add = new Add_account();
            //add.Show();
            Blur_Background(add);
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            grAccount.Rows.Clear();
            grAccount.Refresh();
            string idkhoa = listkhoa[cbKhoa.SelectedIndex].Idkhoa;
            string respons = DataProvider.Instance.GetData("https://localhost:5001/api/ListGiangVien/" + idkhoa);
            listUser = JsonConvert.DeserializeObject<List<UserInfor>>(respons);
            if(listUser!=null)
            {
                for (int i = 0; i < listUser.Count; i++)
                {
                    grAccount.Rows.Add(i + 1, listUser[i].TenGiangVien, listUser[i].IdgiangVien, listUser[i].TenChucVu);
                }
            }
            
        }
        



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Management_Account_ResizeEnd(object sender, EventArgs e)
        {

        }

        private void Management_Account_ResizeBegin(object sender, EventArgs e)
        {

        }

        private void Management_Account_Resize(object sender, EventArgs e)
        {

        }

        private void Management_Account_ParentChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            grAccount.Rows.Clear();
            grAccount.Refresh();
            if (checkOnlyFemale.Checked)
            {
                for (int i = 0; i < listUser.Count; i++)
                {
                    if (listUser[i].GioiTinh.Equals("Nữ"))
                    {
                        grAccount.Rows.Add(i + 1, listUser[i].TenGiangVien, listUser[i].IdgiangVien, listUser[i].TenChucVu);
                    }
                }
            }
        }

        private void dataGridViewAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMaNV.Text = listUser[e.RowIndex].IdgiangVien;
            tbHoTen.Text = listUser[e.RowIndex].TenGiangVien;
            tbChucVu.Text = listUser[e.RowIndex].TenChucVu;
            tbHocHam.Text = listUser[e.RowIndex].HocHamHocVi;
        }

        private void checkOnlyMale_CheckedChanged(object sender, EventArgs e)
        {
            grAccount.Rows.Clear();
            grAccount.Refresh();
            if (checkOnlyMale.Checked)
            {
                for(int i=0;i<listUser.Count;i++)
                {
                    if(listUser[i].GioiTinh.Equals("Nam"))
                    {
                        grAccount.Rows.Add(i + 1, listUser[i].TenGiangVien, listUser[i].IdgiangVien, listUser[i].TenChucVu);
                    }           
                }
            }
        }
    }
}
