namespace Task_05_06
{
    internal class Program
    {
        /*Осуществить генерация двумерного [10*5] массива по следующему правилу:
         • 1 столбец содержит нули
         • 2 столбце содержит числа кратные 2
         • 3 столбец содержит числа кратные 3
         • 4 столбец содержит числа кратные 4
         • 5 столбец содержит числа кратные 5
         Осуществить переворот массива (поменять строки и столбцы местами) вывести обновленный массив 
        */

        static void Main(string[] args)
        {
            int[,] array = new int[10, 5];
            int[,] array2 = new int[5, 10];
            Random rnd = new Random();

            Console.WriteLine(" Изначальный массив ");
            FillArray(array, rnd);
            PrintArray(array);
            Console.WriteLine(" Обновленный массив ");
            TransposeArray(array, array2);
            PrintArray(array2);
        }

        static void FillArray(int[,] array, Random rnd) //массив заполняется по условию
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    while (true)
                    {
                        int num = rnd.Next(0, 100);
                        if (j == 0 && num == 0) // 1 столбец содержит нули
                        {
                            array[i, j] = num;
                            break;
                        }
                        if (j == 1 && num % 2 == 0) // 2 столбец содержит числа кратные 2
                        {
                            array[i, j] = num;
                            break;
                        }
                        if (j == 2 && num % 3 == 0) // 3 столбец содержит числа кратные 3
                        {
                            array[i, j] = num;
                            break;
                        }
                        if (j == 3 && num % 4 == 0) // 4 столбец содержит числа кратные 4
                        {
                            array[i, j] = num;
                            break;
                        }
                        if (j == 4 && num % 5 == 0) // 5 столбец содержит числа кратные 5
                        {
                            array[i, j] = num;
                            break;
                        }
                    }
                }
            }
        }

        
        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        
        static void TransposeArray(int[,] source, int[,] destination) //меняем стороны массива
        {
            for (int i = 0; i < source.GetLength(0); i++)
            {
                for (int j = 0; j < source.GetLength(1); j++)
                {
                    destination[j, i] = source[i, j];
                }
            }
        }
    }
}
