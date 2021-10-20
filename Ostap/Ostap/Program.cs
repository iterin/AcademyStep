using System;

namespace Ostap
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите целое число (1 <= n <= 50): ");
			int n = Convert.ToInt32(Console.ReadLine());
			int count = 0;
			int[] array = new int[n];
			for (int i = 1; i <= n; i++)
			{
				if (i % 2 != 0)
					count++;
			}
			if (count % 2 == 0)
				Console.WriteLine("Black");
			else
				Console.WriteLine("Grimy");
		}
	}
}
