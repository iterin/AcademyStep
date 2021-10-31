using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] ar1 = { 1, 3, 4, 5, 6, 7 };
			int[] ar2 = { 4, 6, 7, 8, 4, 5 };
			int[] array = new int[0];

			foreach(int e in ar1)
			{
				if (Array.Exists(ar2, el => el == e))
				{
					Array.Resize(ref array, array.Length + 1);
					array[array.Length - 1] = e;
				}
			}

			foreach (int e in array)
				Console.WriteLine(e);
		}
	}
}
