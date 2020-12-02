using Microsoft.EntityFrameworkCore.Migrations;

namespace IoT.DataAccess.EFCore.Migrations
{
    public partial class migramodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           /* migrationBuilder.RenameTable(
                name: "airline_list",
                schema: "iot_core",
                newName: "AirlineList",
                newSchema: "iot_core");

            migrationBuilder.RenameColumn(
                name: "tree_digit_code",
                schema: "iot_core",
                table: "AirlineList",
                newName: "TreeDigitCode");

            migrationBuilder.RenameColumn(
                name: "icao_designator",
                schema: "iot_core",
                table: "AirlineList",
                newName: "IcaoDesignator");

            migrationBuilder.RenameColumn(
                name: "iata_designator",
                schema: "iot_core",
                table: "AirlineList",
                newName: "IataDesignator");
*/
           /* migrationBuilder.RenameColumn(
                name: "country_territory",
                schema: "iot_core",
                table: "AirlineList",
                newName: "CountryTerritory");

            migrationBuilder.RenameColumn(
                name: "airline_state",
                schema: "iot_core",
                table: "AirlineList",
                newName: "AirlineState");

            migrationBuilder.RenameColumn(
                name: "airline_name",
                schema: "iot_core",
                table: "AirlineList",
                newName: "AirlineName");

            migrationBuilder.AlterColumn<string>(
                name: "IcaoDesignator",
                schema: "iot_core",
                table: "AirlineList",
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IataDesignator",
                schema: "iot_core",
                table: "AirlineList",
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CountryTerritory",
                schema: "iot_core",
                table: "AirlineList",
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AirlineName",
                schema: "iot_core",
                table: "AirlineList",
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

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

            migrationBuilder.RenameColumn(
                name: "TreeDigitCode",
                schema: "iot_core",
                table: "airline_list",
                newName: "tree_digit_code");

            migrationBuilder.RenameColumn(
                name: "IcaoDesignator",
                schema: "iot_core",
                table: "airline_list",
                newName: "icao_designator");

            migrationBuilder.RenameColumn(
                name: "IataDesignator",
                schema: "iot_core",
                table: "airline_list",
                newName: "iata_designator");

            migrationBuilder.RenameColumn(
                name: "CountryTerritory",
                schema: "iot_core",
                table: "airline_list",
                newName: "country_territory");

            migrationBuilder.RenameColumn(
                name: "AirlineState",
                schema: "iot_core",
                table: "airline_list",
                newName: "airline_state");

            migrationBuilder.RenameColumn(
                name: "AirlineName",
                schema: "iot_core",
                table: "airline_list",
                newName: "airline_name");

            migrationBuilder.AlterColumn<string>(
                name: "icao_designator",
                schema: "iot_core",
                table: "airline_list",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "iata_designator",
                schema: "iot_core",
                table: "airline_list",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "country_territory",
                schema: "iot_core",
                table: "airline_list",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "airline_name",
                schema: "iot_core",
                table: "airline_list",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
