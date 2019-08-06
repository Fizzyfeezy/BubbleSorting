using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{
    class Quick
    {
        public static int[] QuickSort(int[] unsortedArray)
        {
            Console.WriteLine("ITERATIONS \n");
            int length = unsortedArray.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - 1 - i; j++)
                {
                    if (unsortedArray[j] > unsortedArray[j + 1])
                    {
                        int num = unsortedArray[j];
                        unsortedArray[j] = unsortedArray[j + 1];
                        unsortedArray[j + 1] = num;
                    }
                }
                foreach (var element in unsortedArray)
                {
                    Console.Write(element + " ");
                }
                Console.Write("\n\n");
            }
            Console.WriteLine("");

            return unsortedArray;
        }
    }
}
