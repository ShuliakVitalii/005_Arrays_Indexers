using System;
using System.Linq;

namespace _005_Arrays_Indexers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] array = { 8, 9, 10, 15, 90, 5, 1, 68, 70, 554 };
            Console.WriteLine($"Максимальное значение: {array.Max()}");
            Console.WriteLine($"Минимальное значение: {array.Min()}");
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"Сума всех элементов: {sum}");
            int y = 0;
            double arf = 0;
            for (int i = 0; i < array.Length; i++)
            {
                y += array[i];
                arf = y / (array.Length);
            }
            Console.WriteLine($"Среднее арифметическое всех элементов: {arf}");
            Console.Write("Всё нечетные числа: ");
            for (int i = 0; i < array.Length; i++)
            {
                int x = array[i] % 2;
                if (x != 0)
                {
                    Console.Write($"{array[i]}, ");
                }
            }
        }
    }
}