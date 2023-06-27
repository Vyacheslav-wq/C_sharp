/* Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/
Console.Clear();
// int randomNumber= new Random().Next(100, 1000);


// Console.WriteLine("Введите число");

Console.Clear();
int randomNumber = new Random().Next(100, 1000);
int result = (randomNumber / 100) * 10 + randomNumber % 10;
Console.WriteLine($"{randomNumber} -> {result}");
// Console.WriteLine($"{randomNumber} -> {randomNumber/100}{randomNumber%10}");