using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class KgAndG
    {
        [Test]
        public void Run()
        {
            var KgReturn= KgtoG(10);
            var GReturn = GToKg(1000);
            double KgResult = 10000;
            double GResult = 1;
            Assert.AreEqual(KgResult, KgReturn);
            Assert.AreEqual(GResult, GReturn);
        }

    double KgtoG(double kg)
        {
            return kg * 1000;
        }

        double GToKg(double G)
        {
            return G / 1000;
        }
    }
}
