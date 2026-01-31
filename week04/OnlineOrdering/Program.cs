using System;
//----Alumn: Erika Fabiola Sánchez Solano---
// --- MAIN PROGRAM ---
    class Program
    {
        static void Main(string[] args)
        {
            // Order 1: USA Customer
            Address addr1 = new Address("123 Maple St", "Seattle", "WA", "USA");
            Customer cust1 = new Customer("Alice Johnson", addr1);
            Order order1 = new Order(cust1);
            order1.AddProduct(new Product("Wireless Mouse", "M001", 25.50, 2));
            order1.AddProduct(new Product("Mechanical Keyboard", "K102", 75.00, 1));

            // Order 2: International Customer
            Address addr2 = new Address("456 Champs-Élysées", "Paris", "Île-de-France", "France");
            Customer cust2 = new Customer("Jean-Pierre", addr2);
            Order order2 = new Order(cust2);
            order2.AddProduct(new Product("USB-C Cable", "C55", 12.99, 3));
            order2.AddProduct(new Product("Monitor Stand", "S900", 45.00, 1));
            order2.AddProduct(new Product("Webcam", "W10", 89.90, 1));

            // Display Results
            List<Order> orders = new List<Order> { order1, order2 };

            foreach (var order in orders)
            {
                Console.WriteLine("========================================");
                Console.WriteLine(order.GetShippingLabel());
                Console.WriteLine();
                Console.WriteLine(order.GetPackingLabel());
                Console.WriteLine($"TOTAL PRICE: ${order.CalculateTotalCost():F2}");
                Console.WriteLine("========================================\n");
            }
        }
    }