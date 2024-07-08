using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace apiBodega.Migrations
{
    /// <inheritdoc />
    public partial class Final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "empresas",
                columns: table => new
                {
                    EmpresaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resumen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empresas", x => x.EmpresaID);
                });

            migrationBuilder.CreateTable(
                name: "pedidos",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CtdProducto = table.Column<int>(type: "int", nullable: false),
                    ProveedorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedidos", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    CtdenStock = table.Column<int>(type: "int", nullable: false),
                    ProveedorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.ProductoId);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.IdUser);
                });

            migrationBuilder.InsertData(
                table: "empresas",
                columns: new[] { "EmpresaID", "NombreEmpresa", "Resumen" },
                values: new object[,]
                {
                    { 1, "Supermaxi", "Empresa de viveres y consumo" },
                    { 2, "ElectronicaEc", "Empresa que vende componentes eléctricos" }
                });

            migrationBuilder.InsertData(
                table: "pedidos",
                columns: new[] { "ClienteId", "CtdProducto", "ProveedorId" },
                values: new object[] { 1, 54, 2 });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "ProductoId", "CtdenStock", "Descripcion", "Nombre", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 1, 300, "Cloro para uso doméstico", "Clorox", 5.9900000000000002, 1 },
                    { 2, 89, "Detergente en crema ideal para el lavado manual de vajilla", "Lava", 6.9900000000000002, 1 },
                    { 3, 4, "Brochas para limpieza de componentes eléctricos", " Kit Brochas antiestáticas", 3.5, 2 },
                    { 4, 34, "Alcohol Isopropilico al 90%", "Alcohol Isopropilico", 6.7999999999999998, 2 }
                });

            migrationBuilder.InsertData(
                table: "usuarios",
                columns: new[] { "IdUser", "UserMail", "UserPassword" },
                values: new object[,]
                {
                    { 1, "Hmateo@gmail.com", "admin1234" },
                    { 2, "cris1234@gmail.com", "admin1234" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "empresas");

            migrationBuilder.DropTable(
                name: "pedidos");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "usuarios");
        }
    }
}
