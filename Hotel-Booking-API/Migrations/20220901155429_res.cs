using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_Booking_API.Migrations
{
    public partial class res : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GuestEmail",
                table: "Reservation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "adminEmail",
                table: "Reservation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "checkInDate",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "managerSpecial",
                table: "Reservation",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "numberofNights",
                table: "Reservation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "roomTypeId",
                table: "Reservation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_roomTypeId",
                table: "Reservation",
                column: "roomTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_RoomType_roomTypeId",
                table: "Reservation",
                column: "roomTypeId",
                principalTable: "RoomType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_RoomType_roomTypeId",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_roomTypeId",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "GuestEmail",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "adminEmail",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "checkInDate",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "managerSpecial",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "numberofNights",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "roomTypeId",
                table: "Reservation");
        }
    }
}
