﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoHogar.App.Persistencia;

#nullable disable

namespace ProyectoHogar.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProyectoHogar.App.Dominio.Hogar", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Hogares");
                });

            modelBuilder.Entity("ProyectoHogar.App.Dominio.PatronCrecimiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Diagnostico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PatronesCrecimiento");
                });

            modelBuilder.Entity("ProyectoHogar.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("ProyectoHogar.App.Dominio.SugerenciaCuidado", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PatronCrecimientoId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("PatronCrecimientoId");

                    b.ToTable("SugerenciasCuidados");
                });

            modelBuilder.Entity("ProyectoHogar.App.Dominio.Familiar", b =>
                {
                    b.HasBaseType("ProyectoHogar.App.Dominio.Persona");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parentesco")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Familiar");
                });

            modelBuilder.Entity("ProyectoHogar.App.Dominio.Medico", b =>
                {
                    b.HasBaseType("ProyectoHogar.App.Dominio.Persona");

                    b.Property<int?>("HorasLaborales")
                        .HasColumnType("int");

                    b.Property<string>("TarjetaProfesional")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("especialidad")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Medico");
                });

            modelBuilder.Entity("ProyectoHogar.App.Dominio.Paciente", b =>
                {
                    b.HasBaseType("ProyectoHogar.App.Dominio.Persona");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("NutricionistaId")
                        .HasColumnType("int");

                    b.Property<int?>("PediatraId")
                        .HasColumnType("int");

                    b.Property<int?>("familiarId")
                        .HasColumnType("int");

                    b.Property<int?>("patronCrecimientoId")
                        .HasColumnType("int");

                    b.HasIndex("NutricionistaId");

                    b.HasIndex("PediatraId");

                    b.HasIndex("familiarId");

                    b.HasIndex("patronCrecimientoId");

                    b.HasDiscriminator().HasValue("Paciente");
                });

            modelBuilder.Entity("ProyectoHogar.App.Dominio.SugerenciaCuidado", b =>
                {
                    b.HasOne("ProyectoHogar.App.Dominio.PatronCrecimiento", null)
                        .WithMany("Sugerencias")
                        .HasForeignKey("PatronCrecimientoId");
                });

            modelBuilder.Entity("ProyectoHogar.App.Dominio.Paciente", b =>
                {
                    b.HasOne("ProyectoHogar.App.Dominio.Medico", "Nutricionista")
                        .WithMany()
                        .HasForeignKey("NutricionistaId");

                    b.HasOne("ProyectoHogar.App.Dominio.Medico", "Pediatra")
                        .WithMany()
                        .HasForeignKey("PediatraId");

                    b.HasOne("ProyectoHogar.App.Dominio.Familiar", "familiar")
                        .WithMany()
                        .HasForeignKey("familiarId");

                    b.HasOne("ProyectoHogar.App.Dominio.PatronCrecimiento", "patronCrecimiento")
                        .WithMany()
                        .HasForeignKey("patronCrecimientoId");

                    b.Navigation("Nutricionista");

                    b.Navigation("Pediatra");

                    b.Navigation("familiar");

                    b.Navigation("patronCrecimiento");
                });

            modelBuilder.Entity("ProyectoHogar.App.Dominio.PatronCrecimiento", b =>
                {
                    b.Navigation("Sugerencias");
                });
#pragma warning restore 612, 618
        }
    }
}
