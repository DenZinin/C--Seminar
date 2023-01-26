// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами.
//  Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах).
//  Реализовать через функции. (* Доп сложность, “введите количество элементов массива”,
//  “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”)
// 1,2,5,7,19,1,2,8-> 1,2,5,7,19,1,2,8 -> 8

int NumberOfElemets(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int MaxNumber(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int MinNumber(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int minimum = MinNumber("Введите минимальный порог случайных значений");
int maximum = MaxNumber("Введите максимальный порог случайных значений");

int[] CreatArray(int elements)
{
    int[] array = new int[elements];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minimum, maximum);
    }
    return array;
}

void ShowArray(int[] array)                       // Вывод массива в консоль
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]}, ");
    }
}

int elements = NumberOfElemets("Введите количество элементов массива: ");
int[] array = CreatArray(elements);
ShowArray(array);