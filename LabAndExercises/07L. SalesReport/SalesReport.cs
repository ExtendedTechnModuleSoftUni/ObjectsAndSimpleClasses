namespace _07L.SalesReport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SalesReport
    {
        class Sales
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }

        }
        static void Main()
        {
            var salesByTown = new SortedDictionary<string, decimal>();
            Sales[] sales = ReadSales();

            GetSalesByTown(salesByTown, sales);

            PrintEachTownSales(salesByTown);
        }

        private static void PrintEachTownSales(SortedDictionary<string, decimal> salesByTown)
        {
            foreach (var town in salesByTown)
            {
                Console.WriteLine($"{town.Key} -> {town.Value:f2}");
            }
        }

        private static void GetSalesByTown(SortedDictionary<string, decimal> salesByTown, Sales[] sales)
        {
            foreach (var sale in sales)
            {
                var currentTown = sale.Town;
                var currentPrice = sale.Price;
                var currentQuantity = sale.Quantity;

                if (!salesByTown.ContainsKey(currentTown))
                {
                    salesByTown.Add(currentTown, 0);
                }

                salesByTown[currentTown] += currentPrice * currentQuantity;
            }
        }

        static Sales[] ReadSales()
        {
            int n = int.Parse(Console.ReadLine());
            Sales[] sales = new Sales[n];

            for (int i = 0; i < n; i++)
            {

                sales[i] = ReadSale();
            }

            return sales;
        }

        private static Sales ReadSale()
        {
            string[] items = Console.ReadLine().Split().ToArray();

            return new Sales
            {
                Town = items[0],
                Price = decimal.Parse(items[2]),
                Quantity = decimal.Parse(items[3])
            };
        }
    }
}
