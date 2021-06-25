using System;

/// <summary>
/// Идея алгоритма следующая:
/// Необходимо выбрать опорный элемент массива, им может быть любой элемент, от этого не зависит правильность работы алгоритма;
/// Разделить массив на три части, в первую должны войти элементы меньше опорного, во вторую - равные опорному и в третью - все элементы больше опорного;
/// Рекурсивно выполняются предыдущие шаги, для подмассивов с меньшими и большими значениями, до тех пор, пока в них содержится больше одного элемента.
/// </summary>

namespace QuickSort
{
    class Program
    {
        //метод возвращающий индекс опорного элемента
        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    int m = array[pivot];
                    array[pivot] = array[i];
                    array[i] = m;
                }
            }

            pivot++;
            int t = array[pivot];
            array[pivot] = array[maxIndex];
            array[maxIndex] = t;
            return pivot;
        }

        //быстрая сортировка
        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        static int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 1, 4, 5 };
            Console.WriteLine(string.Join(" ", QuickSort(array)));

            Console.ReadLine();
        }
    }
}
