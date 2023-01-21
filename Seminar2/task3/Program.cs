/*
Задача 3: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да 
7 -> да 
1 -> нет
*/

Console.WriteLine("Введите число: ");
int usernumber = Convert.ToInt32(Console.ReadLine());

if (usernumber == 0 || usernumber > 7)
{
    Console.WriteLine("Введите другое число!");
}

else
{
    if (usernumber == 7 || usernumber == 6)
        {
            Console.WriteLine("Ура! Сегодня выходной!");
        }

    else
        {
            Console.WriteLine("Увы! Сегодня будний день!");
        }
}

