/*# Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8
*/
int randnum = new Random().Next(10, 100);
Console.WriteLine($"Рандомное число: {randnum}");

int numOne= randnum%10;
int numTwo = randnum / 10;
Console.Write($"У числа: {randnum} большая цифра ");

if (numOne > numTwo)
{
    Console.Write(numOne);
}
else
{
    Console.Write(numTwo);
}