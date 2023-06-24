/*
Напишите программу, которая на вход
принимает два числа и выдает является
ли первое число квадратом второго.
*/
Console.Clear();
Console.Write("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
    Console.WriteLine($"Да число: {number1} является квадратом числа: {number2}");
else
    Console.WriteLine($"Нет число: {number1} не является квадратом числа: {number2}");