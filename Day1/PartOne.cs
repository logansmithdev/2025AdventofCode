using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public class PartOne
    {
        public static int CrackCode(string[] inputs)
        {
            int dial = 50;
            int zeroCount = 0;
            int rotation = 0;
            foreach (string input in inputs)
            {
                if (dial == 0)
                {
                    zeroCount++;
                }
                rotation = int.Parse(input.Substring(1)) % 100;
                if (input[0] == 'L')
                {
                    if (rotation > dial)
                    {
                        dial = 100 - (rotation - dial);
                    }
                    else
                    {
                        dial = dial - rotation;
                    }
                }
                else
                {
                    dial = (dial + rotation) % 100;
                }
            }
            return zeroCount;
        }
    }
}
