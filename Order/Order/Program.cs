using System;

namespace Order
{
	class Program
	{
		static void Main(string[] args)
		{
			var reader = new CustomerReader("Customers.json");
			foreach(var c in reader.ReadAll())
				Console.WriteLine($"{c.Id}, {c.Name}, {c.Phone}");
		}
	}
}
