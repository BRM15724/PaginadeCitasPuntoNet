﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoBD.Models;

namespace ProyectoBD.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20191127170952_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProyectoBD.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellidoMaterno");

                    b.Property<string>("apellidoPaterno");

                    b.Property<int>("claveColonia");

                    b.Property<int>("claveEstado");

                    b.Property<int>("claveMunicipio");

                    b.Property<string>("contrasena");

                    b.Property<string>("direccionCalle");

                    b.Property<int>("direccionNumero");

                    b.Property<string>("email");

                    b.Property<string>("foto");

                    b.Property<string>("nombrePila");

                    b.Property<string>("preferenciaSexual");

                    b.Property<string>("sexo");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}