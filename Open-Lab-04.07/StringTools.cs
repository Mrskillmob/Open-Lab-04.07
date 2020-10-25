using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Open_Lab_04._07
{
    public class StringTools
    {
        public string Reverse(string original)
        {
            string a = "";
          
            char[] rg = new char[original.Length];
            for (int i = 0; i < original.Length; i++)
            {
                rg[i] = original[i];
                   
            }
            Array.Reverse(rg);

              a = String.Join(a, rg);

            return a;

        }
    }
}
