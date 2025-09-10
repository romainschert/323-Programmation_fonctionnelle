namespace Exercice_Marché_RomainSchertenleib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { Location = 1, Producer = "Bornand", ProductName = "Pommes", Quantity = 20,Unit = "kg", PricePerUnit = 5.50 },
                new Product { Location = 1, Producer = "Bornand", ProductName = "Poires", Quantity = 16,Unit = "kg", PricePerUnit = 5.50 },
                new Product { Location = 1, Producer = "Bornand", ProductName = "Pastèques", Quantity = 14,Unit = "pièce", PricePerUnit = 5.50 },
                new Product { Location = 1, Producer = "Bornand", ProductName = "Melons", Quantity = 5,Unit = "kg", PricePerUnit = 5.50 },
                new Product { Location = 2, Producer = "Dumont", ProductName = "Noix", Quantity = 20,Unit = "sac", PricePerUnit = 5.50 },
                new Product { Location = 2, Producer = "Dumont", ProductName = "Raisin", Quantity = 6,Unit = "kg", PricePerUnit = 5.50 },
                new Product { Location = 2, Producer = "Dumont", ProductName = "Pruneaux", Quantity = 13,Unit = "kg", PricePerUnit = 5.50 },
                new Product { Location = 2, Producer = "Dumont", ProductName = "Myrtilles", Quantity = 12,Unit = "kg", PricePerUnit = 5.50 },
            };

            var dictionary = new Dictionary<string, string>
{
                {"Pommes", "Apples"},
                {"Poires", "Pears"},
                {"Pastèques", "Watermelons"},
                {"Melons", "Melons"},
                {"Noix", "Nuts"},
                {"Raisin", "Grapes"},
                {"Pruneaux", "Plums"},
                {"Myrtilles", "Blueberries"}
            };

            var result = products.Select(p => new Product
            {
                Producer = new string(p.Producer
                .Take(3)
                .Concat("...")
                .Concat(new[] { p.Producer.Last() })
                .ToArray()),

                ProductName = dictionary[p.ProductName],
                CA = p.PricePerUnit * p.Quantity,
            }).ToList();
             

            Console.WriteLine("Seller\tProduct\tCA");
            foreach (var r in result)
            {
                Console.WriteLine($"{r.Producer}\t{r.ProductName}\t{r.CA}");
            }

        }
    }
}