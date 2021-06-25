using System;

namespace Inversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {1, 2, 3 };
            int maxCount = array.Length - 1;
            int minCount = 0;
            for (int counter = maxCount; counter >= minCount; --counter)
            {
                Console.Write(array[counter]);
            }
            Console.WriteLine();
        }
    }
}
