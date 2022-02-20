using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class IsPowerTwo
    {
        [Test]
        public void Run()
        {
           bool Return = Power(8);
            bool Result = true;
            Assert.AreEqual(Return, Result);
        }
    bool Power(int num)
        {
            while (num > 1)
            {
                if (num  % 2 != 0)
                {
                    return false;
                }
                num = num / 2;
                
            }
            if (num == 1)
            {
                return true;
            }
            return false;

        }
    }
}
