using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZapateriaSuela.Migrations
{
    /// <inheritdoc />
    public partial class AddTrabajadoresTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trabajadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Puesto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HorasTrabajadas = table.Column<int>(type: "int", nullable: false),
                    PagoPorHora = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sueldo = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trabajadores", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trabajadores");
        }
    }
}
