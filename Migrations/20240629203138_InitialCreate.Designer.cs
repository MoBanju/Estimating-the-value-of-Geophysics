﻿// <auto-generated />
using Decision_Analisis.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Decision_Analisis.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240629203138_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("Decision_Analisis.Models.NPVResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CalculatedNPV")
                        .HasColumnType("REAL");

                    b.Property<double>("NPVE1")
                        .HasColumnType("REAL");

                    b.Property<double>("NPVE2")
                        .HasColumnType("REAL");

                    b.Property<double>("PE1")
                        .HasColumnType("REAL");

                    b.Property<double>("PE2")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("NPVResults");
                });
#pragma warning restore 612, 618
        }
    }
}