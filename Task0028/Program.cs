/*Напишите программу, которая принимает число N, и выдает 
произведение чисел от 1 до N.*/
Console.Clear();
Console.Write("Введите число: ");

int ProductOfNum(int n)
{
    int pum = 1;
    for (int i = 1; i <= n; i++)
    {
        pum *= i;
    }
    return pum;
}

int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели число: {n},");
Console.WriteLine($"Произведение чисел от 1 до {n} равно: {ProductOfNum(n)}");

