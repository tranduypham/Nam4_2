using System;
using System.Collections.Generic;

namespace Design_Dashboard_Modern.Models
{
    public partial class BoMon
    {
        public BoMon()
        {
            GiangVien = new HashSet<GiangVien>();
            MonHoc = new HashSet<MonHoc>();
        }

        public string IdboMon { get; set; }
        public string Idkhoa { get; set; }
        public string TenBoMon { get; set; }

        public virtual Khoa IdkhoaNavigation { get; set; }
        public virtual ICollection<GiangVien> GiangVien { get; set; }
        public virtual ICollection<MonHoc> MonHoc { get; set; }
    }
}
