/*Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.*/
Console.Clear();
Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
int degree = 1;

int count = 1;
while (count <= B)
{
    degree = degree * A;
    count++;
}

Console.Clear();
Console.WriteLine($"Вы ввели число: {A} и число: {B},");
Console.WriteLine($"Число {A} в степени {B} будет равно: {degree}.");
