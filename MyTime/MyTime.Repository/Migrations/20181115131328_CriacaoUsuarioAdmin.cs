using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTime.Repository.Migrations
{
    public partial class CriacaoUsuarioAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string sql = @"INSERT INTO TBLUser (Code, Name, Password, UserType)
                            SELECT 'Admin', 'Administrator', '17111997', 0
                            FROM DUAL
                            WHERE NOT EXISTS (SELECT 1 FROM TBLUser WHERE Code = 'Admin')";
            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
