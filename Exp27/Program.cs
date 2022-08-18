// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
void Number(int A)
{
  int i = 0;
  while (A >= 1)
    {
      i = i + (A%10);
      A = A / 10;
    }
   Console.Write(i);
}
Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Number(A);
