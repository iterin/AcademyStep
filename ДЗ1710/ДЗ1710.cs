//Задание №1
using System;
namespace ДЗ_1
{
	class Program
	{
		static void Main(string[] args)
		{
			char ch = ' ';
			int count = 0;
			while(ch != '.')
			{
				Console.Write("Введите символ: ");
				ch = Convert.ToChar(Console.ReadLine());
				if (ch == ' ')
					count++;
			}
			Console.WriteLine("Количество пробелов равно " + count);
		}
	}
}

//Задание № 2
using System;
namespace ДЗ_1
{
	class Program
	{
		static void Main(string[] args)
		{
			
			int num1 = 0, num2 = 0;
			Console.Write("Введите шестизначный номер билета: ");
			string str = Console.ReadLine();

			for (int i = 0; i <= 2; i++)
				num1 += Convert.ToInt32(str[i]);
			for (int i = 3; i <= 5; i++)
				num2 += Convert.ToInt32(str[i]);

			if (num1 == num2)
				Console.WriteLine("Билет счастливый");
			else
				Console.WriteLine("Билет не счастливый");
		}
	}
}

//Задание № 3
using System;
using System.Text;

namespace ДЗ_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите строку символов: ");
			string str = Console.ReadLine();

			foreach (var s in str)
			{
				if (s != ' ')
				{
					if ((int)s < 97)
						Console.Write((char)(s + 32));
					else
						Console.Write((char)(s - 32));
				}
				else Console.Write(' ');
			}
		}
	}
}

//Задание № 4
using System;
using System.Text;

namespace ДЗ_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите значение темпиратуры по Фаренгейту: ");
			double t = Convert.ToDouble(Console.ReadLine());

			double tf = ((t - 32) * 5) / 9;

			Console.WriteLine(tf);
		}
	}
}

//Задание № 5

using System;

namespace ДЗ_1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] a, b, c;
			double ab, ac, cb;
			double p, pl;
			Console.WriteLine("Введите координаты вершин треугольника");
			Console.WriteLine("Ведите коориднаты вершины A: ");
			a = new int[2];
			a[0] = Convert.ToInt32(Console.ReadLine());
			a[1] = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Ведите коориднаты вершины B: ");
			b = new int[2];
			b[0] = Convert.ToInt32(Console.ReadLine());
			b[1] = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Ведите коориднаты вершины C: ");
			c = new int[2];
			c[0] = Convert.ToInt32(Console.ReadLine());
			c[1] = Convert.ToInt32(Console.ReadLine());

			ab = Math.Sqrt(Math.Pow(a[0] - b[0], 2) + Math.Pow(a[1] - b[1], 2));
			ac = Math.Sqrt(Math.Pow(a[0] - c[0], 2) + Math.Pow(a[1] - c[1], 2));
			cb = Math.Sqrt(Math.Pow(c[0] - b[0], 2) + Math.Pow(c[1] - b[1], 2));
			p = (ab + ac + cb) / 2;

			pl = Math.Sqrt(p * (p - ab) * (p - ac) * (p - cb));

			Console.WriteLine("Площадь треугольника равна: {0}", pl);
		}
	}
}

//Задание № 6
using System;

namespace ДЗ_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите целое трехзначное число в диапазоне 100 - 999: ");
			string str = Console.ReadLine();

			switch (str[0])
			{
				case  '1': 
					Console.Write("Сто ");
					break;
				case '2': 
					Console.Write("Двести ");
					break;
				case '3':
					Console.Write("Тристо ");
					break;
				case '4':
					Console.Write("Четыресто ");
					break;
				case '5':
					Console.Write("Пятьсот ");
					break;
				case '6':
					Console.Write("Шестьсот ");
					break;
				case '7':
					Console.Write("Семьсот ");
					break;
				case '8':
					Console.Write("Восемьсот ");
					break;
				case '9':
					Console.Write("Девятьсот ");
					break;
				default:
					break;
			}

			switch (str[1])
			{
				case '2':
					Console.Write("двадцать ");
					break;
				case '3':
					Console.Write("тридцать ");
					break;
				case '4':
					Console.Write("сорок ");
					break;
				case '5':
					Console.Write("пятьдесят ");
					break;
				case '6':
					Console.Write("шестьдесят ");
					break;
				case '7':
					Console.Write("семьдесят ");
					break;
				case '8':
					Console.Write("восемьдесят ");
					break;
				case '9':
					Console.Write("девяносто ");
					break;
				default:
					break;
			}
			if (str[1] == '1')
			{
				switch (str[2])
				{
					case '1':
						Console.Write("одинадцать");
						break;
					case '2':
						Console.Write("двенадцать");
						break;
					case '3':
						Console.Write("тринадцать");
						break;
					case '4':
						Console.Write("четырнадцать");
						break;
					case '5':
						Console.Write("пятьнадцать");
						break;
					case '6':
						Console.Write("шестьнадцать");
						break;
					case '7':
						Console.Write("семьнадцать");
						break;
					case '8':
						Console.Write("восемьнадцать");
						break;
					case '9':
						Console.Write("девятьнадцать");
						break;
					default:
						break;
				}
			}
			else
			{
				switch (str[2])
				{
					case '1':
						Console.Write("один");
						break;
					case '2':
						Console.Write("два");
						break;
					case '3':
						Console.Write("три");
						break;
					case '4':
						Console.Write("четыре");
						break;
					case '5':
						Console.Write("пять");
						break;
					case '6':
						Console.Write("шесть");
						break;
					case '7':
						Console.Write("семь");
						break;
					case '8':
						Console.Write("восемь");
						break;
					case '9':
						Console.Write("девять");
						break;
					default:
						break;
				}
			}
		}
	}
}

