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
    public partial class EditMonHoc : Form
    {
        public EditMonHoc()
        {
            InitializeComponent();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Có chắc muốn xóa môn" + idMonHoc, "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                return;
            }
            else
            {
                e.Cancel = true;
            }
        }
        string idMonHoc;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idMonHoc = dataGridView1.Rows[e.RowIndex].Cells["maMonHoc"].Value.ToString().Trim();
        }

        private void EditMonHoc_Load(object sender, EventArgs e)
        {

        }

        private void btnXoaKhoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
