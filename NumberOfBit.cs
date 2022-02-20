using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class NumberOfBit
    {
        int NumBit(int num)
        {
            int count = 0;
            while(num > 0)
            {
                if(num % 2 != 0)
                {
                    count = count + 1;
                }
                num = num / 2;

            }
            return count;
        }
    }
}
