using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class InsertionSortTwo
    {
        [Test]
        public void Run()
        {
            int[] arr = new int[6] { 2, 4, 9, 6, 5, 10 };
           var RetunArray =  InsertSort(arr);
            int[] ResultArray = new int[6] { 2, 4,5,6,9,10 };
            Assert.AreEqual(ResultArray, RetunArray);
        }


        int[] InsertSort(int[] arr)
        {
            int value = 0;
            for(int i=1; i <arr.Length; i++)
            {
                value = arr[i];
                for(int j= i-1; j >= 0; j--)
                {
                    if(value < arr[j])
                    {
                        arr[j+1] = arr[j];
                        arr[j] = value;
                    }
                }
            }
            return arr;
        }
    }
}
