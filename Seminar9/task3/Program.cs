// Задача 3: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    System.Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

int AccermanFunction(int firstnumber, int secondnumber)
{
    if (firstnumber == 0)
    {
        return secondnumber + 1;
    }
    if (secondnumber == 0)
    {
        return AccermanFunction(firstnumber - 1, 1);
    }
    return AccermanFunction(firstnumber - 1, AccermanFunction(firstnumber, secondnumber - 1));
}

int firstnumber = Prompt("Введите первое число: ");
int secondnumber = Prompt("Введите второе число: ");
System.Console.Write($"Функция Аккермана для m = {firstnumber}, n = {secondnumber} равна  {AccermanFunction(firstnumber, secondnumber)}");