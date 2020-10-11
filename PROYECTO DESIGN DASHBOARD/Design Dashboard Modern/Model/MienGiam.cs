using System;
using System.Collections.Generic;

namespace QLGV.Models
{
    public partial class MienGiam
    {
        public string IdchucVu { get; set; }
        public int? SoTietGiam { get; set; }

        public virtual ChucVu IdchucVuNavigation { get; set; }
    }
}
