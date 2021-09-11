#include <iostream>
using namespace std;

template <typename T>
class String
{
public:
    String() : String(10) {}
    explicit String(int length)  {
        this->size_ = length; 
        this->capacity = -1;
        this->string = new T[size_];
    }
    String(const char* str) : String() {
        this->capacity = sizeof(str);
        this->size_ = strlen(str);
        this->string = (T*)str;
    }
    String(T* str): String() {
        this->size_ = strlen(str);
        this->capacity = strlen(str);
        this->string = str;
    }
    String(const String& other) : String() {
        this->size_ = other.size_;
        this->capacity = other.capacity;
        copy(other.string, other.string + other.size_, this->string);
    }
    String(const String&& temp) : String() {
        this->size_ = temp.size_;
        this->capacity = temp.capacity;
        this->string = temp.string;

        temp.size_ = 0;
        temp.capacity = 0;
        temp.string = nullptr;
    }
    String& operator=(const String& other) {
        this->size_ = other.size_;
        this->capacity = other.capacity;
        copy(other.string, other.string + other.size_, this->string);
    }
    String& operator=(const String&& temp) {
        this->size_ = temp.size_;
        this->capacity = temp.capacity;
        this->string = temp.string;

        temp.size_ = 0;
        temp.capacity = 0;
        temp.string = nullptr;
    }
    void clear() {
        this->size_ = 0;
        this->capacity = 0;
        this->string = nullptr;
    }
    void empty() {
        this->size_ = 0;
        this->capacity = 0;
        this->string = nullptr;
        delete[] this->string;
    }
    int size() {
        return this->size_;
    }
    void isEmty() {
        if (this->size_)
            return true;
    }
    bool isSame(const String& other)const {
        if (this->string == other.string)
            return true;
        else
            return false;
    }

    bool isEqual(const String& other)const {
        if (*this->string == *other.string)
            return true;
        else
            return false;
    }
    void PrintString() {
        cout << (char*)string << endl;
    }
    void Printsize() {
        cout << this->size_ << endl;;
    }
private:
    T* string;
    int size_; 
    int capacity;
};

