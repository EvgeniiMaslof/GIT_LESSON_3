// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

 void Num(int M)
{
    int sum = 0;
    int count = 0;
    for (int i = 1; i <= M; i++)
    {
        Console.Write("Введите число: ");
        count = Convert.ToInt32(Console.ReadLine());
        if(count > 0)  sum++; 
    }
    Console.Write($"Колличество чисел больше ноля: {sum}");
}
Console.Write("Введите колличество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
Num(M);