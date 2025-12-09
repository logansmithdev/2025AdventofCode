using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class PartOne
    {
        public static int FindAccessibleRollsSum(string[] rollMap)
        {
            string[] resultMap = new string[rollMap.Length];

            int result = 0;
            int adjacentRollCount = 0;
            for (int i = 0; i < rollMap.Length; i++)
            {
                adjacentRollCount = 0;
                resultMap[i] = "";
                for (int j = 0; j < rollMap[0].Length; j++)
                {
                    adjacentRollCount = 0;
                    if (rollMap[i][j] == '@')
                    {
                        //x..
                        //.0.
                        //...
                        if (i - 1 >= 0 && j - 1 >= 0 && rollMap[i - 1][j - 1] == '@')
                        {
                            adjacentRollCount++;
                        }
                        //.x.
                        //.0.
                        //...
                        if (i - 1 >= 0 && rollMap[i - 1][j] == '@')
                        {
                            adjacentRollCount++;
                        }
                        //..x
                        //.0.
                        //...
                        if (i - 1 >= 0 && (j + 1) < rollMap[i].Length && rollMap[i - 1][j + 1] == '@')
                        {
                            adjacentRollCount++;
                        }
                        //...
                        //x0.
                        //...
                        if (j - 1 >= 0 && rollMap[i][j - 1] == '@')
                        {
                            adjacentRollCount++;
                        }
                        //...
                        //.0x
                        //...
                        if ((j + 1) < rollMap[i].Length && rollMap[i][j + 1] == '@')
                        {
                            adjacentRollCount++;
                        }
                        //...
                        //.0.
                        //x..
                        if ((i + 1) < rollMap.Length && j - 1 >= 0 && rollMap[i + 1][j - 1] == '@')
                        {
                            adjacentRollCount++;
                        }
                        //...
                        //.0.
                        //.x.
                        if ((i + 1) < rollMap.Length && rollMap[i + 1][j] == '@')
                        {
                            adjacentRollCount++;
                        }
                        //...
                        //.0.
                        //..x
                        if ((i + 1) < rollMap.Length && (j + 1) < rollMap.Length && rollMap[i + 1][j + 1] == '@')
                        {
                            adjacentRollCount++;
                        }
                        if (adjacentRollCount < 4)
                        {
                            resultMap[i] += "X";
                            result++;
                        }
                        else
                        {
                            resultMap[i] += "@";
                        }
                    }
                    else
                    {
                        resultMap[i] += ".";
                    }
                }
                
            }
            foreach (var line in resultMap)
            {
                //Console.WriteLine(line);
            }
            return result;
        }
    }
}
