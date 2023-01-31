// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 6] -> 0

int NumberOfElemets(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int userinput)
{
    int[] array = new int[userinput];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 50);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}

int SumNumber(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i +=2)
    {
        sum += array[i];
    }
    return sum;
}

int userinput = NumberOfElemets("Введите длинну массива: ");
int[] creatarray = GenerateArray(userinput);
PrintArray(creatarray);
int summa = SumNumber(creatarray);
System.Console.WriteLine($"Сумма элементов нечетных позиций равна - {summa}");