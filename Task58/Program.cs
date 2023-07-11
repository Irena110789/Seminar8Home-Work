// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateNewArray()
{
    Console.WriteLine("Input array 1 size: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[size, size];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 4);
        }
    }
    return array;
}
int[,] CreateNewArray2()
{
    Console.WriteLine("Input array 2 size: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[size, size];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 4);
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] arrA, int[,] arrB)
{
    int[,] res = new int[arrA.GetLength(0), arrB.GetLength(1)];
    if (arrA.GetLength(1) == arrB.GetLength(0))
    {
        for (int i = 0; i < arrA.GetLength(0); i++)
        {
            for (int j = 0; j < arrB.GetLength(1); j++)
            {
                for (int k = 0; k < arrB.GetLength(0); k++)
                {
                    res[i, j] += arrA[i, k] * arrB[k, j];
                }
                Console.Write(res[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    else
        Console.WriteLine("The number of columns of matrix A must be equal to the number of rows of matrix B");
    return res;
}

int[,] myArray1 = CreateNewArray();
ShowArray(myArray1);
Console.WriteLine();
int[,] myArray2 = CreateNewArray2();
ShowArray(myArray2);
Console.WriteLine("Result: ");
MatrixMultiplication(myArray1, myArray2);

int[,] myArray = CreateNewArray();
ShowArray(myArray);