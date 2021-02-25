using Microsoft.EntityFrameworkCore.Migrations;

namespace BarkerAssignment5.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookTitle = table.Column<string>(nullable: true),
                    AuthFName = table.Column<string>(nullable: true),
                    AuthLName = table.Column<string>(nullable: true),
                    Publisher = table.Column<string>(nullable: true),
                    ISBN = table.Column<string>(nullable: true),
                    BookCat = table.Column<string>(nullable: true),
                    BookPrice = table.Column<double>(nullable: false),
                    Pages = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.BookId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
