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
            if (!_context.Categories.Any())
                {
                var categories = new List<Category>
                {
                    new Category { CategoryId = 1,  Name = "Main" },
                    new Category { CategoryId = 2, Name = "Dessert" },
                    new Category { CategoryId = 3, Name = "Side Dish" },
                    new Category { CategoryId = 4, Name = "Beverage" },
                    new Category { CategoryId = 5, Name = "Appetizer" }
                };
                _context.Categories.AddRange(categories);
                await _context.SaveChangesAsync();
                }
            if (!_context.Ingredients.Any())
                {
                var ingredients = new List<Ingredient>
                {
                    new Ingredient {IngredientId=1, Name="Rise"},
                    new Ingredient {IngredientId=2, Name="Potato"},
                    new Ingredient {IngredientId=3, Name="Tomato"},
                    new Ingredient {IngredientId=4, Name="Chicken"},
                    new Ingredient {IngredientId=5, Name="Beef"},
                    new Ingredient {IngredientId=6, Name="Fish"},
                    new Ingredient {IngredientId=7, Name="Cheese"},
                    new Ingredient {IngredientId=8, Name="Onion"},
                    new Ingredient {IngredientId=9, Name="Honey" }
                };
                _context.Ingredients.AddRange(ingredients);
                await _context.SaveChangesAsync();
                }
            if (!_context.Products.Any())
                {
                var products = new List<Product>
  {
    new Product
    {
        ProductId = 1,
        Name = "Ghormeh Sabzi",
        Description = "A traditional Persian herb stew with lamb, kidney beans, and dried limes.",
        Price = 10.50m,
        Stock = 50,
        CategoryId = 1
    },
    new Product
    {
        ProductId = 2,
        Name = "Fesenjan",
        Description = "A rich and flavorful Persian stew made with pomegranate sauce and walnuts, served with chicken.",
        Price = 12.99m,
        Stock = 40,
        CategoryId = 1
    },
    new Product
    {
        ProductId = 3,
        Name = "Tahchin",
        Description = "A beautiful Persian rice cake layered with saffron rice, yogurt-marinated chicken, and crispy golden crust.",
        Price = 9.99m,
        Stock = 30,
        CategoryId = 1
    }
};

                _context.Products.AddRange(products);
                await _context.SaveChangesAsync();
                };
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
                }

            }
        }

    }



