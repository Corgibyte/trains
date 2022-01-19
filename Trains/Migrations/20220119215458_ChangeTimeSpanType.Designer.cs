﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Trains.Models;

namespace Trains.Migrations
{
    [DbContext(typeof(TrainsContext))]
    [Migration("20220119215458_ChangeTimeSpanType")]
    partial class ChangeTimeSpanType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Trains.Models.Station", b =>
                {
                    b.Property<int>("StationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4");

                    b.HasKey("StationId");

                    b.ToTable("Stations");

                    b.HasData(
                        new
                        {
                            StationId = 1,
                            Name = "Vancouver"
                        },
                        new
                        {
                            StationId = 2,
                            Name = "Calgary"
                        },
                        new
                        {
                            StationId = 3,
                            Name = "Winnipeg"
                        },
                        new
                        {
                            StationId = 4,
                            Name = "Seattle"
                        },
                        new
                        {
                            StationId = 5,
                            Name = "Helena"
                        });
                });

            modelBuilder.Entity("Trains.Models.Track", b =>
                {
                    b.Property<int>("TrackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<double>("Fare")
                        .HasColumnType("double");

                    b.Property<int>("OriginId")
                        .HasColumnType("int");

                    b.Property<int>("TravelTime")
                        .HasColumnType("int");

                    b.HasKey("TrackId");

                    b.HasIndex("DestinationId");

                    b.HasIndex("OriginId");

                    b.ToTable("Tracks");

                    b.HasData(
                        new
                        {
                            TrackId = 1,
                            DestinationId = 2,
                            Fare = 8.5,
                            OriginId = 1,
                            TravelTime = 3
                        },
                        new
                        {
                            TrackId = 2,
                            DestinationId = 1,
                            Fare = 8.5,
                            OriginId = 2,
                            TravelTime = 3
                        },
                        new
                        {
                            TrackId = 3,
                            DestinationId = 4,
                            Fare = 15.5,
                            OriginId = 1,
                            TravelTime = 1
                        },
                        new
                        {
                            TrackId = 4,
                            DestinationId = 1,
                            Fare = 15.5,
                            OriginId = 4,
                            TravelTime = 1
                        },
                        new
                        {
                            TrackId = 5,
                            DestinationId = 4,
                            Fare = 13.5,
                            OriginId = 2,
                            TravelTime = 4
                        },
                        new
                        {
                            TrackId = 6,
                            DestinationId = 2,
                            Fare = 13.5,
                            OriginId = 4,
                            TravelTime = 4
                        },
                        new
                        {
                            TrackId = 7,
                            DestinationId = 3,
                            Fare = 8.5,
                            OriginId = 2,
                            TravelTime = 6
                        },
                        new
                        {
                            TrackId = 8,
                            DestinationId = 2,
                            Fare = 8.5,
                            OriginId = 3,
                            TravelTime = 6
                        },
                        new
                        {
                            TrackId = 9,
                            DestinationId = 5,
                            Fare = 17.5,
                            OriginId = 2,
                            TravelTime = 4
                        },
                        new
                        {
                            TrackId = 10,
                            DestinationId = 2,
                            Fare = 17.5,
                            OriginId = 5,
                            TravelTime = 4
                        },
                        new
                        {
                            TrackId = 11,
                            DestinationId = 5,
                            Fare = 15.5,
                            OriginId = 3,
                            TravelTime = 4
                        },
                        new
                        {
                            TrackId = 12,
                            DestinationId = 3,
                            Fare = 15.5,
                            OriginId = 5,
                            TravelTime = 4
                        },
                        new
                        {
                            TrackId = 13,
                            DestinationId = 4,
                            Fare = 20.5,
                            OriginId = 5,
                            TravelTime = 6
                        },
                        new
                        {
                            TrackId = 14,
                            DestinationId = 5,
                            Fare = 20.5,
                            OriginId = 4,
                            TravelTime = 6
                        });
                });

            modelBuilder.Entity("Trains.Models.Track", b =>
                {
                    b.HasOne("Trains.Models.Station", "Destination")
                        .WithMany("DestinationTracks")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Trains.Models.Station", "Origin")
                        .WithMany("OriginTracks")
                        .HasForeignKey("OriginId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Destination");

                    b.Navigation("Origin");
                });

            modelBuilder.Entity("Trains.Models.Station", b =>
                {
                    b.Navigation("DestinationTracks");

                    b.Navigation("OriginTracks");
                });
#pragma warning restore 612, 618
        }
    }
}