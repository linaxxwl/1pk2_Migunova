namespace Task_11_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" введите буквы :");
            string input = Console.ReadLine();

            int vowelsCount, consonantsCount;

            // вызываю метод с выводом
            CountVowelsAndConsonants(input, out vowelsCount, out consonantsCount);

            Console.WriteLine(" количество гласных: " + vowelsCount);
            Console.WriteLine(" количество согласных: " + consonantsCount);
        }

        static void CountVowelsAndConsonants(string str, out int vowels, out int consonants)
        {
            vowels = 0;
            consonants = 0;

            char[] vowelsArray = { 'у', 'е', 'ы', 'а', 'о', 'э', 'я', 'и', 'ю', 'У', 'Е', 'Ы', 'А', 'О', 'Я', 'Э', 'И', 'Ю' };

            foreach (char c in str)
            {
                if (char.IsLetter(c)) 
                {
                    if (Array.Exists(vowelsArray, v => v == c)) // 
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
            }
        }
    }
}
    

