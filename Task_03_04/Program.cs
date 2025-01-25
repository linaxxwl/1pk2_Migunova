namespace Task_03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            int lineCount = 0;

            while (true)
            {
                Console.WriteLine("Введите текст или 'exit':");
                line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                {
                    break;
                }

                lineCount++;
            }

            Console.WriteLine($"Количество введенных строк: {lineCount}");

        }
    }
}
