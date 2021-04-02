﻿// <auto-generated />
using FoodWorld.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodWorld.Data.Migrations
{
    [DbContext(typeof(FoodWorldDbContext))]
    [Migration("20210402110825_initialcreate")]
    partial class initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FoodWorld.Core.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantID");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Chicken pot pie",
                            Name = "Chicken pot pie",
                            Price = 2,
                            RestaurantID = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Carrot pudding, made by cooking fresh grated carrots along with sugar, milk and ghee",
                            Name = "Gajar Halwa",
                            Price = 5,
                            RestaurantID = 2
                        },
                        new
                        {
                            Id = 3,
                            Description = "Besan is hindi name for chickpea flour. This pudding is made by cooking chickpea flour in a rich sugar syrup ",
                            Name = "Besan Halwa",
                            Price = 4,
                            RestaurantID = 2
                        },
                        new
                        {
                            Id = 4,
                            Description = "Barfi is essentially a more solidified form of a milk-based pudding. In this dish, a sweet batter is thickened and then set to cool and cut into smaller pieces ",
                            Name = "Barfi",
                            Price = 25,
                            RestaurantID = 2
                        },
                        new
                        {
                            Id = 5,
                            Description = "Saag is simply the hindi name for leafy green vegetables. But this particular dish refers to a delicious curry where spinach is cooked with spices and then paneer is added to the dish ",
                            Name = "Saag Paneer",
                            Price = 11,
                            RestaurantID = 2
                        },
                        new
                        {
                            Id = 6,
                            Description = "Vadas are deep fried dumplings or flattened patties of potato, and a pav is a plain old dinner roll. Vada pav is essentially a spicier vegetarian version of sliders where the dumpling or patty is sandwiched between two halves of a dinner roll. ",
                            Name = "Vada Pav",
                            Price = 22,
                            RestaurantID = 2
                        },
                        new
                        {
                            Id = 7,
                            Description = "Naan is one of the most popular Indian flatbreads. To make a naan, wheat flour dough is prepared either by allowing it to rise using yeast, or by the addition of yogurt to the dough. ",
                            Name = "Naan",
                            Price = 7,
                            RestaurantID = 2
                        },
                        new
                        {
                            Id = 8,
                            Description = "Tikka is the Hindi term for “small chunks,” and masala means a spice blend. So when small chunks of anything, like chicken, are cooked in a sauce with a particular spice blend, it is called Chicken Tikka Masala. ",
                            Name = "Tikka Masala",
                            Price = 8,
                            RestaurantID = 2
                        },
                        new
                        {
                            Id = 9,
                            Description = "A delight for veggie lovers! Choose from our wide range of delicious vegetarian pizzas, it's softer and tastier ",
                            Name = "VEG PIZZA",
                            Price = 5,
                            RestaurantID = 3
                        },
                        new
                        {
                            Id = 10,
                            Description = "Tomato | Grilled Mushroom |Jalapeno |Golden Corn | Beans in a fresh pan crust",
                            Name = "PIZZA MANIA",
                            Price = 18,
                            RestaurantID = 3
                        },
                        new
                        {
                            Id = 11,
                            Description = "The good just got better! Treat yourself to the premium taste of the Burger Pizza, that looks good and tastes great with paneer and red paprika. ",
                            Name = "BURGER PIZZA- PREMIUM VEG",
                            Price = 16,
                            RestaurantID = 3
                        });
                });

            modelBuilder.Entity("FoodWorld.Core.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cuisine")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cuisine = 2,
                            Location = "London",
                            Name = "Pall Mall Restaurant"
                        },
                        new
                        {
                            Id = 2,
                            Cuisine = 3,
                            Location = "India",
                            Name = "Indian Coffee House"
                        },
                        new
                        {
                            Id = 3,
                            Cuisine = 1,
                            Location = "Mexico",
                            Name = "Boston Pizza"
                        });
                });

            modelBuilder.Entity("FoodWorld.Core.Food", b =>
                {
                    b.HasOne("FoodWorld.Core.Restaurant", "Restaurant")
                        .WithMany("Foods")
                        .HasForeignKey("RestaurantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("FoodWorld.Core.Restaurant", b =>
                {
                    b.Navigation("Foods");
                });
#pragma warning restore 612, 618
        }
    }
}
