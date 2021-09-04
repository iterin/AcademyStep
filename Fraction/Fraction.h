#include <iostream>
#include <ctype.h>
#include<stdlib.h>


class  Fraction {
public:
	Fraction() :
		sing(false),
		numerator(0),
		denominator(1)
	{};

	Fraction(bool sing, unsigned numerator, unsigned denominator) :Fraction() {
		this->sing = sing;
		this->numerator = numerator;
		this->denominator = denominator;
	};
	void setSing(bool sing) {
		this->sing = sing;
	};

	void setNumerator(unsigned numerator) {
		this->numerator = numerator;
	};

	void setDenominator(unsigned denominator) {
		try
		{
					
			if (denominator == 0) 
				throw std::exception("Знаменатель не может быть равен 0");
			this->denominator = denominator;
		}
		catch (std::exception& err)
		{
			std::cout << err.what();
			exit(1);
		}

	};

	bool getSing() const {
		return sing;
	};

	unsigned getNumerator()const {
		return numerator;
	};
	unsigned getDenominator() const {

	};

	Fraction operator+(const Fraction& other) const;
	Fraction operator-(const Fraction& other) const;
	Fraction operator*(const Fraction& other) const;
	Fraction operator/(const Fraction& other) const;

	void PrintFraction() {
		if (this->sing)
			std::cout << '+';
		else
			std::cout << '-';

		std::cout << this->numerator << '/' << this->denominator << std::endl;
	}

private:
	bool sing;
	unsigned numerator;
	unsigned denominator;
};

Fraction Fraction::operator+(const Fraction& other) const
{
	Fraction result;
	if (this->sing && other.sing)
	{
		result.numerator = this->numerator * other.denominator + this->denominator * other.numerator;
		result.setSing(true);
	}
	else if (!this->sing && !other.sing)
	{
		result.numerator = this->numerator * other.denominator + this->denominator * other.numerator;
		result.setSing(false);
	}
	else if (!this->sing && other.sing)
	{
		if (this->numerator * other.denominator > other.numerator * this->denominator)
		{
			result.numerator = this->numerator * other.denominator - this->denominator * other.numerator;
			result.setSing(false);
		}
		else
		{
			result.numerator = other.numerator * this->denominator - this->numerator * other.denominator;
			result.setSing(true);
		}
	}
	else if (this->sing && !other.sing)
	{
		if (this->numerator * other.denominator > other.numerator * this->denominator)
		{
			result.numerator = this->numerator * other.denominator - this->denominator * other.numerator;
			result.setSing(true);
		}
		else
		{
			result.numerator = other.numerator * this->denominator - this->numerator * other.denominator;
			result.setSing(false);
		}
	}

	result.denominator = this->denominator * other.denominator;
	return result;
}

Fraction Fraction::operator-(const Fraction& other) const
{
	Fraction result;
	if (this->sing && other.sing)
	{
		if (this->numerator * other.denominator > other.numerator * this->denominator)
		{
			result.numerator = this->numerator * other.denominator - this->denominator * other.numerator;
			result.setSing(true);
		}
		else
		{
			result.numerator = this->denominator * other.numerator - this->numerator * other.denominator;
			result.setSing(false);
		}
	}
	if (!this->sing && !other.sing)
	{
		if (this->numerator * other.denominator > other.numerator * this->denominator)
		{
			result.numerator = this->numerator * other.denominator - this->denominator * other.numerator;
			result.setSing(false);
		}
		else
		{
			result.numerator = this->denominator * other.numerator - this->numerator * other.denominator;
			result.setSing(true);
		}
	}

	if (!this->sing && other.sing)
	{
		result.numerator = this->numerator * other.denominator + this->denominator * other.numerator;
		result.setSing(false);
	}
	else if (this->sing && !other.sing)
	{
		result.numerator = this->numerator * other.denominator + this->denominator * other.numerator;
		result.setSing(true);
	}
	result.denominator = this->denominator * other.denominator;
	return result;
}

Fraction Fraction::operator*(const Fraction& other) const
{
	Fraction result;
	if ((this->sing && other.sing) || (!this->sing && !other.sing))
		result.sing = true;
	else
		result.sing = false;

	result.numerator = this->numerator * other.numerator;
	result.denominator = this->denominator * other.denominator;
	return result;
}

Fraction Fraction::operator/(const Fraction& other) const
{
	Fraction result;
	if ((this->sing && other.sing) || (!this->sing && !other.sing))
		result.sing = true;
	else
		result.sing = false;

	result.numerator = this->numerator * other.denominator;
	result.denominator = this->denominator * other.numerator;
	return result;
}