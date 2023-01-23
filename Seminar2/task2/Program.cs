/*
Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет. Не использовать строки для расчета.
645 -> 5
78 -> третьей цифры нет
326792 -> 6
*/

Console.WriteLine("Введите число: ");
int usernumber = Convert.ToInt32(Console.ReadLine());

if (usernumber < 100)
{
    Console.WriteLine("Третьей цифры нет!");
}

if (usernumber >= 100 && usernumber < 1000)
{
    int thirdnumber = usernumber % 10;
    Console.WriteLine($"Третье число {usernumber} = {thirdnumber}");
}

if (usernumber >= 1000 && usernumber < 10000)
{
    int thirdnumber = (usernumber / 10) % 10;
    Console.WriteLine($"Третье число {usernumber} = {thirdnumber}");
}

if (usernumber >= 10000 && usernumber < 100000)
{
    int thirdnumber = (usernumber / 100) % 10;
    Console.WriteLine($"Третье число {usernumber} = {thirdnumber}");
}

if (usernumber >= 100000 && usernumber < 1000000)
{
    int thirdnumber = (usernumber / 1000) % 10;
    Console.WriteLine($"Третье число {usernumber} = {thirdnumber}");
}