using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class FibonacciSeries
    {
        [Test]
        public void Run()
        {
            var ArrReturn = Fibonacci(5);
            int[] Result = new int[] { 0, 1, 1, 2, 3, 5, 8 };
            Assert.AreEqual(Result, ArrReturn);
        }
        int[] Fibonacci(int n)
        {
            int first_num = 0, second_num = 1, next_num; List<int> lst = new List<int>();
            if (n <= 0)
            {
                return new int[0];
            }
            else
            {
                lst.Add(0);
                lst.Add(1);
                for (int i = 1; i <= n; i++)
                {
                    next_num = first_num + second_num;
                    lst.Add(next_num);
                    first_num = second_num;
                    second_num = next_num;
                }

            }
            return lst.ToArray();
        }
    }


}
