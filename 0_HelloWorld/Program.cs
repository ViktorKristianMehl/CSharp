//Change appearance of Console
Console.Title = "Matrix";
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WindowHeight = 40;

//Presentation
Console.WriteLine("Did you ever hear the tragedy of darth plagueius the wise?");

string firstanswer = Console.ReadLine();
bool Darth = false;
if (firstanswer == "no")
{
    Darth = true;
}
else
{
    Darth = false;
}
bool cool = false;
if (Darth == true)
{
    Console.WriteLine("I thought not, its not a story the jedi would tell you");
    Thread.Sleep(500);
    Console.WriteLine("Its a Sith legend.");
    Thread.Sleep(500);
    Console.WriteLine("Darth Plagueius was a sith lord so powerful he could save others from dying.");
    Thread.Sleep(500);
    Console.WriteLine("do you want to know more?");
    string secondAnswer = Console.ReadLine();
    if (secondAnswer == "yes")
    {
        cool = true;
    }
}

if (cool == true)
{
    Console.WriteLine("bla bla bla");
    Thread.Sleep(500);
    Console.WriteLine("(after what seems like ages you grow tired of hearing his constant blabbering)");
    Thread.Sleep(500);
    Console.WriteLine("(You decide to threaten him so that he shuts up)");

}
else
{
    Console.WriteLine("f you then");
}
Console.ReadLine();