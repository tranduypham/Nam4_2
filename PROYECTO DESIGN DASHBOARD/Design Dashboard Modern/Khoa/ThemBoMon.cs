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
    public partial class ThemBoMon : Form
    {
        public ThemBoMon()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoaKhoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemBoMon_Load(object sender, EventArgs e)
        {

        }
    }
}
