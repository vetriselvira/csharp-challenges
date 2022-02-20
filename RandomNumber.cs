using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class RandomNumber

    {
        List<int> RandomNum(int n)
        {

            Random rnd = new Random();
            List<int> lst = new List<int>();
            for (int j = 0; j < n; j++)
            {
                lst.Add(rnd.Next());

            }
            return lst;
        }
    }
}
