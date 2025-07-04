using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HelpYAll.Migrations
{
    /// <inheritdoc />
    public partial class basicStructureCpu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cpus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tdp = table.Column<int>(type: "INTEGER", nullable: false),
                    Cores = table.Column<int>(type: "INTEGER", nullable: false),
                    Threads = table.Column<int>(type: "INTEGER", nullable: false),
                    Socket = table.Column<int>(type: "INTEGER", nullable: false),
                    CodeName = table.Column<string>(type: "TEXT", nullable: false),
                    BaseClock = table.Column<decimal>(type: "TEXT", nullable: false),
                    BoostClock = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cpus", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cpus");
        }
    }
}
