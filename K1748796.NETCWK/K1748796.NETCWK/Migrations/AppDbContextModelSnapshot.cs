﻿// <auto-generated />
using System;
using K1748796.NETCWK.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace K1748796.NETCWK.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("K1748796.NETCWK.Models.Event", b =>
                {
                    b.Property<int>("Eventid")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("SportId");

                    b.HasKey("Eventid");

                    b.HasIndex("SportId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("K1748796.NETCWK.Models.Sport", b =>
                {
                    b.Property<int>("SportId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("SportId");

                    b.ToTable("Sports");
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

                    b.Property<int?>("SportId");

                    b.HasKey("id");

                    b.HasIndex("SportId");

                    b.ToTable("Users");

                    b.HasData(
                        new { id = 1, Address = "44 Evergreen Terrace", Biography = "There are cardio issues", Email = "Homer@aol.com", Gender = "Male", Name = "Homer Simpson", Phone = 1323435, Postcode = "TSGKDSF", Skills = 2 },
                        new { id = 2, Address = "44 Evergreen Terrace", Biography = "Great at Tackling", Email = "Marge@aol.com", Gender = "Female", Name = "Marge Simpson", Phone = 1234214, Postcode = "TSGKDSF", Skills = 0 },
                        new { id = 3, Address = "88 Evergreen Terrace", Biography = "Drinking Problem", Email = "Moe@aol.com", Gender = "Male", Name = "Moe", Phone = 14654232, Postcode = "GSDFJGKJ", Skills = 1 },
                        new { id = 4, Address = "22 Evergreen Terrace", Biography = "Good at shooting", Email = "Barney@aol.com", Gender = "Male", Name = "Barney", Phone = 1323435, Postcode = "TSGKDSF", Skills = 2 },
                        new { id = 5, Address = "Springfiled Prison", Biography = "Great Thinker", Email = "Bob@aol.com", Gender = "Male", Name = "Sideshow Bob", Phone = 13443, Postcode = "TSGDSJS", Skills = 0 }
                    );
                });

            modelBuilder.Entity("K1748796.NETCWK.Models.Event", b =>
                {
                    b.HasOne("K1748796.NETCWK.Models.Sport", "Sport")
                        .WithMany()
                        .HasForeignKey("SportId");
                });

            modelBuilder.Entity("K1748796.NETCWK.Models.User", b =>
                {
                    b.HasOne("K1748796.NETCWK.Models.Sport", "Sport")
                        .WithMany()
                        .HasForeignKey("SportId");
                });
#pragma warning restore 612, 618
        }
    }
}
