using Day5;

string filePath = "input.txt";
string[] input = File.ReadAllLines(filePath);
int blankLineIndex = Array.IndexOf(input, "");
//Console.WriteLine("Part One: " + PartOne.FreshIngredientSum(input.Take(blankLineIndex).ToArray(), input.Skip(blankLineIndex + 1).ToArray()));
Console.WriteLine("Part Two: " + PartTwo.FindFreshIdSum(input.Take(blankLineIndex).ToArray()));