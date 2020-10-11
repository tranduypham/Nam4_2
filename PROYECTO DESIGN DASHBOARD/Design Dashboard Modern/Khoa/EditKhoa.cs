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
    public partial class EditKhoa : Form
    {
        public EditKhoa()
        {
            InitializeComponent();
            LoadKhoa();
        }

        void LoadKhoa()
        {
            List<Khoa> listkhoa;
            string json = DataProvider.Instance.GetData("https://localhost:5001/api/Khoa");
            listkhoa = JsonConvert.DeserializeObject<List<Khoa>>(json);
            for (int i = 0; i < listkhoa.Count; i++)
            {
                string respons = DataProvider.Instance.GetData("https://localhost:5001/api/Khoa/GetTruongKhoa/" + listkhoa[i].Idkhoa);
                
                   
                if(respons == "")
                    grKhoa.Rows.Add(listkhoa[i].Idkhoa, listkhoa[i].TenKhoa,"null");
                else
                {
                    UserInfor gv = JsonConvert.DeserializeObject<UserInfor>(respons);
                    grKhoa.Rows.Add(listkhoa[i].Idkhoa, listkhoa[i].TenKhoa, gv.IdgiangVien);
                }
                    
            }

        }

        private string idKhoa;
        string tenKhoa;

        public string IdKhoa { get => idKhoa; set => idKhoa = value; }

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
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuaKhoa_Click(object sender, EventArgs e)
        {
            //Có cái idkhoa ở trên nó lưu các giá trị mã khoa ấn khi ấn vào
            SuaKhoa f = new SuaKhoa(IdKhoa);
            //f.ShowDialog();
            Blur_Background(f);
        }

        private void btnXoaKhoa_Click(object sender, EventArgs e)
        {
            //Có cái idkhoa ở trên nó lưu các giá trị mã khoa ấn khi ấn vào
            if(MessageBox.Show("Có chăc muốn xóa khoa "+ tenKhoa,"Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string response = DataProvider.Instance.GetData("https://localhost:5001/api/Khoa/XoaKhoa/" + IdKhoa);
                if(response.Equals("true"))
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
            else
            {
                return;
            }
        }

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            
        }

        private void EditKhoa_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnSuaKhoa.Enabled = true;
            IdKhoa = grKhoa.Rows[e.RowIndex].Cells["maKhoa"].Value.ToString();
            tenKhoa = grKhoa.Rows[e.RowIndex].Cells["ten_Khoa"].Value.ToString();
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            btnSuaKhoa.Enabled = false;
        }

        private void btnThemKhoa_Click_1(object sender, EventArgs e)
        {
            ThemKhoa f = new ThemKhoa();
            //f.ShowDialog();
            Blur_Background(f);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btRefesh_Click(object sender, EventArgs e)
        {
            grKhoa.Rows.Clear();
            grKhoa.Refresh();
            LoadKhoa();
        }
    }
}
