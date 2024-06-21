using System.Text.RegularExpressions;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
public class Palindrom
{
    class Program
    {
        static void Main()
        {
            //Каждое задание нужно проверять по отдельности.
            //Task1 Пользователь вводит число от 1 до 9999 (сумму выдачи в банкомате). Необходимо вывести на экран введенную сумму и в конце написать название валюты с правильным окончанием. 
            //Например: 1 доллар, 70 долларов. Для решения этой задачи вам необходимо будет применять оператор % (остаток от деления).
            Console.Write("Введите сумму (от 1 до 9999): ");
            int amount = int.Parse(Console.ReadLine());

            string currencyName = "доллар";
            string ending;

            if (amount % 10 == 1 && amount % 100 != 11)
                ending = "";
            else if ((amount % 10 >= 2 && amount % 10 <= 4) && (amount % 100 < 10 || amount % 100 >= 20))
                ending = "а";
            else
            {

                ending = "ов";
            }
            Console.WriteLine($"{amount} {currencyName}{ending}");

            //Task2 Пользователь вводит число с клавиатуры. С использованием цикла for проверить, является ли это число простым.

            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            bool isPrime = true;

            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"Число {number} является простым.");
            }
            else
            {
                Console.WriteLine($"Число {number} не является простым.");
            }
            //Task3 Пользователь вводит число с клавиатуры. С помощью цикла while вывести все его цифры справа налево.

            Console.Write("Введите число: ");
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            bool buffer = true;
            while (buffer)
            {
                Array.Reverse(arr);
                buffer = false;
            }

            Console.WriteLine(arr);

            //Task4 Пользователь вводит число с клавиатуры. С использованием цикла for проверить, является ли это число числом Армстронга.
            Console.Write("Введите число: ");
            string str = Console.ReadLine();

            int number = Convert.ToInt32(str);
            int degree = str.Length;
            int buffer = 0;

            for (int i = number; i > 0; i /= 10)
            {
                int digit = i % 10;
                buffer += (int)Math.Pow(digit, degree);
            }

            if (buffer == number)
            {
                Console.WriteLine("Это число Армстронга");
            }
            else
            {
                Console.WriteLine("Это обычное число");
            }
            //Task5 Начальный вклад в банке равен 10000 грн. Через каждый месяц размер вклада увеличивается на P процентов от имеющейся суммы (P — вещественное число, 0 < P < 25). 
            //Значение Р программа должна получать у пользователя. 
            //По данному P определить, через сколько месяцев размер вклада превысит 11000 грн., и вывести найденное количество месяцев K (целое число) и итоговый размер вклада S (вещественное число).
            double initialDeposit = 10000.0;
            double targetDeposit = 11000.0;
            Console.Write("Введите значение P (в процентах, от 0 до 25): ");
            double P = double.Parse(Console.ReadLine());

            if (P <= 0 || P > 25)
            {
                Console.WriteLine("Ошибка: значение P должно быть в пределах (0, 25).");
                return;
            }
            int months = 0;
            double currentDeposit = initialDeposit;
            while (currentDeposit <= targetDeposit)
            {
                currentDeposit += currentDeposit * (P / 100);
                months++;
            }
            Console.WriteLine($"Количество месяцев: {months}");
            Console.WriteLine($"Итоговый размер вклада: {currentDeposit} грн.");
        }
    }
    
}
