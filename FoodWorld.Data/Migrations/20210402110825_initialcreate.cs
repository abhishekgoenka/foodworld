using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodWorld.Data.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Cuisine = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foods_Restaurants_RestaurantID",
                        column: x => x.RestaurantID,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Cuisine", "Location", "Name" },
                values: new object[] { 1, 2, "London", "Pall Mall Restaurant" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Cuisine", "Location", "Name" },
                values: new object[] { 2, 3, "India", "Indian Coffee House" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Cuisine", "Location", "Name" },
                values: new object[] { 3, 1, "Mexico", "Boston Pizza" });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Description", "Name", "Price", "RestaurantID" },
                values: new object[,]
                {
                    { 1, "Chicken pot pie", "Chicken pot pie", 2, 1 },
                    { 2, "Carrot pudding, made by cooking fresh grated carrots along with sugar, milk and ghee", "Gajar Halwa", 5, 2 },
                    { 3, "Besan is hindi name for chickpea flour. This pudding is made by cooking chickpea flour in a rich sugar syrup ", "Besan Halwa", 4, 2 },
                    { 4, "Barfi is essentially a more solidified form of a milk-based pudding. In this dish, a sweet batter is thickened and then set to cool and cut into smaller pieces ", "Barfi", 25, 2 },
                    { 5, "Saag is simply the hindi name for leafy green vegetables. But this particular dish refers to a delicious curry where spinach is cooked with spices and then paneer is added to the dish ", "Saag Paneer", 11, 2 },
                    { 6, "Vadas are deep fried dumplings or flattened patties of potato, and a pav is a plain old dinner roll. Vada pav is essentially a spicier vegetarian version of sliders where the dumpling or patty is sandwiched between two halves of a dinner roll. ", "Vada Pav", 22, 2 },
                    { 7, "Naan is one of the most popular Indian flatbreads. To make a naan, wheat flour dough is prepared either by allowing it to rise using yeast, or by the addition of yogurt to the dough. ", "Naan", 7, 2 },
                    { 8, "Tikka is the Hindi term for “small chunks,” and masala means a spice blend. So when small chunks of anything, like chicken, are cooked in a sauce with a particular spice blend, it is called Chicken Tikka Masala. ", "Tikka Masala", 8, 2 },
                    { 9, "A delight for veggie lovers! Choose from our wide range of delicious vegetarian pizzas, it's softer and tastier ", "VEG PIZZA", 5, 3 },
                    { 10, "Tomato | Grilled Mushroom |Jalapeno |Golden Corn | Beans in a fresh pan crust", "PIZZA MANIA", 18, 3 },
                    { 11, "The good just got better! Treat yourself to the premium taste of the Burger Pizza, that looks good and tastes great with paneer and red paprika. ", "BURGER PIZZA- PREMIUM VEG", 16, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_RestaurantID",
                table: "Foods",
                column: "RestaurantID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Restaurants");
        }
    }
}
