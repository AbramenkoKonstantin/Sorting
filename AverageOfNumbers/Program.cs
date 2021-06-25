using System;

namespace AverageOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double averageOfNumbers;
            int[,] array = { { 5, 6, 4 }, { 1, 2, 3 }, { 3, 0, 6 } };
            int sumOfElements = 0;
            int amountOfElements = 3;
            int maxCount = 3;
            int minCount = 0;
            for (int counterColumns = minCount; counterColumns < maxCount; ++counterColumns)
            {
                for (int counterStrings = minCount; counterStrings < maxCount; ++counterStrings)
                {
                    sumOfElements += array[counterColumns, counterStrings];
                }
                averageOfNumbers = sumOfElements / amountOfElements;
                Console.WriteLine(averageOfNumbers);
                sumOfElements = 0;
            }
        }
    }
}
