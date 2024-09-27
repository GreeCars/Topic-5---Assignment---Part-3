// See https://aka.ms/new-console-template for more information
// Carsen
Console.WriteLine("Part 3 - Mini Quiz");
Console.WriteLine();

string waterElement, xperia, brandenburg;
int independence;
double score;
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
Console.WriteLine();

Console.WriteLine("What element is combined with hydrogen to make water?");
waterElement = Console.ReadLine();
if (waterElement.ToLower() == "oxygen" || waterElement.ToUpper() == "O2")
{
    Console.WriteLine("That's correct.");
    score += 1;
}
else
    Console.WriteLine("That's not the right element.");
Console.WriteLine();

Console.WriteLine("What company makes the Xperia model of smartphone?");
Console.WriteLine("A. Samsung");
Console.WriteLine("B. Xiaomi");
Console.WriteLine("C. Sony");
Console.WriteLine("D. Vivo");
xperia = Console.ReadLine();
if (xperia.ToLower() == "c" || xperia.ToLower() == "sony")
{
    Console.WriteLine("That's correct.");
    score += 1;
}
else if (xperia.ToLower() == "a" || xperia.ToLower() == "samsung")
{
    Console.WriteLine("Incorrect, they make the Galaxy model.");
}
else if (xperia.ToLower() == "b" || xperia.ToLower() == "xiaomi")
{
    Console.WriteLine("Incorrect, they make the Redmi model.");
}
else if (xperia.ToLower() == "d" || xperia.ToLower() == "vivo")
{
    Console.WriteLine("Incorrect, they name their models after the comany name.");
}
else
    Console.WriteLine("That's an invalid answer.");
Console.WriteLine();

Console.WriteLine("Vienna is home to the Brandenburg Gate. True or False?");
brandenburg = Console.ReadLine();
if (brandenburg.ToLower() == "false" || brandenburg.ToLower() == "f")
{
    Console.WriteLine("That's correct.");
    score += 1;
}
else if (brandenburg.ToLower() == "true" || brandenburg.ToLower() == "t")
    Console.WriteLine("Incorrect, the Brandenbrug Gate is in Berlin.");
else
    Console.WriteLine("That's an invalid answer.");
Console.WriteLine();

Console.WriteLine("You got " + score + " answers correct. That's a score of" + Math.Round(score, 1));
if (score == 0)
    Console.WriteLine("You're not too good at this, are you?");
else if (score == 4)
    Console.WriteLine("Great job!");