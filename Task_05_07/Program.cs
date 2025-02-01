namespace Task_05_07
{
    internal class Program
    {
        /*
         У пользователя в консоли запрашивается число n, генерируется квадратный массив целых числе [n*n]. Заполнение случайными
         числами в диапазоне от 10 до 99 включительно.
         Найти и вывести отдельно минимальный элемент в матрице (LINQ под запретом) Осуществить умножение матрицы на ее
         минимальный элемент, при выводе цветом выделить пять максимальных значений в массиве
        */


        static void Main(string[] args)
        {

            Console.Write(" Введите число n ");
            int size;
            int minValue = 100; 
            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine(" Ошибка,введите число снова ");
            }

            int[,] matrix = new int[size, size];
            Random random = new Random();

            
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = random.Next(10, 100); 
                    if (matrix[row, col] < minValue)
                    {
                        minValue = matrix[row, col]; // обновляю минимальное значение
                    }
                    Console.Write(matrix[row, col] + "\t"); 
                }
                Console.WriteLine();
            }

            Console.WriteLine($" Минимальный элемент: {minValue} ");

           
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] *= minValue;
                }
            }

            
            int[] topFive = new int[5];
            for (int i = 0; i < 5; i++)
            {
                int max = int.MinValue; //сначала максимальное значение - минимальное
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        
                        bool isIncluded = false;
                        for (int j = 0; j < i; j++)
                        {
                            if (matrix[row, col] == topFive[j])
                            {
                                isIncluded = true;
                                break;
                            }
                        }

                        
                        if (!isIncluded && matrix[row, col] > max) //обновляю максимум,если не соответствует условию
                        {
                            max = matrix[row, col];
                        }
                    }
                }
                if (max != int.MinValue) // проверка максимального значения
                {
                    topFive[i] = max; // максимум сохраняю
                }
            }

            Console.WriteLine(" Матрица после умножения ");
            //марица с выделением пяти максимальных значений
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    bool isMax = false; 
                    for (int i = 0; i < 5; i++)
                    {
                        if (matrix[row, col] == topFive[i])
                        {
                            isMax = true; 
                            break;
                        }
                    }

                    if (isMax)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow; 
                    }
                    Console.Write(matrix[row, col] + "\t");
                    Console.ResetColor(); 
                }
                Console.WriteLine();
            }
        }
        }
    }
        
