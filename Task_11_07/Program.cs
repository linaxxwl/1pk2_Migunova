namespace Task_11_07
{
    internal class Program
    {
             static void IncreaseArray(ref int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] += 1; // +1 на каждое число
                }
            }

            static void Main()
            {
                int[] numbers = { 1, 2, 3, 4, 5 };

                Console.WriteLine(" изначальный массив: " + string.Join(", ", numbers));
                IncreaseArray(ref numbers);
                Console.WriteLine(" измененный массив: " + string.Join(", ", numbers));
            }
        }
    }


