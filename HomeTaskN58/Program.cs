// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
void FillArrayRandomNumbers(int[,] array)  // Метод создает массив из случайных чисел
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5); 
        }
    }
}
void PrintArray(int[,] array)  // Метод печатает массив в терминале
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

Console.Write("Введите количество строк матрицы А ");
int sizeA1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы А ");
int sizeA2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк матрицы B ");
int sizeB1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы B ");
int sizeB2 = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = new int[sizeA1, sizeA2];
int[,] matrixB = new int[sizeB1, sizeB2];
int size1 = sizeA1;
int size2 = sizeB2;

if (sizeA2 == sizeB1)
{
    FillArrayRandomNumbers(matrixA);
    FillArrayRandomNumbers(matrixB);
    int[,] matrixC = new int[size1, size2];
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            for (int k = 0; k < size2; k++)
            {
               matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
            }
        }
    }
    Console.WriteLine("Матрица - А");
    PrintArray(matrixA);
    Console.WriteLine();
    Console.WriteLine("Матрица - В");
    PrintArray(matrixB);
    Console.WriteLine();
    Console.WriteLine("Произведение матриц А и В матрица С");
    PrintArray(matrixC);
}
else Console.WriteLine("Умножение матриц невозможно!");