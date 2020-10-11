using Design_Dashboard_Modern;
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
    public partial class Confirm_Report : Form
    {
        List<Don> list;
        private int i = 1;
        public Confirm_Report()
        {
            InitializeComponent();
            list = new List<Don>();
            list.Add(new Don(i++, 20, "DUY", "A", "chưa duyệt","dcm"));
            list.Add(new Don(i++, 20, "HOa", "A", "duyệt", "dcm"));
            list.Add(new Don(i++, 20, "Ngan", "B", "duyệt", "dcm"));
            list.Add(new Don(i++, 20, "tuyet", "B", "chưa duyệt", "dcm"));
            list.Add(new Don(i++, 20, "Nguyet", "C", "chưa duyệt", "dcm"));
            list.Add(new Don(i++, 20, "Van", "D", "chưa duyệt", "dcm"));




        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        string idDon;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tbIdDon.Text = dataGridView1.Rows[e.RowIndex].Cells["soDon"].Value.ToString();
            idDon = tbIdDon.Text;
            dateTimePickerNgayGui.Value = Convert.ToDateTime( dataGridView1.Rows[e.RowIndex].Cells["ngayGui"].Value.ToString());
            cbTrangThai.Text = dataGridView1.Rows[e.RowIndex].Cells["trangThai"].Value.ToString();
            tbNguoiGui.Text = dataGridView1.Rows[e.RowIndex].Cells["tenGV"].Value.ToString();
            cbKhoa.Text = dataGridView1.Rows[e.RowIndex].Cells["khoa"].Value.ToString();
            tbGhiChu.Text = dataGridView1.Rows[e.RowIndex].Cells["ghiChu"].Value.ToString();


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbIdDon.Text = "";
            dateTimePickerNgayGui.Value = DateTime.Now;
            cbTrangThai.Text = "";
            tbGhiChu.Text = "";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
            //MessageBox.Show(textBox2.Text == null ? "0" : "1");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                
                
                if (tbNguoiGui.Text == "" && cbKhoa.Text == "")
                {
                    break;
                }
                if (tbNguoiGui.Text.ToLower() == row.Cells["tenGV"].Value.ToString().ToLower())
                {
                    if(cbKhoa.Text.ToLower() == row.Cells["khoa"].Value.ToString().ToLower()|| cbKhoa.Text == "")
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.White;
                        if (row.Selected == true)
                            row.Selected = false;
                        
                    }
                    
                    
                }
                if (cbKhoa.Text.ToLower() == row.Cells["khoa"].Value.ToString().ToLower() )
                {
                    if(tbNguoiGui.Text.ToLower() == row.Cells["tenGV"].Value.ToString().ToLower()|| tbNguoiGui.Text == "")
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.White;
                        if (row.Selected == true)
                            row.Selected = false;
                       
                    }
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
                
        }
        private void OnChanged_1(object sender, EventArgs e)
        {

        }
        string ten;
        private void textBox2_Click(object sender, EventArgs e)
        {
            ten = tbNguoiGui.Text;
            tbNguoiGui.Text = "";
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tbIdDon.Text = dataGridView1.Rows[e.RowIndex].Cells["soDon"].Value.ToString();
            dateTimePickerNgayGui.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["ngayGui"].Value.ToString());
            cbTrangThai.Text = dataGridView1.Rows[e.RowIndex].Cells["trangThai"].Value.ToString();
            tbNguoiGui.Text = dataGridView1.Rows[e.RowIndex].Cells["tenGV"].Value.ToString();
            cbKhoa.Text = dataGridView1.Rows[e.RowIndex].Cells["khoa"].Value.ToString();
            tbGhiChu.Text = dataGridView1.Rows[e.RowIndex].Cells["ghiChu"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Chưa biêt làm gì cả
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DocWord f = new DocWord();
        }
    }
}
