// Задача 1: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5    7    -2  -0,2
//  1   -3,3    8   -9,9
//  8    7,8  -7,1    9

int Prompt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(double[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rand.Next(-100, 101)*0.1, 1);
        }
    }
}

void PrintArray(double[,] array)
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

int row = Prompt("Введите количество строк массива: ");
int column = Prompt("Введите количество строк массива: ");
double[,] userarray = new double[row, column];
FillArray(userarray);
PrintArray(userarray);
