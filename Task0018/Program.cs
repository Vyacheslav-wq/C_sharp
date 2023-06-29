/* Напишите программу, которая по заданному номеру четверти, показывает
диапазон возможных координат точек в четверти (x и y).
*/
Console.Clear();
string QuadrantRange(int quadrant)
{
  if (quadrant == 1) return "x > 0; y > 0";
    else if (quadrant == 2) return "x < 0; y > 0.";
    else if (quadrant == 3) return "x < 0; y < 0.";
    else if (quadrant == 4) return "x > 0; y < 0.";
    else return "Недопустимый номер четверти.";
}
    
    Console.Write("Введите номер четверти: ");
    int quarter = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(QuadrantRange(quarter));