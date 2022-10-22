/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Введите трехзначное число:");
int digit = Convert.ToInt32(Console.ReadLine());
if (digit < 100 || digit > 1000)
{
    Console.WriteLine("Некорректный ввод");
}
int digit1 = digit % 100;
int temp = digit1;
int digit2 = temp / 10;

Console.WriteLine($"Вторая цифра числа {digit} >> {digit2}");