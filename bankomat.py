class BankomatClass:
    ValueMoney = 0
    money = 10000
    money1000 = 5
    money500 = 5
    money200 = 5
    money100 = 10
    money50 = 10
    y = "y"
    def CheckValueMoney(self, valueMoney):
        if (valueMoney % 50 != 0):
            return False
        else:  
            return True
    
    def MinMaxMoney(self, valueMoney):
            if (valueMoney > 1000):
                return 1000
            elif (valueMoney > 500):
                return 500
            elif (valueMoney > 200):
                return 200
            elif (valueMoney > 100):
                return 100
            else:
                return 50

    def func1(self, valueMoney):
        #print(not self.CheckValueMoney(valueMoney))
        if (not self.CheckValueMoney(valueMoney)):
            if (valueMoney > 1000):
                print("Рекомендуеться ", self.MinMaxMoney(valueMoney), " грн.")
            else:
                print("Рекомендуеться ", self.MinMaxMoney(valueMoney), " грн. или ", self.MinMaxMoney(valueMoney) * 2, " грн.")
            return

        if (self.money < valueMoney):
            print("Банкомат недостаточно средств.\n")
            return
        s = ""
        while (self.money > 0 and valueMoney > 0):
            if (self.money1000 > 0 and valueMoney >= 1000):
                self.money -= 1000
                valueMoney -= 1000
                self.money1000 -= 1
                s += "1000"
            elif (self.money500 > 0 and valueMoney >= 500):
                self.money -= 500
                valueMoney -= 500
                self.money500 -= 1
                s += "500"
            elif (self.money200 > 0 and valueMoney >= 200):
                self.money -= 200
                valueMoney -= 200
                self.money200 -= 1
                s += "200"
            elif (self.money100 > 0 and valueMoney >= 100):
                self.money -= 100
                valueMoney -= 100
                self.money100 -= 1
                s += "100"
            elif (self.money50 > 0 and valueMoney >= 50):
                self.money -= 50
                valueMoney -= 50
                self.money50 -= 1
                s += "50"

            if (valueMoney > 0):
                s += " + "
            else:
                s += " = " + str(self.ValueMoney) + " грн."
        print(s)

        if (self.money == 0):
            print("\nНет средства в банкомате!")


        print("\n\n=====================================")
        print("Осталось деньги: ", self.money, " грн.")
        print(self.money1000, " копьюров по 1000 грн.")
        print(self.money500, " копьюров по 500 грн.")
        print(self.money200, " копьюров по 200 грн.")
        print(self.money100, " копьюров по 100 грн.")
        print(self.money50, " копьюров по 50 грн.")
        print("=====================================\n")


bank = BankomatClass()

while(bank.y == "y"):
    print("Снять наличие деньги:")
    bank.ValueMoney = int(input("==> "))
    print()
    bank.func1(bank.ValueMoney)
    print("Продолжить работу? (y/n)")
    bank.y = input()
    print()
        
            