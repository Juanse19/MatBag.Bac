using Microsoft.EntityFrameworkCore.Migrations;

namespace IoT.DataAccess.EFCore.Migrations
{
    public partial class mimodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           /* migrationBuilder.DropPrimaryKey(
                name: "PK_airline_list",
                schema: "iot_core",
                table: "airline_list");

            migrationBuilder.RenameTable(
                name: "airline_list",
                schema: "iot_core",
                newName: "AirlineList",
                newSchema: "iot_core");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AirlineList",
                schema: "iot_core",
                table: "AirlineList",
                column: "Id");*/
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AirlineList",
                schema: "iot_core",
                table: "AirlineList");

            migrationBuilder.RenameTable(
                name: "AirlineList",
                schema: "iot_core",
                newName: "airline_list",
                newSchema: "iot_core");

            migrationBuilder.AddPrimaryKey(
                name: "PK_airline_list",
                schema: "iot_core",
                table: "airline_list",
                column: "Id");
        }
    }
}
