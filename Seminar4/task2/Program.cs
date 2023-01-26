// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Реализовать через функции.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    System.Console.WriteLine($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int usernumber = Prompt("Ведите число");

int SumUserNumber(int usernumber)
{
    int sum = 0;
    for (int i = usernumber; i > 0; sum += i % 10, i /= 10) ;
    return sum;
}

int result = SumUserNumber(usernumber);

System.Console.WriteLine($"Сумма цифр числа {usernumber} равна {result}!");