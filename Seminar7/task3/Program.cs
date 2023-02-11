// Задача 3: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Prompt(string message)
{
    System.Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
}

void PrintArray(int[,] array)
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

void AverageNumberColumn(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double averagecolumn = 0.0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            averagecolumn += array[j, i];
        }
        averagecolumn /= array.GetLength(0);
        System.Console.Write($"{Math.Round(averagecolumn, 1)}; ");
        
    }
}

int row = Prompt("Ведите количество строк массива:");
int column = Prompt("Введите количество столбцов массива: ");
int[,] randomarray = new int[row, column];
FillArray(randomarray);
PrintArray(randomarray);
System.Console.WriteLine();
AverageNumberColumn(randomarray);


