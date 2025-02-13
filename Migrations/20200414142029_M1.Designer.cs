﻿// <auto-generated />
using System;
using Heaven;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Heaven.Migrations
{
    [DbContext(typeof(AdapostContext))]
    [Migration("20200414142029_M1")]
    partial class M1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Heaven.Models.Adapost", b =>
                {
                    b.Property<int>("AdapostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContactId")
                        .HasColumnType("int");

                    b.Property<int?>("DoneazaId")
                        .HasColumnType("int");

                    b.Property<int>("adresa")
                        .HasColumnType("int");

                    b.Property<int>("denumire")
                        .HasColumnType("int");

                    b.Property<int>("oras")
                        .HasColumnType("int");

                    b.HasKey("AdapostId");

                    b.HasIndex("ContactId");

                    b.HasIndex("DoneazaId");

                    b.ToTable("Adaposts");
                });

            modelBuilder.Entity("Heaven.Models.Caini", b =>
                {
                    b.Property<int>("CainiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("culoare")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("marime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nume_caine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("varsta")
                        .HasColumnType("int");

                    b.HasKey("CainiId");

                    b.ToTable("Caini");
                });

            modelBuilder.Entity("Heaven.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UtilizatorId")
                        .HasColumnType("int");

                    b.HasKey("ContactId");

                    b.HasIndex("UtilizatorId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("Heaven.Models.Doneaza", b =>
                {
                    b.Property<int>("DoneazaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CVC")
                        .HasColumnType("int");

                    b.Property<int?>("UtilizatorId")
                        .HasColumnType("int");

                    b.Property<int>("data")
                        .HasColumnType("int");

                    b.Property<int>("nr_card")
                        .HasColumnType("int");

                    b.HasKey("DoneazaId");

                    b.HasIndex("UtilizatorId");

                    b.ToTable("Doneaza");
                });

            modelBuilder.Entity("Heaven.Models.Pisici", b =>
                {
                    b.Property<int>("PisiciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("culoare")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nume_pisica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("varsta")
                        .HasColumnType("int");

                    b.HasKey("PisiciId");

                    b.ToTable("Pisici");
                });

            modelBuilder.Entity("Heaven.Models.Poze", b =>
                {
                    b.Property<int>("PozeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdapostId")
                        .HasColumnType("int");

                    b.Property<int?>("CainiId")
                        .HasColumnType("int");

                    b.Property<int?>("PisiciId")
                        .HasColumnType("int");

                    b.Property<int>("id_caine")
                        .HasColumnType("int");

                    b.Property<int>("id_pisica")
                        .HasColumnType("int");

                    b.HasKey("PozeId");

                    b.HasIndex("AdapostId");

                    b.HasIndex("CainiId");

                    b.HasIndex("PisiciId");

                    b.ToTable("Poze");
                });

            modelBuilder.Entity("Heaven.Models.Utilizator", b =>
                {
                    b.Property<int>("UtilizatorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UtilizatorId");

                    b.ToTable("Utilizator");
                });

            modelBuilder.Entity("Heaven.Models.Adapost", b =>
                {
                    b.HasOne("Heaven.Models.Contact", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactId");

                    b.HasOne("Heaven.Models.Doneaza", "Doneaza")
                        .WithMany()
                        .HasForeignKey("DoneazaId");
                });

            modelBuilder.Entity("Heaven.Models.Contact", b =>
                {
                    b.HasOne("Heaven.Models.Utilizator", null)
                        .WithMany("Contact")
                        .HasForeignKey("UtilizatorId");
                });

            modelBuilder.Entity("Heaven.Models.Doneaza", b =>
                {
                    b.HasOne("Heaven.Models.Utilizator", "utilizator")
                        .WithMany()
                        .HasForeignKey("UtilizatorId");
                });

            modelBuilder.Entity("Heaven.Models.Poze", b =>
                {
                    b.HasOne("Heaven.Models.Adapost", null)
                        .WithMany("Poze")
                        .HasForeignKey("AdapostId");

                    b.HasOne("Heaven.Models.Caini", null)
                        .WithMany("Poze")
                        .HasForeignKey("CainiId");

                    b.HasOne("Heaven.Models.Pisici", null)
                        .WithMany("Poze")
                        .HasForeignKey("PisiciId");
                });
#pragma warning restore 612, 618
        }
    }
}
