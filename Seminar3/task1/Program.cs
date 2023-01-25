// Задача 1: Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да


int Prompt(string message)
{
    Console.Write($"{message}: ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int usernumber = Prompt("Введите число: ");

int UserReverse(int usernumber)
{
    int reverse = 0;
    while (usernumber != 0)
    {
        reverse = reverse *10;
        reverse = reverse + usernumber % 10;
        usernumber /= 10;
    }
    return reverse;
    
}
int numberreverse = UserReverse(usernumber);

if (numberreverse == usernumber)
{
    System.Console.WriteLine($"Число {usernumber} является палиндромом.");
}
else
{
    System.Console.WriteLine($"Число {usernumber} не является палиндромом.");
}


