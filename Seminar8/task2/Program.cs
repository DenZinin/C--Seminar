// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

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

int[] MinSumElementsRow(int[,] array)
{
    int[] sumelements = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sumelements[i] = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumelements[i] += array[i, j];
        }
    }
    return sumelements;
}

int indexRowMinSum(int[] array)
{
    int min = array[0];
    int index = 0;
    for (int i = 1; i < array.Length; i++)
        if (min > array[i])
        {
            min = array[i];
            index = i;
        }
    return index + 1;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}

int row = Prompt("Введите число строк массива: ");
int column = Prompt("Введите число столбцов массива: ");
if (row == column) { System.Console.WriteLine("Массив не прямоугольный, введите другой размер массива!"); return; }
int[,] usermatrix = new int[row, column];
FillArray(usermatrix);
PrintMatrix(usermatrix);
System.Console.WriteLine();
int[] sumelementsarray = MinSumElementsRow(usermatrix);
System.Console.WriteLine("Суммы элементов стpок массива: ");
PrintArray(sumelementsarray);
System.Console.WriteLine();
int minvalueindex = indexRowMinSum(sumelementsarray);
System.Console.WriteLine($"Индекс массива с мининальной суммой элементов строки: {minvalueindex}");