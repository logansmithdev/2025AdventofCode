using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class PartTwo
    {
        public static long FindMaximumJoltageSum(string[] banks)
        {
            long results = 0;

            foreach (string bank in banks)
            {
                results += FindMaximumJoltage(bank);
            }
            return results;
        }


        public static long FindMaximumJoltage(string bank)
        {
            int currentDigit = 0;
            int[] resultDigits = [0,0,0,0,0,0,0,0,0,0,0,0];
            int startIndex = 0;
            int endIndex = bank.Length - resultDigits.Length;
            for(int i =  0; i < resultDigits.Length; i++)
            {
                for(int j = startIndex; j <= endIndex; j++)
                {
                    currentDigit = int.Parse(bank[j].ToString());
                    if(currentDigit > resultDigits[i])
                    {
                        resultDigits[i] = currentDigit;
                        startIndex = j + 1;
                    }
                }
                endIndex++;
            }
            string resultStr = "";
            for(int k = 0; k < resultDigits.Length; k++)
            {
                resultStr +=resultDigits[k].ToString();
            }
            return long.Parse(resultStr);
        }
    }
}
