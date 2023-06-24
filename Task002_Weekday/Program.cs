/* Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/
Console.Clear();
Console.Write("Введите номер дня недели: ");
int numberDayOfWeek = Convert.ToInt32(Console.ReadLine());
while (numberDayOfWeek < 1 || numberDayOfWeek > 7)
{
    Console.Write("Введен не правильный номер");
    Console.Write("Введите номер дня недели: ");
    numberDayOfWeek = Convert.ToInt32(Console.ReadLine());
}if (numberDayOfWeek == 1)
{    Console.Write("Вы ввели цифру: 1, это - Понедельник.");
}if (numberDayOfWeek == 2)
{    Console.Write("Вы ввели цифру: 2, это - Вторник.");
}if (numberDayOfWeek == 3)
{    Console.Write("Вы ввели цифру: 3, это - Среда.");
}if (numberDayOfWeek == 4)
{    Console.Write("Вы ввели цифру: 4, это - Четверг.");
}if (numberDayOfWeek == 5)
{    Console.Write("Вы ввели цифру: 5, это - Пятница.");
}if (numberDayOfWeek == 6)
{    Console.Write("Вы ввели цифру: 6, это - Суббота.");
}if (numberDayOfWeek == 7)
{    Console.Write("Вы ввели цифру: 7, это - Воскресенье.");
}