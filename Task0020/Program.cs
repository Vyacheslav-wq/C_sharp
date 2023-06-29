/*# Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/
Console.Clear();
Console.Write("Введите x1 ");
double x1 = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите y1 ");
double y1 = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите x2 ");
double x2 = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите y2 ");
double y2 = Convert.ToInt64(Console.ReadLine());
double d = Math.Sqrt(-5);

double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

Console.WriteLine($"d ={d}");