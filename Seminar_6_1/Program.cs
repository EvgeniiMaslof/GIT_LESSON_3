// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//  уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//  задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите число К1: ");
double K1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число B1: ");
double B1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число К2: ");
double K2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число B2: ");
double B2 = Convert.ToDouble(Console.ReadLine());
if(K1 == K2 && B1 ==B2) Console.Write("Прямые совподают!");
else if(K1==K2) Console.Write("Прямые параллельны!");
else 
{
    double x = (B1 - B2)/(K2 - K1);
    double y = K1 * x + B1;
    Console.Write($"X = {x} y= {y}");
}
