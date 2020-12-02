using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IoT.DataAccess.EFCore.Migrations
{
    public partial class Newmigra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           /* migrationBuilder.DropTable(
                name: "airline_list",
                schema: "iot_core");

            migrationBuilder.DropTable(
                name: "bhs_alarms",
                schema: "iot_core");

            migrationBuilder.DropTable(
                name: "bhs_atr",
                schema: "iot_core");

            migrationBuilder.DropTable(
                name: "bhs_bpi",
                schema: "iot_core");

            migrationBuilder.DropTable(
                name: "bhs_ConveyorInfo",
                schema: "iot_core");

            migrationBuilder.DropTable(
                name: "bhs_conveyors",
                schema: "iot_core");

            migrationBuilder.DropTable(
                name: "bhs_ConveyorState",
                schema: "iot_core");

            migrationBuilder.DropTable(
                name: "bhs_counters",
                schema: "iot_core");

            migrationBuilder.DropTable(
                name: "bhs_DashboardV2",
                schema: "iot_core");

            migrationBuilder.DropTable(
                name: "bhs_Log",
                schema: "iot_core");

            migrationBuilder.DropTable(
                name: "bhs_variableState",
                schema: "iot_core");

            migrationBuilder.DropTable(
                name: "carruseles",
                schema: "iot_core");*/
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "airline_list",
                schema: "iot_core",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    airline_name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    iata_designator = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    tree_digit_code = table.Column<int>(nullable: true),
                    icao_designator = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    country_territory = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    airline_state = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "bhs_alarms",
                schema: "iot_core",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                      .Annotation("SqlServer:Identity", "1, 1"),
                    idConveyors = table.Column<int>(nullable: false),
                    aux = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    DateRegister = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "bhs_atr",
                schema: "iot_core",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idAtr = table.Column<int>(nullable: false),
                    bagtag = table.Column<string>(maxLength: 50, nullable: true),
                    aux = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DateRegister = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "bhs_bpi",
                schema: "iot_core",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    bagtag = table.Column<string>(fixedLength: true, maxLength: 10, nullable: true),
                    quality = table.Column<string>(fixedLength: true, maxLength: 10, nullable: true),
                    aux = table.Column<string>(fixedLength: true, maxLength: 10, nullable: true),
                    DateRegister = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "bhs_ConveyorInfo",
                schema: "iot_core",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idConveyors = table.Column<int>(nullable: false),
                    description = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    ubication = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    coordX = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    coordY = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    DateRegister = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "bhs_conveyors",
                schema: "iot_core",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    idConveyors = table.Column<int>(nullable: false),
                    current = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    power = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    state = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    idFailure = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DateRegister = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "bhs_ConveyorState",
                schema: "iot_core",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    description = table.Column<string>(unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "bhs_counters",
                schema: "iot_core",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    value = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    aux = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DateRegister = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "bhs_DashboardV2",
                schema: "iot_core",
                columns: table => new
                {
                    idConveyor = table.Column<int>(nullable: false),
                    ValueDateTime = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "bhs_Log",
                schema: "iot_core",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Thread = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    Context = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    Level = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Logger = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    Method = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    Parameters = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    Message = table.Column<string>(unicode: false, maxLength: 4000, nullable: true),
                    Exception = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    ExecutionTime = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    UserName = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    Module = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "bhs_variableState",
                schema: "iot_core",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    value = table.Column<string>(maxLength: 50, nullable: true),
                    aux = table.Column<string>(maxLength: 50, nullable: true),
                    dateRegister = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "carruseles",
                schema: "iot_core",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    carrusel = table.Column<int>(nullable: true),
                    id_airline_list = table.Column<int>(nullable: true),
                    register_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });
        }
    }
}
