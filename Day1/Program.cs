using Day1;

string filePath = "input.txt";
string[] inputs = File.ReadAllLines(filePath);
Console.WriteLine("Part One: " + PartOne.CrackCode(inputs));
Console.WriteLine("Part Two: " + PartTwo.CrackCode(inputs));