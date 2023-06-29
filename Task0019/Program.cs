/* Программа проверяет пятизначное число на палиндромом.
*/
Console.WriteLine("Введите пятизначное число: ");

int a = Convert.ToInt32(Console.ReadLine());

if (a < 99999 & a >= 10000)
{
    int xx = a / 1000;
    int num1 = xx / 10;
    int num2 = xx % 10;
    int yy = a % 100;
    int num4 = yy / 10;
    int num5 = yy % 10;

    if ((num1 == num5) & (num2 == num4))
    {
        Console.WriteLine("Это число полидром.");
    }

    else
    {
        Console.WriteLine("Это число не полидром.");
    }

}
else
{
    Console.WriteLine("Неправильное число.");
}