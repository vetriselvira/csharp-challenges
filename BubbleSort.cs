using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class BubbleSort
    {
        [Test]
        public void Run()
        {
            int[] arr = new int[5] { 2, 8, 4, 6, 7 };
            var arr_sorted = BubbleSort1(arr);
            int[] Result = new int[5] { 2, 4, 6, 7, 8 };
            Assert.AreEqual(Result, arr_sorted);
        }

        int[] BubbleSort1(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = 0;
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                    }
                }
            }
            return arr;
        }
    }

}
