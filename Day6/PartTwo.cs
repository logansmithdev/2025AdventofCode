using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class PartTwo
    {
        public static long MathProblemSum(string[] problemRows)
        {
            long result = 0;
            List<int> columnIndex = new List<int>();
            for (int i = 0; i < problemRows[0].Length; i++)
            {
                if (problemRows[0][i] == ' ')
                {
                    bool foundANumber = false;
                    for (int j = 1; j < problemRows.Length; j++)
                    {
                        if (problemRows[j][i] != ' ')
                        {
                            foundANumber = true;
                            break;
                        }
                    }
                    if (!foundANumber)
                    {
                        for (int k = 0; k < problemRows.Length; k++)
                        {
                            StringBuilder sb = new StringBuilder(problemRows[k]);
                            sb[i] = '|';
                            problemRows[k] = sb.ToString();
                        }
                    }
                }
            }

            string[][] problemMatrix = new string[problemRows.Length][];
            for (int l = 0; l < problemMatrix.Length; l++)
            {
                problemMatrix[l] = problemRows[l].Replace(' ', '.').Split("|");
            }

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

        public static long MathProblemAnswer(string[] problemColumn)
        {
            
            string[] problemNumbers = new string[problemColumn[0].Length + 1];
            for (int i = 0; i < problemColumn[0].Length; i++)
            {
                problemNumbers[i] = "";
            }
            problemNumbers[problemNumbers.Length - 1] = problemColumn[problemColumn.Length - 1];
            for (int i = 0; i < problemNumbers.Length - 1; i++) {
                for (int j = 0; j < problemColumn.Length - 1; j++)
                {
                    if (problemColumn[j].Substring(problemColumn[j].Length - 1, 1) != ".")
                    {
                        problemNumbers[i] += problemColumn[j].Substring(problemColumn[j].Length - 1, 1);
                    }
                    problemColumn[j] = problemColumn[j].Substring(0, problemColumn[j].Length - 1);
                }
            }
            long result = 0;
            if (problemNumbers[problemNumbers.Length - 1].Contains("+"))
            {
                for (int i = 0; i < problemNumbers.Length - 1; i++)
                {
                    result += long.Parse(problemNumbers[i]);
                }
            }
            else if (problemNumbers[problemNumbers.Length - 1].Contains("*"))
            {
                for (int j = 0; j < problemNumbers.Length - 1; j++)
                {
                    if (j == 0)
                    {
                        result = long.Parse(problemNumbers[j]);
                    }
                    else
                    {
                        result *= long.Parse(problemNumbers[j]);
                    }
                }
            }
            return result;
        }
    }
}
