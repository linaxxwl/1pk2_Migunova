using System;

namespace Task_04_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rainfall = new int[30];
            Random random = new Random();
            int[] decadalRainfall = new int[3]; //суммп осадков

            int maxRainfall = 0;
            int maxRainfallDay = 0; 

           
            for (int i = 0; i < 30; i++)
            {
                rainfall[i] = random.Next(0, 301); 

               
                int decadalIndex = i / 10;
                decadalRainfall[decadalIndex] += rainfall[i]; //складываю осадки за день

                
                if (rainfall[i] > maxRainfall)
                {
                    maxRainfall = rainfall[i];
                    maxRainfallDay = i + 1; 
                }
            }

            Console.WriteLine(" Сумма осадков ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Декада {i + 1}: {decadalRainfall[i]} ");
            }

            Console.WriteLine($"День с самыми сильными осадками: {maxRainfallDay} (осадки: {maxRainfall} )");

            Console.WriteLine("Дни без осадков:");
            for (int i = 0; i < 30; i++)
            {
                if (rainfall[i] == 0)
                {
                    Console.WriteLine($"День {i + 1}");
                }
            }
        }
    }
}
