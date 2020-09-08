﻿// <auto-generated />
using System;
using K1748796.NETCWK.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace K1748796.NETCWK.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200329082826_SeedSportTable")]
    partial class SeedSportTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("K1748796.NETCWK.Models.Event", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("Sportid");

                    b.HasKey("id");

                    b.HasIndex("Sportid");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("K1748796.NETCWK.Models.Sport", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("id");

                    b.ToTable("Sports");

                    b.HasData(
                        new { id = 1, Name = "Football" },
                        new { id = 2, Name = "Rugby" },
                        new { id = 3, Name = "Tennis" },
                        new { id = 4, Name = "Cricket" }
                    );
                });

            modelBuilder.Entity("K1748796.NETCWK.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Biography");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Gender");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Phone");

                    b.Property<string>("Postcode")
                        .IsRequired();

                    b.Property<int>("Skills");

                    b.Property<int?>("Sportid");

                    b.HasKey("id");

                    b.HasIndex("Sportid");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("K1748796.NETCWK.Models.Event", b =>
                {
                    b.HasOne("K1748796.NETCWK.Models.Sport", "Sport")
                        .WithMany()
                        .HasForeignKey("Sportid");
                });

            modelBuilder.Entity("K1748796.NETCWK.Models.User", b =>
                {
                    b.HasOne("K1748796.NETCWK.Models.Sport", "Sport")
                        .WithMany()
                        .HasForeignKey("Sportid");
                });
#pragma warning restore 612, 618
        }
    }
}