using System;
using System.Collections;
using System.Collections.Generic;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("имя: ");
            string name = "Ruslan";
            string username = Console.ReadLine();
            Console.Write("пароль: ");
            int password = 2482;
            int userpassword = int.Parse(Console.ReadLine());
            if (name==username&&password==userpassword)
            {
                Console.WriteLine("Добро пожаловать ");
            }
            else
            {
                Console.WriteLine("Не правильеный логин или пароль ");
            }
            ATM myATM = new ATM(300);
            Cart myCart = new Cart(2500);
            Console.WriteLine(" Выбирите ниже перечисленные функции");
            Console.WriteLine("1. Посмотреть балансе:");
            Console.WriteLine("2. Вывести деньги с баласа:");
            Console.Write("Фенкции: ");
            byte choice = byte.Parse(Console.ReadLine());
          
            switch (choice)
            {
                case 1:
                    myATM.balance(myCart);
                    break;
                case 2:
                    myATM.check_Balance(myCart);
                    break;
                default:
                    Console.WriteLine("Нет такой функции!!");
                    break;
            }
        }
        class ATM 
        {
            private int MaxBalance;
            public void check_Balance(Cart cart) 
            {
                Console.WriteLine("Сколько хотите вывести с баланса: ");
                int money = int.Parse(Console.ReadLine());
                if (money>cart.Cash)
                {
                    Console.WriteLine("На ващем балансе нет столько денег: ");
                }
               else if (money > MaxBalance )
                {
                    Console.WriteLine("Максималный вывод с баласна ");
                }
                else
                {
                    cart.Cash -= money;
                    balance(cart);
                }
            }
            public void balance(Cart cart)
            {
                Console.WriteLine($"На ващем балансе {cart.Cash} AZN");
            }
            public ATM(int Maxsimum)
            {
                MaxBalance = Maxsimum;
            }
        }
        class Cart 
        {
            public int Cash { get; set; }
            public Cart(int input_cash)
            {
                Cash = input_cash;
            }

        }

    }
}
