using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Trains.Migrations
{
    public partial class ChangeTimeSpanType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TravelTime",
                table: "Tracks",
                type: "int",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time(6)");

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 1,
                column: "TravelTime",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 2,
                column: "TravelTime",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 3,
                column: "TravelTime",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 4,
                column: "TravelTime",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 5,
                column: "TravelTime",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 6,
                column: "TravelTime",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 7,
                column: "TravelTime",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 8,
                column: "TravelTime",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 9,
                column: "TravelTime",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 10,
                column: "TravelTime",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 11,
                column: "TravelTime",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 12,
                column: "TravelTime",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 13,
                column: "TravelTime",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 14,
                column: "TravelTime",
                value: 6);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "TravelTime",
                table: "Tracks",
                type: "time(6)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 1,
                column: "TravelTime",
                value: new TimeSpan(0, 3, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 2,
                column: "TravelTime",
                value: new TimeSpan(0, 3, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 3,
                column: "TravelTime",
                value: new TimeSpan(0, 1, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 4,
                column: "TravelTime",
                value: new TimeSpan(0, 1, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 5,
                column: "TravelTime",
                value: new TimeSpan(0, 4, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 6,
                column: "TravelTime",
                value: new TimeSpan(0, 4, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 7,
                column: "TravelTime",
                value: new TimeSpan(0, 6, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 8,
                column: "TravelTime",
                value: new TimeSpan(0, 6, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 9,
                column: "TravelTime",
                value: new TimeSpan(0, 4, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 10,
                column: "TravelTime",
                value: new TimeSpan(0, 4, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 11,
                column: "TravelTime",
                value: new TimeSpan(0, 4, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 12,
                column: "TravelTime",
                value: new TimeSpan(0, 4, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 13,
                column: "TravelTime",
                value: new TimeSpan(0, 6, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 14,
                column: "TravelTime",
                value: new TimeSpan(0, 6, 0, 0, 0));
        }
    }
}
