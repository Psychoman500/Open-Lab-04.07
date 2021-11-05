using System;
using System.Linq;

namespace Open_Lab_04._07
{
    public class StringTools
    {
        public string Reverse(string original)
        {
            return new string(original.Reverse().ToArray());
        }
    }
}
