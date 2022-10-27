/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
5 ->
1 | 1
2 | 8
3 | 27
4 | 64
5 | 125 */

void Table(int digit)
{
    if (digit > 0)
    {
      int count = 1;
      while (count <= digit)
      {
        Console.WriteLine($"{count,4} {count*count*count,4}");
        count ++;
      }
    }
    else Console.WriteLine("Некорректный ввод");
}

Console.WriteLine("Введите натуральное число: ");
int digit = Convert.ToInt32(Console.ReadLine());

Table(digit);