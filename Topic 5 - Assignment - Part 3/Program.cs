// See https://aka.ms/new-console-template for more information
// Carsen
Console.WriteLine("Part 3 - Mini Quiz");
Console.WriteLine();

string waterElement;
int score, independence;
score = 0;

Console.WriteLine("How many years has it been since Canada gained independence?");
Int32.TryParse(Console.ReadLine(), out independence);
if (independence == 157)
{
    Console.WriteLine("That's correct.");
    score += 1;
}
else if (independence > 157)
    Console.WriteLine("That's too high.");
else if (independence < 157)
    Console.WriteLine("That's too low.");

Console.WriteLine("What element is combined with hydrogen to make water?");
waterElement = Console.ReadLine();
if (waterElement.ToLower() == "oxygen")
{
    Console.WriteLine("That's correct.");
    score += 1;
}
else
    Console.WriteLine("That's not the right element.");