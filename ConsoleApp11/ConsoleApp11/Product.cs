using System;
using System.Collections.Generic;
using System.Text;

namespace Order
{
	public class Product
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }

		Product() { }
		Product(Guid id, string name, decimal price)
		{
			Id = id;
			Name = name;
			Price = price;
		}
	}
}
