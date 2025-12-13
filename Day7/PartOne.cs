using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public class PartOne
    {
        public static long SplitBeamSum(string[] inputs)
        {
            long results = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                for (int j = 0; j < inputs[i].Length; j++)
                {
                    if ((inputs[i][j] == 'S' || inputs[i][j] == '|') && i < (inputs.Length - 2))
                    {
                        StringBuilder sb = new StringBuilder(inputs[i + 1]);
                        if (inputs[i + 1][j] == '^')
                        {
                            results++;
                            if (j > 0 && sb[j - 1] != '|') 
                            {
                                sb[j - 1] = '|';
                                inputs[i + 1] = sb.ToString();
                            }
                            if(j < inputs.Length - 2)
                            {
                                sb[j + 1] = '|';
                                inputs[i + 1] = sb.ToString();
                            }
                        }
                        else
                        {
                            sb[j] = '|';
                            inputs[i + 1] = sb.ToString();
                        }
                    }
                    Console.Write(inputs[i][j]);
                }
                Console.WriteLine();
            }
            return results;
        }
    }
}
