// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateNewArray()
{
    Console.WriteLine("Input array size: ");
    int size = Convert.ToInt32(Console.ReadLine());
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
    }Console.WriteLine();
}

void ArrangeArrayFromMaxToMin(int[,] array)
{
    int size = array.GetLength(1);
    int temp = 0;
    for (int i = 0; i < array.GetLength(0);i++,size = array.GetLength(1))
    {
        while (size != 0)
        {
            for (int j = 0; j < size - 1;)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
                j++;
            }size--;

        }
    }
}
int[,] myArray = CreateNewArray();
ShowArray(myArray);
ArrangeArrayFromMaxToMin(myArray);
Console.WriteLine("Sorted array from max value to min value:");
ShowArray(myArray);