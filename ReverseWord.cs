using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class ReverseWord
    {
        [Test]
        public void Run()
        {
            string str = "My end";
            var ReturnStr = Reverse(str);
            List<string> lst= new List<string>() { "yM","dne"};
            Assert.AreEqual(lst, ReturnStr);
        }
        List<string> Reverse(string str)
        {
            string ReturnStr = string.Empty;
            List<string> lst = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                
                if(str[i] != ' ')
                {
                    ReturnStr = str[i] + ReturnStr;
                }
                else if(str[i] == ' '|| i == str.Length-1)
                {
                    lst.Add(ReturnStr);
                    ReturnStr = string.Empty;
                }
                

            }

            return lst;
        }
    }
}
