﻿// <auto-generated />
using System;
using CadastroDeVeiculosEtec.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CadastroDeVeiculosEtec.Migrations
{
    [DbContext(typeof(AppVeiculosContext))]
    [Migration("20220929000656_CampoCodigo")]
    partial class CampoCodigo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CadastroDeVeiculosEtec.Models.Veiculo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Aluguel")
                        .HasColumnType("bit");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<string>("Chassi")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<int>("Combustivel")
                        .HasColumnType("int");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Fabricante")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<double>("Kilometragem")
                        .HasColumnType("float");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Observacao")
                        .HasColumnType("varchar(150)");

                    b.Property<bool>("Particular")
                        .HasColumnType("bit");

                    b.Property<bool>("Revisão")
                        .HasColumnType("bit");

                    b.Property<bool>("RouboFurto")
                        .HasColumnType("bit");

                    b.Property<bool>("Sinistro")
                        .HasColumnType("bit");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<bool>("Venda")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Veiculos", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
