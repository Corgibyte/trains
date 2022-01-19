using Microsoft.EntityFrameworkCore.Migrations;

namespace Trains.Migrations
{
    public partial class AddFare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Fare",
                table: "Tracks",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fare",
                table: "Tracks");
        }
    }
}
