using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class PartTwo
    {
        public static long invalidRecordCount(string[] inputs)
        {
            long results = 0;
            string[] range;
            foreach (string input in inputs)
            {
                range = input.Split('-');
                results += duplicatesInRange(long.Parse(range[0]), long.Parse(range[1]));
            }
            return results;
        }


        private static long duplicatesInRange(long start, long end)
        {
            long results = 0;
            for (long i = start; i <= end; i++)
            {
                if (isInvalid(i))
                {
                    {
                        results += i;
                    }
                }
            }
            return results;
        }

        private static bool isInvalid(long number)
        {
            string numberStr = number.ToString();
            for(int i = 0; i <= numberStr.Length / 2; i++)
            {
               string currentSubString = numberStr.Substring(0, i + 1);
                for (int j = currentSubString.Length; j + currentSubString.Length <= numberStr.Length; j += currentSubString.Length)
                {
                    if( numberStr.Substring(j, currentSubString.Length) == currentSubString)
                    {
                        int numberOfPatterns = numberStr.Length / currentSubString.Length;
                        string patternToCheck = "";
                        for (int k = 0; k < numberOfPatterns; k++)
                        {
                            patternToCheck += currentSubString;
                        }
                        if(patternToCheck == numberStr)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
