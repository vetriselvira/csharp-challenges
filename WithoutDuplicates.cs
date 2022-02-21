using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class WithoutDuplicates
    {
        [Test]
        public void Run()
        {
            string str = "googles";
          var Return =  WithoutDuplicatesChar(str);
            List<char> Result = new List<char>() { 'l','e','s'};
            Assert.AreEqual(Result, Return);

        }
        List<char> WithoutDuplicatesChar(string str)
        {
            List<char> Returnstr = new List<char>();
            for (int i =0; i < str.Length; i++)
            {
           
                int count = 0;
                for(int j =0; j < str.Length; j++)
                {
                    if(i== j)
                    {
                        continue;
                    }
                    else
                    {
                        if(str[i] == str[j])
                        {
                            count = count + 1;
                            break;
                        } 
                        
                     } 
                    }
                if (count == 0)
                    Returnstr.Add(str[i]);

            }
            return Returnstr;
        }
    }
}
