﻿// <auto-generated />
using System;
using MegaDesk_ASP.NET_Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MegaDesk_ASP.NET_Core.Migrations
{
    [DbContext(typeof(MegaDesk_ASPNET_CoreContext))]
    partial class MegaDesk_ASPNET_CoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("MegaDesk_ASP.NET_Core.Models.DeskQuote", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Depth")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumberOfDrawers")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuoteAmount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RushDays")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SurfaceMaterial")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Width")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("orderedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("DeskQuote");
                });
#pragma warning restore 612, 618
        }
    }
}
