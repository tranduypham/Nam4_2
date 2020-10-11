using System;
using System.Collections.Generic;

namespace Design_Dashboard_Modern.Models
{
    public partial class Khoa
    {
        public Khoa()
        {
            BoMon = new HashSet<BoMon>();
            GiangVien = new HashSet<GiangVien>();
            HuongDanTotNghiep = new HashSet<HuongDanTotNghiep>();
        }

        public string Idkhoa { get; set; }
        public string TenKhoa { get; set; }

        public virtual ICollection<BoMon> BoMon { get; set; }
        public virtual ICollection<GiangVien> GiangVien { get; set; }
        public virtual ICollection<HuongDanTotNghiep> HuongDanTotNghiep { get; set; }
    }
}
