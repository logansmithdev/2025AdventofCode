using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class PartOne
    {
        public static long MathProblemSum(string[][] problemMatrix)
        {
            long result = 0;
            for (int i = 0; i < problemMatrix[0].Length; i++)
            {
                string[] problem = new string[problemMatrix.Length];
                for (int j = 0; j < problemMatrix.Length; j++)
                {
                    problem[j] = problemMatrix[j][i].ToString();
                }
                result += MathProblemAnswer(problem);
            }
            return result;
        }

        public static long MathProblemAnswer(string[] problem)
        {
            long result = 0;
            if (problem[problem.Length - 1] == "+")
            {
                for (int i = 0; i < problem.Length - 1; i++)
                {
                    result += long.Parse(problem[i]);
                }
            }
            else if (problem[problem.Length - 1] == "*")
            {
                for (int j = 0; j < problem.Length - 1; j++)
                {
                    if(j == 0)
                    {
                        result = long.Parse(problem[j]);
                    }
                    else
                    {
                        result *= long.Parse(problem[j]);
                    }  
                }
            }
                return result;
        }
    }
}
