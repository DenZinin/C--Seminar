// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int Prompt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = Prompt("Введите первой X точки");
int y1 = Prompt("Введите первой Y точки");
int z1 = Prompt("Введите первой Z точки");
int x2 = Prompt("Введите второй X точки");
int y2 = Prompt("Введите второй Y точки");
int z2 = Prompt("Введите второй Z точки");

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double a; double b; double c;
    a = x2 - x1;
    b = y2 - y1;
    c = z2 - z1;
    return Math.Sqrt(a * a + b * b + c * c);
}

System.Console.WriteLine(Distance(x1, y1, z1, x2, y2, z2));