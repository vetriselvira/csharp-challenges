using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class RightCircularRotation
    {
        [Test]
        public void Run()
        {
            int[] arr = new int[] { 6, 7, 8, 9, 10 };
            var Return =CircularRotation(arr);
            int[] result = new int[] { 7, 8, 9, 10,6 };
            Assert.AreEqual(result, arr);

        }

        int[] CircularRotation(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                temp = arr[i];
                arr[i] = arr[i+1];
                arr[i+1] = temp;
            }
            return arr;
        }
    }
}
