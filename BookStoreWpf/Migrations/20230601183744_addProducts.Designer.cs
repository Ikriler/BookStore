﻿// <auto-generated />
using System;
using BookStoreWpf.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookStoreWpf.Migrations
{
    [DbContext(typeof(BookStoreDBContext))]
    [Migration("20230601183744_addProducts")]
    partial class addProducts
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookStoreWpf.Models.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("amountPrice")
                        .HasColumnType("float");

                    b.Property<DateTime?>("dateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("statusid")
                        .HasColumnType("int");

                    b.Property<int?>("userid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("statusid");

                    b.HasIndex("userid");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BookStoreWpf.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Orderid")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Orderid");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("BookStoreWpf.Models.Role", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("BookStoreWpf.Models.Status", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("BookStoreWpf.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("middleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("roleid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("roleid");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BookStoreWpf.Models.Order", b =>
                {
                    b.HasOne("BookStoreWpf.Models.Status", "status")
                        .WithMany()
                        .HasForeignKey("statusid");

                    b.HasOne("BookStoreWpf.Models.User", "user")
                        .WithMany("orders")
                        .HasForeignKey("userid");
                });

            modelBuilder.Entity("BookStoreWpf.Models.Product", b =>
                {
                    b.HasOne("BookStoreWpf.Models.Order", null)
                        .WithMany("products")
                        .HasForeignKey("Orderid");
                });

            modelBuilder.Entity("BookStoreWpf.Models.User", b =>
                {
                    b.HasOne("BookStoreWpf.Models.Role", "role")
                        .WithMany()
                        .HasForeignKey("roleid");
                });
#pragma warning restore 612, 618
        }
    }
}
