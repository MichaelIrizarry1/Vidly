using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Data.Migrations
{
    public partial class PopulateGenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Genre (Name) VALUES('Action')");
            migrationBuilder.Sql("INSERT INTO Genre (Name) VALUES('Adventure')");
            migrationBuilder.Sql("INSERT INTO Genre (Name) VALUES('Fantasy')");
            migrationBuilder.Sql("INSERT INTO Genre (Name) VALUES('Horror')");
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
