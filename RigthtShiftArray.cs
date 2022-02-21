using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class RigthtShiftArray
    {
        [Test]
        public void Run()
        {
            int[] arr = new int[]{ 1,2,3,4,5};
           var Return =  RightShift(arr);
            int[] Result= new int[] {5, 1, 2, 3, 4 };
            Assert.AreEqual(Result, Return);

        }
        int[] RightShift(int[] arr)
        {
            int temp = 0;
            for(int i = arr.Length-1; i> 0; i--)
            {
                temp = arr[i];
                arr[i] = arr[i - 1];
                arr[i - 1] = temp;
            }
            return arr;
        }
    }
}
