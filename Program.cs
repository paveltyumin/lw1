//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите пятизначное число:");
        int number = int.Parse(Console.ReadLine());

        int digit1 = number / 10000;       // Первая цифра
        int digit2 = (number / 1000) % 10; // Вторая цифра
        int digit4 = (number / 10) % 10;   // Четвертая цифра
        int digit5 = number % 10;          // Пятая цифра

        if (digit1 == digit5 && digit2 == digit4)
        {
            Console.WriteLine("Число является палиндромом.");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом.");
        }
    }
}