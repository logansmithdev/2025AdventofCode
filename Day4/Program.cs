using Day4;

string filePath = "input.txt";
string[] input = File.ReadAllLines(filePath);

//Console.WriteLine("Part One: " + PartOne.FindAccessibleRollsSum(input));
Console.WriteLine("Part Two: " + PartTwo.FindAccessibleRollsSums(input));
