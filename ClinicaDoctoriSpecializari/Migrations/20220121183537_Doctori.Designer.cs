﻿// <auto-generated />
using ClinicaDoctoriSpecializari.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClinicaDoctoriSpecializari.Migrations
{
    [DbContext(typeof(ClinicaDoctoriSpecializariContext))]
    [Migration("20220121183537_Doctori")]
    partial class Doctori
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClinicaDoctoriSpecializari.Models.Clinica", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Judet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Oras")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Clinica");
                });

            modelBuilder.Entity("ClinicaDoctoriSpecializari.Models.Doctor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClinicaID")
                        .HasColumnType("int");

                    b.Property<int>("SpecializareID")
                        .HasColumnType("int");

                    b.Property<string>("nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prenume")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ClinicaID");

                    b.HasIndex("SpecializareID");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("ClinicaDoctoriSpecializari.Models.Specializare", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("aniStudiu")
                        .HasColumnType("int");

                    b.Property<string>("nume")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Specializare");
                });

            modelBuilder.Entity("ClinicaDoctoriSpecializari.Models.Doctor", b =>
                {
                    b.HasOne("ClinicaDoctoriSpecializari.Models.Clinica", "clinica")
                        .WithMany()
                        .HasForeignKey("ClinicaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClinicaDoctoriSpecializari.Models.Specializare", "specializare")
                        .WithMany()
                        .HasForeignKey("SpecializareID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}