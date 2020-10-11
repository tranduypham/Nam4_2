using System;
using System.Collections.Generic;

namespace Design_Dashboard_Modern.Models
{
    public partial class ChucVu
    {
        public ChucVu()
        {
            GiangVien = new HashSet<GiangVien>();
        }

        public string IdchucVu { get; set; }
        public string TenChucVu { get; set; }

        public virtual MienGiam MienGiam { get; set; }
        public virtual ICollection<GiangVien> GiangVien { get; set; }
    }
}
