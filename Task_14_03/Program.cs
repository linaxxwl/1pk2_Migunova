namespace Task_14_03
{
    internal class Program
    {
      
             /// <summary>
             /// статический метод для вычисления факториала
             /// </summary>
             /// <param name="number">Целое неотрицательное число</param>
             /// <returns>Факториал числа</returns>
        public static int Factorial(int number)
        {
            if (number < 0) 
            {
                Console.WriteLine(" Ошибка: факториал определяется только для неотрицательных чисел ");
                return -1; // возврат значения указывающего на ошибку
            }

            int result = 1;
            for (int i = 1; i <= number; i++) // цикл для вычисления факториала
            {
                result *= i;
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write(" Введите число для вычисления факториала: ");
            int number = int.Parse(Console.ReadLine());

            int factorial = Factorial(number);
            if (factorial != -1) 
            {
                Console.WriteLine($" Факториал числа {number} равен {factorial} ");
            }
        }
    }
}
      
