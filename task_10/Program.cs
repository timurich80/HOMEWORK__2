﻿/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */


Console.Clear();
System.Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
int result = (a/10) % 10;
System.Console.WriteLine(result);