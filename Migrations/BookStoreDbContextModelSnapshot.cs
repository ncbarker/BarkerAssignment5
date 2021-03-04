﻿// <auto-generated />
using BarkerAssignment5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BarkerAssignment5.Migrations
{
    [DbContext(typeof(BookStoreDbContext))]
    partial class BookStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12");

            modelBuilder.Entity("BarkerAssignment5.Models.Project", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AuthFName")
                        .HasColumnType("TEXT");

                    b.Property<string>("AuthLName")
                        .HasColumnType("TEXT");

                    b.Property<string>("BookCat")
                        .HasColumnType("TEXT");

                    b.Property<string>("BookClass")
                        .HasColumnType("TEXT");

                    b.Property<double>("BookPrice")
                        .HasColumnType("REAL");

                    b.Property<string>("BookTitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("ISBN")
                        .HasColumnType("TEXT");

                    b.Property<int>("Pages")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Publisher")
                        .HasColumnType("TEXT");

                    b.HasKey("BookId");

                    b.ToTable("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
