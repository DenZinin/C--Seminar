/* Задача 2: Напишите программу, 
которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Ведите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int[] nums = {num1, num2, num3};


Console.WriteLine($"Максимальное число = {nums.Max()}!");