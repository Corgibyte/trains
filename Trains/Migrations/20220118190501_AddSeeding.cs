using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Trains.Migrations
{
    public partial class AddSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "StationId", "Name" },
                values: new object[,]
                {
                    { 1, "Vancouver" },
                    { 2, "Calgary" },
                    { 3, "Winnipeg" },
                    { 4, "Seattle" },
                    { 5, "Helena" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "TrackId", "DestinationId", "OriginId", "TravelTime" },
                values: new object[,]
                {
                    { 1, 2, 1, new TimeSpan(0, 3, 0, 0, 0) },
                    { 2, 1, 2, new TimeSpan(0, 3, 0, 0, 0) },
                    { 7, 3, 2, new TimeSpan(0, 6, 0, 0, 0) },
                    { 8, 2, 3, new TimeSpan(0, 6, 0, 0, 0) },
                    { 3, 4, 1, new TimeSpan(0, 1, 0, 0, 0) },
                    { 4, 1, 4, new TimeSpan(0, 1, 0, 0, 0) },
                    { 5, 4, 2, new TimeSpan(0, 4, 0, 0, 0) },
                    { 6, 2, 4, new TimeSpan(0, 4, 0, 0, 0) },
                    { 9, 5, 2, new TimeSpan(0, 4, 0, 0, 0) },
                    { 10, 2, 5, new TimeSpan(0, 4, 0, 0, 0) },
                    { 11, 5, 3, new TimeSpan(0, 4, 0, 0, 0) },
                    { 12, 3, 5, new TimeSpan(0, 4, 0, 0, 0) },
                    { 13, 4, 5, new TimeSpan(0, 6, 0, 0, 0) },
                    { 14, 5, 4, new TimeSpan(0, 6, 0, 0, 0) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: 5);
        }
    }
}
