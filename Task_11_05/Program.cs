namespace Task_11_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 7;
            int num2 = 2;
            int sum, product;

            Console.WriteLine(" до вызова метода: num1 = " + num1 + ", num2 = " + num2);

            // Вызов метода с использованием ref и out
            Calculate(ref num1, ref num2, out sum, out product);

            Console.WriteLine(" после вызова метода: num1 = " + num1 + ", num2 = " + num2);
            Console.WriteLine(" сумма: " + sum);
            Console.WriteLine("произведение: " + product);
        }

        static void Calculate(ref int a, ref int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;

           
            a += 1;
            b += 1;
        }
    }
}
    

