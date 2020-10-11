using System;
using System.Collections.Generic;

namespace Design_Dashboard_Modern.Models
{
    public partial class GiangVien
    {
        public GiangVien()
        {
            GiangDay = new HashSet<GiangDay>();
            HuongDanTotNghiep = new HashSet<HuongDanTotNghiep>();
            NghienCucKhoaHoc = new HashSet<NghienCucKhoaHoc>();
        }

        public string IdgiangVien { get; set; }
        public string IdchucVu { get; set; }
        public string TenGiangVien { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Email { get; set; }
        public string LuongThucNhan { get; set; }
        public string HocHamHocVi { get; set; }
        public string Idkhoa { get; set; }
        public string Pass { get; set; }
        public int? AccountType { get; set; }
        public string IdBoMon { get; set; }

        public virtual BoMon IdBoMonNavigation { get; set; }
        public virtual ChucVu IdchucVuNavigation { get; set; }
        public virtual Khoa IdkhoaNavigation { get; set; }
        public virtual ICollection<GiangDay> GiangDay { get; set; }
        public virtual ICollection<HuongDanTotNghiep> HuongDanTotNghiep { get; set; }
        public virtual ICollection<NghienCucKhoaHoc> NghienCucKhoaHoc { get; set; }
    }
}
