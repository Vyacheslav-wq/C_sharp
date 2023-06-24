/* Напишите программу, которая принимает на вход  трёхзначное число
и на выходе показывает последнюю цифру.
*/
Console.Clear();
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int y = num % 10;
Console.WriteLine($"Вы ввели трехзначное число: {num},");
Console.Write($"последняя цифра этого числа: {y}.");