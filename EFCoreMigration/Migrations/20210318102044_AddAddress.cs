using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreMigration.DataAccess.Migrations
{
    public partial class AddAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certificate_CertificateLocation_LocationId",
                table: "Certificate");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Certificate",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_EmployeeId",
                table: "Address",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Certificate_CertificateLocation_LocationId",
                table: "Certificate",
                column: "LocationId",
                principalTable: "CertificateLocation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certificate_CertificateLocation_LocationId",
                table: "Certificate");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Certificate",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Certificate_CertificateLocation_LocationId",
                table: "Certificate",
                column: "LocationId",
                principalTable: "CertificateLocation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
