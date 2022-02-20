using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class BuzzNum
    {
        [Test]
        public void Run()
        {
            var ReturnTrue = Buzz(7);
            var ReturnFalse = Buzz(9);
            bool ResultTrue = true;
            bool ResultFalse = false;
            Assert.AreEqual(ResultTrue, ReturnTrue);
            Assert.AreEqual(ResultFalse, ReturnFalse);
        } 
        bool Buzz(int num)
        {
            if(num % 7 == 0 || num % 10 == 7)
            {
                return true;
            }
            return false;
        }
    }
}
