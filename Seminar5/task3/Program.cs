// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7.4, 22.3, 2, 78] -> 76

int NumberOfElemets(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double[] GenerateArray(int userinput)
{
    double[] array = new double[userinput];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100) + rnd.NextDouble();
    }
    return array;
}

double findMin(double[] realnumber)
{
    double min = double.MaxValue;
    foreach (var i in realnumber)
    {
        if (i < min)
        {
            min = i;
        }
    }
    return min;
}

double findMax(double[] realnumber)
{
    double max = double.MinValue;
    foreach (var i in realnumber)
    {
        if (i > max)
        {
            max = i;
        }
    }
    return max;
}

void PrintArray(double[] array)
{
    foreach (double item in array)
    {
        System.Console.Write($"{Math.Round(item, 1)}\t");
    }
    System.Console.WriteLine();
}

int usernumber = NumberOfElemets("Введите длинну массива: ");

double[] realnumber = GenerateArray(usernumber);

PrintArray(realnumber);

double max = findMax(realnumber);
double min = findMin(realnumber);
double difminmax = max - min; 
System.Console.WriteLine($"Разница между MAX-массива и MIN-массива равна - {Math.Round(difminmax, 1)}");