﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ecommerce.Models;

namespace ecommerce.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20191017184647_migration2")]
    partial class migration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ecommerce.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ecommerce.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerId");

                    b.Property<int>("ProductId");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ecommerce.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Owner");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ecommerce.Models.Order", b =>
                {
                    b.HasOne("ecommerce.Models.Customer", "Customer")
                        .WithMany("CustomerOrders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ecommerce.Models.Product", "Product")
                        .WithMany("ProductOrders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
