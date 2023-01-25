// Задача 3: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int usernumber = Prompt("Введите число");

int NumberCube(int usernumber)
{
    int x = 1;
    for (int i = 1; i <= usernumber; i++)
    {
        int intcube = i * i * i;
        System.Console.Write($"{intcube}, ");
    }
    return x;
}

int x = NumberCube(usernumber);
