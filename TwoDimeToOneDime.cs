using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class TwoDimeToOneDime
    {
        [Test]
        public void Run()
        {
            int[] Result = new int[] { 1, 2, 3, 4, 5, 6 };
            int[,] TwoD = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            var Return = TwoDimentional(TwoD);
           
            Assert.AreEqual(Result,Return);


        }
        int[] TwoDimentional(int[,] Tarr)
        {
            int Rows = Tarr.GetLength(0);
            int Columns = Tarr.GetLength(1);

            int[] OneD = new int[Rows* Columns];
            int index = 0;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    OneD[index] = Tarr[i, j]; 
                    index++;
                }
            }
            return OneD;
        }
    }
}
