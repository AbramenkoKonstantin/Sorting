using System;

namespace SumOfNegativeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfNegativeNumbers = 0;
            int[,] array = { { -5, -6, 4 }, { 1, -2, 3 }, { -3, 0, 5 } };
            int maxCount = 3;
            int minCount = 0;
            for (int counterColumns = minCount; counterColumns < maxCount; ++counterColumns)
            {
                for (int counterStrings = minCount; counterStrings < maxCount; ++counterStrings)
                {
                    if (array[counterColumns, counterStrings] < 0)
                    {
                        sumOfNegativeNumbers += array[counterColumns, counterStrings];
                    }
                }
                Console.WriteLine(sumOfNegativeNumbers);
                sumOfNegativeNumbers = 0;
            }
        }
    }
}
