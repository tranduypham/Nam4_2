using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QLGV.Models
{
    public partial class QLGVContext : DbContext
    {
        public QLGVContext()
        {
        }

        public QLGVContext(DbContextOptions<QLGVContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BoMon> BoMon { get; set; }
        public virtual DbSet<ChucVu> ChucVu { get; set; }
        public virtual DbSet<GiangDay> GiangDay { get; set; }
        public virtual DbSet<GiangVien> GiangVien { get; set; }
        public virtual DbSet<HuongDanTotNghiep> HuongDanTotNghiep { get; set; }
        public virtual DbSet<Khoa> Khoa { get; set; }
        public virtual DbSet<ListGiangvienBomon> ListGiangvienBomon { get; set; }
        public virtual DbSet<MienGiam> MienGiam { get; set; }
        public virtual DbSet<MonHoc> MonHoc { get; set; }
        public virtual DbSet<NghienCucKhoaHoc> NghienCucKhoaHoc { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-J28KA02;Initial Catalog=QLGV;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoMon>(entity =>
            {
                entity.HasKey(e => e.IdboMon)
                    .HasName("PK__BoMon__308562872F866574");

                entity.Property(e => e.IdboMon)
                    .HasColumnName("IDBoMon")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Idkhoa)
                    .HasColumnName("IDKhoa")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdkhoaNavigation)
                    .WithMany(p => p.BoMon)
                    .HasForeignKey(d => d.Idkhoa)
                    .HasConstraintName("FK__BoMon__IDKhoa__267ABA7A");
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.HasKey(e => e.IdchucVu)
                    .HasName("PK__ChucVu__70FCCF652E94D802");

                entity.Property(e => e.IdchucVu)
                    .HasColumnName("IDChucVu")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TenChucVu).HasMaxLength(50);
            });

            modelBuilder.Entity<GiangDay>(entity =>
            {
                entity.HasKey(e => e.IdgiangDay)
                    .HasName("PK__GiangDay__7428D2F390E6BB4F");

                entity.Property(e => e.IdgiangDay)
                    .HasColumnName("IDGiangDay")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdgiangVien)
                    .HasColumnName("IDGiangVien")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdmonHoc)
                    .HasColumnName("IDMonHoc")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Lop).HasMaxLength(5);

                entity.HasOne(d => d.IdgiangVienNavigation)
                    .WithMany(p => p.GiangDay)
                    .HasForeignKey(d => d.IdgiangVien)
                    .HasConstraintName("FK__GiangDay__IDGian__398D8EEE");

                entity.HasOne(d => d.IdmonHocNavigation)
                    .WithMany(p => p.GiangDay)
                    .HasForeignKey(d => d.IdmonHoc)
                    .HasConstraintName("FK__GiangDay__IDMonH__3A81B327");
            });

            modelBuilder.Entity<GiangVien>(entity =>
            {
                entity.HasKey(e => e.IdgiangVien)
                    .HasName("PK__GiangVie__EA9BCA1C5024BC6A");

                entity.Property(e => e.IdgiangVien)
                    .HasColumnName("IDGiangVien")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType).HasColumnName("Account_type");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GioiTinh).HasMaxLength(4);

                entity.Property(e => e.IdBoMon)
                    .HasColumnName("idBoMon")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdchucVu)
                    .HasColumnName("IDChucVu")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Idkhoa)
                    .HasColumnName("IDKhoa")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.Pass).HasDefaultValueSql("('1')");

                entity.Property(e => e.TenGiangVien).HasMaxLength(60);

                entity.HasOne(d => d.IdBoMonNavigation)
                    .WithMany(p => p.GiangVien)
                    .HasForeignKey(d => d.IdBoMon)
                    .HasConstraintName("FK__GiangVien__idBoM__5AEE82B9");

                entity.HasOne(d => d.IdchucVuNavigation)
                    .WithMany(p => p.GiangVien)
                    .HasForeignKey(d => d.IdchucVu)
                    .HasConstraintName("FK__GiangVien__IDChu__32E0915F");

                entity.HasOne(d => d.IdkhoaNavigation)
                    .WithMany(p => p.GiangVien)
                    .HasForeignKey(d => d.Idkhoa)
                    .HasConstraintName("FK__GiangVien__IDKho__52593CB8");
            });

            modelBuilder.Entity<HuongDanTotNghiep>(entity =>
            {
                entity.HasKey(e => e.IdtotNghiep)
                    .HasName("PK__HuongDan__D79ADF8CC2AACADE");

                entity.Property(e => e.IdtotNghiep)
                    .HasColumnName("IDTotNghiep")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.HoTenSv).HasColumnName("HoTenSV");

                entity.Property(e => e.IdgiangVien)
                    .HasColumnName("IDGiangVien")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Idkhoa)
                    .HasColumnName("IDKhoa")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.KhoaHoc).HasMaxLength(5);

                entity.HasOne(d => d.IdgiangVienNavigation)
                    .WithMany(p => p.HuongDanTotNghiep)
                    .HasForeignKey(d => d.IdgiangVien)
                    .HasConstraintName("FK__HuongDanT__IDGia__47DBAE45");

                entity.HasOne(d => d.IdkhoaNavigation)
                    .WithMany(p => p.HuongDanTotNghiep)
                    .HasForeignKey(d => d.Idkhoa)
                    .HasConstraintName("FK__HuongDanT__IDKho__48CFD27E");
            });

            modelBuilder.Entity<Khoa>(entity =>
            {
                entity.HasKey(e => e.Idkhoa)
                    .HasName("PK__Khoa__FF52374855EB6B4E");

                entity.Property(e => e.Idkhoa)
                    .HasColumnName("IDkhoa")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TenKhoa).HasMaxLength(30);
            });

            modelBuilder.Entity<ListGiangvienBomon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("List_Giangvien_Bomon");

                entity.Property(e => e.IdboMon)
                    .HasColumnName("IDBoMon")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdgiangVien)
                    .HasColumnName("IDGiangVien")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdboMonNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdboMon)
                    .HasConstraintName("FK__List_Gian__IDBoM__5070F446");

                entity.HasOne(d => d.IdgiangVienNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdgiangVien)
                    .HasConstraintName("FK__List_Gian__IDGia__5165187F");
            });

            modelBuilder.Entity<MienGiam>(entity =>
            {
                entity.HasKey(e => e.IdchucVu)
                    .HasName("PK__MienGiam__70FCCF65DC280F93");

                entity.Property(e => e.IdchucVu)
                    .HasColumnName("IDChucVu")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdchucVuNavigation)
                    .WithOne(p => p.MienGiam)
                    .HasForeignKey<MienGiam>(d => d.IdchucVu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MienGiam__IDChuc__412EB0B6");
            });

            modelBuilder.Entity<MonHoc>(entity =>
            {
                entity.HasKey(e => e.IdmonHoc)
                    .HasName("PK__MonHoc__5A37850A8CDC63C7");

                entity.Property(e => e.IdmonHoc)
                    .HasColumnName("IDMonHoc")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Idbomon)
                    .HasColumnName("IDBomon")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SoTietQc).HasColumnName("SoTietQC");

                entity.Property(e => e.SoTietTg).HasColumnName("SoTietTG");

                entity.HasOne(d => d.IdbomonNavigation)
                    .WithMany(p => p.MonHoc)
                    .HasForeignKey(d => d.Idbomon)
                    .HasConstraintName("FK__MonHoc__IDBomon__29572725");
            });

            modelBuilder.Entity<NghienCucKhoaHoc>(entity =>
            {
                entity.HasKey(e => e.IdnghienCuu)
                    .HasName("PK__NghienCu__7AFD72525C8516A9");

                entity.Property(e => e.IdnghienCuu)
                    .HasColumnName("IDNghienCuu")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdgiangVien)
                    .HasColumnName("IDGiangVien")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdgiangVienNavigation)
                    .WithMany(p => p.NghienCucKhoaHoc)
                    .HasForeignKey(d => d.IdgiangVien)
                    .HasConstraintName("FK__NghienCuc__IDGia__4BAC3F29");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
