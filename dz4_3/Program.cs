/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

Console.WriteLine("Введите длинну массива: ");
int Length = int.Parse(Console.ReadLine());

int[] newArray = new int[Length];
for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = new Random().Next(1,100);
    Console.Write(newArray[i] + ",");
}

