﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
//  возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int degreee(int firstNumber, int secondNumber)
{
    int result = 1;
    for (int i = 1; i<=secondNumber; i++)
    {
        result *= firstNumber;
    }
    return result;
}
Console.WriteLine("Введите число, которе хотите возвести в степень: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень, в которую хотите возвести число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int x = degreee(firstNumber,secondNumber);
Console.WriteLine(x);


