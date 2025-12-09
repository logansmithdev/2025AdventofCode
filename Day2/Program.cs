using Day2;

string filePath = "input.txt";
string inputText = File.ReadAllText(filePath);

string[] inputs = inputText.Split(',');

//Console.WriteLine(PartOne.invalidRecordCount(inputs));

Console.WriteLine(PartTwo.invalidRecordCount(inputs));

