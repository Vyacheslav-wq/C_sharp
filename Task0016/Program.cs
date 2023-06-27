// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 * num1 == num2 || num2 * num2 == num1) 
    Console.Write("Да.");
else 
    Console.Write("Нет.");

