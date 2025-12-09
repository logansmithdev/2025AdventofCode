using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class PartOne
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
            int middleIndex = numberStr.Length / 2;
            string firstHalfStr = numberStr.Substring(0, middleIndex);
            string secondHalfStr = numberStr.Substring(middleIndex);
            return firstHalfStr == secondHalfStr;
        }


        // Why the fuck doesn't this work
        //private static long duplicatesInRange(long start, long end)
        //{
        //    if (start > end)
        //    {
        //        return 0;
        //    }
        //    string startStr = start.ToString();
        //    if (startStr.Length % 2 != 0)
        //    {
        //        string newSequenceStr = "1";
        //        for (int i = 0; i < startStr.Length / 2; i++)
        //        {
        //            newSequenceStr += "0";
        //        }
        //        return duplicatesInRange(long.Parse(newSequenceStr + newSequenceStr), end);
        //    }
        //    int middleIndex = startStr.Length / 2;
        //    string startFirstHalfStr = startStr.Substring(0, middleIndex);
        //    string startSecondHalfStr = startStr.Substring(middleIndex);
        //    long startFirstHalfInt = long.Parse(startFirstHalfStr);
        //    long startSecondHalfInt = long.Parse(startSecondHalfStr);
        //    if (startFirstHalfStr == startSecondHalfStr)
        //    {
        //        string newSequenceHalf = (startFirstHalfInt + 1).ToString();
        //        return  start + duplicatesInRange(long.Parse(newSequenceHalf + newSequenceHalf), end);
        //    }
        //    else if (startFirstHalfInt > startSecondHalfInt)
        //    {
        //        return duplicatesInRange(long.Parse(startFirstHalfStr + startFirstHalfStr), end);
        //    }
        //    else
        //    {
        //        return duplicatesInRange(long.Parse(startSecondHalfStr + startSecondHalfStr), end);
        //    }
        //}
    }
}
//54070724758 is not right

//54641809925 is correct