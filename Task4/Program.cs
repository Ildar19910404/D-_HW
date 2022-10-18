/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */
Console.Write("Введите 3 числа: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int maximum = a;
if (a < b && b < c)
{
    Console.WriteLine($"{c} == maximum");
}
if (a > b && a > c)
{
    Console.WriteLine($"{a} == maximum");
}
if (a < b && b > c)
{
    Console.WriteLine($"{b} == maximum");
}