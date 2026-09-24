namespace BlazingPizza.Data;

public class PizzaService
{
    public Task<Pizza[]> GetPizzasAsync()
    {
        // Call your data access technology here
        return Task.FromResult(new Pizza[]
        {
            new Pizza()
            {
                Name = "Basic Cheese Pizza",
                Description = "It's cheesy and delicious. Why wouldn't you want one?",
                Price = 9.99m,
                Vegetarian = true,
                Vegan = false,
            },
            new Pizza()
            {
                Name = "The Baconatorizor",
                Description = "It has EVERY kind of bacon",
                Price = 11.99m,
                Vegetarian = false,
                Vegan = false,
            },
            new Pizza()
            {
                Name = "Classic pepperoni",
                Description = "It's the pizza you grew up with, but Blazing hot!",
                Price = 10.50m,
                Vegetarian = false,
                Vegan = false,
            },
            new Pizza()
            {
                Name = "Buffalo chicken",
                Description = "Spicy chicken, hot sauce and bleu cheese, guaranteed to warm you up",
                Price = 12.75m,
                Vegetarian = false,
                Vegan = false,
            },
            new Pizza()
            {
                Name = "Mushroom Lovers",
                Description = "It has mushrooms. Isn't that obvious?",
                Price = 11.00m,
                Vegetarian = true,
                Vegan = false,
            },
            new Pizza()
            {
                Name = "Veggie Delight",
                Description = "It's like salad, but on a pizza",
                Price = 11.50m,
                Vegetarian = true,
                Vegan = true,
            },
            new Pizza()
            {
                Name = "Margherita",
                Description = "Traditional Italian pizza with tomatoes and basil",
                Price = 11.00m,
                Vegetarian = true,
                Vegan = false,
            }
        });
    }
}
