using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class PartOne
    {
        public static int FreshIngredientSum(string[] freshRanges, string[] availableIngredients)
        {
            int result = 0;
            var freshRangeDictionary = new Dictionary<long, long>();
            foreach (var range in freshRanges)
            {
                long start = long.Parse(range.Split('-')[0]);
                long end = long.Parse(range.Split('-')[1]);
                if (freshRangeDictionary.ContainsKey(start))
                {
                    if (freshRangeDictionary[start] < end)
                    {
                        freshRangeDictionary[start] = end;
                    }
                }
                else
                {
                    freshRangeDictionary.Add(start, end);
                }
            }
            var sortedRangeDictionary = freshRangeDictionary.OrderBy(pair => pair.Key);

            foreach (string ingredient in availableIngredients)
            {
                long ingredientInt = long.Parse(ingredient);
                foreach (var range in sortedRangeDictionary)
                {
                    if (ingredientInt >= range.Key)
                    {
                        if (ingredientInt <= range.Value)
                        {
                            result++;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return result;
        }
    }
}
