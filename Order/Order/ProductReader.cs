﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Order
{
	public class ProductReader : BaseModelReader
	{
		public ProductReader(string filename) : base(filename)
		{
		}

		public Product ReadNext()
		{
			if (!IsOpened)
				Open();
			var s = ReadLine();
			if (s == null)
				return null;
			return JsonSerializer.Deserialize<Product>(s);
		}

		public IEnumerable<Product> ReadAll()
		{
			if (IsOpened) Close();
			Product c;
			while ((c = ReadNext()) != null)
				yield return c;
		}
	}
}
