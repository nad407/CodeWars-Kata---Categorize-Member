using System;
using System.Collections.Generic;
using System.Text;

namespace CategorizeYourMember
{
    class OpenSenior
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            List<string> category = new List<string>();
            int i = 0;

            foreach (int[] person in data)
            {
                if ((person[0] >= 55) & (person[1] > 7))
                {
                    category.Add("Senior");
                }
                else
                {
                    category.Add("Open");
                }
                i++;
            }

            return category;
        }
    }
}
