// Задача 13: 
// 1. Напишите программу, которая выводит третью цифру заданного числа 
// 2.или сообщает, что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(n +" ");
if (n < 99) Console.Write("there is no third digit");
else
{
    while (n > 999)
    {
        n = n / 10;
       
    }
    Console.Write($"the third digit of the number -> {n%10}");
}

















