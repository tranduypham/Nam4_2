using System;
using System.Collections.Generic;

namespace QLGV.Models
{
    public partial class ListGiangvienBomon
    {
        public string IdboMon { get; set; }
        public string IdgiangVien { get; set; }

        public virtual BoMon IdboMonNavigation { get; set; }
        public virtual GiangVien IdgiangVienNavigation { get; set; }
    }
}
