using System;
using System.Collections.Generic;
using System.Text;

namespace Order
{
	public class Customer
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
        
        public List<Product> Products { get; set; }

		Customer() 
        {
            Products = new List<Product>();
        }
		Customer(Guid id, string name, string phone, string email, List<Product> products)
		{
			Id = id;
			Name = name;
			Phone = phone;
			Email = email;
            Products = products;
		}
	}
}
