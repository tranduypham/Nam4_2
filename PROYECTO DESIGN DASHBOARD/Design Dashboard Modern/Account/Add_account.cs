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
    public partial class Add_account : Form
    {
        public Add_account()
        {
            InitializeComponent();
            LoadChucVu();
            LoadKhoa();
        }
        List<ChucVu> listcv;
        List<Khoa> listkhoa;
        private string gender;

        public string Gender { get => gender; set => gender = value; }

        void LoadChucVu()
        {
            string respons = DataProvider.Instance.GetData("https://localhost:5001/api/ChucVu");
            listcv = JsonConvert.DeserializeObject<List<ChucVu>>(respons.ToString());
            for (int i = 0; i < listcv.Count; i++)
            {
                cbChucVu.Items.Add(listcv[i].TenChucVu);
            }
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
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            GiangVien gv = new GiangVien();
            gv.IdgiangVien = tbMaNV.Text;
            gv.TenGiangVien = tbTen.Text;
            gv.IdchucVu = listcv[cbChucVu.SelectedIndex].IdchucVu;
            gv.Idkhoa = listkhoa[cbKhoa.SelectedIndex].Idkhoa;
            gv.NgaySinh = ngaysinh.Value;
            gv.GioiTinh = Gender;
            gv.HocHamHocVi = cbHocHam.Text;
            gv.LuongThucNhan = tbHeSoLuong.Text;
            string response = DataProvider.Instance.PostData("https://localhost:5001/api/giangvien/ThemGiangVien", JsonConvert.SerializeObject(gv));
            MessageBox.Show(response);
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if(radio.Checked)
            {
                this.Gender = radio.Text;
            }
        }
    }
}