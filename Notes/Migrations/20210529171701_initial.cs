using Microsoft.EntityFrameworkCore.Migrations;

namespace Notes.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    przedmiot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    zaliczenie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    termin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    notatka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    wazne = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");
        }
    }
}
