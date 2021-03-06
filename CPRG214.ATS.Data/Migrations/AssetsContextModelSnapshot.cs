﻿// <auto-generated />
using CPRG214.ATS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CPRG214.ATS.Data.Migrations
{
    [DbContext(typeof(AssetsContext))]
    partial class AssetsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CPRG214.ATS.Domain.Asset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssetTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TagNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AssetTypeId");

                    b.ToTable("Asset");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AssetTypeId = 1,
                            Description = "Boardroom Computer",
                            Manufacturer = "Dell",
                            SerialNumber = "CN-00FFXD-74261-3AB-1KFS",
                            TagNumber = "ASSET-0001"
                        },
                        new
                        {
                            Id = 2,
                            AssetTypeId = 2,
                            Description = "Entrance Monitor",
                            Manufacturer = "LG",
                            Model = "LG-U2419HC",
                            SerialNumber = "604RMMD8U923",
                            TagNumber = "ASSET-0002"
                        },
                        new
                        {
                            Id = 3,
                            AssetTypeId = 3,
                            Description = "Reception Phone",
                            Manufacturer = "Cisco",
                            SerialNumber = "SAD083-00D4W",
                            TagNumber = "ASSET-0003"
                        },
                        new
                        {
                            Id = 4,
                            AssetTypeId = 1,
                            Description = "Manager's Laptop",
                            Manufacturer = "Acer",
                            Model = "Aspire 3",
                            SerialNumber = "NX.GNPSI.012)",
                            TagNumber = "ASSET-0004"
                        },
                        new
                        {
                            Id = 5,
                            AssetTypeId = 2,
                            Description = "Boardroom Monitor",
                            Manufacturer = "HP",
                            Model = "WQHD-GTG",
                            SerialNumber = "LC49RG90SSNXZA",
                            TagNumber = "ASSET-0005"
                        });
                });

            modelBuilder.Entity("CPRG214.ATS.Domain.AssetType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AssetType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Computer"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Monitor"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Phone"
                        });
                });

            modelBuilder.Entity("CPRG214.ATS.Domain.Asset", b =>
                {
                    b.HasOne("CPRG214.ATS.Domain.AssetType", "AssetType")
                        .WithMany("Assets")
                        .HasForeignKey("AssetTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
