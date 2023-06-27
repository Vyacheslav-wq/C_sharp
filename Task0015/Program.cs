/*Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет,
 является ли этот день выходным.
*/
Console.Clear();
Console.Write("Введите номер дня недели: ");
int numberDayOfWeek = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели цифру: {numberDayOfWeek},");
while (numberDayOfWeek < 1 || numberDayOfWeek > 7)
{
    Console.Clear();
    Console.WriteLine($"Вы ввели цифру: {numberDayOfWeek}");
    Console.WriteLine("это не верный номер дня недели");
    Console.Write("Введите правильный номер дня недели: ");
    numberDayOfWeek = Convert.ToInt32(Console.ReadLine());
}
if (numberDayOfWeek < 6 || numberDayOfWeek > 7)
    Console.Write("Нет это не выходной день недели: ");

if (numberDayOfWeek == 6 || numberDayOfWeek == 7)
    Console.Write("Да - это выходной день недели.");
