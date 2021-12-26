using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Linq;

namespace Order
{
	public class OrderReader : BaseModelReader
	{
		public OrderReader(string filename) : base(filename)
		{ 
		}

		public Order ReadNext()
		{
			if (!IsOpened)
				Open();
			var s = ReadLine();
			if (s == null)
				return null;
			return JsonSerializer.Deserialize<Order>(s);
		}

		public void ReadAll(IEnumerable<Product> products, IEnumerable<Customer> customers)
		{
			if (IsOpened) Close();
			Order c;
			while ((c = ReadNext()) != null)
            {
                var customer = customers.FirstOrDefault(x => x.Id == c.Customer);
                var product = products.FirstOrDefault(x => x.Id == c.Product);
                if(product != null)
                    customer.Products.Add(product);
                else
                    throw new ArgumentNullException("Продукт не существует ");
                 
            }           
		}

	}
}
