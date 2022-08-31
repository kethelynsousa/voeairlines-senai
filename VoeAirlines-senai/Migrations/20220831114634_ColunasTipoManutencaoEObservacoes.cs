using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoeAirlines_senai.Migrations
{
    public partial class ColunasTipoManutencaoEObservacoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voos_Piloto_PilotoId",
                table: "Voos");

            migrationBuilder.DropTable(
                name: "Piloto");

            migrationBuilder.DropColumn(
                name: "Observacoes",
                table: "Manutencao");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Manutencao");

            migrationBuilder.AddColumn<string>(
                name: "Observacao",
                table: "Manutencao",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoManutencao",
                table: "Manutencao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Aeronaves",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Fabricante",
                table: "Aeronaves",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "Aeronaves",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.CreateTable(
                name: "Pilotos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Matricula = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pilotos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pilotos_Matricula",
                table: "Pilotos",
                column: "Matricula",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Voos_Pilotos_PilotoId",
                table: "Voos",
                column: "PilotoId",
                principalTable: "Pilotos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voos_Pilotos_PilotoId",
                table: "Voos");

            migrationBuilder.DropTable(
                name: "Pilotos");

            migrationBuilder.DropColumn(
                name: "Observacao",
                table: "Manutencao");

            migrationBuilder.DropColumn(
                name: "TipoManutencao",
                table: "Manutencao");

            migrationBuilder.AddColumn<string>(
                name: "Observacoes",
                table: "Manutencao",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Tipo",
                table: "Manutencao",
                type: "int",
                maxLength: 100,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Aeronaves",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "Fabricante",
                table: "Aeronaves",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "Aeronaves",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.CreateTable(
                name: "Piloto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Matricula = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piloto", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Piloto_Matricula",
                table: "Piloto",
                column: "Matricula",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Voos_Piloto_PilotoId",
                table: "Voos",
                column: "PilotoId",
                principalTable: "Piloto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
