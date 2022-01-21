using System;
using System.Linq;

namespace Order
{
	class Program
	{
		static void Main(string[] args)
		{
			string custmonerName = "Ilya Pavlovich";
			string productName = "Product6";

			var customer = new CustomerReader("Customers.json");
			var product = new ProductReader("Product.json");
			var order = new OrderReader("Orders2.json");

            var customers = customer.ReadAll().ToArray();
            var products = product.ReadAll().ToArray();
;
            order.ReadAll(products, customers);

			var SumOrders = customers.Where(c => c.Name == custmonerName).FirstOrDefault().Products.Sum(x => x.Price);
			Console.WriteLine($"Сумма заказов {custmonerName} равна {SumOrders}");

			var CountProducts = customers.Sum(c => c.Products.Count(p => p.Name == productName));		
			Console.WriteLine($"Количество проданого { productName} равно {CountProducts}");

        }
	}
}
