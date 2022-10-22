/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

string Dd(int digit)
{
    switch (digit)
    {
        case 1:
            return "Понедельник";
        case 2:
            return "Вторник";
        case 3:
            return "Среда";
        case 4:
            return "Четверг";
        case 5:
            return "Пятница";
        case 6:
            return "Суббота";
        case 7:
            return "Воскресенье";
        default:
            return "Некорректный ввод";
    }
}
Console.WriteLine("Введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Dd(digit));

if (digit >= 1 && digit <= 5)
{
    Console.Write("Будний день");
}
if (digit >= 6 || digit <= 7)
{
    Console.Write("Выходной день");
}

/* Console.WriteLine("Введите число");
int day = Convert.ToInt32(Console.ReadLine());
if (day < 1 || day > 7) Console.WriteLine("Некорректный ввод");
else if (day == 1) Console.WriteLine($"Monday, будни");
else if (day == 2) Console.WriteLine($"Tuesday, будни");
else if (day == 3) Console.WriteLine($"Wednesday, будни");
else if (day == 4) Console.WriteLine($"Thursday, будни");
else if (day == 5) Console.WriteLine($"Friday, будни");
else if (day == 6) Console.WriteLine($"Saturday, является выходным");
else if (day == 7) Console.WriteLine($"Sunday, является выходным"); */