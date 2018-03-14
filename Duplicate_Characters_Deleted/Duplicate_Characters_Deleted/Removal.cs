using System;
using System.Collections.Generic;
using System.Text;

namespace Duplicate_Characters_Deleted
{
    class Removal
    {
        public string RemoveDuplicates(string input)
        {
            string result = "";

            foreach (char value in input)
            {
                if (result.IndexOf(value) == -1)
                {
                    result += value;
                }
            }
            return result;
        }
    }
}
