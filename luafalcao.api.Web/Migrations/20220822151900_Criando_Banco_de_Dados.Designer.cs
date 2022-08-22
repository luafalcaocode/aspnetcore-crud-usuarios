﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using luafalcao.api.Persistence.Contexts;

namespace luafalcao.api.Web.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220822151900_Criando_Banco_de_Dados")]
    partial class Criando_Banco_de_Dados
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("luafalcao.api.Persistence.Entities.Escolaridade", b =>
                {
                    b.Property<int>("EscolaridadeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EscolaridadeId");

                    b.ToTable("Escolaridade");
                });

            modelBuilder.Entity("luafalcao.api.Persistence.Entities.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EscolaridadeId")
                        .HasColumnType("int");

                    b.Property<int?>("HistoricoEscolarId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.HasIndex("EscolaridadeId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("luafalcao.api.Persistence.Entities.Usuario", b =>
                {
                    b.HasOne("luafalcao.api.Persistence.Entities.Escolaridade", "Escolaridade")
                        .WithMany()
                        .HasForeignKey("EscolaridadeId");
                });
#pragma warning restore 612, 618
        }
    }
}
