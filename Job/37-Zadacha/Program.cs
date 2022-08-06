/*
Задача 37: 
Найдите произведение пар чисел 
в одномерном массиве. 
Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. 
Результат запишите в новом массиве.
Пример:
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

// Создание метода:
int[] Massive(int len)
{
    Random rnd = new Random();
    int[] massive = new int[len];
    int[] NewMassive = new int[len/2];
    int indexNewMassive = 0;

// Создание массива со случайными значениями:
    Console.WriteLine("\n\t---Массив:---");
    for (int i = 0; i < len; i++)
    {
        massive[i] = rnd.Next(100);
        Console.Write(massive[i] + " ");
    }
    Console.WriteLine();

// Действие с произведением указанных пар числел, в задании:
    Console.WriteLine("\t---Произведение пар чисел:---");
    for (int i = 0, j = len - 1; i <= j; i++, j--)
    {
// Проверка, на то есть ли пара у числа..
        if (i == j)
        {
            int ChisloBezPary = massive[i];
            Console.WriteLine();
            Console.WriteLine("\t---у данного числа нет пары!!!---");
            Console.WriteLine(ChisloBezPary);
            break;
        }
// Создание Массива с перемноженными числами:
        int ProizvedenieChisel = massive[i] * massive[j];         
        NewMassive[indexNewMassive] = ProizvedenieChisel;
        indexNewMassive++;
        //NewMassive = NewMassive.Concat(new int[] {ProizvedenieChisel}).ToArray();
        Console.Write(ProizvedenieChisel + " ");
    }
    return NewMassive;

}
// Вызов метода:
int[] NewMassive = Massive(11);

// Проверка и вывод на консоль нового МАССИВА !!!
Console.WriteLine("\t---Создан и выведен на консоль, новый массив с числами, указанными в задании---"); 
for (int i = 0; i < NewMassive.Length; i++)
{
    System.Console.Write(NewMassive[i] + " ");
}
Console.WriteLine("\n");