using Microsoft.EntityFrameworkCore.Migrations;

namespace L04_LinqToEntities_HW.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    IsAvailable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "IsAvailable", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "This is Product 1", true, "Product 1", 120m },
                    { 2, "This is Product 2", false, "Product 2", 300m },
                    { 3, "This is Product 3", true, "Product 3", 125m },
                    { 4, "This is Product 4", true, "Product 4", 264m },
                    { 5, "This is Product 5", false, "Product 5", 210m },
                    { 6, "This is Product 6", true, "Product 6", 430m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
