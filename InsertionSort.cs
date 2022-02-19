using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_challenges
{
    internal class InsertionSort
    {

    int[] Insert(int[] arr)
        {
            int value = 0,temp =0;
            for(int i=1; i < arr.Length; i++)
            {
                value = arr[i]; 
                for(int j = i-1; j> 0; j--)
                {
                    if(value < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        
                        arr[j + 1] = value;
                    }
                }
            }
            return arr;
        }
    }
}
