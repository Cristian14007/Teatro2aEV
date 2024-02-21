using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEnd.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Obras",
                columns: table => new
                {
                    ObraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obras", x => x.ObraId);
                });

            migrationBuilder.InsertData(
                table: "Obras",
                columns: new[] { "ObraId", "Descripcion", "Genero", "Imagen", "Titulo" },
                values: new object[,]
                {
                    { 1, "Desc obra 1", "Gen obra 1", "Img obra 1", "Obra 1" },
                    { 2, "Desc obra 2", "Gen obra 2", "Img obra 2", "Obra 2" },
                    { 3, "Desc obra 3", "Gen obra 3", "Img obra 3", "Obra 3" },
                    { 4, "Desc obra 4", "Gen obra 4", "Img obra 4", "Obra 4" },
                    { 5, "Desc obra 5", "Gen obra 5", "Img obra 5", "Obra 5" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Obras");
        }
    }
}
