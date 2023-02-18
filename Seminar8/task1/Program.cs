// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает 
// по убыванию элементы каждой строки двумерного массива.

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

void OrderedRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int maxvalue = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, maxvalue]) maxvalue = k;
            }
            int temparray = array[i, j];
            array[i, j] = array[i, maxvalue];
            array[i, maxvalue] = temparray;
        }
    }

}

int row = Prompt("Введите число строк массива: ");
int column = Prompt("Введите число столбцов массива: ");
int[,] usermatrix = new int[row, column];
FillArray(usermatrix);
PrintArray(usermatrix);
System.Console.WriteLine();
OrderedRow(usermatrix);
PrintArray(usermatrix);