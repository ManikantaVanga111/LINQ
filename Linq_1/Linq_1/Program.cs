namespace Linq_1

{
    class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
    class Details
    {
        List<Product> products;
        public void SeedData()
        {
            products = new List<Product>()
            {
                new Product {ProductId = "P001", ProductName = "Laptop", Brand = "Dell", Quantity = 5, Price = 35000},
                new Product {ProductId = "P002", ProductName = "Camera", Brand = "Canon", Quantity = 8, Price = 28500},
                new Product {ProductId = "P003", ProductName = "Tablet", Brand = "Lenovo", Quantity = 4, Price = 15000},
                new Product {ProductId = "P004", ProductName = "Mobile", Brand = "Apple", Quantity = 9, Price = 65000},
                new Product {ProductId = "P005", ProductName = "Earphones", Brand = "Boat", Quantity = 2, Price = 1500},
            };
            var query = from p in products where p.Price >= 20000 && p.Price <= 40000 select p;
            Console.WriteLine("ProductName with price between 20000 and 40000");
            foreach (Product p in query)
            {
                Console.WriteLine($"{p.ProductName}");
            }
            var item = products.Where(p => p.ProductName.Contains('A'));
            foreach (Product p in item)
            {
                Console.WriteLine($"{p.ProductName}");
            }
            var Sort = products.OrderBy(p => p.ProductName);
            Console.WriteLine("Product Name based on Alphabetical Order");
            foreach (Product p in Sort)
            {
                Console.WriteLine($"{p.ProductName} {p.ProductId}  {p.Brand} {p.Quantity} {p.Price}");
            }
            var maximum = products.Max(p => p.Price);
            Console.WriteLine($"Product with highest price : {maximum}");

            var exist = products.Any(p => p.ProductId == "P003");
            Console.WriteLine($"Product with ProductId P003 exists in Products: {exist}");


        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Details Sc = new Details();
            Sc.SeedData();




        }
    }
}