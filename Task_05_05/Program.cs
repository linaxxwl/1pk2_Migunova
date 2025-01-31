namespace Task_05_05
{
    internal class Program
    {
        /* У пользователя в консоли запрашивается числа n и m, генерируется прямоугольный массив целых числе [n*m]. Заполнение
           случайными числами в диапазоне от -99 до 99 включительно. Осуществите без создания нового массива преобразование текущего
           по следующему правилу:
           • Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым цветом
           • Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цветом 
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа n и m:");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] array = new int[n, m];

            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rnd.Next(-99, 100);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (array[i, j] < 0) // если число меньше 0,то устанавливаю зеленый цвет
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"{Math.Abs(array[i, j])} \t"); // выводим модуль числа
                    }
                    else if (array[i, j] == 0) // если число = 0,устанавливаю красный
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"1 \t"); // выводится 1 вместо 0
                        array[i, j] = 1; // обновляется значение массива
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"{array[i, j]} \t");
                    }
                }

                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}
