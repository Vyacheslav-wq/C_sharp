/*Напишите программу, которая принимает на вход трехзначное 
// число и на выходе показывает вторую цифру этого числа
*/

Console.Clear();
Console.Write("Введите трех значное число: ");
// int num = new Random().Next(100, 1000);
int num = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"Вы ввели число: {num},");

int a = num%100;
int b = a / 10;
Console.WriteLine($"Вторая цифра: {b}.");