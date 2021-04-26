using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieRatingApp.Migrations
{
    public partial class AddRatingPointsCounter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfRatingPoints",
                table: "Contents",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfRatingPoints",
                table: "Contents");
        }
    }
}
