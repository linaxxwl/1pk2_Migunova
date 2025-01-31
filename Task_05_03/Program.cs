namespace Task_05_03
{
    internal class Program
    {
        /* Даны два массива, заполненные символами английского алфавита размером 3*3. Проверить, являются ли матрицы равными, если
        да, то вывести сообщение о том, что они равны, если нет, то вывести повторно матрицы с цветовой индикацией только тех
        элементов, которые равны. (матрицы считаются равными, если их соответствующие элементы равны.
        */

        static void Main(string[] args)
        {
            char[,] array = { { 'c', 'h', 'k' }, { 'm', 'g', 'e' }, { 'v', 'n', 'l' } };
            char[,] array2 = { { 'f', 'h', 'k' }, { 'm', 'o', 'e' }, { 'v', 'u', 'q' } };
            int rows = array.GetLength(0);
            int colomns = array.GetLength(1);
            bool areEqual = true;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colomns; j++)
                {
                    if (array[i, j] != array2[i, j])
                    {
                        areEqual = false;
                    }
                }
            }

            if (areEqual)
            {
                Console.WriteLine(" Матрицы равны ");
            }
            else
            {
                Console.WriteLine(" Матрицы не равны ");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < colomns; j++)
                    {
                        if (array[i, j] == array2[i, j])
                        {
                            Console.ForegroundColor = ConsoleColor.Red; //цвет неравных символов
                            Console.Write($"{array[i, j]} \t");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow; //цвет неравных символов
                            Console.Write($"{array[i, j]} \t");
                        }
                    }
                    Console.WriteLine();
                }
                Console.ResetColor(); 

            }
        }
    }
}
