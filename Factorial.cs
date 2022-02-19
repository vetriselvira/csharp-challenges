using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class FactorialClass
    {

        [Test]
        public void Run()
        {
            int F_For = FactorialFor(5);
            int F_re = FactorialRecursive(5);
            Assert.AreEqual(120, F_re);
            Assert.AreEqual(120, F_For);

        }


        int FactorialFor(int n)
        {
            int result = 1;
            for (int i = n; i > 0; i--)
            {
                result = result * i;
            }
            return result;
        }


       int  FactorialRecursive(int n)
        {
            if(n <= 0)
            {
                return 1;
            } else
            {
                return n * FactorialRecursive(n - 1);
            }

        }
    }
}
