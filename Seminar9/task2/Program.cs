// Задача 2: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string message)
{
    System.Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

int SumElements(int start, int finish)
{
    if (start > finish)
    {
        return 0;
    }
    return start + SumElements(start + 1, finish);
}

int start = Prompt("Введите первое число: ");
int finish = Prompt("Введите второе число: ");
System.Console.Write($"Сумма чисел от {start} до {finish}:  {SumElements(start, finish)}");