using System;
using System.Collections.Generic;

namespace Design_Dashboard_Modern.Models
{
    public partial class HuongDanTotNghiep
    {
        public string IdtotNghiep { get; set; }
        public string IdgiangVien { get; set; }
        public string Idkhoa { get; set; }
        public string HoTenSv { get; set; }
        public string KhoaHoc { get; set; }
        public int? SoTietQuyDoi { get; set; }
        public int? SoNguoiHuongDan { get; set; }

        public virtual GiangVien IdgiangVienNavigation { get; set; }
        public virtual Khoa IdkhoaNavigation { get; set; }
    }
}
