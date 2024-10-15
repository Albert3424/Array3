using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Одномерный массив
            int[] numbers = { 5, 4, 3, 2, 1 };
            int numbersSum = numbers.Sum();
            double numbersAverage = numbers.Average();
            int minValue1 = numbers.Min();
            int maxValue1 = numbers.Max();
            Array.Sort(numbers);

            // Двумерный массив
            int[,] numbers2 = new int[2, 3] { { 6, 7, 3 }, { 2, 4, 8 } };
            int totalElements = numbers2.Length;
            var numbers2Sum = numbers2.Cast<int>().Sum();
            int[] flattenedArray = numbers2.Cast<int>().ToArray();
            double numbers2Average = numbers2Sum / totalElements;
            int minValue2 = flattenedArray.Min();
            int maxValue2 = flattenedArray.Max();

            // Зубчатый массив
            int[][] numbers3 = new int[][] { new int[] { 3, 5, 7 }, new int[] { 1, 2, 4, 6 }};
            int numbers3Sum = 0;
            int totalElements2 = 0;
            int minValue3 = numbers3.SelectMany(a => a).Min();
            int maxValue3 = numbers3.SelectMany(a => a).Max();

            foreach (int[] subArray in numbers3)
            {
                totalElements2 += subArray.Length;
            }

            foreach (int[] subArray in numbers3)
            {
                foreach (int element in subArray)
                {
                    numbers3Sum += element;
                }
            }
            double numbers3Average = numbers3Sum / totalElements2;
        }
    }
}
