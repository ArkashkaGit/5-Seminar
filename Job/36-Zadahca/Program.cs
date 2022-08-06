/*
Задача 36: 
Задайте одномерный массив, 
заполненный случайными числами. 
Найдите сумму элементов, 
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Random rnd = new Random();

int[] Massive(int len)
{
    int Summa = 0;
    int[] massive = new int[len];

    Console.WriteLine("Массив:");
    for (int i = 0; i < len; i++)
    {
        massive[i] = rnd.Next(-10, 10);
        Console.Write(massive[i] + " ");
    }
    Console.WriteLine();
   
    Console.WriteLine("Числа с не чётными индексами массива:");
    for (int i = 0; i < len; i++)
    {
        if (i % 2 != 0)
        {
            Summa += massive[i];
            Console.Write(massive[i] + " ");
        }
    }

    Console.WriteLine();
    Console.WriteLine($"Сумма чисел, с не четными индексами равна: {Summa}");
    return massive;
}
// Вызов метода:
Massive(10);