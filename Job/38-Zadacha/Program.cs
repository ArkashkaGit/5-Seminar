/*
Задача 38: 
 Задайте массив вещественных чисел. 
 Найдите разницу между максимальным 
 и минимальным элементов массива.
Пример:
[3 7 22 2 78] -> 76

    В ЗАДАНИИ УКАЗАНЫ ВЕЩЕСТВЕННЫЕ ЧИСЛА, 
    КАК Я ПОНИМАЮ ЭТО ДРОБНЫЕ(double, float)..
    В ПРИМЕРЕ УКАЗАНЫ ЦЕЛЫЕ ЧИСЛА.. 
    ВЫПОЛНЮ С ЦЕЛЫМИ ЧИСЛАМИ, КАК УКАЗАНО В ПРИМЕРЕ
*/

// Создание метода:
int[] Massive(int len)
{
    int[] massive = new int[len];
    Random rnd = new Random();

// Создание массива со случайными числами:
    Console.Write("\nМассив со случайными числами: ");
    for (int i = 0; i < len; i++)
    {
        massive[i] = rnd.Next(100);
        Console.Write(massive[i] + " ");
    }
    Console.WriteLine();

//Поиск максимального и минимального значения массива:
    int numMax = massive[0];
    int numMin = massive[0];

    for (int i = 0; i < massive.Length; i++)
    {

        if (numMax < massive[i])
        {
            numMax = massive[i];
        }
        if (numMin > massive[i])
        {
            numMin = massive[i];
        }
    }
    Console.WriteLine($"Наибольший элемент массива равен: {numMax}");
    Console.WriteLine($"Наименьший элемент массива равен: {numMin}");
    Console.WriteLine($"Разниза между наибольим и наименьшим элементами равна: {numMax - numMin}\n");
    return massive;
}
// Вызов массива и вывод результата метода на экран 
Massive(10);
