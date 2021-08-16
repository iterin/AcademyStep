#pragma once
#include<iostream>
#include "Address.h"

class Human {
public:
    Human() = delete;
    Human(std::string name, std::shared_ptr<Address> registration) :
        name(name),
        registration(registration)
    {}
    void setName(std::string name) {
        this->name = name;
    }
    void setRegistration(std::shared_ptr<Address> registration) {
        this->registration.swap(registration);
    }
    std::string getName()const {
        return this->name;
    }
    std::weak_ptr<Address> getRegistration()const {
        return registration;
    }
    Number getBuildingAge() {
        return registration->getBuildingAge();
    }
private:
    std::string name;
    std::shared_ptr<Address> registration;
};
