using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class ElementsWithoutDuplicates
    {
        [Test]
        public void Run()
        {
            int[] arr = new int[] { 2, 3, 4, 4, 6, 2, 7 };
            int[] Result = new int[] { 3, 6, 7 };
            var ReturnArray = ElementsWitoutDuplicates(arr);
            Assert.AreEqual(Result, ReturnArray);

        }
        List<int> ElementsWitoutDuplicates(int[] arr)
        {
            List<int> lst = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                { 
                    if(i == j)
                    {
                        continue;
                    }
                   
                    if (arr[i] == arr[j])
                    {
                        count = count + 1;
                        break;
                        
                    }
                   
                }
                if (count != 1)
                {
                    lst.Add(arr[i]);
                }
            }
            return lst;
        }
    }
}
