using System.Security.Cryptography;

namespace Task_10_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 5;
            Console.WriteLine(" до вызова метода: num1 = " + num1 + ", num2 = " + num2);
            Swap(ref num1, ref num2); // меняю местами

            Console.WriteLine(" после вызова: num1 = " + num1 + ", num2 = " + num2);
        }

        static void Swap(ref int num1, ref int num2)
        {
            Console.WriteLine(" Вне метода,до обмена: num1 = " + num1 + ", num2 = " + num2);
            int temp = num1;
            num1 = num2; // a значение b
            num2 = temp; // b значение из temp
            Console.WriteLine(" Вне метода,после обмена: num1 = " + num1 + ", num2 = " + num2);
        }
    }
}
    

