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

		Customer() { }
		Customer(Guid id, string name, string phone, string email)
		{
			Id = id;
			Name = name;
			Phone = phone;
			Email = email;
		}
	}
}
