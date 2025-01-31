using MomaFoodRes.Models;

namespace MomaFoodRes.Data
    {
    public class DbSeeder
        {
        public readonly ApplicationDbContext _context;
        public DbSeeder(ApplicationDbContext context)
            {
            _context = context;
            }

        public async Task SeedDataAsync()
            {
            // Seed Categories if they don't exist
            if (!_context.Categories.Any())
                {
                var categories = new List<Category>
                {
                    new Category { Name = "Main" },
                    new Category { Name = "Dessert" },
                    new Category { Name = "Side Dish" },
                    new Category { Name = "Beverage" },
                    new Category { Name = "Appetizer" }
                };
                _context.Categories.AddRange(categories);
                await _context.SaveChangesAsync();
                Console.WriteLine("Categories seeded.");
                }

            // Seed Ingredients if they don't exist
            if (!_context.Ingredients.Any())
                {
                var ingredients = new List<Ingredient>
                {
                    new Ingredient { Name = "Rice" },
                    new Ingredient { Name = "Potato" },
                    new Ingredient { Name = "Tomato" },
                    new Ingredient { Name = "Chicken" },
                    new Ingredient { Name = "Beef" },
                    new Ingredient { Name = "Fish" },
                    new Ingredient { Name = "Cheese" },
                    new Ingredient { Name = "Onion" },
                    new Ingredient { Name = "Honey" }
                };
                _context.Ingredients.AddRange(ingredients);
                await _context.SaveChangesAsync();
                Console.WriteLine("Ingredients seeded.");
                }

            // Seed Products if they don't exist
            if (!_context.Products.Any())
                {
                var products = new List<Product>
                {
                    new Product
                    {
                        Name = "Ghormeh Sabzi",
                        Description = "A traditional Persian herb stew with lamb, kidney beans, and dried limes.",
                        Price = 10.50m,
                        Stock = 50,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Name = "Fesenjan",
                        Description = "A rich and flavorful Persian stew made with pomegranate sauce and walnuts, served with chicken.",
                        Price = 12.99m,
                        Stock = 40,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Name = "Tahchin",
                        Description = "A beautiful Persian rice cake layered with saffron rice, yogurt-marinated chicken, and crispy golden crust.",
                        Price = 9.99m,
                        Stock = 30,
                        CategoryId = 1
                    }
                };

                _context.Products.AddRange(products);
                await _context.SaveChangesAsync();
                Console.WriteLine("Products seeded.");
                }

            // Seed ProductIngredients if they don't exist
            if (!_context.ProductIngredients.Any())
                {
                var productIngredients = new List<ProductIngredient>
                {
                    new ProductIngredient { ProductId = 1, IngredientId = 1 },
                    new ProductIngredient { ProductId = 1, IngredientId = 4 },
                    new ProductIngredient { ProductId = 1, IngredientId = 5 },
                    new ProductIngredient { ProductId = 1, IngredientId = 6 },
                    new ProductIngredient { ProductId = 2, IngredientId = 2 },
                    new ProductIngredient { ProductId = 2, IngredientId = 4 },
                    new ProductIngredient { ProductId = 2, IngredientId = 5 },
                    new ProductIngredient { ProductId = 2, IngredientId = 6 },
                    new ProductIngredient { ProductId = 3, IngredientId = 3 },
                    new ProductIngredient { ProductId = 3, IngredientId = 4 },
                    new ProductIngredient { ProductId = 3, IngredientId = 5 },
                    new ProductIngredient { ProductId = 3, IngredientId = 6 }
                };

                _context.ProductIngredients.AddRange(productIngredients);
                await _context.SaveChangesAsync();
                Console.WriteLine("ProductIngredients seeded.");
                }
            }
        }
    }
