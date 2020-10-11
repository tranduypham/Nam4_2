using System;
using System.Collections.Generic;

namespace QLGV.Models
{
    public partial class MonHoc
    {
        public MonHoc()
        {
            GiangDay = new HashSet<GiangDay>();
        }

        public string IdmonHoc { get; set; }
        public string Idbomon { get; set; }
        public string TenMonHoc { get; set; }
        public int? SoTietQc { get; set; }
        public int? SoTietTg { get; set; }
        public int? DonViHocTrinh { get; set; }

        public virtual BoMon IdbomonNavigation { get; set; }
        public virtual ICollection<GiangDay> GiangDay { get; set; }
    }
}
