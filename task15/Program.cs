// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 1 || n > 7) Console.WriteLine($"There is no such day of the week {n}");

else if (n <= 5) Console.WriteLine($"No {n}");

else if (n == 6 || n == 7) Console.WriteLine($"Yes {n}");
