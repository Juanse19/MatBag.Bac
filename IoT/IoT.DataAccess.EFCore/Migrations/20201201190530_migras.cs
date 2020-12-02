using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IoT.DataAccess.EFCore.Migrations
{
    public partial class migras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AirlineList",
                schema: "iot_core",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AirlineName = table.Column<string>(nullable: true),
                    IataDesignator = table.Column<string>(nullable: true),
                    TreeDigitCode = table.Column<int>(nullable: true),
                    IcaoDesignator = table.Column<string>(nullable: true),
                    CountryTerritory = table.Column<string>(nullable: true),
                    AirlineState = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirlineList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "bhs_alarms",
                schema: "iot_core",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdConveyors = table.Column<int>(nullable: false),
                    Aux = table.Column<string>(nullable: true),
                    DateRegister = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bhs_alarms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BhsAtr",
                schema: "iot_core",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAtr = table.Column<int>(nullable: false),
                    Bagtag = table.Column<string>(nullable: true),
                    Aux = table.Column<string>(nullable: true),
                    DateRegister = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BhsAtr", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BhsBpi",
                schema: "iot_core",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bagtag = table.Column<string>(nullable: true),
                    Quality = table.Column<string>(nullable: true),
                    Aux = table.Column<string>(nullable: true),
                    DateRegister = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BhsBpi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BhsConveyorInfo",
                schema: "iot_core",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdConveyors = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Ubication = table.Column<string>(nullable: true),
                    CoordX = table.Column<string>(nullable: true),
                    CoordY = table.Column<string>(nullable: true),
                    DateRegister = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BhsConveyorInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BhsConveyors",
                schema: "iot_core",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdConveyors = table.Column<int>(nullable: false),
                    Current = table.Column<string>(nullable: true),
                    Power = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    IdFailure = table.Column<string>(nullable: true),
                    DateRegister = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BhsConveyors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BhsConveyorState",
                schema: "iot_core",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BhsConveyorState", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BhsCounters",
                schema: "iot_core",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(nullable: true),
                    Aux = table.Column<string>(nullable: true),
                    DateRegister = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BhsCounters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BhsDashboardV2",
                schema: "iot_core",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdConveyor = table.Column<int>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    ValueDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BhsDashboardV2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BhsLog",
                schema: "iot_core",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: true),
                    Thread = table.Column<string>(nullable: true),
                    Context = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: true),
                    Logger = table.Column<string>(nullable: true),
                    Method = table.Column<string>(nullable: true),
                    Parameters = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    Exception = table.Column<string>(nullable: true),
                    ExecutionTime = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Module = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BhsLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BhsVariableState",
                schema: "iot_core",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(nullable: true),
                    Aux = table.Column<string>(nullable: true),
                    DateRegister = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BhsVariableState", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carruseles",
                schema: "iot_core",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Carrusel = table.Column<int>(nullable: true),
                    IdAirlineList = table.Column<int>(nullable: true),
                    RegisterDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carruseles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirlineList",
                schema: "iot_core");

            migrationBuilder.DropTable(
                name: "bhs_alarms",
                schema: "iot_core");

            migrationBuilder.DropTable(
                name: "BhsAtr",
                schema: "iot_core");

            migrationBuilder.DropTable(
                name: "BhsBpi",
                schema: "iot_core");

            migrationBuilder.DropTable(
                name: "BhsConveyorInfo",
                schema: "iot_core");

            migrationBuilder.DropTable(
                name: "BhsConveyors",
                schema: "iot_core");

            migrationBuilder.DropTable(
                name: "BhsConveyorState",
                schema: "iot_core");

            migrationBuilder.DropTable(
                name: "BhsCounters",
                schema: "iot_core");

            migrationBuilder.DropTable(
                name: "BhsDashboardV2",
                schema: "iot_core");

            migrationBuilder.DropTable(
                name: "BhsLog",
                schema: "iot_core");

            migrationBuilder.DropTable(
                name: "BhsVariableState",
                schema: "iot_core");

            migrationBuilder.DropTable(
                name: "Carruseles",
                schema: "iot_core");
        }
    }
}
