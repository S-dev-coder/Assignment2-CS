 class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            // Adding products
            inventory.AddProduct(new Product("lettuce", 10.5m, 50, "Leafy green"));
            inventory.AddProduct(new Product("cabbage", 20, 100, "Cruciferous"));
            inventory.AddProduct(new Product("pumpkin", 30, 30, "Marrow"));
            inventory.AddProduct(new Product("cauliflower", 10, 25, "Cruciferous"));
            inventory.AddProduct(new Product("zucchini", 20.5m, 50, "Marrow"));
            inventory.AddProduct(new Product("yam", 30, 50, "Root"));
            inventory.AddProduct(new Product("spinach", 10, 100, "Leafy green"));
            inventory.AddProduct(new Product("broccoli", 20.2m, 75, "Cruciferous"));
            inventory.AddProduct(new Product("garlic", 30, 20, "Leafy green"));
            inventory.AddProduct(new Product("silverbeet", 10, 50, "Marrow"));

            // Printing total number of products
            inventory.PrintTotalNumberOfProducts();

            // Adding a new product
            inventory.AddProduct(new Product("Potato", 10, 50, "Root"));
            Console.WriteLine("\nList of all products after adding Potato:");
            inventory.PrintAllProducts();
            inventory.PrintTotalNumberOfProducts();

            // Printing products of type Leafy green
            Console.WriteLine("\nProducts of type Leafy green:");
            inventory.PrintProductsByType("Leafy green");

            // Removing garlic
            inventory.RemoveProduct("garlic");
            Console.WriteLine("\nTotal number of products after removing garlic:");
            inventory.PrintTotalNumberOfProducts();

            // Updating quantity of cabbage
            inventory.UpdateQuantity("cabbage", 50);
            Console.WriteLine("\nFinal quantity of cabbage in the inventory:");
            inventory.PrintProductQuantity("cabbage");

            // Calculating total price for purchases
            string[] purchases = { "lettuce 1", "zucchini 2", "broccoli 1" };
            decimal totalPrice = inventory.CalculateTotalPrice(purchases);
            Console.WriteLine($"\nTotal price for purchases: {totalPrice} RS");
        }
    }

