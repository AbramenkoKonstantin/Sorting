using System;
/// <summary>
/// Наугад выбираются и меняются местами два элемента. 
/// После этого проверяется, отсортирован ли массив. 
/// Если нет, то повторяются те же действия.
/// </summary>
namespace BozoSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int count = 0;
            int sum = 0;
            int[] array = new int[] { 2, 8, 3, 9};
            int minCount = 0;
            int maxCount = array.Length - 1;
            while (count != maxCount)
            {
                int firstIndex = rnd.Next(0, array.Length);
                int secondIndex = rnd.Next(0, array.Length);
                int temp = array[firstIndex];
                array[firstIndex] = array[secondIndex];
                array[secondIndex] = temp;

                for (int counter = minCount; counter < array.Length; ++counter)
                {
                    Console.Write(array[counter]);
                }
                sum += 1;
                Console.WriteLine();

                for (int counter = minCount; counter < maxCount; ++counter)
                {
                    int nextElement = counter + 1;
                    if (array[nextElement] >= array[counter])
                    {
                        count += 1;
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
