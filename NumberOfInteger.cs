using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class NumberOfInteger
    {
        [Test]
        public void Run()
        {
           var Return =  Integers(1548554);
            int Result = 7;
            Assert.AreEqual(Result, Return);

        }
        int Integers(int num)
        {
            int count = 0;
            while (num > 0)
            {
                num = num / 10;
                count++;
            }
            return count;
        }
    }
}
