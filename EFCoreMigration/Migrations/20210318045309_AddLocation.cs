using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreMigration.DataAccess.Migrations
{
    public partial class AddLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Certificate",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CertificateLocation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificateLocation", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Certificate_LocationId",
                table: "Certificate",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Certificate_CertificateLocation_LocationId",
                table: "Certificate",
                column: "LocationId",
                principalTable: "CertificateLocation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certificate_CertificateLocation_LocationId",
                table: "Certificate");

            migrationBuilder.DropTable(
                name: "CertificateLocation");

            migrationBuilder.DropIndex(
                name: "IX_Certificate_LocationId",
                table: "Certificate");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Certificate");
        }
    }
}
