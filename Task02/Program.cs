//  3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

System.Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 1 || a > 7)
{
    System.Console.WriteLine("Такого дня нет");
}
if (a == 1)
    System.Console.WriteLine("Понедельник");
if (a == 2)
    System.Console.WriteLine("Вторник");
if (a == 3)
    System.Console.WriteLine("Среда");
if (a == 4)
    System.Console.WriteLine("Четверг");
if (a == 5)
    System.Console.WriteLine("Пятница");
if (a == 6)
    System.Console.WriteLine("Суббота");
if (a == 7)
    System.Console.WriteLine("Воскресенье");
