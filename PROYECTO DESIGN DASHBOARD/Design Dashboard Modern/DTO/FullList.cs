using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Dashboard_Modern.DTO
{
    public class ListKhoa
    {
        public string ID { get; set; }
        public string TenKhoa { get; set; }
    }

    public class ListBoMon
    {
        public string TenBoMon { get; set; }
        public string IDKhoa { get; set; }
        public string IDBoMon { get; set; }
    }

    public class ListMonHoc
    {
        public string IDMonHoc { get; set; }
        public string IDBoMon { get; set; }
        public string TenMonHoc { get; set; }
        public int SoTietQC { get; set; }
        public int SoTietTG { get; set; }
        public int DonViHocTrinh { get; set; }
    }

    public class FullList
    {
        public List<ListKhoa> ListKhoa { get; set; }
        public List<ListBoMon> ListBoMon { get; set; }
        public List<ListMonHoc> ListMonHoc { get; set; }
    }

}
