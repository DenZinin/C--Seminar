/*
Задача 4 * : Напишите программу, которая выводит случайное трёхзначное число
и удаляет вторую цифру этого числа. Не использовать строки для расчета.
*/

int randnumber = new Random().Next(100, 1000);
Console.WriteLine(randnumber);

int cutnumber1 = randnumber / 100;
int cutnumber2 = randnumber % 10;

Console.Write(cutnumber1);
Console.Write(cutnumber2);