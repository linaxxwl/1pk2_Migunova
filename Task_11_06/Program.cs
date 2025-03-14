namespace Task_11_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine(" массив до вызова метода: ");
            PrintArray(numbers);

            IncrementArray(numbers);

            Console.WriteLine(" массив после вызова метода: ");
            PrintArray(numbers);
        }

        //увеличение  каждого элемента массива на 1
        static void IncrementArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 1;
            }
        }

        // вывод массива на экран
        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
    

