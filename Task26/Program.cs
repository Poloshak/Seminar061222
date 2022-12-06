// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

Console.Write ("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine ($"количество цифр в {num} - {Count(num)}");

int Count (int number) 
{
    int count = 0;
    while (number>0)
    {
count = count + 1;
number = number/10;
    }
    
    return count;
}