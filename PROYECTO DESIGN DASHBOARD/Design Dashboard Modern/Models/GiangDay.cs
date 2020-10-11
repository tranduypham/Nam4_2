using System;
using System.Collections.Generic;

namespace Design_Dashboard_Modern.Models
{
    public partial class GiangDay
    {
        public string IdgiangDay { get; set; }
        public string IdgiangVien { get; set; }
        public string IdmonHoc { get; set; }
        public int? HocKy { get; set; }
        public string Lop { get; set; }
        public int? NamHoc { get; set; }

        public virtual GiangVien IdgiangVienNavigation { get; set; }
        public virtual MonHoc IdmonHocNavigation { get; set; }
    }
}
