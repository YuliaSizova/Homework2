﻿/*Задача 13: Напишите программу, 
которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/ 

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int i = 10;
if (num >= 100)
{
  while (num/i > 1000 )
  {
    i=i*10;
  }
  int result =(num / i ) % 10 ;
System.Console.WriteLine($"{num} -> {result}");
}

else
{
    System.Console.WriteLine("Третьей цифры нет");
}


