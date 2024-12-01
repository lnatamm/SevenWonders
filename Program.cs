using SevenWonders.Models;

List<Card> allCards = new List<Card>()
{
    new ResourceCard(age:1, name:"Lumber Yard", type:"Raw Material", minimumPlayers:3, resources:new List<string>(){"Wood"}),
    new ResourceCard(age:1, name:"Lumber Yard", type:"Raw Material", minimumPlayers:4, resources:new List<string>(){"Wood"}),
    new ResourceCard(age:1, name:"Stone Pit", type:"Raw Material", minimumPlayers:3, resources:new List<string>(){"Stone"}),
    new ResourceCard(age:1, name:"Stone Pit", type:"Raw Material", minimumPlayers:5 , resources:new List<string>(){"Stone"}),
    new ResourceCard(age:1, name:"Clay Pool", type:"Raw Material", minimumPlayers:3 , resources:new List<string>(){"Clay"}),
    new ResourceCard(age:1, name:"Clay Pool", type:"Raw Material", minimumPlayers:5 , resources:new List<string>(){"Clay"}),
    new ResourceCard(age:1, name:"Ore Vein", type:"Raw Material", minimumPlayers:3 , resources:new List<string>(){"Ore"}),
    new ResourceCard(age:1, name:"Ore Vein", type:"Raw Material", minimumPlayers:4 , resources:new List<string>(){"Ore"}),
    new ResourceCard(age:1, name:"Tree Farm", type:"Raw Material", minimumPlayers:6 , resources:new List<string>(){"Wood", "Clay"}),
    new ResourceCard(age:1, name:"Excavation", type:"Raw Material", minimumPlayers:4 , resources:new List<string>(){"Stone", "Clay"}),
    new ResourceCard(age:1, name:"Clay Pit", type:"Raw Material", minimumPlayers:3 , resources:new List<string>(){"Clay", "Ore"}),
};

void addCardsToDeck(Deck deck, List<Card> cards, int numberOfPlayers)
{
    foreach (Card card in cards)
    {
        if (card.MinimumPlayers <= numberOfPlayers)
        {
            deck.AddCard(card);
        }
    }
}

bool validateRange(int x, int op)
{
    switch (op)
    {
        case 1:
            return true;
        default: return false;
    }
}

int inputInt(int op)
{
    int value;
    if (!int.TryParse(Console.ReadLine(), out value))
    {
        return inputInt(op);   
    }
    if (!validateRange(value, op))
    {
        return inputInt(op);
    }
    return value;
}

void print(Object message)
{
    Console.WriteLine(message);
}

void printMenu()
{
    Console.WriteLine("Hello Welcome to Seven Wonders!");
    Console.WriteLine("1 - Start Game");
    Console.WriteLine("Anything Else - End Game");
}

printMenu();
int value = inputInt(1);
if (value == 1)
{
    Deck deck = new Deck();
    print("How many players?");
    int numberOfPlayers = inputInt(1);
    addCardsToDeck(deck, allCards, numberOfPlayers);
    print(deck);
}

