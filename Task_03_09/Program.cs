namespace Task_03_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Введите начальную сумму вклада (x) ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Введите процент увеличения (p) ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Введите целевую сумму (y) ");
            double y = Convert.ToDouble(Console.ReadLine());

            int years = 0;

           
            while (x < y)
            {
                x += x * p / 100; //вклад увеличиваетсч
                x = Math.Truncate(x); //убираю дробь
                years++; //
            }

            
            Console.WriteLine($" Количество лет до достижения суммы {y}: {years} ");
        }
    }
}
