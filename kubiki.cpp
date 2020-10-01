#include <iostream>
#include <ctime>
using namespace std;

class Person
{
    private:
    int array[2];
    public:
    Person()
    {
        srand(time(NULL));
        cout << "Бросить 2 кубики:" << endl;
        for(int i = 0; i < 2; i++)
        {
            array[i] = 1 + rand() % 6;
        }
    }


    int func1()
    {
        for(int i = 0; i < 2; i++)
        {
            cout << array[i] << "  ";
        }
        cout << "\nРезультат:" << endl;
        
        if(array[0] == array[1])
        {
            for(int i = 0; i < 4; i++)
            {
                if(i != 3)
                {
                    cout << array[0] << " + ";
                }
                else
                {
                    cout << array[0];
                }
            }
            cout << " = ";
            return array[0] * 4;
        }
        else
        {
            cout << array[0] << " + " << array[1] << " = ";
            return array[0] + array[1];
        }
    }

};

int main()
{
    Person per = Person();
    cout << per.func1() << endl;
    return 0;
}