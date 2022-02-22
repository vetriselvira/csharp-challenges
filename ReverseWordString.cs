using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class ReverseWordString
    {[Test]
    public void Run()
        {
            string str = "my boy";
         var Return = ReverseWord(str);
            string Result = "ym yob";
            Assert.AreEqual(Result, Return);
        }
       string ReverseWord(string str)
        {
            string strWord = string.Empty;
            string final = string.Empty;
            List<string> lst = new List<string>();
            for(int i=0; i < str.Length; i++)
            {
                if(str[i] != ' ')
                {
                    strWord = str[i] + strWord;

                }
                else
                {
                    lst.Add(strWord);
                    strWord = string.Empty;

                }
            }
            lst.Add(strWord);
            foreach(var word in lst)
            {
                final = final + word + " ";
            }
            final =final.Substring(0, final.Length-1);
            return final;
        }
    }
}
