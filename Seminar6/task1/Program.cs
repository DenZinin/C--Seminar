// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


int Prompt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] FillArray(int usernumber)
{
    int[] array = new int[usernumber];

    for (int i = 0; i < usernumber; i++)
    {
        array[i] = Prompt("Введите число: ");
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("Введены числа: ");
    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($", {array[i]}");
    }
    System.Console.WriteLine();
}

int CountPositiveNumber(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item > 0) count++;
    }
    return count;
}

int usernumber = Prompt("Введите количество чисел: ");
if (usernumber < 1)
{
    System.Console.WriteLine("Введите другое число!");
}
else
{
    int[] arrayfromuserinput = FillArray(usernumber);
    int positivenumber = CountPositiveNumber(arrayfromuserinput);
    PrintArray(arrayfromuserinput);
    System.Console.WriteLine($"Количество положительных чисел = {positivenumber}");
}