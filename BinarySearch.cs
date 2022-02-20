using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class BinarySearch
    {
        [Test]
        public void Run()
        {
            int[] arr = new int[5] { 2, 5, 4, 7, 1 };
            var index = BinarySearchAlgorithm(arr, 4);
            Assert.AreEqual(2, index);
        }

        int BinarySearchAlgorithm(int[] arr, int num)
        {
            int min = 0, max = arr.Length - 1, mid = 0;
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                mid = (min + max) / 2;
                if (arr[mid] == num)
                {
                    return mid;
                }
                else if (arr[mid] > num)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }

            }

            return -1;
        }
    }

}
