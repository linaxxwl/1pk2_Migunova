using System;

namespace Task_04_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            int[] array = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(-10, 11); 
                Console.Write(array[i] + " ");
            }

            
            ReverseArray(array, 0, size / 2 - 1);//реверсия 1
            ReverseArray(array, size / 2, size - 1);//реверсия 2

            Console.WriteLine();
           
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        
        static void ReverseArray(int[] array, int start, int end)
        {
            while (start < end)
            {
               
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }
        }
    }
}
