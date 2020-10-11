using System;
using System.Collections.Generic;

namespace Design_Dashboard_Modern.Models
{
    public partial class MienGiam
    {
        public string IdchucVu { get; set; }
        public int? SoTietGiam { get; set; }

        public virtual ChucVu IdchucVuNavigation { get; set; }
    }
}
