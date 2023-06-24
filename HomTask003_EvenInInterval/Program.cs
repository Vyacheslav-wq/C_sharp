/*Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
*/
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели число: {n},");
Console.WriteLine($"Четные числа: от 1 до {n},");
for (int a = 2; a < (n + 1); a += 2)
{
    Console.Write($"{a}, ");
}