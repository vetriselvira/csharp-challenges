using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    
    internal class Swap
    {
        [Test]
        public void Run()
        {
            var rs = SwapInt(5, 6);
            Assert.AreEqual(rs.MyProperty1, 6);
            Assert.AreEqual(rs.MyProperty2, 5);

        }
        SwapNumbers SwapInt(int n1, int n2)
        {
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;


            return new SwapNumbers() { MyProperty1 = n1, MyProperty2 = n2 };
        }

    }


    public class SwapNumbers
    {
        public int MyProperty1 { get; set; }

        public int MyProperty2 { get; set; }
    }

}
