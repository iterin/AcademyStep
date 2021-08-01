#include<string>
#pragma once

class Item 
{
public:
	Item() :cost(0), name("") {}
	Item(std::string name, int cost) : cost(cost), name(name) {}
	
	void setCost(int cost) 
	{
		this->cost = cost;
	}	
	void setName(std::string name) 
	{
		this->name = name;
	}
	std::string getName() const 
	{
		return name;
	}
	int getCost() const 
	{
		return cost;
	}
private:
	std::string name;
	int cost;
};

class SandLike :public Item
{
public:
	SandLike(std::string name, int cost, float volume) : Item(name, cost), volume(volume) {}
	float getvolume() const
	{
		return volume;
	}
private:
	float volume;
};

class Counted :public Item 
{
public:
	Counted(std::string name, int cost, int length, int width, int higth) : Item(name, cost), length(length), width(width), higth(higth) {}
	int getVolume() 
	{
		return length * width * higth;
	}
private:
	int length;
	int width;
	int higth;
};