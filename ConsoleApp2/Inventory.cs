using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManagementSystem
{
    public class Inventory
    {
        private List<Product> products;

        public object Products { get; internal set; }

        public Inventory()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void PrintTotalNumberOfProducts()
        {
            Console.WriteLine($"Total number of products: {products.Count}");
        }

        public void PrintAllProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name}, {product.Price} RS, {product.Quantity}, {product.Type}");
            }
        }

        public void PrintProductsByType(string type)
        {
            var productsOfType = products.Where(p => p.Type.Equals(type, StringComparison.OrdinalIgnoreCase));
            foreach (var product in productsOfType)
            {
                Console.WriteLine($"{product.Name}, {product.Price} RS, {product.Quantity}, {product.Type}");
            }
        }

        public void RemoveProduct(string name)
        {
            products.RemoveAll(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
        public Product GetProductByName(string name)
        {
            return products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
        public void PrintProductQuantity(string name)
        {
            var product = GetProductByName(name);
            if (product != null)
            {
                Console.WriteLine($"{name} quantity: {product.Quantity}");
            }
            else
            {
                Console.WriteLine($"{name} not found in the inventory.");
            }
        }

        public decimal CalculateTotalPrice(string[] purchases)
        {
            decimal totalPrice = 0;
            foreach (var purchase in purchases)
            {
                var parts = purchase.Split(' ');
                var productName = parts[0];
                var quantity = int.Parse(parts[1]);

                var product = products.FirstOrDefault(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));
                if (product != null)
                {
                    totalPrice += product.Price * quantity;
                }
            }
            return totalPrice;
        }

        internal void UpdateQuantity(string productName, int newQuantity)
        {
            var product = products.FirstOrDefault(p => p.Name == productName);
            if (product != null)
            {
                product.Quantity += newQuantity;
            }
        }

    }
}
