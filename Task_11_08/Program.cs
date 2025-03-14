namespace Task_11_08
{
    internal class Program
        /*Использование params и out: Напишите метод, который принимает переменное количество
        чисел и возвращает их сумму и максимальное значение через выходные параметры(out) */

    {
               static void CalculateSumAndMax(out int sum, out int max, params int[] numbers)
            {
                sum = 0;
                max = int.MinValue; // max минимальн значение

                foreach (int number in numbers)
                {
                    sum += number;
                    if (number > max) // проверка является ли текущее число максимальным
                    {
                        max = number;
                    }
                }
            }

            static void Main()
            {
       
                CalculateSumAndMax(out int sumValue, out int maxValue, 5, 6, 3, 9, 2);
                Console.WriteLine(" сумма: " + sumValue);
                Console.WriteLine(" максимальное значение: " + maxValue);
            }
        }
    }

