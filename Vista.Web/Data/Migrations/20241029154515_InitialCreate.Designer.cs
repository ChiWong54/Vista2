﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vista.Web.Data;

#nullable disable

namespace Vista.Web.Data.Migrations
{
    [DbContext(typeof(WorkshopsContext))]
    [Migration("20241029154515_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("Vista.Web.Data.Staff", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StaffId");

                    b.ToTable("Staff");

                    b.HasData(
                        new
                        {
                            StaffId = 1,
                            FirstName = "Shripati",
                            LastName = "MacGrory"
                        },
                        new
                        {
                            StaffId = 2,
                            FirstName = "Nani",
                            LastName = "Martinsson"
                        },
                        new
                        {
                            StaffId = 3,
                            FirstName = "Harrison",
                            LastName = "Presley"
                        },
                        new
                        {
                            StaffId = 4,
                            FirstName = "Theo",
                            LastName = "Orr"
                        },
                        new
                        {
                            StaffId = 5,
                            FirstName = "Drew",
                            LastName = "Metcalfe"
                        });
                });

            modelBuilder.Entity("Vista.Web.Data.Vista.Web.Data.WorkshopStaff", b =>
                {
                    b.Property<int>("WorkshopId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StaffId")
                        .HasColumnType("INTEGER");

                    b.HasKey("WorkshopId", "StaffId");

                    b.HasIndex("StaffId");

                    b.ToTable("WorkshopStaff");

                    b.HasData(
                        new
                        {
                            WorkshopId = 1,
                            StaffId = 1
                        },
                        new
                        {
                            WorkshopId = 1,
                            StaffId = 2
                        },
                        new
                        {
                            WorkshopId = 2,
                            StaffId = 1
                        },
                        new
                        {
                            WorkshopId = 2,
                            StaffId = 2
                        },
                        new
                        {
                            WorkshopId = 2,
                            StaffId = 4
                        },
                        new
                        {
                            WorkshopId = 3,
                            StaffId = 4
                        });
                });

            modelBuilder.Entity("Vista.Web.Data.Workshop", b =>
                {
                    b.Property<int>("WorkshopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BookingRef")
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateAndTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("WorkshopId");

                    b.ToTable("Workshops");

                    b.HasData(
                        new
                        {
                            WorkshopId = 1,
                            CategoryCode = "",
                            DateAndTime = new DateTime(2023, 1, 10, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Excel (Beginner)"
                        },
                        new
                        {
                            WorkshopId = 2,
                            CategoryCode = "",
                            DateAndTime = new DateTime(2023, 1, 11, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Excel (Intermediate)"
                        },
                        new
                        {
                            WorkshopId = 3,
                            CategoryCode = "",
                            DateAndTime = new DateTime(2023, 9, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Word (Beginner)"
                        });
                });

            modelBuilder.Entity("Vista.Web.Data.Vista.Web.Data.WorkshopStaff", b =>
                {
                    b.HasOne("Vista.Web.Data.Staff", "Staff")
                        .WithMany("Workshops")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vista.Web.Data.Workshop", "Workshop")
                        .WithMany("Staff")
                        .HasForeignKey("WorkshopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Staff");

                    b.Navigation("Workshop");
                });

            modelBuilder.Entity("Vista.Web.Data.Staff", b =>
                {
                    b.Navigation("Workshops");
                });

            modelBuilder.Entity("Vista.Web.Data.Workshop", b =>
                {
                    b.Navigation("Staff");
                });
#pragma warning restore 612, 618
        }
    }
}
