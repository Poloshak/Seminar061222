// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

Console.Clear();
int [] arr = new int [8];

void FulfillArray (int[] array)
{
    int i = 1;
    while (i<=array.Length)
    {
    Console.Write($"{new Random().Next(2)} ");
    i++;
    }
}

FulfillArray(arr);