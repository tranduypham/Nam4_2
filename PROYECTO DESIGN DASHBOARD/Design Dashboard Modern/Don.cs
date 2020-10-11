using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Design_Dashboard_Modern
{
    class Don
    {
        public int so_don { get; set; }
        public int so_tiet { get; set; }
        public string ten { get; set; }
        public string khoa { get; set; }
        public string ngay_gui { get; set; }
        public string trang_thai { get; set; }
        public string ghi_chu { get; set; }

        static int i = 0;
        public Don(int so_don, int so_tiet, string ten, string khoa, string trang_thai, string ghi_chu)
        {
            this.so_don = so_don;
            this.so_tiet = so_tiet;
            this.ten = ten;
            this.ngay_gui = DateTime.Now.AddDays(i).ToString("d");
            i++;
            this.trang_thai = trang_thai;
            this.khoa = khoa;
            this.ghi_chu = ghi_chu;
        }
    }
}