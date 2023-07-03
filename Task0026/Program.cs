/*Напишите программу, которая на вход принимает число и на выход
выдает колличество цифр этого числа.*/
Console.Clear();
Console.Write("Введите число: ");

int CountNum(int n)
{
    int count = 0;
    if (n < 0)
        n *= (-1);
    while (n > 0)
    {
        n /= 10;
        count ++;
    }
    return (count);
}
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели число: {n},");
Console.WriteLine($"Колличество цифр в числе: {CountNum(n)}.");

