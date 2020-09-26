#include <iostream>
#include <cstring>
#include <cctype>
using namespace std;

class Class1
{
private:
    int money = 10000,
        money1000 = 5,
        money500 = 5,
        money200 = 5,
        money100 = 10,
        money50 = 10;

    int CheckValueMoney(int valueMoney)
    {
        if (valueMoney % 50)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }

    int MinMaxMoney(int valueMoney)
    {
        if (valueMoney > 1000)
        {
            return 1000;
        }
        else if (valueMoney > 500)
        {
            return 500;
        }
        else if (valueMoney > 200)
        {
            return 200;
        }
        else if (valueMoney > 100)
        {
            return 100;
        }
        else
        {
            return 50;
        }
    }

public:
    int ValueMoney = 0;
    char y = 'y';
    Class1()
    {
        system("chcp 65001");
    }

    void func1(int valueMoney)
    {

        if (!CheckValueMoney(valueMoney))
        {
            if (valueMoney > 1000)
            {
                cout << "Рекомендуеться " << MinMaxMoney(valueMoney) << " грн." << endl;
            }
            else
            {
                cout << "Рекомендуеться " << MinMaxMoney(valueMoney) << " грн. или " << (MinMaxMoney(valueMoney)) * 2 << " грн." << endl;
            }
            return;
        }

        if (money < valueMoney)
        {
            cout << "Банкомат недостаточно средств.\n"
                 << endl;
            return;
        }

        while (money && valueMoney)
        {
            if (money1000 && valueMoney >= 1000)
            {
                money -= 1000;
                valueMoney -= 1000;
                money1000--;
                cout << "1000";
            }
            else if (money500 && valueMoney >= 500)
            {
                money -= 500;
                valueMoney -= 500;
                money500--;
                cout << "500";
            }
            else if (money200 && valueMoney >= 200)
            {
                money -= 200;
                valueMoney -= 200;
                money200--;
                cout << "200";
            }
            else if (money100 && valueMoney >= 100)
            {
                money -= 100;
                valueMoney -= 100;
                money100--;
                cout << "100";
            }
            else if (money50 && valueMoney >= 50)
            {
                money -= 50;
                valueMoney -= 50;
                money50--;
                cout << "50";
            }

            if (valueMoney)
            {
                cout << " + ";
            }
            else
            {
                cout << " = " << ValueMoney << " грн.";
            }
        }

        if (!money)
        {
            cout << "\nНет средства в банкомате!" << endl;
        }

        cout << "\n\n=====================================" << endl;
        cout << "Осталось деньги: " << money << " грн." << endl;
        cout << money1000 << " копьюров по 1000 грн." << endl;
        cout << money500 << " копьюров по 500 грн." << endl;
        cout << money200 << " копьюров по 200 грн." << endl;
        cout << money100 << " копьюров по 100 грн." << endl;
        cout << money50 << " копьюров по 50 грн." << endl;
        cout << "=====================================\n"
             << endl;
    }
};

int main()
{
    Class1 class1 = Class1();
    class1.func1(class1.ValueMoney);
    while (class1.y == 'y')
    {
        cout << "Снять наличие деньги:" << endl;
        cout << "==> ";
        cin >> class1.ValueMoney;
        cout << endl;
        class1.func1(class1.ValueMoney);
        cout << "Продолжить работу? (y/n)" << endl;
        cin >> class1.y;
        int i = tolower(class1.y);
        class1.y = i;
        cout << endl;
    }
    return 0;
}