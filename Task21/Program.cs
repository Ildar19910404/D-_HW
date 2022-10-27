/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53  */


double Distance(int dotA1, int dotA2, int dotA3, int dotB1, int dotB2, int dotB3)
{
    double distance = Math.Sqrt(Math.Pow(dotA1 - dotB1, 2) + Math.Pow(dotA2 - dotB2, 2) + Math.Pow(dotA3 - dotB3, 2));
    return Math.Round(distance, 2, MidpointRounding.ToZero);
}


Console.Write("Введите первую координату точки А: ");
int dotA1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую координату точки А: ");
int dotA2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью координату точки А: ");
int dotA3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первую координату точки B: ");
int dotB1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую координату точки B: ");
int dotB2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью координату точки B: ");
int dotB3 = Convert.ToInt32(Console.ReadLine());

double distance = Distance (dotA1, dotA2, dotA3, dotB1, dotB2, dotB3);
Console.WriteLine($"Расстояние между точками А({dotA1},{dotA2},{dotA3}) и B({dotB1},{dotB2},{dotB3}) равняется {distance}");