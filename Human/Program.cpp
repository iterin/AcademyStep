#include <iostream>
#include <deque>
#include<algorithm>
#include "Human.h"

int main()
{
    Human first("Vasiliy", std::make_shared<Address>("Plushkina", 12, 2, 1976));
    Human second("Adam", std::make_shared<Address>("Amundsena", 23, 5, 1977));
    Human third("Eva", std::make_shared<Address>("Bardina", 4, 7, 1980));

    //std::cout << std::shared_ptr<Address>(first.getRegistration())->getHouse();
    std::deque<std::shared_ptr<Human>> q;//step 1 create queue
    q.push_back(std::make_shared<Human>(first));
    q.push_back(std::make_shared<Human>(second));
    q.push_back(std::make_shared<Human>(third));
    std::sort(
        q.begin(),
        q.end(),
        [](std::shared_ptr<Human> A, std::shared_ptr<Human> B)->bool {
            return A->getBuildingAge() < B->getBuildingAge();
        }
    );

    std::cout << q.front()->getBuildingAge();
}