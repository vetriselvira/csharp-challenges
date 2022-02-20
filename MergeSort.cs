using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class MergeSort
    {
       /* [Test]
        public void Run()
        {
            int[] arr1 = new int[4] { 2, 4, 8, 24 };
            int[] arr2 = new int[4] { 1, 5, 18, 20 };

            var ReturnArray = MergeElements(arr1, arr2);
            int[] Result = new int[8] { 1, 2, 4, 5, 8, 18, 20, 24 };
            Assert.AreEqual(Result, ReturnArray);
        }*/

    
  
        int[] MergeElements(int[]arr1, int[] arr2)
        {
            List<int> lst = new List<int>();
            for(int i =0; i < arr1.Length;)
            {
                for(int j = 0; j < arr2.Length; )
                {
                    if(arr1[i] < arr2[j])
                    {
                        lst.Add(arr1[i]);
                        i++;
                    } else
                    {
                        lst.Add(arr2[j]);
                        j++;
                    }
                }
            }
            return lst.ToArray();
        }
    }
}
