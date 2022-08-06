/*
Задача 34: 
Задайте массив 
заполненный случайными положительными трёхзначными числами. 
Напишите программу, 
которая покажет количество чётных чисел в массиве.

Пример:
[345, 897, 568, 234] -> 2
*/

Random rnd = new Random();

int[] Massive(int len)
{
    int CountChetNumber = 0;
    int[] massive = new int[len];

    Console.WriteLine("Массив:");
    for (int i = 0; i < len; i++)
    {
        massive[i] = rnd.Next(100, 1000);
        Console.Write(massive[i] + " ");
    }
    Console.WriteLine();
   
    Console.WriteLine("Чётные числа Массива:");
    for (int i = 0; i < len; i++)
    {
        if (massive[i] % 2 == 0)
        {
            CountChetNumber++;
            Console.Write(massive[i] + " ");
        }
    }

    Console.WriteLine();
    Console.WriteLine($"Число чётных чисел в данном массиве равна: {CountChetNumber}");
    return massive;
}
// Вызов метода:
Massive(100);