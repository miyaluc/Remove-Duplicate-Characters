using System;
using System.Collections.Generic;
using System.Text;

namespace Duplicate_Characters_Deleted
{
    class Removal
    {
        //Given a string of characters, remove all duplicate characters, returning the string with the characters in order of first appearance

        public string RemoveDuplicates(string input)
        {
            //declaring empty string called result
            string result = "";

            //for each character in input
            foreach (char value in input)
            {
                //IndexOf() returns an index when the substring is found, but -1 if not. We must test for -1 if no value may exist.
                //if the char value is not already in string result 
                if (result.IndexOf(value) == -1)
                {
                    //add the value to string result
                    result += value;
                }
            }
            //output result
            Console.WriteLine(result);
            //return
            return result;
        }
    }
}
