/*
Доп задача:
объеденить два массива 
и раставить числа по возрастанию..
пример
[1,3,5,7]
[2,4,6,8,9]
->
[1,2,3,4,5,6,7,8]
*/

int[] massive1 = { 1, 3, 5, 7 };
int[] massive2 = { 2, 4, 6, 8 };
int a = massive1.Length;
int b = massive2.Length;
int c = a + b;
int[] sortMassive = new int[c];

//Объединение массивов...

Console.WriteLine("Объединение массивов:");
for (int i = 0; i < massive1.Length; i++)
{
    sortMassive[i] = massive1[i];
}

for (int i = 0; i < massive2.Length; i++)
{
    sortMassive[a + i] = massive2[i];
}

for (int i = 0; i < sortMassive.Length; i++)
{
    Console.Write(sortMassive[i] + " ");
}

// Сортировка методом:
//Array.Sort(newMassive);

// Сортировка кодом:

for (int i = 0; i < sortMassive.Length; i++)
{
    for (int j = 0; j < sortMassive.Length - 1; j++)
    {
        if (sortMassive[j] > sortMassive[j + 1])
        {
            int num = sortMassive[j];
            sortMassive[j] = sortMassive[j + 1];
            sortMassive[j + 1] = num;
        }
    }
}
Console.WriteLine();
Console.WriteLine("Отсортированный массив:");
for (int i = 0; i < sortMassive.Length; i++)
{
    Console.Write(sortMassive[i] + " ");
}
