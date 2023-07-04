/*Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.*/
Console.Clear();
Console.Write("Введите число основание: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число степень: ");
int B = Convert.ToInt32(Console.ReadLine());

int RaiseDegree(int n, int degree)
{
    int c = 1;
    for (int i = 1; i <= degree; i++)
    {
        c = c * n;
    }
    return c;
}
Console.Clear();
Console.WriteLine($"Вы ввели основание: {A} и степень: {B},");
Console.WriteLine($"Число {A} в степени {B} будет равно: {RaiseDegree(A, B)}.");