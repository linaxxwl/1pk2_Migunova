using System;

namespace Task_04_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 50;
            int[] array = new int[size];
            Random rnd = new Random();
            int pairCount = 0;

            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(0, 50);
                Console.WriteLine(array[i]);
            }

            for (int i = 0; i < size; i++)//пары чисел

            {
                for (int j = 0; j < i; j++)

                {
                    if (array[i] == array[j])
                    {
                        pairCount++;
                        Console.WriteLine($" Пара: {array[i]}");
                    }
                }
            }

            Console.WriteLine($"Количество пар чисел: {pairCount}");
        }
    }
}
