using Microsoft.EntityFrameworkCore.Migrations;

namespace Trains.Migrations
{
    public partial class UpdateFareSeedings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 1,
                column: "Fare",
                value: 8.5);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 2,
                column: "Fare",
                value: 8.5);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 3,
                column: "Fare",
                value: 15.5);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 4,
                column: "Fare",
                value: 15.5);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 5,
                column: "Fare",
                value: 13.5);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 6,
                column: "Fare",
                value: 13.5);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 7,
                column: "Fare",
                value: 8.5);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 8,
                column: "Fare",
                value: 8.5);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 9,
                column: "Fare",
                value: 17.5);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 10,
                column: "Fare",
                value: 17.5);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 11,
                column: "Fare",
                value: 15.5);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 12,
                column: "Fare",
                value: 15.5);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 13,
                column: "Fare",
                value: 20.5);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 14,
                column: "Fare",
                value: 20.5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 1,
                column: "Fare",
                value: 10.5);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 2,
                column: "Fare",
                value: 10.5);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 3,
                column: "Fare",
                value: 10.5);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 4,
                column: "Fare",
                value: 10.5);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 5,
                column: "Fare",
                value: 10.5);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 6,
                column: "Fare",
                value: 10.5);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 7,
                column: "Fare",
                value: 10.5);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 8,
                column: "Fare",
                value: 10.5);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 9,
                column: "Fare",
                value: 10.5);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 10,
                column: "Fare",
                value: 10.5);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 11,
                column: "Fare",
                value: 10.5);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 12,
                column: "Fare",
                value: 10.5);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 13,
                column: "Fare",
                value: 10.5);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 14,
                column: "Fare",
                value: 10.5);
        }
    }
}
