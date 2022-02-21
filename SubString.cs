using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class SubString
    {
        [Test]
        public void Run()
        {
            string str = "ABC";
            var Return = SubStringList(str);
            List<string> Result = new List<string>() { "A","AB","ABC","B","BC","C"};
        
            Assert.AreEqual(Result, Return);

        }

        List<string> SubStringList(string str)
        {
            List<string> lst = new List<string>();
       
            for(int i = 0; i <str.Length; i++)
            {
                for(int j = 0; j < str.Length-i ; j++ )
                {
                    lst.Add(str.Substring(i, j + 1));
                }
            }
            return lst;
        }
    }
}
