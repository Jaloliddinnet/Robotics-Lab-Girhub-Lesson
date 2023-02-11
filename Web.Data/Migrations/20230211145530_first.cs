using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Data.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "futbolist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Komanda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oylik = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_futbolist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kompyuterlars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    modeli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    xotirasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tezkotXotirasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    protsessori = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kompyuterlars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mashinalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modeli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rangi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Narxi = table.Column<int>(type: "int", nullable: false),
                    Nomeri = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mashinalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "meals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    IsHalyal = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_meals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "universities",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    year = table.Column<int>(type: "int", nullable: false),
                    Director_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Students_number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_universities", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "futbolist");

            migrationBuilder.DropTable(
                name: "Kompyuterlars");

            migrationBuilder.DropTable(
                name: "Mashinalar");

            migrationBuilder.DropTable(
                name: "meals");

            migrationBuilder.DropTable(
                name: "universities");
        }
    }
}
