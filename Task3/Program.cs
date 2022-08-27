// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.WriteLine("введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
   if  ( x < 1 || x > 7)
        Console.WriteLine("Такого дня не существует");
      
   else if ( x == 6 || x == 7)
        Console.WriteLine("Выходной!");
      
   else 
        Console.WriteLine("Рабочий день(");
      

   
        