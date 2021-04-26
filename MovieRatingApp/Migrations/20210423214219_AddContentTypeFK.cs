using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieRatingApp.Migrations
{
    public partial class AddContentTypeFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContentTypeId",
                table: "Contents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ContentType",
                columns: table => new
                {
                    ContentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentType", x => x.ContentTypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contents_ContentTypeId",
                table: "Contents",
                column: "ContentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_ContentType_ContentTypeId",
                table: "Contents",
                column: "ContentTypeId",
                principalTable: "ContentType",
                principalColumn: "ContentTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_ContentType_ContentTypeId",
                table: "Contents");

            migrationBuilder.DropTable(
                name: "ContentType");

            migrationBuilder.DropIndex(
                name: "IX_Contents_ContentTypeId",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "ContentTypeId",
                table: "Contents");
        }
    }
}
