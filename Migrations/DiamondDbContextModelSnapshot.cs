﻿// <auto-generated />
using System;
using DiamondApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DiamondApi.Migrations
{
    [DbContext(typeof(DiamondDbContext))]
    partial class DiamondDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DiamondApi.Models.Diamond", b =>
                {
                    b.Property<int>("DiamondId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiamondCarat")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("DiamondColor")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int?>("DiamondImageId")
                        .HasColumnType("int");

                    b.Property<int>("DiamondPrice")
                        .HasColumnType("int");

                    b.Property<string>("DiamondShape")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("DiamondType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DiamondId");

                    b.HasIndex("DiamondImageId");

                    b.ToTable("Diamond");
                });

            modelBuilder.Entity("DiamondApi.Models.DiamondImage", b =>
                {
                    b.Property<int>("DiamondImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiamondFrontImage")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("DiamondSideImage")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("DiamondTopImage")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("DiamondImageId");

                    b.ToTable("DiamondImage");
                });

            modelBuilder.Entity("DiamondApi.Models.Retailer", b =>
                {
                    b.Property<int>("RetailerId")
                        .HasColumnType("int");

                    b.Property<string>("RetailerName")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("RetailerId");

                    b.ToTable("Retailer");
                });

            modelBuilder.Entity("DiamondApi.Models.Diamond", b =>
                {
                    b.HasOne("DiamondApi.Models.DiamondImage", "DiamondImage")
                        .WithMany()
                        .HasForeignKey("DiamondImageId");
                });

            modelBuilder.Entity("DiamondApi.Models.Retailer", b =>
                {
                    b.HasOne("DiamondApi.Models.Diamond", "Diamond")
                        .WithOne("RetailerDetails")
                        .HasForeignKey("DiamondApi.Models.Retailer", "RetailerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
