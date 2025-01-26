namespace Task_03_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double g = 9.8;
            double t = 0;
            double maxt = 5;

            Console.WriteLine(" Время\tСкорость ");
            Console.WriteLine();

            while (t <= maxt)
            {
                double v = g * t;
                Console.WriteLine($" {t,-12} {v:F2} ");
                t += 0.5;
            }
        }
    }
}
