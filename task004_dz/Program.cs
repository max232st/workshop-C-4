﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.WriteLine("Введите число 1: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 2: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {a} в степени {b} = {NumExponent(a, b)}");
int NumExponent(int a, int b)
{
    int count = 1;
    int num = 1;
    while (count <= b)
    {
        //Console.Write($"{num} ");
        num *= a;
        count++;
    }
    return num;
}