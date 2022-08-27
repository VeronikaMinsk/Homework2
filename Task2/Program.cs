// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
string xText = Convert.ToString(x);
{
    if ( xText.Length > 2)
        Console.WriteLine("Третья цифра: " + xText[2]);

    else 
        Console.WriteLine("Третьей цифры нет");
} 