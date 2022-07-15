﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using app.Models;

#nullable disable

namespace app.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20220715183136_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("app.Models.Product", b =>
                {
                    b.Property<int>("ProductCode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<float>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("ProductCode");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductCode = 82621,
                            Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                            ImageName = "82621.jpg",
                            Name = "بوت بوفالو",
                            Price = 285000f
                        },
                        new
                        {
                            ProductCode = 45246,
                            Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                            ImageName = "45246.jpg",
                            Name = "ونس",
                            Price = 220000f
                        },
                        new
                        {
                            ProductCode = 62183,
                            Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                            ImageName = "62183.jpg",
                            Name = "ایرجردن وان",
                            Price = 360000f
                        },
                        new
                        {
                            ProductCode = 87239,
                            Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                            ImageName = "87239.jpg",
                            Name = "نایک",
                            Price = 250000f
                        },
                        new
                        {
                            ProductCode = 94850,
                            Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                            ImageName = "94850.jpg",
                            Name = "کالج پازلی",
                            Price = 180000f
                        },
                        new
                        {
                            ProductCode = 41234,
                            Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                            ImageName = "41234.jpg",
                            Name = "نیم بوت",
                            Price = 398000f
                        },
                        new
                        {
                            ProductCode = 64368,
                            Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                            ImageName = "64368.jpg",
                            Name = "سئول",
                            Price = 265000f
                        },
                        new
                        {
                            ProductCode = 12357,
                            Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                            ImageName = "12357.jpg",
                            Name = "بوت دکتر مارتنز",
                            Price = 410000f
                        },
                        new
                        {
                            ProductCode = 78940,
                            Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                            ImageName = "78940.jpg",
                            Name = "ایرفورس وان",
                            Price = 310000f
                        },
                        new
                        {
                            ProductCode = 67830,
                            Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                            ImageName = "67830.jpg",
                            Name = "استن اسمیت",
                            Price = 330000f
                        },
                        new
                        {
                            ProductCode = 29604,
                            Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                            ImageName = "29604.jpg",
                            Name = "تکنو",
                            Price = 320000f
                        },
                        new
                        {
                            ProductCode = 146097,
                            Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                            ImageName = "146097.jpg",
                            Name = "نیوبالانس",
                            Price = 320000f
                        });
                });
#pragma warning restore 612, 618
        }
    }
}