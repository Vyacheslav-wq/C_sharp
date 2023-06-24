/*Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.
*/
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы ввели число: {n}, ");
Console.WriteLine($"Целые числа в промежутке от -{n} до {n}:");
for (int i = -n; i < n + 1; i++)
{
    Console.Write($"{i}, ");
}
