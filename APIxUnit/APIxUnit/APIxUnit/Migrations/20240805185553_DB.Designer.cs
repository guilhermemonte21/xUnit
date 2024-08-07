﻿// <auto-generated />
using System;
using APIxUnit.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIxUnit.Migrations
{
    [DbContext(typeof(XContext))]
    [Migration("20240805185553_DB")]
    partial class DB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APIxUnit.Domains.ProductsDomain", b =>
                {
                    b.Property<Guid?>("IdProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("VARCHAR(70)");

                    b.HasKey("IdProduct");

                    b.ToTable("ProductsDomain");
                });
#pragma warning restore 612, 618
        }
    }
}
