/*Задача 15: Напишите программу,
 которая принимает на вход цифру, 
 обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
System.Console.WriteLine("Введите цифру,обозначающую день недели");
int numDay = Convert.ToInt32(Console.ReadLine());
if (numDay ==6  || numDay ==7)
{
    System.Console.WriteLine("(Этот день выходной)-> да");
}
else if (numDay<-1 || numDay>7)
{
    System.Console.WriteLine("Таких дней недели нет");
}
else 
{
    System.Console.WriteLine("Это день не выходной");
}