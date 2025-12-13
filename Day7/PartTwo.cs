using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public class PartTwo
    {

        public static long SplitBeamSum(string[] inputs)
        {
            long[,] resultsStorage = new long[inputs.Length, inputs[0].Length];
            inputs[0] = inputs[0].Replace('S', '1');
            resultsStorage[0, inputs[0].IndexOf('1')] = 1;
            for (int i = 0; i < inputs.Length; i++)
            {
                for (int j = 0; j < inputs[i].Length; j++)
                {
                    if ((inputs[i][j] != '^' && inputs[i][j] != '.') && i < (inputs.Length - 1))
                    {
                        StringBuilder sb = new StringBuilder(inputs[i + 1]);
                        if (inputs[i + 1][j] == '^')
                        {
                            if (j > 0)
                            {
                                if (sb[j - 1] == '.')
                                {
                                    resultsStorage[i + 1, j - 1] = resultsStorage[i, j];
                                    sb[j - 1] = '|';
                                }
                                else
                                {
                                    resultsStorage[i + 1, j - 1] = resultsStorage[i + 1, j - 1] + resultsStorage[i, j];
                                    sb[j - 1] = '|';
                                }
                                inputs[i + 1] = sb.ToString();
                            }
                            if (j < inputs[i].Length - 1)
                            {
                                if (sb[j + 1] == '.')
                                {
                                    resultsStorage[i + 1, j + 1] = resultsStorage[i, j];
                                    sb[j + 1] = '|';
                                }
                                else
                                {
                                    resultsStorage[i + 1, j + 1] = resultsStorage[i + 1, j + 1] + resultsStorage[i, j];
                                    sb[j + 1] = '|';
                                }
                                inputs[i + 1] = sb.ToString();
                            }
                        }
                        else if (inputs[i + 1][j] == '.')
                        {
                            resultsStorage[i + 1, j] = resultsStorage[i, j];
                            sb[j] = '|';
                            inputs[i + 1] = sb.ToString();
                        }
                        else
                        {
                            resultsStorage[i + 1, j] = resultsStorage[i, j] + resultsStorage[i + 1, j];
                            sb[j] = '|';
                            inputs[i + 1] = sb.ToString();
                        }
                    }
                    Console.Write(inputs[i][j]);
                }
                Console.WriteLine();
            }
            long results = 0;
            for (int k = 0; k < inputs[inputs.Length - 1].Length; k++)
            {
                if (resultsStorage[inputs.Length -1, k] != null)
                {
                    results += resultsStorage[inputs.Length - 1, k];
                }

            }
            return results;
        }
    }
}
