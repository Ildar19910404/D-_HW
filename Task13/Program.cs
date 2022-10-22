/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());
int temp = 1;
if (digit < 100) System.Console.WriteLine("Третьей цифры нет");
if (digit > 100 && digit < 1000) temp = digit % 10;
if (digit > 1000 && digit < 100000) temp = digit / 100 % 10;


Console.WriteLine($"Третьей цифрой числа {digit} является -> {temp}");