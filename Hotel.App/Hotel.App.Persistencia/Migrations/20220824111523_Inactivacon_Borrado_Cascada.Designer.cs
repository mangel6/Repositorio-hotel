﻿// <auto-generated />
using System;
using Hotel.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hotel.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220824111523_Inactivacon_Borrado_Cascada")]
    partial class Inactivacon_Borrado_Cascada
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hotel.App.Dominio.Habitacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int>("camas")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Habitaciones");
                });

            modelBuilder.Entity("Hotel.App.Dominio.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreTomador")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ocupacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("Hotel.App.Dominio.ReservaHabitacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("HabitacionId")
                        .HasColumnType("int");

                    b.Property<int>("ReservaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HabitacionId");

                    b.HasIndex("ReservaId");

                    b.ToTable("ReservaHabitacion");
                });

            modelBuilder.Entity("Hotel.App.Dominio.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UltimoAcceso")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Hotel.App.Dominio.Reserva", b =>
                {
                    b.HasOne("Hotel.App.Dominio.Usuario", "Usuario")
                        .WithMany("ListaReservas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Hotel.App.Dominio.ReservaHabitacion", b =>
                {
                    b.HasOne("Hotel.App.Dominio.Habitacion", "Habitacion")
                        .WithMany("ReservasHabitaciones")
                        .HasForeignKey("HabitacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel.App.Dominio.Reserva", "Reserva")
                        .WithMany("ReservasHabitaciones")
                        .HasForeignKey("ReservaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Habitacion");

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("Hotel.App.Dominio.Habitacion", b =>
                {
                    b.Navigation("ReservasHabitaciones");
                });

            modelBuilder.Entity("Hotel.App.Dominio.Reserva", b =>
                {
                    b.Navigation("ReservasHabitaciones");
                });

            modelBuilder.Entity("Hotel.App.Dominio.Usuario", b =>
                {
                    b.Navigation("ListaReservas");
                });
#pragma warning restore 612, 618
        }
    }
}
