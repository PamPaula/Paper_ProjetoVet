﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoVetMVCNew.Data;

#nullable disable

namespace ProjetoVetMVCNew.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20230620125107_Criacao-Inicial")]
    partial class CriacaoInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProjetoVetMVCNew.Models.Animais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<string>("Castrado")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Castrado");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Genero");

                    b.Property<string>("Idade")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Idade");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Nome");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Observação");

                    b.Property<string>("Pelagem")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Pelagem");

                    b.Property<string>("Porte")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Porte");

                    b.Property<string>("Raca")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Raca");

                    b.Property<string>("Responsavel")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Responsavel");

                    b.HasKey("Id");

                    b.ToTable("Animais");
                });
#pragma warning restore 612, 618
        }
    }
}
