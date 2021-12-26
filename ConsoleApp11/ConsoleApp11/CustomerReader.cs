using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Order
{
	public class CustomerReader : BaseModelReader
	{
		public CustomerReader(string filename) : base(filename)
		{ 
		}

		public Customer ReadNext()
		{
			if (!IsOpened) 
				Open();
			var s = ReadLine();
			if (s == null)
				return null;
			return JsonSerializer.Deserialize<Customer>(s);
		}

		public IEnumerable<Customer> ReadAll()
		{
			if (IsOpened) Close();
			Customer c;
			while ((c = ReadNext()) != null)
				yield return c;
		}
	}
}
