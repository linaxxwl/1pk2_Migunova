namespace Task_04_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] heights = new int[30]; 
            Random random = new Random();

            int boys = 0;
            int girls = 0;
            int boysSum = 0; 
            int girlsSum = 0; 
            
            for (int i = 0; i < heights.Length; i++)
            {
                heights[i] = random.Next(-150, 201);
            }

            
            foreach (int height in heights)
            {
                if (height < 0)
                {
                    boys++;
                    boysSum += -height; //сумма роста ( + значения)
                }
                else 
                {
                    girls++;
                    girlsSum += height;
                }
            }

            
            double boysAverageHeight = boys > 0 ? (double)boysSum / boys : 0;
            double girlsAverageHeight = girls> 0 ? (double)girlsSum / girls : 0;

            
            Console.WriteLine($" Количество мальчиков: {boys}, Средний рост: {boysAverageHeight} см ");
            Console.WriteLine($" Количество девочек: {girls}, Средний рост: {girlsAverageHeight} см ");
        }
    }
}
  
