﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI_Swagger.Context;

#nullable disable

namespace WebAPI_Swagger.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAPI_Swagger.Model.Fornecedor", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Contato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ID_Produto")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nome_Produto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fornecedores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Contato = "contato@fornecedorA.com",
                            Endereco = "Endereço A",
                            ID_Produto = 1,
                            Nome = "Fornecedor A",
                            Nome_Produto = "Caderno"
                        },
                        new
                        {
                            Id = 2,
                            Contato = "contato@fornecedorB.com",
                            Endereco = "Endereço B",
                            ID_Produto = 2,
                            Nome = "Fornecedor B",
                            Nome_Produto = "Lápis"
                        },
                        new
                        {
                            Id = 3,
                            Contato = "contato@fornecedorC.com",
                            Endereco = "Endereço C",
                            ID_Produto = 3,
                            Nome = "Fornecedor C",
                            Nome_Produto = "Borracha"
                        });
                });

            modelBuilder.Entity("WebAPI_Swagger.Model.Produto", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<int?>("Estoque")
                        .HasColumnType("int");

                    b.Property<int?>("FornecedorId")
                        .HasColumnType("int");

                    b.Property<string>("Nome_Produto")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<decimal?>("Preco")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Estoque = 50,
                            Nome_Produto = "Caderno",
                            Preco = 7.99m
                        },
                        new
                        {
                            Id = 2,
                            Estoque = 100,
                            Nome_Produto = "Lápis",
                            Preco = 1.99m
                        },
                        new
                        {
                            Id = 3,
                            Estoque = 20,
                            Nome_Produto = "Borracha",
                            Preco = 0.75m
                        });
                });

            modelBuilder.Entity("WebAPI_Swagger.Model.Produto", b =>
                {
                    b.HasOne("WebAPI_Swagger.Model.Fornecedor", "Fornecedor")
                        .WithMany("Produtos")
                        .HasForeignKey("FornecedorId");

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("WebAPI_Swagger.Model.Fornecedor", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}