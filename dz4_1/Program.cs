/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("В какую степень его возводить ? ");
int s  = int.Parse(Console.ReadLine());
Console.WriteLine("");

double result = Math.Pow(n , s);

Console.WriteLine(result);