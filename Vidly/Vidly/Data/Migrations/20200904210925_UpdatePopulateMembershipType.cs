using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Data.Migrations
{
    public partial class UpdatePopulateMembershipType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE MembershipType SET MembershipName = 'Pay as you GO' WHERE Id = 1");
            migrationBuilder.Sql("UPDATE MembershipType SET MembershipName = 'Monthly' WHERE Id = 2");
            migrationBuilder.Sql("UPDATE MembershipType SET MembershipName = 'Quarterly' WHERE Id = 3");
            migrationBuilder.Sql("UPDATE MembershipType SET MembershipName = 'Annual' WHERE Id = 4");
           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
