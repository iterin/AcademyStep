#include <iostream>
#include"Item.h"
#include "Car.h"
#include "Storage.h"

int rnd()
{
	srand(time(0));
	return rand() % 10 * 10;
}

int main()
{
	setlocale(LC_ALL, "Russian");

	Car car1, car2, car3;
	int count = 3 + rand() % 10;
	for (size_t i = 0; i < rnd(); i++)
	{
		if (rand() % 2)
		{
			car1.put(new SandLike("name" + char(i), rnd(), rnd()));
		}
		else
		{
			car1.put(new Counted("name" + char(i), rand() % 10, rnd(), rnd(), rnd()));
		}
	}
	for (size_t i = 0; i < rnd(); i++)
	{
		if (rand() % 2)
		{
			car2.put(new SandLike("name" + char(i), rnd(), rnd()));
		}
		else
		{
			car2.put(new Counted("name" + char(i), rnd(), rnd(), rnd(), rnd()));
		}
	}
	for (size_t i = 0; i < 10; i++)
	{
		if (rand() % 2)
		{
			car3.put(new SandLike("name" + char(i), rnd(), rnd()));
		}
		else
		{
			car3.put(new Counted("name" + char(i), rnd(), rnd(), rnd(), rnd()));
		}
	}

	Storage storage;
	while (!car1.isEmpty())
	{
		storage.putItem(car1.get());
	}

	std::cout << "Количество товаров: " << storage.getCountItems() << " на общую сумму: " << storage.getCosts() << std::endl;
}

