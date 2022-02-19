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
            var v = Factorial(5);
            Assert.AreEqual(15, v);
        }


        int Factorial(int n)
        {

            int result = 0;
            for (int i = n; i >= 0; i--)
            {
                result = result + i;
            }
            return result;

        }
    }
}
