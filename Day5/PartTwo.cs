using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class PartTwo
    {
        public static long FindFreshIdSum(string[] ranges)
        {
            long result = 0;
            var freshRangeSortedDictionary = new SortedDictionary<long, long>();
            foreach (var range in ranges)
            {
                long start = long.Parse(range.Split('-')[0]);
                long end = long.Parse(range.Split('-')[1]);
                if (freshRangeSortedDictionary.ContainsKey(start))
                {
                        freshRangeSortedDictionary[start] = Math.Max(freshRangeSortedDictionary[start] , end);
                }
                else
                {
                    freshRangeSortedDictionary.Add(start, end);
                }
            }
            var distinctRangeDictionary = new Dictionary<long, long>();
            for(int i = 0; i < freshRangeSortedDictionary.Count(); i++)
            {
                if (distinctRangeDictionary.Count() == 0)
                {
                    distinctRangeDictionary.Add(freshRangeSortedDictionary.Keys.ElementAt(i), freshRangeSortedDictionary[freshRangeSortedDictionary.Keys.ElementAt(i)]);
                }
                else if(freshRangeSortedDictionary.Keys.ElementAt(i) >= distinctRangeDictionary.Keys.Last() && freshRangeSortedDictionary.Keys.ElementAt(i) <= distinctRangeDictionary.Values.Last())
                {
                    distinctRangeDictionary[distinctRangeDictionary.Keys.Last()] = Math.Max(distinctRangeDictionary[distinctRangeDictionary.Keys.Last()], freshRangeSortedDictionary[freshRangeSortedDictionary.Keys.ElementAt(i)]);
                }
                else
                {
                    distinctRangeDictionary.Add(freshRangeSortedDictionary.Keys.ElementAt(i), freshRangeSortedDictionary[freshRangeSortedDictionary.Keys.ElementAt(i)]);
                }
            }

            foreach(var distinctRange in distinctRangeDictionary)
            {
                Console.WriteLine("Key: " + distinctRange.Key + " Value: " + distinctRange.Value);
                result += distinctRange.Value - distinctRange.Key + 1;
            }
            return result;
        }
    }
}
