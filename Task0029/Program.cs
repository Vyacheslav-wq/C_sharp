/*Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.*/
Console.Clear();
Console.Write("Массив Array");

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
int[] array = new int[8];
for (uint i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-2147483648, 2147483647);
}
PrintArray(array);