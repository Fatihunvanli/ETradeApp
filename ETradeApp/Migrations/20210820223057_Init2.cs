using Microsoft.EntityFrameworkCore.Migrations;

namespace ETradeApp.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProductDescription",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StockAmount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "UnitPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    PictureName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Giyim" },
                    { 2, "Elektronik" },
                    { 3, "Ev" },
                    { 4, "Kozmetik" },
                    { 5, "Spor" },
                    { 6, "Kitap" }
                });

            migrationBuilder.InsertData(
                table: "Pictures",
                columns: new[] { "Id", "PictureName", "ProductId" },
                values: new object[,]
                {
                    { 10, "bizanstarihi.png", 10 },
                    { 9, "mogoltarihi.png", 9 },
                    { 8, "proteintozu.png", 8 },
                    { 6, "parfum.png", 6 },
                    { 7, "futboltopu.png", 7 },
                    { 4, "telefon.png", 4 },
                    { 3, "laptop.png", 3 },
                    { 2, "mont.png", 2 },
                    { 1, "gomlek.png", 1 },
                    { 5, "koltuk.png", 5 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ProductDescription", "ProductName", "StockAmount", "UnitPrice" },
                values: new object[,]
                {
                    { 9, 6, "Abraham Constantin Mouradgea D’ohsson SELENGE YAYINLARI", "Moğol Tarihi", 12, 45m },
                    { 1, 1, "Mavi Gömlek", "Gömlek", 12, 45m },
                    { 2, 1, "Çocuk Montu", "Mont", 4, 245m },
                    { 3, 2, "Lenovo Laptop", "Laptop", 5, 12245m },
                    { 4, 2, "Akıllı Telefon", "Telefon", 45, 5245m },
                    { 5, 3, "Yeşil Konforlu Koltuk", "Koltuk", 32, 6245m },
                    { 6, 4, "Kalıcı Parfüm", "Parfüm", 22, 345m },
                    { 7, 5, "Desenli Futbol Topu", "Futbol Topu", 32, 145m },
                    { 8, 5, "Mini Protein Tozu", "Protein Tozu", 22, 445m },
                    { 10, 6, "Kuruluşundan Yıkılışına Kadar", "Bizans Tarihi", 2, 55m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductDescription",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "StockAmount",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "Products");
        }
    }
}
