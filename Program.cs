﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: "); 
int a = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число B: "); 
int b = Convert.ToInt32(Console.ReadLine()); 
int result = a; 
for (int i = 1; i < b; i++)
    {
        result = result * a;
    }
    Console.WriteLine("A в степени B равно: " + result);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: "); 
int num = Convert.ToInt32(Console.ReadLine()); 
int sum = 0;  
while (num>0)
{
     sum=sum+num%10;
     num=num/10;
     
}
Console.WriteLine(sum);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

     
int[]array = new int[8];
     
for (int i = 0; i < array.Length; i++)
{
     array[i] = new Random().Next(0,100);
     Console.Write($" {array[i]}","");
}
Console.WriteLine();
    



