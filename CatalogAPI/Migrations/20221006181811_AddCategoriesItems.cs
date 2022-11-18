using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogAPI.Migrations
{
    public partial class AddCategoriesItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Categories(Name, ImageUrl) Values('Drinks','drinks.jpg')");
            migrationBuilder.Sql("Insert into Categories(Name, ImageUrl) Values('Snacks','snacks.jpg')");
            migrationBuilder.Sql("Insert into Categories(Name, ImageUrl) Values('Desserts','desserts.jpg')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete * from categories");
        }
    }
}
