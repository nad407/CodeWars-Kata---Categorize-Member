using System;
using System.Collections.Generic;

namespace CategorizeYourMember
{
    class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<string> cat;
            int[][] data = new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } };
            cat = OpenSenior.OpenOrSenior(data);
        }
    }
}
