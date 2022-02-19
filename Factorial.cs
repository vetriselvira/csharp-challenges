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
            int F = Factorial(5);     
            Assert.AreEqual(120, F);

            Assert.AreNotEqual(0, Factorial(0));

            Assert.AreEqual(1, Factorial(1));

           
        }


        int Factorial(int n)
        {
            int result = 1;
            for (int i = n; i > 0; i--)
            {
                result = result * i;
            }
            return result;
        }
    }
}
