/*Напишите программу, которая принимает на вход число (N) и выдаёт 
таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели число: {num},");
Console.WriteLine($"Таблица кубов от 1 до {num} будет:");
if (num != 0)
{
    if (num > 0)
    {
        for (int i = 1; i <= num; i++)
        {
            Console.Write(Math.Pow(i, 3));
            if (i != num)
                Console.Write(", ");
            else
                Console.WriteLine(".");
        }
    }
    else
    {
        for (int i = num; i <= 1; i++)
        {
            Console.Write(Math.Pow(i, 3));
            if (i != 1)
                Console.Write(", ");
            else
                Console.WriteLine(".");
        }
    }
}
else
    Console.WriteLine(0);

