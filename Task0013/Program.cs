/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Clear();
Console.WriteLine("Введите цифру в итервале: от -2147483648, и до 2147483648");
int num = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"Вы ввели число: {num},");

if (num / 100 == 0)
    Console.WriteLine("В этом числе нет третьей цифры.");
else
{
    while (num / 1000 != 0)
    {
        num = num / 10;
        // удаляем все цифры с правой стороны.
    }
    int TrDig = num % 10;
    Console.WriteLine($"Третья цифра: {TrDig}");
}
