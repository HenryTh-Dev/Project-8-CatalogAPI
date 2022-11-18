using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogAPI.Migrations
{
    public partial class AddProductsItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Products(Name, Description, Price, ImageUrl, Stock, RegistryData, CategoryId)" +
                " Values('Pepsi','350 ml soda',5.45,'cocacola.png',50,CURRENT_TIMESTAMP,1)");
            migrationBuilder.Sql("Insert into Products(Name, Description, Price, ImageUrl, Stock, RegistryData, CategoryId)" +
                " Values('Tuna lunch','150g tuna lunch',8.45,'tuna.png',10,CURRENT_TIMESTAMP,2)");
            migrationBuilder.Sql("Insert into Products(Name, Description, Price, ImageUrl, Stock, RegistryData, CategoryId)" +
                " Values('pudding','100g condensed milk pudding',6.75,'pudding.png',20,CURRENT_TIMESTAMP,3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from products");
        }
    }
}
