﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaEventos.DAL;

namespace SistemaEventos.DAL.Migrations
{
    [DbContext(typeof(SistemaEventosContext))]
    [Migration("20210524133945_Migration00.0")]
    partial class Migration000
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Latin1_General_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SistemaEventos.Domain.Entity.CategoriaEvento", b =>
                {
                    b.Property<int>("IdCategoriaEvento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeCategoria")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.HasKey("IdCategoriaEvento");

                    b.ToTable("CategoriaEvento");
                });

            modelBuilder.Entity("SistemaEventos.Domain.Entity.Evento", b =>
                {
                    b.Property<int>("IdEvento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataHoraFim")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DataHoraInicio")
                        .HasColumnType("datetime");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)");

                    b.Property<int>("IdCategoriaEvento")
                        .HasColumnType("int");

                    b.Property<int>("IdEventoStatus")
                        .HasColumnType("int");

                    b.Property<int>("LimiteVagas")
                        .HasColumnType("int");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.HasKey("IdEvento");

                    b.HasIndex("IdCategoriaEvento");

                    b.HasIndex("IdEventoStatus");

                    b.ToTable("Evento");
                });

            modelBuilder.Entity("SistemaEventos.Domain.Entity.Participacao", b =>
                {
                    b.Property<int>("IdParticipacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comentario")
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)");

                    b.Property<bool>("FlagPresente")
                        .HasColumnType("bit");

                    b.Property<int>("IdEvento")
                        .HasColumnType("int");

                    b.Property<string>("LoginParticipante")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<int?>("Nota")
                        .HasColumnType("int");

                    b.HasKey("IdParticipacao");

                    b.HasIndex("IdEvento");

                    b.ToTable("Participacao");
                });

            modelBuilder.Entity("SistemaEventos.Domain.Entity.StatusEvento", b =>
                {
                    b.Property<int>("IdEventoStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeStatus")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.HasKey("IdEventoStatus");

                    b.ToTable("StatusEvento");
                });

            modelBuilder.Entity("SistemaEventos.Domain.Entity.Evento", b =>
                {
                    b.HasOne("SistemaEventos.Domain.Entity.CategoriaEvento", "IdCategoriaEventoNavigation")
                        .WithMany("Eventos")
                        .HasForeignKey("IdCategoriaEvento")
                        .HasConstraintName("FK_Evento_CategoriaEvento")
                        .IsRequired();

                    b.HasOne("SistemaEventos.Domain.Entity.StatusEvento", "IdEventoStatusNavigation")
                        .WithMany("Eventos")
                        .HasForeignKey("IdEventoStatus")
                        .HasConstraintName("FK_Evento_EventoStatus")
                        .IsRequired();

                    b.Navigation("IdCategoriaEventoNavigation");

                    b.Navigation("IdEventoStatusNavigation");
                });

            modelBuilder.Entity("SistemaEventos.Domain.Entity.Participacao", b =>
                {
                    b.HasOne("SistemaEventos.Domain.Entity.Evento", "IdEventoNavigation")
                        .WithMany("Participacaos")
                        .HasForeignKey("IdEvento")
                        .HasConstraintName("FK_Participacao_Evento")
                        .IsRequired();

                    b.Navigation("IdEventoNavigation");
                });

            modelBuilder.Entity("SistemaEventos.Domain.Entity.CategoriaEvento", b =>
                {
                    b.Navigation("Eventos");
                });

            modelBuilder.Entity("SistemaEventos.Domain.Entity.Evento", b =>
                {
                    b.Navigation("Participacaos");
                });

            modelBuilder.Entity("SistemaEventos.Domain.Entity.StatusEvento", b =>
                {
                    b.Navigation("Eventos");
                });
#pragma warning restore 612, 618
        }
    }
}
