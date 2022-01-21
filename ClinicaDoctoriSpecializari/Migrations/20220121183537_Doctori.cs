using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicaDoctoriSpecializari.Migrations
{
    public partial class Doctori : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nume = table.Column<string>(nullable: true),
                    prenume = table.Column<string>(nullable: true),
                    ClinicaID = table.Column<int>(nullable: false),
                    SpecializareID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Doctor_Clinica_ClinicaID",
                        column: x => x.ClinicaID,
                        principalTable: "Clinica",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Doctor_Specializare_SpecializareID",
                        column: x => x.SpecializareID,
                        principalTable: "Specializare",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_ClinicaID",
                table: "Doctor",
                column: "ClinicaID");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_SpecializareID",
                table: "Doctor",
                column: "SpecializareID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctor");
        }
    }
}
