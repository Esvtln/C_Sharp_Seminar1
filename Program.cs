//  Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число №1: ");
string number1 = Console.ReadLine()!;
int num1 = int.Parse(number1);

Console.WriteLine("Веедите число №2: ");
string number2 = Console.ReadLine()!;
int num2 = int.Parse(number2);

if (num1 > num2)
{
    Console.WriteLine($"Максимальное число: {num1}");
}
else 
{
    Console.WriteLine($"Максимальное число: {num2}");
}