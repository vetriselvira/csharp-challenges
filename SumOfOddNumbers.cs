using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class SumOfOddNumbers
    {
        [Test]
        public void Run()
        {
            var Return = OddNumbers(50,100);
            int Result = 1875;
            Assert.AreEqual(Result, Return);
        }
       int  OddNumbers(int Fnum,int Tnum)
        {
            int Result = 0;
            for(int i =Fnum; i <= Tnum; i++)
            {
                if(i % 2 != 0)
                {
                    Result = Result + i;
                }
            }
            return Result;
        }
    }
}
