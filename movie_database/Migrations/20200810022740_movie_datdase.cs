using Microsoft.EntityFrameworkCore.Migrations;

namespace movie_database.Migrations
{
    public partial class movie_datdase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie_details",
                columns: table => new
                {
                    Movie_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Movie_Name = table.Column<string>(nullable: true),
                    Movie_Director_Name = table.Column<string>(nullable: true),
                    Movie_Language = table.Column<string>(nullable: true),
                    Movie_Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie_details", x => x.Movie_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie_details");
        }
    }
}
