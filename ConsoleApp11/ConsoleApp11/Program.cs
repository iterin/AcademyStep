using System;
using System.Linq;

namespace Order
{
	class Program
	{
		static void Main(string[] args)
		{
			string custmonerName = "Ilya Pavlovich";
			string productName = "Product9";

			var customer = new CustomerReader("Customers.json");
			var product = new ProductReader("Product.json");
			var order = new OrderReader("Orders2.json");

            var customers = customer.ReadAll().ToArray();
            var products = product.ReadAll().ToArray();
;
            order.ReadAll(products, customers);

            foreach (var c in customers)
            {
                foreach (var p in c.Products)
                    Console.WriteLine($"Заказчик {c.Name} заказ {p.Name}");
            }
        }
	}
}
