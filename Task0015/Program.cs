/*Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет,
 является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Clear();
Console.Write("Введите номер дня недели: ");
int numberDayOfWeek = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели цифру: {numberDayOfWeek},");
if (numberDayOfWeek < 6 || numberDayOfWeek > 7)
    Console.Write("Нет это не выходной день недели: ");

if (numberDayOfWeek == 6 || numberDayOfWeek == 7)
    Console.Write("Да - это выходной день недели.");
