//Задача 10: Напишите программу, 
//которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int a1 = x / 10;
int a2 = a1 % 10;
Console.WriteLine(a2);

