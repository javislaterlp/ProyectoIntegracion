using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Shop.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Games"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Consoles"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Accesories"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Pay cards"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Merchandising"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Bioshock Infinite",
                    Description = "Set in 1912, players assume the role of former Pinkerton agent Booker DeWitt, sent to the flying city of Columbia on a rescue mission. "
                    + "His target? Elizabeth, imprisoned since childhood.",
                    ImagePath="bio.png",
                    UnitPrice = 35.00,
                    CategoryID = 1
               },
                new Product 
                {
                    ProductID = 2,
                    ProductName = "XBOX ONE",
                    Description = "The new console of the latest generation from Microsoft.",
                    ImagePath="xone.png",
                    UnitPrice = 350.00,
                    CategoryID = 2
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "PlayStation 4 Controller",
                    Description = "All you need to sit and play.",
                    ImagePath="ps4c.png",
                    UnitPrice = 60.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "World of Warcraft 30 days",
                    Description = "1 month of unlimited adventures!",
                    ImagePath="wow.png",
                    UnitPrice = 12.50,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Dragon Ball T-shirt",
                    Description = "Feel like you are a Super Saiyan and save the world.",
                    ImagePath="dbs.png",
                    UnitPrice = 22.00,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Diablo III",
                    Description = "Diablo III, Blizzard Entertainment action epic RPG, carries the eternal war between the high heavens and the burning Hells to a new battlefield: the consoles!",
                    ImagePath="db3.png",
                    UnitPrice = 34.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Nintendo 3DS XL",
                    Description = "New portable console from Nintendo. Even bigger!",
                    ImagePath="nds.png",
                    UnitPrice = 194.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Rocksmith cable",
                    Description = "Plug your guitar to your console and start rocking.",
                    ImagePath="rcksmth.png",
                    UnitPrice = 15.95,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "League of Legends RP",
                    Description = "Buy your favorite heros and skins.",
                    ImagePath="lol.png",
                    UnitPrice = 10.99,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Pikachu Amiibo",
                    Description = "Take Pikachu as your game mate!",
                    ImagePath="amiibo.png",
                    UnitPrice = 12.95,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "GTA V",
                    Description = "15th and most waited game from GTA",
                    ImagePath="gta.png",
                    UnitPrice = 54.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "PlayStation 4",
                    Description = "Newest console from Sony.",
                    ImagePath="ps4.png",
                    UnitPrice = 380.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Razer game mouse",
                    Description = "More buttons that you could use!",
                    ImagePath="razer.png",
                    UnitPrice = 37.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "iTunes pre-pay card",
                    Description = "Adds 50€ to your iTunes account.",
                    ImagePath="itunes.png",
                    UnitPrice = 50.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Watch Dogs keyring",
                    Description = "Give style to your keys.",
                    ImagePath="wdg.png",
                    UnitPrice = 12.50,
                    CategoryID = 5
                }
            };

            return products;
        }
    }
}