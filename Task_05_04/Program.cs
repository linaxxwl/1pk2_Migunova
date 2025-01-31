namespace Task_05_04
{
    internal class Program
    {
        /* Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица
        диагональной (все элементы вне главной диагонали равны нулю)
        Если матрица является диагональной, то вывести ее повторно с цветовым выделением главной диагонали. Если нет, то вывеси
        сообщение что матрица не является диагональной. 
        */

        static void Main(string[] args)
        {
            Console.WriteLine(" Введите размер матрицы ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($" Введите число [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine()); //рассматривается каждое число            
                }
            }

            bool isDiagonal = true;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && matrix[i, j] != 0) //матрица будет не диагональной,если число не на главной диагонали + не равно 0
                    {
                        isDiagonal = false;
                        break;
                    }
                }
                if (!isDiagonal) break; //выход из внешнего цикла
            }

            if (isDiagonal)
            {
                Console.WriteLine(" Матрица диагональная ");

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        
                        if (i == j)//выделяю главную диаональ
                        {
                            Console.ForegroundColor = ConsoleColor.Blue; //ее цвет
                            Console.Write(matrix[i, j] + "\t");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(matrix[i, j] + "\t");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine(" Матрица не диагональная ");
            }
        }
    }
}
