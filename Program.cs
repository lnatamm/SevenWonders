using SevenWonders.Models;
using SevenWonders.Static;

List<Card> ageICards = PreDefs.AgeICards;
List <AbstractWonder> wonders = PreDefs.Wonders;

bool ValidateRange(int x, int op)
{
    switch (op)
    {
        case 1:
            return true;
        default: return false;
    }
}

int InputInt(int op)
{
    int value;
    if (!int.TryParse(Console.ReadLine(), out value))
    {
        return InputInt(op);   
    }
    if (!ValidateRange(value, op))
    {
        return InputInt(op);
    }
    return value;
}

string InputString(int op)
{
    string value;
    if (op == 1)
    {
        value = Console.ReadLine();
        return value;
    }
    return "";
}

void Print(Object message)
{
    Console.WriteLine(message);
}

void Clear()
{
    Console.Clear();
}

void PrintMenu()
{
    Console.WriteLine("Hello Welcome to Seven Wonders!");
    Console.WriteLine("1 - Start Game");
    Console.WriteLine("Anything Else - End Game");
}

PrintMenu();
int value = InputInt(1);
if (value == 1)
{
    Clear();
    Print("How many players?");
    int numberOfPlayers = InputInt(1);
    Clear();
    List<string> playerNames = new List<string>();
    for (int i = 0; i < numberOfPlayers; i++)
    {
        Print($"Type the name of the player {i + 1}:");
        string playerName = InputString(1);
        playerNames.Add(playerName);
        Clear();
    }
    Game game = new Game(playerNames);
    game.Start();
    while (game.GameRunning)
    {
        if (game.CurrentAge == 1)
        {
            
        }
        else if (game.CurrentAge == 2)
        {
            
        }
        else if (game.CurrentAge == 3)
        {
            
        }
        game.Stop();
    }
    foreach (Player player in game.Players)
    {
        Print(player);
    }
}

