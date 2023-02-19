// Задача 3: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

int Prompt(string message)
{
    System.Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[row, column] = new Random().Next(1, 20);
        }
    }
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int row1 = Prompt("Введите число строк массива первой матрицы: ");
int column1 = Prompt("Введите число столбцов массива первой матрицы: ");
int[,] usermatrix1 = new int[row1, column1];
FillArray(usermatrix1);
PrintMatrix(usermatrix1);
int row2 = Prompt("Введите число строк массива второй матрицы: ");
int column2 = Prompt("Введите число столбцов массива второй матрицы: ");
int[,] usermatrix2 = new int[row2, column2];
FillArray(usermatrix2);
PrintMatrix(usermatrix2);
System.Console.WriteLine();

int[,] MultiplicationMatrix(int[,] array1, int[,] array2)
{
    int[,] resultmatrix = new int[row1, column2];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                resultmatrix[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return resultmatrix;
}

if (column1 != row2) { System.Console.WriteLine("Умножение матриц невозможно! Введите корректные данные!"); return; }
int[,] resultmatrix = MultiplicationMatrix(usermatrix1, usermatrix2);
System.Console.WriteLine("Результат произведения матриц: ");
PrintMatrix(resultmatrix);