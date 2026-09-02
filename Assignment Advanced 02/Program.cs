
using Assignment_Advanced_02;

List<Product> catalog = new()
{
    new Product { Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10 },
    new Product { Id=2, Name="Phone", Category="Electronics", Price=800, Stock=25 },
    new Product { Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
    new Product { Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
    new Product { Id=5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
    new Product { Id=6, Name="Coffee Beans", Category="Food", Price=15, Stock=80 },
    new Product { Id=7, Name="C# Book", Category="Books", Price=45, Stock=30 },
    new Product { Id=8, Name="Novel", Category="Books", Price=20, Stock=60 },
    new Product { Id=9, Name="Headphones", Category="Electronics", Price=150, Stock=40 },
    new Product { Id=10, Name="Jacket", Category="Clothing", Price=120, Stock=15 }
};
Func<Product, bool> searchvalid1 = (Elec) => Elec.Category.Equals("Electronics");
Func<Product, bool> searchvalid2 = (price) => price.Price < 50;
Func<Product, bool> searchvalid3 = (stock) => stock.Stock > 0;
Func<Product, bool> searchvalid4 = (p) => p.Category == "Clothing" && p.Price < 100;
List<Product> result1 = Product.SearchProducts(catalog, searchvalid1);
Console.WriteLine("- - -Electronics- - -");
foreach (Product product in result1)
{
    Console.WriteLine($"{product.Name}-${product.Price} (Stock:{product.Stock})");
}
List<Product> result2 = Product.SearchProducts(catalog, searchvalid2);
Console.WriteLine("\n- - -Under $50- - -");
foreach (Product product in result2)
{
    Console.WriteLine($"{product.Name}-${product.Price} (Stock:{product.Stock})");
}
List<Product> result3 = Product.SearchProducts(catalog, searchvalid3);
Console.WriteLine("\n- - -In Stock- - -");
foreach (Product product in result3)
{
    Console.WriteLine($"{product.Name}-${product.Price} (Stock:{product.Stock})");
}
List<Product> result4 = Product.SearchProducts(catalog, searchvalid4);
Console.WriteLine("\n- - -Clothing Under 100$- - -");
foreach (Product product in result4)
{
    Console.WriteLine($"{product.Name}-${product.Price} (Stock:{product.Stock})");
}
Console.WriteLine("\n- - -Print Reports- - - ");
Action<Product> Printreports1 = (p) => Console.WriteLine($"{p.Name} - Price: ${p.Price}");
Action<Product> Printreports2 = (p) => Console.WriteLine($"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock:{p.Stock}");
Console.WriteLine("- - -Short Report- - - ");
Product.PrintReports(catalog, Printreports1);
Console.WriteLine("\n- - -Detailed Report- - - ");
Product.PrintReports(catalog, Printreports2);