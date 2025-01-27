namespace Task_04__09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Введите количество чисел в массиве ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("");
            }

            
            int[] numbers = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(1, 10);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine(" \nУникальные элементы массива ");

            
            for (int i = 0; i < size; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < size; j++)
                {
                    if (i != j && numbers[i] == numbers[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
