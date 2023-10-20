﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PNLS.Edusystem.Models;

#nullable disable

namespace PNLS.Edusystem.Migrations
{
    [DbContext(typeof(AdminDbcontext))]
    [Migration("20231018160103_initwork")]
    partial class initwork
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PNLS.Edusystem.Models.AdMin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasColumnName("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasColumnName("Password");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasColumnName("Phone");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasColumnName("UserName");

                    b.HasKey("Id");

                    b.ToTable("adMinsTable");
                });

            modelBuilder.Entity("PNLS.Edusystem.Models.Docter", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Hospetalroom")
                        .IsRequired()
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Name");

                    b.Property<string>("Speclist")
                        .IsRequired()
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Name");

                    b.Property<string>("description")
                        .IsRequired()
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Name");

                    b.Property<string>("name")
                        .IsRequired()
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Name");

                    b.HasKey("id");

                    b.ToTable("doctertable");
                });

            modelBuilder.Entity("PNLS.Edusystem.Models.StudentsRecod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Adress");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasColumnName("City");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Country");

                    b.Property<string>("Deparment")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Deparment");

                    b.Property<string>("Distrit")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Distrit");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("varchar(8)")
                        .HasColumnName("Gender");

                    b.Property<DateTime>("Joindate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Level");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("varchar(13)")
                        .HasColumnName("Mobile");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Name");

                    b.Property<string>("fatherName")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("fatherName");

                    b.Property<int>("fee")
                        .HasColumnType("int");

                    b.Property<string>("provence")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("provence");

                    b.HasKey("Id");

                    b.ToTable("studentsTable");
                });
#pragma warning restore 612, 618
        }
    }
}
