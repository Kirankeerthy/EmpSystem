﻿// <auto-generated />
using System;
using LabDal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LabDal.Migrations
{
    [DbContext(typeof(TestDb1Context))]
    [Migration("20231108105137_v7")]
    partial class v7
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LabDal.ManyCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("ManyCourses");
                });

            modelBuilder.Entity("LabDal.OneCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ToManyStudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ToManyStudentId");

                    b.ToTable("OneCourses");
                });

            modelBuilder.Entity("LabDal.OneStudent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ManyCourseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ManyCourseId");

                    b.ToTable("OneStudents");
                });

            modelBuilder.Entity("LabDal.ToManyStudent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("ToManyStudents");
                });

            modelBuilder.Entity("LabDal.ToOneCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("RelatedToOneStudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RelatedToOneStudentId");

                    b.ToTable("ToOneCompanies");
                });

            modelBuilder.Entity("LabDal.OneCourse", b =>
                {
                    b.HasOne("LabDal.ToManyStudent", null)
                        .WithMany("oneCourses")
                        .HasForeignKey("ToManyStudentId");
                });

            modelBuilder.Entity("LabDal.OneStudent", b =>
                {
                    b.HasOne("LabDal.ManyCourse", null)
                        .WithMany("OneStudents")
                        .HasForeignKey("ManyCourseId");
                });

            modelBuilder.Entity("LabDal.ToOneCompany", b =>
                {
                    b.HasOne("LabDal.OneStudent", "RelatedToOneStudent")
                        .WithMany()
                        .HasForeignKey("RelatedToOneStudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RelatedToOneStudent");
                });

            modelBuilder.Entity("LabDal.ManyCourse", b =>
                {
                    b.Navigation("OneStudents");
                });

            modelBuilder.Entity("LabDal.ToManyStudent", b =>
                {
                    b.Navigation("oneCourses");
                });
#pragma warning restore 612, 618
        }
    }
}
