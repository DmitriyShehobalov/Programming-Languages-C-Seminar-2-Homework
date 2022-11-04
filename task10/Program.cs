//Задача 10:
// Напишите программу которая принимает на вход трехзначное числа 
// и на выходе показывает вторую цифру этого числа

int num = new Random().Next(100, 1000);

int SecondNumberMethod(int arg1)
{
    int thirdDigit = num / 10;
    int secondDigit = thirdDigit % 10;
    return arg1 = secondDigit;
}
int result = SecondNumberMethod(num);
Console.WriteLine($"Second number {num} is a {result}");

