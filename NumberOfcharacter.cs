using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace csharp_challenges
{
    internal class NumberOfcharacter
    {
        [Test]
        public void Run()
        {
            string str = "Hello";
            var Return = OccuranceOfElements(str);
            Dictionary<char, int> dict = new Dictionary<char, int> { ['H']=1,['e']=1,['l']=2,['o']=1};

            Assert.AreEqual(dict, Return);
        }
        Dictionary<char, int> OccuranceOfElements (string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i=0; i < str.Length; i++)
            {
                
                foreach(var ch in str)
                {
                    if (dict.ContainsKey(ch))
                    {
                        dict[ch] = dict[ch] + 1;
                    }
                    else
                    {
                        dict.Add(ch, 1);
                    }
                }
               
              
            }
            return dict;
        }
    }
}
