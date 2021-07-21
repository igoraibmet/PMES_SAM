﻿// <auto-generated />
using System;
using Infra.Model.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infra.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210716121030_addCountMaterial")]
    partial class addCountMaterial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("Infra.Model.Cautela", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Cautela")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataDevolucao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataRetirada")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdMilitar")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Observations")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Cautela");

                    b.HasIndex("IdMilitar");

                    b.ToTable("Cautela");
                });

            modelBuilder.Entity("Infra.Model.Cautela_Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdMaterial")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Id_Cautela")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IdMaterial");

                    b.HasIndex("Id_Cautela");

                    b.ToTable("Cautela_Material");
                });

            modelBuilder.Entity("Infra.Model.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Log");
                });

            modelBuilder.Entity("Infra.Model.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("Infra.Model.Militar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Curso")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Funcional")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("Numero")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PIN")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("TEXT");

                    b.Property<string>("Pelotao")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("Posto")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Militar");
                });

            modelBuilder.Entity("Infra.Model.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdMilitar")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("IdMilitar");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Infra.Model.Usuario_Credential", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Credential")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Usuario_Credential");
                });

            modelBuilder.Entity("Infra.Model.Cautela", b =>
                {
                    b.HasOne("Infra.Model.Militar", null)
                        .WithMany("Cautelas")
                        .HasForeignKey("Cautela");

                    b.HasOne("Infra.Model.Militar", "Militar")
                        .WithMany()
                        .HasForeignKey("IdMilitar")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Militar");
                });

            modelBuilder.Entity("Infra.Model.Cautela_Material", b =>
                {
                    b.HasOne("Infra.Model.Material", "Material")
                        .WithMany()
                        .HasForeignKey("IdMaterial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infra.Model.Cautela", "Cautela")
                        .WithMany()
                        .HasForeignKey("Id_Cautela")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cautela");

                    b.Navigation("Material");
                });

            modelBuilder.Entity("Infra.Model.Log", b =>
                {
                    b.HasOne("Infra.Model.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Infra.Model.Usuario", b =>
                {
                    b.HasOne("Infra.Model.Militar", "Militar")
                        .WithMany()
                        .HasForeignKey("IdMilitar")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Militar");
                });

            modelBuilder.Entity("Infra.Model.Usuario_Credential", b =>
                {
                    b.HasOne("Infra.Model.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Infra.Model.Militar", b =>
                {
                    b.Navigation("Cautelas");
                });
#pragma warning restore 612, 618
        }
    }
}
