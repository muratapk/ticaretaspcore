using Microsoft.EntityFrameworkCore.Migrations;

namespace ticaretaspcore.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    category_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.category_Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    product_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_Price = table.Column<int>(type: "int", nullable: false),
                    product_Picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    product_Stock = table.Column<int>(type: "int", nullable: false),
                    category_Id = table.Column<int>(type: "int", nullable: false),
                    Categoriescategory_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.product_Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_Categoriescategory_Id",
                        column: x => x.Categoriescategory_Id,
                        principalTable: "Categories",
                        principalColumn: "category_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_Categoriescategory_Id",
                table: "Products",
                column: "Categoriescategory_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
