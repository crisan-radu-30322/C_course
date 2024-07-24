namespace WeatherSimulator
{
    internal class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate:");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Couldy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for(int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }

            //double averageTemp = CalculateAverage(temperature);

            Console.WriteLine($"Averge Temperature is: {CalculateAverage(temperature)}");
            Console.WriteLine($"The max temp was: {temperature.Max()}");
            Console.WriteLine($"The min temp was: {temperature.Min()}");
            Console.WriteLine($"The most common condition is: {MostCommonCondition(weatherConditions)}");
        }

        static double CalculateAverage(int[] temperature)
        {
            double sum = 0;
            for(int i = 0; i < temperature.Length; i++)
            {
                sum += temperature[i];
            }

            double average = sum / temperature.Length;

            return average;
        }

        static string MostCommonCondition(string[] conditions)
        {
            int count = 0;
            string mostCommon = conditions[0];

            for(int i = 0;i < conditions.Length;i++)
            {
                int tempCount = 0;
                for (int j = 0; j < conditions.Length; j++)
                {
                    if (conditions[j] == conditions[i])
                    {
                        tempCount++;
                    }
                }
                if(tempCount > count)
                {
                    count = tempCount;
                    mostCommon = conditions[i];
                }
            }

            return mostCommon; 
        }

    }
}
