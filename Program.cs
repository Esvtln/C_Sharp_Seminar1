//  Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите число №1: ");
// string number1 = Console.ReadLine()!;
// int num1 = int.Parse(number1);

// Console.WriteLine("Веедите число №2: ");
// string number2 = Console.ReadLine()!;
// int num2 = int.Parse(number2);

// if (num1 > num2)
// {
//     Console.WriteLine($"Максимальное число: {num1}");
// }
// else 
// {
//     Console.WriteLine($"Максимальное число: {num2}");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите первое число ");
// string number1 = Console.ReadLine()!;
// int num1 = int.Parse(number1);

// Console.WriteLine("Введите второе число ");
// string number2 = Console.ReadLine()!;
// int num2 = int.Parse(number2);

// Console.WriteLine("Введите третье число ");
// string number3 = Console.ReadLine()!;
// int num3 = int.Parse(number3);

// if (num1> num2)
//     if (num1 > num3)
//     {
//         Console.WriteLine($"Max = {num1} ");
//     }
//     else
//     {
//         Console.WriteLine($"Max = {num3} ");
//     }
// else if (num2 > num3)
// {
//     Console.WriteLine($"Max = {num2} ");
// }
// else 
// {
//     Console.WriteLine($"Max = {num3} ");
// }


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Ввведите число: ");
// string number = Console.ReadLine()!;
// int num = int.Parse(number);

// if (num%2 == 0)
// {
//     Console.WriteLine($"{num} -> Четное число");
// }
// else
// {
//     Console.WriteLine($"{num} -> Нечетное число");
// } 

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
string number = Console.ReadLine()!;
int num = int.Parse(number);
int startNum = 1;

while(startNum <= num)
{
    if(startNum%2 ==0)
    Console.Write($" {startNum} , ");
    startNum ++;
}