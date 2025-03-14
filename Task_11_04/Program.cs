namespace Task_11_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Среднее значение: " + CalculateAverage(1, 2, 3, 4, 5, 6));
            Console.WriteLine("Среднее значение: " + CalculateAverage(10, 15, 20, 30, 35));
            Console.WriteLine("Среднее значение: " + CalculateAverage(7, 9));
        }

        // для расчета среднего значения
        static double CalculateAverage(params int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0; // если массив пуст возвращаем 0
            }

            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            return (double)sum / numbers.Length;
        }
    }
}
    

