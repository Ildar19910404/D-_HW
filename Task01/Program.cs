﻿/* 1. Напишите программу, которая на вход принимает два
числа и проверяет, является ли первое число квадратом
второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет */

System.Console.WriteLine("Введите первое число: ");
System.Console.WriteLine("Введите второе число: ");

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 * num1 == num2)
{
    Console.Write("Число является квадратом");
}
else
{
    Console.WriteLine("Нет");
}