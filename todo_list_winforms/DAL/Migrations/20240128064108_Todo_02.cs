using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace todo_list_winforms.Migrations
{
    public partial class Todo_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoNotes_TodoCategories_CategoryId",
                table: "TodoNotes");

            migrationBuilder.DropTable(
                name: "TodoCategories");

            migrationBuilder.DropIndex(
                name: "IX_TodoNotes_CategoryId",
                table: "TodoNotes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TodoCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoCategories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TodoNotes_CategoryId",
                table: "TodoNotes",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoNotes_TodoCategories_CategoryId",
                table: "TodoNotes",
                column: "CategoryId",
                principalTable: "TodoCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
