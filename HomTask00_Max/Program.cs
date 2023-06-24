/*Напишите программу, которая на вход принимает два числа и 
выдает, какое число больше, а какое меньше.
*/
Console.Clear();
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1;
int min = num2;
if (num2 > num1) max = num2; min = num1;
Console.WriteLine($"Вы ввели числа: {num1} и {num2},");
Console.Write($"Число: {max} больше, а число: {min} меньше.");