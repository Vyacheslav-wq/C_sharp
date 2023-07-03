/*Напишите программу, которая на вход принимает число А, 
и на выход выдает сумму всех чисел от 1 го до А.*/

Console.Clear();
Console.Write("Введите число: ");

int GetSum(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}

int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели число: {n},");
Console.WriteLine($"Сумма от 1 до {n} равна: {GetSum(n)}");
