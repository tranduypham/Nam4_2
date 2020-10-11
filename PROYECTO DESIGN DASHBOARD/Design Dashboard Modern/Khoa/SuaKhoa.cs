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
    public partial class SuaKhoa : Form
    {
        public SuaKhoa(string idKhoa)
        {
            InitializeComponent();
            LoadKhoa();
        }
        List<Khoa> listkhoa;
        void LoadKhoa()
        {
            
            string json = DataProvider.Instance.GetData("https://localhost:5001/api/Khoa");
            listkhoa = JsonConvert.DeserializeObject<List<Khoa>>(json);
            for (int i = 0; i < listkhoa.Count; i++)
            {
                cbKhoa.Items.Add(listkhoa[i].TenKhoa + " - " + listkhoa[i].Idkhoa);
            }

        }



        private void SuaKhoa_Load(object sender, EventArgs e)
        {

        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTenKhoa.Text = listkhoa[cbKhoa.SelectedIndex].TenKhoa;
        }

        private void btnLuuSuaKhoa_Click(object sender, EventArgs e)
        {
            Khoa khoa = new Khoa();
            khoa.Idkhoa = listkhoa[cbKhoa.SelectedIndex].Idkhoa;
            khoa.TenKhoa = tbTenKhoa.Text;
            string respons = DataProvider.Instance.PostData("https://localhost:5001/api/Khoa/ChangeInforKhoa", JsonConvert.SerializeObject(khoa));
            if (respons.Equals("true"))
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }

            this.Close();



        }

        private void btnThoatSuaKhoa_Click(object sender, EventArgs e)
        {

        }
    }
}
