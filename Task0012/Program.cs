/* Напишите программу, которая будет принимать на вход два числа и выводить,
является ли второе число кратным первому. Если число 2 не кратно числу 1,
то программа выводит остаток от деления.
*/
Console.Clear();
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"Вы ввели: {num1}, {num2}, (первое и второе числа.) ");
if (num1 % num2 == 0)
{
    Console.WriteLine("Кратно. (первое число кратно второму числу).");
}
else
{
    Console.WriteLine("Не кратно. (первое число не кратно второму числу),");
    Console.WriteLine($"Остаток: {num1 % num2},");
}
