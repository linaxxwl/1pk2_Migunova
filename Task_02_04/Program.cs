namespace Task_02_04
{
    internal class Program
    {
        static void Main(string[] args)

        {
                Console.WriteLine(" Введите текущую дату (день, месяц, год) ");
                int currentDay = Convert.ToInt32(Console.ReadLine());
                int currentMonth = Convert.ToInt32(Console.ReadLine());
                int currentYear = Convert.ToInt32(Console.ReadLine());

     
                Console.WriteLine(" Введите дату своего рождения (день, месяц, год) ");
                int birthDay = Convert.ToInt32(Console.ReadLine());
                int birthMonth = Convert.ToInt32(Console.ReadLine());
                int birthYear = Convert.ToInt32(Console.ReadLine());

                int age = currentYear - birthYear;

                if (currentMonth < birthMonth || (currentMonth == birthMonth && currentDay < birthDay))
                {
                    age--; //-1 год,если др было в том году
                }

                if (age >= 18)
                {
                    Console.WriteLine(" Совершеннолетний ");
                }
                else
                {
                    Console.WriteLine(" Несовершеннолетний ");
                }

                Console.ReadKey();
            }
        }
    }

