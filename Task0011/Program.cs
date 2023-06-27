/* Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/
Console.Clear();
// int randomNumber= new Random().Next(100, 1000);

/* Напишите программу, которая выводит случайное трёхзначное число 
и удаляет вторую цифру этого числа.
*/

Console.Clear();
int RandNum = new Random().Next(100, 1000);
int result = (RandNum/ 100) * 10 + RandNum % 10;
Console.WriteLine($"Рандомное число: {RandNum},");
Console.WriteLine($"Удаляем вторую цифру и получаем: {result}.");
// Console.WriteLine($"{randomNumber} -> {randomNumber/100}{randomNumber%10}");