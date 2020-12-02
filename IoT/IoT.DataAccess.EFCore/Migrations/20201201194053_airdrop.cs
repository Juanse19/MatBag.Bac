using Microsoft.EntityFrameworkCore.Migrations;

namespace IoT.DataAccess.EFCore.Migrations
{
    public partial class airdrop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          /*  migrationBuilder.CreateTable(
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
                });*/
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirlineList",
                schema: "iot_core");
        }
    }
}
