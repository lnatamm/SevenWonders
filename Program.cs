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

void AddCardsToDeck(Deck deck, List<Card> cards, int age, int numberOfPlayers)
{
    foreach (Card card in cards)
    {
        if (card.Age == age && card.MinimumPlayers <= numberOfPlayers)
        {
            deck.Cards.Add(card);
        }
    }
}

void Shuffle(Deck deck)
{
    Random random = new Random();
    int n = deck.Size;
    for (int i = (n - 1); i > 0; i--) 
    {
        int j = random.Next(0, i+1);
        (deck.Cards[i], deck.Cards[j]) = (deck.Cards[j], deck.Cards[i]);
    }
}

PrintMenu();
int value = InputInt(1);
if (value == 1)
{
    Clear();
    Deck deckAgeI = new Deck();
    Print("How many players?");
    int numberOfPlayers = InputInt(1);
    Clear();
    AddCardsToDeck(deckAgeI, allCards, 1, numberOfPlayers);
    Shuffle(deckAgeI);
    Print(deckAgeI);
    Print($"Drawed Card:\n{deckAgeI.Draw()}");
}

