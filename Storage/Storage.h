#pragma once
#include <iostream>
#include"Item.h"
#include "Car.h"
#include <list>

class Storage
{
public:
	void putItem(Item *obj)
	{
		listItem.push_back(obj);
		countItems++;
		costItems = costItems + obj->getCost();
	}
	int getCosts()
	{
		return costItems;
	}
	int getCountItems()
	{
		return countItems;
	}
private:
	int countItems;
	int costItems;
	std::list<Item*> listItem;
};

