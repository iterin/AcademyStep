using System;
using System.Collections.Generic;
using System.Text;

namespace Order
{
	public class Order
	{
		public Guid Customer { get; set; }
		public Guid Product { get; set; }
		Order() { }
		Order(Guid customerId, Guid productId)
		{
			customerId = Customer;
			productId = Product;
		}
	}
}
