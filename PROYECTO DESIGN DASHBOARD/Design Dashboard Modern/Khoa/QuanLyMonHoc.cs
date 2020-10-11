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
    public partial class QuanLyMonHoc : Form
    {
        public QuanLyMonHoc(string idMonHoc)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string idGiangVien;


        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Xóa Giảng Viên " + idGiangVien, "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                return;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idGiangVien = dataGridView1.Rows[e.RowIndex].Cells["maGiangVien"].Value == null ? "0" : dataGridView1.Rows[e.RowIndex].Cells["maGiangVien"].Value.ToString();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuanLyMonHoc_Load(object sender, EventArgs e)
        {

        }
    }
}
