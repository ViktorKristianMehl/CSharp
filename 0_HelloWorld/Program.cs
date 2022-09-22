
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


List<string> attacks = new List<string>();

Console.WriteLine("Write 5 ways to threaten him");
for (int i = 0; i < 5; i++)
{
    attacks.Add(Console.ReadLine());
}

Random attack = new Random();
int randomAttack = attack.Next(0, 4);
Console.WriteLine(attacks[randomAttack]);
Thread.Sleep(500);
switch (randomAttack)
{

    case 0:
        Console.WriteLine("you threaten him with your " + attacks[0] + " and looks he confused");
        break;

    case 1:
        Console.WriteLine("you threaten him with your " + attacks[1] + " and he laughs");
        break;

    case 2:
        Console.WriteLine("you threaten him with your " + attacks[2] + " and you see him getting nervous and he leaves");
        break;
    case 3:
        Console.WriteLine("you threaten him with your " + attacks[3] + " and he flees the scene");
        break;
    case 4:
        Console.WriteLine("you threaten him with your " + attacks[4] + " and he ignores you");
        break;
}
Thread.Sleep(500);
if (randomAttack == 0 || randomAttack == 1 || randomAttack == 4)
{

    Console.WriteLine("you fail to make him go away. You will have to listen to his talking for eternity");
}
else
{
    Console.WriteLine("he flees the scene, now you are free");
};

bool loss = false;
if (randomAttack == 0 || randomAttack == 1 || randomAttack == 4)
{
    loss = true;
}
Thread.Sleep(500);
bool battle = false;

if (loss == true)
{
    Console.WriteLine("threatening him didn't work. You will have to fight him");
    string[] weapons = {
    "Gun",
    "Sword",
    "Frying Pan",
    "Fists",
    "Bow"
    };
    Thread.Sleep(300);

    Console.WriteLine("Which the following weapons do you choose for the battle?");

    foreach (string item in weapons)
    {
        Console.WriteLine(item);
    }
    string weaponChoice = Console.ReadLine();
    if (weaponChoice == "Gun" || weaponChoice == "gun")
    {
        battle = true;
    }
    else
    {
        battle = false;
    }
    string diceAnswer;
    if (battle == true)
    {
        Console.WriteLine("He runs towards you with his lightsaber but you quickly pull out your gun and shoot him in the head. You win");
    }
    else if (battle == false)
    {
        Console.WriteLine("Your weapon has no effect on him as he dodges every try to him him");
        Thread.Sleep(300);
        Console.WriteLine("He moves towards out and cuts of your hand in one swing");
        Thread.Sleep(300);
        Console.WriteLine("you beg for mercy /n him: if you roll a 6 with this dice, i will let you live");
        Thread.Sleep(500);
        Console.WriteLine("Do you accept this challenge?");
    }
    diceAnswer = Console.ReadLine();
    Random diceroll = new Random();
    Thread.Sleep(500);
    while (diceAnswer == "yes")
    {
        Console.WriteLine("you roll the dice");
        int yourRoll = diceroll.Next(1, 6);
        Console.WriteLine("you roll a " + yourRoll);
        if (yourRoll == 6)
        {
            Console.WriteLine("You have been spared");
            break;
        }
        else
        {
            Console.WriteLine("You lose and he kills you");
            break;
        }
    }
}
Console.ReadLine();


