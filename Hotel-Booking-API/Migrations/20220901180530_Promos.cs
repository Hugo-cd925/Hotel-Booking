using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_Booking_API.Migrations
{
    public partial class Promos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Promo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PromoCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expiration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isFlatRate = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Promo");
        }
    }
}
