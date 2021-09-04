#include<iostream>
#include<string>
#include <sstream>
#include "Fraction.h"
#include <ctype.h>
//Добавлены проверки на строки. Добавлена проверка знаменателя на ноль



int main()
{
	Fraction fraction1;
	Fraction fraction2;
	setlocale(LC_ALL, "Russian");

	std::string str;
	unsigned numerator1{ 0 }, denominator1{ 1 };
	unsigned numerator2{ 0 }, denominator2{ 1 };
	char sing1{}, sing2{};
		
	try
	{
		std::cout << "Введите числитель первой дроби дроби> "; 
		std::cin >> str;
		numerator1 = std::stoi(str);
		std::cout << "Введите знаменатель первой дроби> ";
		std::cin >> str;
		denominator1 = std::stoi(str);
	}
	catch (...)
	{
		std::cout << "Строка не является числом" << std::endl;
		return 0;
	}
	fraction1.setNumerator(numerator1);
	fraction1.setDenominator(denominator1);

	std::cout << "Введите знак первой дроби +/- >";
	std::cin >> sing1;
		
	if (sing1 == '+')
		fraction1.setSing(true);
	else if (sing1 == '-')
		fraction1.setSing(false);

	try
	{
		std::cout << "Введите числитель первой дроби дроби> ";
		std::cin >> str;
		numerator2 = std::stoi(str);
		std::cout << "Введите знаменатель первой дроби> ";
		std::cin >> str;
		denominator2 = std::stoi(str);
	}
	catch (...)
	{
		std::cout << "Строка не является числом" << std::endl;
		return 0;
	}

	fraction2.setNumerator(numerator2);
	fraction2.setDenominator(denominator2);

	std::cout << "Введите знак второй дроби +/- >";
	std::cin >> sing2;
		
	if (sing2 == '+')
		fraction2.setSing(true);
	else if (sing2 == '-')
		fraction2.setSing(false);

	std::cout << std::endl;

	std::cout << "Сумма дробей равна: ";
	(fraction1 + fraction2).PrintFraction();
	std::cout << "Разность дробей равна: ";
	(fraction1 - fraction2).PrintFraction();
	std::cout << "Поизведение дробей равно: ";
	(fraction1 * fraction2).PrintFraction();
	std::cout << "Частное дробей равно: ";
	(fraction1 / fraction2).PrintFraction();

}