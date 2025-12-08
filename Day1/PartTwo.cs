using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public class PartTwo
    {
        public static int CrackCode(string[] inputs)
        {
            int dial = 50;
            int zeroCount = 0;
            int rotation = 0;
            int normalizedRotation = 0;
            foreach (string input in inputs)
            {
                rotation = int.Parse(input.Substring(1));
                normalizedRotation = rotation % 100;
                zeroCount += rotation / 100;
                if (input[0] == 'L')
                {
                    if (normalizedRotation > dial)
                    {
                        if (dial != 0)
                        {
                            zeroCount++;
                        }
                        dial = 100 - (normalizedRotation - dial);
                    }
                    else
                    {
                        dial = dial - normalizedRotation;
                        if (dial == 0)
                        {
                            zeroCount++;
                        }
                    }
                }
                else
                {
                    zeroCount += (dial + normalizedRotation) / 100;
                    dial = (dial + normalizedRotation) % 100;
                }
            }
            return zeroCount;
        }
    }
}
