﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksApi.Models;

#nullable disable

namespace ParksApi.Migrations
{
    [DbContext(typeof(ParksApiContext))]
    [Migration("20230818165012_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParksApi.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("State")
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Description = "First national park in the world, known for its geothermal features and wildlife.",
                            Name = "Yellowstone National Park",
                            State = "Wyoming",
                            Type = "National"
                        },
                        new
                        {
                            ParkId = 2,
                            Description = "Famous for its giant sequoias, waterfalls, and granite cliffs.",
                            Name = "Yosemite National Park",
                            State = "California",
                            Type = "National"
                        },
                        new
                        {
                            ParkId = 3,
                            Description = "Iconic for its immense canyon and Colorado River views.",
                            Name = "Grand Canyon National Park",
                            State = "Arizona",
                            Type = "National"
                        },
                        new
                        {
                            ParkId = 4,
                            Description = "Known for its mist-covered mountains, diverse flora, and historical buildings.",
                            Name = "Great Smoky Mountains National Park",
                            State = "Tennessee",
                            Type = "National"
                        },
                        new
                        {
                            ParkId = 5,
                            Description = "Famous for its red rock formations, canyons, and diverse plant and animal life.",
                            Name = "Zion National Park",
                            State = "Utah",
                            Type = "National"
                        },
                        new
                        {
                            ParkId = 6,
                            Description = "Known for its wildlife, including a herd of bison, and scenic drives.",
                            Name = "Custer State Park",
                            State = "South Dakota",
                            Type = "State"
                        },
                        new
                        {
                            ParkId = 7,
                            Description = "Largest state park in New York, offering hiking, boating, and camping.",
                            Name = "Harriman State Park",
                            State = "New York",
                            Type = "State"
                        },
                        new
                        {
                            ParkId = 8,
                            Description = "Famous for its quartzite bluffs, lake views, and recreational activities.",
                            Name = "Devil's Lake State Park",
                            State = "Wisconsin",
                            Type = "State"
                        },
                        new
                        {
                            ParkId = 9,
                            Description = "Known for its waterfalls, gorges, and diverse ecosystems.",
                            Name = "Fall Creek Falls State Park",
                            State = "Tennessee",
                            Type = "State"
                        },
                        new
                        {
                            ParkId = 10,
                            Description = "Offers beaches, fishing, and historical sites on the Delaware coast.",
                            Name = "Cape Henlopen State Park",
                            State = "Delaware",
                            Type = "State"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}