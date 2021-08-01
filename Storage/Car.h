#pragma once
#include<time.h>
#include<list>
#include<queue>
#include "Item.h"

//Нет здесь никаких изменений
class Car 
{
public:
	Car() : id(0), furage() {}
	void put(Item *obj) 
	{
		furage.push(obj);
	}
	Item* get() 
	{
		auto result = furage.back();
		furage.pop();
		return result;
	}
	bool isEmpty()
	{
		return furage.empty();
	}
private:
	int id;
	std::queue<Item*> furage;
};
