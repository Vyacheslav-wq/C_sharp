/*
Напишите программу, которая на вход
принимает число и выдает его квадрат.
*/
Console.Clear();
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int resalt = number * number;
Console.WriteLine($"Число: {resalt} является квадратом числа: {number}");
