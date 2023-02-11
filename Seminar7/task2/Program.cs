// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 4


int Prompt(string message)
{
    System.Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 11);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

bool FindElement(int[,] array, int row, int column)
{
    bool flag = (row >= 0 && row < array.GetLength(0)
     && column >= 0 && column < array.GetLength(1));
    return flag;
}

int[,] randomarray = new int[5, 5];
FillArray(randomarray);
PrintArray(randomarray);
int row = Prompt("Введите строку массива: ");
int column = Prompt("Введите столбец массива: ");
bool flag = FindElement(randomarray, row, column);

if (flag)
{
    System.Console.WriteLine($"Элемент с индексами [{row}, {column}] имеется, значение: {randomarray[row, column]}");
}
else
{
    System.Console.WriteLine($"Элемент с индексами [{row}, {column}] в массиве не найден");
}

