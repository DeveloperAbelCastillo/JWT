// <auto-generated />
using System;
using JWT.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JWT.Migrations
{
    [DbContext(typeof(JWTContext))]
    [Migration("20220928152845_MigracionInicial")]
    partial class MigracionInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JWT.Pais", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Habitantes")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Pais");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7861dfd8-2b03-4d77-a163-f51dd23c9958"),
                            Habitantes = 46000000,
                            Nombre = "España"
                        },
                        new
                        {
                            Id = new Guid("cb3f4c9c-b869-47c6-ae27-d9e39383c9b7"),
                            Habitantes = 83000000,
                            Nombre = "Alemania"
                        },
                        new
                        {
                            Id = new Guid("2edba698-8a13-492b-920d-31a55638519b"),
                            Habitantes = 65000000,
                            Nombre = "Francia"
                        },
                        new
                        {
                            Id = new Guid("4db28417-c3c7-4fa9-8775-58f124096f89"),
                            Habitantes = 61000000,
                            Nombre = "Italia"
                        },
                        new
                        {
                            Id = new Guid("3525f2d8-5dc5-4fff-b053-dba08a0e7095"),
                            Habitantes = 96000000,
                            Nombre = "Mexico"
                        },
                        new
                        {
                            Id = new Guid("08dd1c95-f61d-41a1-9cd4-25505d4213eb"),
                            Habitantes = 63000000,
                            Nombre = "EUA"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
