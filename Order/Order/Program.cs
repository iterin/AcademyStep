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

			var tagertPrice = product.ReadAll()
				.Join(order.ReadAll(), p => p.Id, o => o.Product, (p, o) => new { p.Price, o.Customer })
				.Join(customer.ReadAll(), p => p.Customer, c => c.Id, (p, c) => new { p.Price, c.Name })
				.Where(c => c.Name == custmonerName)
				.Sum(c => c.Price);

			Console.WriteLine($"Сумма заказов заказчика {custmonerName} равна {tagertPrice}");

			//var countProduct = product.ReadAll()
			//	.Join(order.ReadAll(), p => p.Id, o => o.Product, (p, o) => new { p.Price, p.Name })
			//	.Where(p => p.Name == productName)
			//	.Sum(x => x.Price);
		}
	}
}
