//  Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double Prompt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToDouble(Console.ReadLine());
}

double b1 = Prompt("Введите значение B1");
double k1 = Prompt("Введите значение K1");
double b2 = Prompt("Введите значение B2");
double k2 = Prompt("Введите значение K2");


if (k1 != k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    System.Console.WriteLine($"Точка пересечения прямых: x = {Math.Round(x, 1)} y = {Math.Round(y, 1)}");
}
else
{
    System.Console.WriteLine($"Прямые не пересекаются!");
}