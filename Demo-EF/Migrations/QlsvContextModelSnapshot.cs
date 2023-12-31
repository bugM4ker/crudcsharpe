﻿// <auto-generated />
using System;
using Demo_EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Demo_EF.Migrations
{
    [DbContext(typeof(QlsvContext))]
    partial class QlsvContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Demo_EF.Models.Detai", b =>
                {
                    b.Property<string>("MaDt")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("MaDT")
                        .IsFixedLength();

                    b.Property<decimal?>("KinhPhi")
                        .HasColumnType("numeric(10, 0)");

                    b.Property<string>("NoiThucTap")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenDt")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TenDT");

                    b.HasKey("MaDt");

                    b.ToTable("DETAI");
                });

            modelBuilder.Entity("Demo_EF.Models.Giangvien", b =>
                {
                    b.Property<int>("MaGv")
                        .HasColumnType("int")
                        .HasColumnName("MaGV");

                    b.Property<decimal?>("Luong")
                        .HasColumnType("numeric(10, 0)");

                    b.Property<string>("MaKhoa")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("char(5)")
                        .IsFixedLength();

                    b.Property<string>("TenGv")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenGV");

                    b.HasKey("MaGv");

                    b.ToTable("GIANGVIEN");
                });

            modelBuilder.Entity("Demo_EF.Models.Huongdan", b =>
                {
                    b.Property<int>("MaSv")
                        .HasColumnType("int")
                        .HasColumnName("MaSV");

                    b.Property<int>("MaGv")
                        .HasColumnType("int")
                        .HasColumnName("MaGV");

                    b.Property<string>("MaDt")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("MaDT")
                        .IsFixedLength();

                    b.Property<decimal?>("KetQua")
                        .HasColumnType("decimal(5, 2)");

                    b.HasKey("MaSv", "MaGv", "MaDt");

                    b.HasIndex("MaDt");

                    b.HasIndex("MaGv");

                    b.ToTable("HUONGDAN");
                });

            modelBuilder.Entity("Demo_EF.Models.Khoa", b =>
                {
                    b.Property<string>("MaKhoa")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("char(5)")
                        .IsFixedLength();

                    b.Property<string>("Filter")
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasComputedColumnSql("LOWER([MaKhoa] + [TenKhoa] + [SDT])");

                    b.Property<string>("Sdt")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("SDT")
                        .IsFixedLength();

                    b.Property<string>("TenKhoa")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaKhoa");

                    b.ToTable("KHOA");
                });

            modelBuilder.Entity("Demo_EF.Models.Sinhvien", b =>
                {
                    b.Property<int>("MaSv")
                        .HasColumnType("int")
                        .HasColumnName("MaSV");

                    b.Property<string>("GioiTinh")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .IsFixedLength();

                    b.Property<string>("MaKhoa")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("char(5)")
                        .IsFixedLength();

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("date");

                    b.Property<string>("TenSv")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenSV");

                    b.HasKey("MaSv");

                    b.HasIndex("MaKhoa");

                    b.ToTable("SINHVIEN");
                });

            modelBuilder.Entity("Demo_EF.Models.Huongdan", b =>
                {
                    b.HasOne("Demo_EF.Models.Detai", "MaDtNavigation")
                        .WithMany("Huongdans")
                        .HasForeignKey("MaDt")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_HUONGDAN_DETAI");

                    b.HasOne("Demo_EF.Models.Giangvien", "MaGvNavigation")
                        .WithMany("Huongdans")
                        .HasForeignKey("MaGv")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_HUONGDAN_GIANGVIEN");

                    b.HasOne("Demo_EF.Models.Sinhvien", "MaSvNavigation")
                        .WithMany("Huongdans")
                        .HasForeignKey("MaSv")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_HUONGDAN_SINHVIEN");

                    b.Navigation("MaDtNavigation");

                    b.Navigation("MaGvNavigation");

                    b.Navigation("MaSvNavigation");
                });

            modelBuilder.Entity("Demo_EF.Models.Sinhvien", b =>
                {
                    b.HasOne("Demo_EF.Models.Khoa", "MaKhoaNavigation")
                        .WithMany("Sinhviens")
                        .HasForeignKey("MaKhoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FK_SINHVIEN_KHOA");

                    b.Navigation("MaKhoaNavigation");
                });

            modelBuilder.Entity("Demo_EF.Models.Detai", b =>
                {
                    b.Navigation("Huongdans");
                });

            modelBuilder.Entity("Demo_EF.Models.Giangvien", b =>
                {
                    b.Navigation("Huongdans");
                });

            modelBuilder.Entity("Demo_EF.Models.Khoa", b =>
                {
                    b.Navigation("Sinhviens");
                });

            modelBuilder.Entity("Demo_EF.Models.Sinhvien", b =>
                {
                    b.Navigation("Huongdans");
                });
#pragma warning restore 612, 618
        }
    }
}
