namespace Task_03_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h = 0.5;
            double start = -4;
            double end = 4;

            for (double x = start; x <= end; x += h)
            {
                double y = Math.Abs(x); 
                Console.WriteLine($"x: {x:F1}, y: {y:F1}");
            }
        }
    }
}
 