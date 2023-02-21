﻿// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (MultiTwoDigit(number1, number2)) Console.WriteLine("Да");
else
    Console.WriteLine("Нет");

bool MultiTwoDigit(int num1, int num2)
{
    bool result = (num1 * num1 == num2) && (num2 / num1 == num1);
    return result;
}



