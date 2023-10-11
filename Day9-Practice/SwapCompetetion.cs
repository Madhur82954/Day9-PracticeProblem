using System;
using System.Collections.Generic;
using System.Text;

namespace Day9_Practice
{
    public class SwapCompetetion
    {
        public string checkString(string s1, string s2)
        {
            char[] arr1 = s1.ToLower().ToCharArray();
            char[] arr2= s1.ToLower().ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);
            if(new string(arr1) == new string(arr2))
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
    }
}
