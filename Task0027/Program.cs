/*Напишите программу, которая принимает на вход число и выдаёт 
сумму цифр в числе.*/
Console.Clear();
Console.Write("Введите число: ");

int SumNum(int n)
{
    
    int sum = 0;
    while (n > 0)
    {
        sum += n % 10;
        n /= 10;
    }
    return (sum);
}
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Вы ввели число: {n},");
Console.WriteLine($"Сумма цифр в числе: {SumNum(n)}.");