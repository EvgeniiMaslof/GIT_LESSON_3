﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
// натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
void Step(int A, int B)
{
  int num = 1;
  int i = 1;
  while (i <= B)
    {
      num = num * A;
      i++;
    }
   Console.Write(num);
}
Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
Step(A,B);
