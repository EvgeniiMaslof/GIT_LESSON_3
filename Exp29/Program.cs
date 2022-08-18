// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void ArrayRandom(int [] array)
{
  int i = 0;
  for (int length = array.Length; i < length; i++)
   {
     array[i] = new Random().Next(-99,99);
     Console.Write($"{array[i]} ");
   }
}
Console.Write("Введите длину массива: ");
int A = Convert.ToInt32(Console.ReadLine());
int[] array = new int[A];
ArrayRandom(array);