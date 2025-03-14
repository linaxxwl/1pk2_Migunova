namespace Task_10_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 5; 
            Console.WriteLine(" До вызова метода: num1 = " + num1 + ", num2 = " + num2);

            SwapNumbers(num1, num2); // здесь пробую поменять

            Console.WriteLine(" После вызова метода: num1 = " + num2 + ", num2 = " + num1);
        }
        //метод для замены чисел местами
        static void SwapNumbers(int num1, int num2)
        {
            Console.WriteLine(" До обмена: num1 = " + num1 + ", num2 = " + num2);
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine(" После обмена: num1 = " + num1 + ", num2 = " + num2);
        }
    }
}

