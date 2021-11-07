﻿// <auto-generated />
using System;
using ExamenFinal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExamenFinal.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExamenFinal.Models.Bodega", b =>
                {
                    b.Property<int>("CodigoIngreso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("ExistenciaMinima")
                        .HasColumnType("float");

                    b.Property<DateTime?>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaSalida")
                        .HasColumnType("datetime2");

                    b.Property<string>("Observacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Ubicacion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CodigoIngreso");

                    b.HasIndex("ProductoId");

                    b.ToTable("Bodega");
                });

            modelBuilder.Entity("ExamenFinal.Models.Producto", b =>
                {
                    b.Property<int>("CodigoProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaVencimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreProducto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PrecioXMayor")
                        .HasColumnType("float");

                    b.Property<double>("PrecioXMenor")
                        .HasColumnType("float");

                    b.Property<int>("ProveedorId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("CodigoProducto");

                    b.HasIndex("ProveedorId");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("ExamenFinal.Models.Proveedor", b =>
                {
                    b.Property<int>("CodigoProveedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DireccionProveedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreProveedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("TelefonoProveedor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CodigoProveedor");

                    b.ToTable("Proveedor");
                });

            modelBuilder.Entity("ExamenFinal.Models.Bodega", b =>
                {
                    b.HasOne("ExamenFinal.Models.Producto", "CodigoProducto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CodigoProducto");
                });

            modelBuilder.Entity("ExamenFinal.Models.Producto", b =>
                {
                    b.HasOne("ExamenFinal.Models.Proveedor", "CodigoProveedor")
                        .WithMany()
                        .HasForeignKey("ProveedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CodigoProveedor");
                });
#pragma warning restore 612, 618
        }
    }
}
