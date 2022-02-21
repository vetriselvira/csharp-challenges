using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class R_emoveDuplicateFromArray
    {
        [Test]
        public void Run()
        {
            int[] arr = new int[] { 2, 3, 4, 6, 9,4, 3, 2 };
            var ReturnItem = ArrayDuplicateRemoval(arr);
            List<int> lst = new List<int>() { 2, 3, 4, 6,9 };
            Assert.AreEqual(lst, ReturnItem);
        }
        List<int> ArrayDuplicateRemoval(int[] arr)
        {
            List<int> lst = new List<int>();
            for(int i =0; i < arr.Length; i++)
            {
                int count = 0;
               if(lst.Count == 0)
                {
                    lst.Add(arr[i]);
                }
                else
                {
                    foreach (var j in lst)
                    {
                        if (arr[i] == j)
                        {
                            count = count + 1;
                        }
                    }
                    if (count == 0)
                    {
                        lst.Add(arr[i]);
                    }
                }
            }
            return lst;
        }
    }
}
