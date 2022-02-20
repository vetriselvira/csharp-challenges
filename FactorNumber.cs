using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class NumberNumber
    {
        [Test]
        public void Run()
        {
            var RetunList = Factors(9);
            List<int> ResultList = new List<int>() { 1,3,6};
            Assert.AreEqual(ResultList, RetunList);
        }
   List<int> Factors(int n)
        {
            List<int> lst = new List<int>();
            for(int i=1; i <= n; i++)
            {
                if(n% i == 0)
                {
                    lst.Add(i);
                }
            }
            return lst;
        }
    }
}
