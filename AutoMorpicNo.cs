using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class AutoMorpicNo
    {

        [Test]
        public void Run()
        {
            var ReturnTrue = Morpic(25);
            var ReturnFalse = Morpic(7);
            bool ResultTrue = true;
            bool ResultFalse = false;
            Assert.AreEqual(ResultTrue, ReturnTrue);
            Assert.AreEqual(ReturnFalse, ReturnFalse);


        }
        bool Morpic(int num)
        {
            int count = 0, Remainder = 0;
            int SqNum = num * num;



            while (num > 0)
            {
                if (num % 10 != SqNum % 10)
                {
                    return false;
                }
                num = num / 10;
                SqNum = SqNum / 10;
             }
            return true;
        }
    }
}
