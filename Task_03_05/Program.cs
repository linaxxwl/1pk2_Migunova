using System;
using System.Data;

namespace Task_03_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
        Console.Write(" Начальная температура в градусах Цельсия ");
        double start = Convert.ToDouble(Console.ReadLine());

        Console.Write(" Конечная температура в градусах Цельсия ");
        double end = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Цельсия\tФаренгейт");
            
            
        for (double C = start; C <= end; C++)
            
        {
             double F = C * 1.8 + 32;
             Console.WriteLine($"{C}\t{F}"); 
        }

        }
    }
}
