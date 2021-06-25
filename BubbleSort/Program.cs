using System;
/// <summary>
/// Алгоритм заключается в циклических проходах по массиву.
/// За каждый проход элементы массива попарно сравниваются и, если их порядок не правильный, то осуществляется обмен. 
/// Обход массива повторяется до тех пор, пока массив не будет упорядочен.
/// </summary>
namespace BubbleSort
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] array = new int[] {3, 4, 1, 5};
            int minCount = 0;
            int maxCount = array.Length - 1;
            for (int counterRepetition = minCount; counterRepetition < maxCount; ++counterRepetition)
            {
                for (int counter = minCount; counter < maxCount; ++counter)
                {
                    if (array[counter] > array[counter + 1])
                    {
                        int nextElement = counter + 1;
                        int temp = array[counter];
                        array[counter] = array[nextElement];
                        array[nextElement] = temp;
                    }
                }
            }
            for (int counter = minCount; counter < array.Length; ++counter)
            {
                Console.Write(array[counter]);
            }
            Console.ReadLine();
        }
    }
}
