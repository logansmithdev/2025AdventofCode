using Day6;

string filePath = "input.txt";
string[] input = File.ReadAllLines(filePath);
string[][] inputMatrix = new string[input.Length][];

for (int i = 0; i < input.Length; i++)
{
    inputMatrix[i] = input[i].Split(" ").Where(inp => inp != "").ToArray();
}
//Console.WriteLine("Part One: " + PartOne.MathProblemSum(inputMatrix));
Console.WriteLine("Part Two: " + PartTwo.MathProblemSum(input));
