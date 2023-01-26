// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Реализовать через функции.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double usernumber1 = Prompt("Введите первое число");
double usernumber2 = Prompt("Введите второе число");

double DegreeNumber(double usernumber1, double usernumber2)
{
    double x = 1;
    for (double i = 1; i <= usernumber2; i++);
    {
        double result = Math.Pow(usernumber1, usernumber2);
        System.Console.WriteLine(result);
    }
    return x;
}

double x = DegreeNumber(usernumber1, usernumber2);