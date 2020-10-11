using System;
using System.Collections.Generic;

namespace Design_Dashboard_Modern.Models
{
    public partial class NghienCucKhoaHoc
    {
        public string IdnghienCuu { get; set; }
        public string IdgiangVien { get; set; }

        public virtual GiangVien IdgiangVienNavigation { get; set; }
    }
}
