// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateNewArray()
{
    int size = 5;
    int[,] array = new int[size, size];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]);
            Console.Write(" ");
        }Console.WriteLine();
    }
}
int[] FoundSumOfRowlEments(int[,] array)
{
    int[] res = new int[array.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++,sum = 0)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        res[i] = sum;
        Console.WriteLine($"row:{i+1} sum: {sum}");
    }return res;
}

void ShowIndex(int[] array)
{
    int index = 0;
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            index = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Row with smaller sum: {index + 1}");
}

int[,] myArray = CreateNewArray();
ShowArray(myArray);
int[] res = FoundSumOfRowlEments(myArray);
ShowIndex(res);
