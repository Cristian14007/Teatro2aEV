﻿// <auto-generated />
using BackEnd.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BackEnd.Data.Migrations
{
    [DbContext(typeof(ObraContext))]
    partial class ObraContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BackEnd.Models.Obra", b =>
                {
                    b.Property<int>("ObraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ObraId"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ObraId");

                    b.ToTable("Obras");

                    b.HasData(
                        new
                        {
                            ObraId = 1,
                            Descripcion = "Desc obra 1",
                            Genero = "Gen obra 1",
                            Imagen = "Img obra 1",
                            Titulo = "Obra 1"
                        },
                        new
                        {
                            ObraId = 2,
                            Descripcion = "Desc obra 2",
                            Genero = "Gen obra 2",
                            Imagen = "Img obra 2",
                            Titulo = "Obra 2"
                        },
                        new
                        {
                            ObraId = 3,
                            Descripcion = "Desc obra 3",
                            Genero = "Gen obra 3",
                            Imagen = "Img obra 3",
                            Titulo = "Obra 3"
                        },
                        new
                        {
                            ObraId = 4,
                            Descripcion = "Desc obra 4",
                            Genero = "Gen obra 4",
                            Imagen = "Img obra 4",
                            Titulo = "Obra 4"
                        },
                        new
                        {
                            ObraId = 5,
                            Descripcion = "Desc obra 5",
                            Genero = "Gen obra 5",
                            Imagen = "Img obra 5",
                            Titulo = "Obra 5"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
