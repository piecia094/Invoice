﻿// <auto-generated />
using System;
using InvoiceCreator.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InvoiceCreator.Migrations
{
    [DbContext(typeof(InvoiceDbContext))]
    [Migration("20220130152600_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("InvoiceCreator.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BuldingNumber")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostCode")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("InvoiceCreator.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("KlientId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KlientId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("InvoiceCreator.Entities.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("CreateDate")
                        .HasColumnType("int");

                    b.Property<int>("InvoiceDate")
                        .HasColumnType("int");

                    b.Property<int>("InvoiceNumber")
                        .HasColumnType("int");

                    b.Property<int?>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("ItemId");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("InvoiceCreator.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("NetValue")
                        .HasColumnType("int");

                    b.Property<int>("OrdinalNumber")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Tax")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("InvoiceCreator.Entities.Client", b =>
                {
                    b.HasOne("InvoiceCreator.Entities.Address", "Klient")
                        .WithMany()
                        .HasForeignKey("KlientId");

                    b.Navigation("Klient");
                });

            modelBuilder.Entity("InvoiceCreator.Entities.Invoice", b =>
                {
                    b.HasOne("InvoiceCreator.Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("InvoiceCreator.Entities.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId");

                    b.Navigation("Client");

                    b.Navigation("Item");
                });
#pragma warning restore 612, 618
        }
    }
}
