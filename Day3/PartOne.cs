using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class PartOne
    {
        public static int FindMaximumJoltageSum(string[] banks)
        {
            int results = 0;

            foreach (string bank in banks)
            {
                results += FindMaximumJoltage(bank);
            }
            return results;
        }


        public static int FindMaximumJoltage(string bank)
        {
            int currentDigit = 0;
            int firstDigit = 0;
            int firstDigitIndex = 0;
            int secondDigit = 0;
            for(int i = 0; i < bank.Length - 1; i++)
            {
                currentDigit = int.Parse(bank[i].ToString());
                if (currentDigit > firstDigit)
                {
                    firstDigitIndex = i;
                    firstDigit = currentDigit;
                }
            }
            for (int j = firstDigitIndex + 1; j < bank.Length; j++)
            {
                currentDigit = int.Parse(bank[j].ToString());
                if (currentDigit > secondDigit)
                {
                    secondDigit = currentDigit;
                }
            }
            return int.Parse(firstDigit.ToString() + secondDigit.ToString());
        }
    }
}
