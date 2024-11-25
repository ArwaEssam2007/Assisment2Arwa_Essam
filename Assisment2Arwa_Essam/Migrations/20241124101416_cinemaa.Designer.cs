﻿// <auto-generated />
using System;
using Assisment2Arwa_Essam.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assisment2ArwaEssam.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241124101416_cinemaa")]
    partial class cinemaa
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Assisment2Arwa_Essam.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Assisment2Arwa_Essam.Models.Cinema", b =>
                {
                    b.Property<int>("C_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("C_Id"));

                    b.Property<string>("C_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlaceHolder")
                        .HasColumnType("int");

                    b.HasKey("C_Id");

                    b.ToTable("Cinema");
                });

            modelBuilder.Entity("Assisment2Arwa_Essam.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Category_id")
                        .HasColumnType("int");

                    b.Property<int>("Cinema_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Category_id");

                    b.HasIndex("Cinema_id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Assisment2Arwa_Essam.Models.Movie", b =>
                {
                    b.HasOne("Assisment2Arwa_Essam.Models.Category", "Category")
                        .WithMany("Movies")
                        .HasForeignKey("Category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assisment2Arwa_Essam.Models.Cinema", "Cinema")
                        .WithMany("Movies")
                        .HasForeignKey("Cinema_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Cinema");
                });

            modelBuilder.Entity("Assisment2Arwa_Essam.Models.Category", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("Assisment2Arwa_Essam.Models.Cinema", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
