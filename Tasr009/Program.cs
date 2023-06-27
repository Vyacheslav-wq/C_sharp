/*# Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8
*/
int rundnum = new Random().Next(10, 100);
Console.WriteLine($"Рандомное число: {rundnum}");

int numOne= rundnum%10;
int numTwo = rundnum / 10;
Console.Write($"У числа: {rundnum} большая цифра ");

if (numOne > numTwo)
{
    Console.Write(numOne);
}
else
{
    Console.Write(numTwo);
}