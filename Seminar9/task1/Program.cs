// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    System.Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

void EvenNumbers(int start, int finish)
{
    if (start > finish)
    {
        return;
    }
    if (start % 2 == 1)
    {
        start++;
    }
    System.Console.Write(start + " ");
    EvenNumbers(start + 2, finish);
}

int start = Prompt("Введите первое число: ");
int finish = Prompt("Введите второе число: ");
System.Console.WriteLine($"Четные числа в интервале от {start} до {finish}: ");
EvenNumbers(start, finish);