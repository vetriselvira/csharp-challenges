using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class DuplicateFromString
    {
        [Test]
        public void Run()
        {
            string str = "googlse";
            string Return = Dulplicates(str);
            string Result = "golse";
            Assert.AreEqual(Result, Return);
        }
        string Dulplicates(string str)
        {
            
            string ReturnStr = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                int count = 0;
               
                    if (ReturnStr.Length == 0)
                    {
                        ReturnStr = ReturnStr + str[i];
                    }
                    foreach (var c in ReturnStr)
                    {
                        if (str[i] == c)
                        {
                            count = count + 1;
                        break;
                        }

                    }

                    if (count == 0)
                    {
                        ReturnStr = ReturnStr + str[i];
                    }
                
            }
            return ReturnStr;
        }
    }
}
