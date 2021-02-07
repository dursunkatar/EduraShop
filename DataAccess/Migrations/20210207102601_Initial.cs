using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.KategoriId);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    UrunId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UrunFiyati = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UrunStok = table.Column<int>(type: "int", nullable: false),
                    UrunResmi = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.UrunId);
                    table.ForeignKey(
                        name: "FK_Urunler_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "KategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "KategoriId", "KategoriAdi" },
                values: new object[,]
                {
                    { 1, "Furniture" },
                    { 2, "Electronics" },
                    { 3, "Books" },
                    { 4, "Accessories" },
                    { 5, "Computers" },
                    { 6, "Cameras" }
                });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunId", "IsFeatured", "KategoriId", "UrunAdi", "UrunFiyati", "UrunResmi", "UrunStok" },
                values: new object[,]
                {
                    { 2, false, 4, "Wood Chair", 99m, "product2", 302 },
                    { 3, false, 4, "Comfortable Sofa", 526m, "product3", 693 },
                    { 4, false, 4, "Hand Bag", 125m, "product4", 56 },
                    { 1, false, 6, "Photo Camera", 153m, "product1", 220 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_KategoriId",
                table: "Urunler",
                column: "KategoriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Kategoriler");
        }
    }
}
