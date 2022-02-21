using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class OneDimeToTwoDime
    {
        [Test]
        public void Run()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            int Rows = 2, Columns = 3;
            var Return = TwoDimentional(arr, Rows, Columns);
            int[,] TwoD = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            Assert.AreEqual(Return, TwoD);


        }
        int[,] TwoDimentional(int[] arr, int Rows, int Columns)
        {

            int[,] TwoD = new int[Rows, Columns];
            int index = 0;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    TwoD[i, j] = arr[index];
                    index++;
                }
            }
            return TwoD;
        }
    }
}
