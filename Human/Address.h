#pragma once
#include<iostream>

using Number = int;
class Address {
public:
   Address() = delete;
   Address(std::string street, Number house, Number appartment, Number buildingAge) :
        street(street),
        house(house),
        appartment(appartment),
        buildingAge(buildingAge)
    { }
    void setStreet(std::string street) {
        this->street = street;
    }
    void setHouse(Number house) {
        this->house = house;
    }
    void setAppartment(Number appartment) {
        this->appartment = appartment;
    }
    void setBuildingAge(Number buildingAge) {
        this->buildingAge = buildingAge;
    }
    std::string getStreet() const {
        return this->street;
    }
    Number getHouse()const {
        return this->house;
    }
    Number getAppartment() const {
        return this->appartment;
    }
    Number getBuildingAge() {
        return this->buildingAge;
    }
private:
    std::string street;
    Number house;
    Number appartment;
    Number buildingAge;
};