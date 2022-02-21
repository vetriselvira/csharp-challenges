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
            string lst="yM dne";
            Assert.AreEqual(lst, ReturnStr);
        }
        string Reverse(string str)
        {
            string ReturnStr = string.Empty;
            string final = string.Empty;
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
            lst.Add(ReturnStr);
            lst.ToArray();
          foreach(var word in lst)
            {
                final = final  + word +" ";
                
                
            }
           final =  final.Substring(0, str.Length);
            
            return final;
        }

    }
}
