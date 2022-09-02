// Задача 64: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
Console.Clear();
Console.Write("Введите значение M ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N ");
int N = Convert.ToInt32(Console.ReadLine());
string OutputsNaturalNumbers(int N)
{
    if(M == N) return Convert.ToString(M);
    else return OutputsNaturalNumbers(N - 1) + " " +  Convert.ToString(N);
}
Console.Write(OutputsNaturalNumbers(N));