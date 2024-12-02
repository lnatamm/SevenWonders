namespace SevenWonders.Models;

public class Player
{
    private string _name;
    private int _coins;
    private List<string> _resources;
    private List<int> _sciencePoints; //0: Stone Slab; 1: Freemasonry 2: Bear trap
    private int _shields;
    private int _victoryPoints;
    private AbstractWonder _wonder;
    private List<Card> _cards;

    public string Name
    {
        get => _name;
    }
    public List<string> Resources
    {
        get => _resources;
    }
    public List<int> SciencePoints
    {
        get => _sciencePoints;
    }
    public int Shields
    {
        get => _shields;
    }
    public int VictoryPoints
    {
        get => _victoryPoints;
    }
    public AbstractWonder Wonder
    {
        get => _wonder;
    }
    public List<Card> Cards
    {
        get => _cards;
    }

    public Player(string name, AbstractWonder wonder)
    {
        _name = name;
        _resources = new List<string>();
        _sciencePoints = new List<int>(){0, 0, 0};
        _shields = 0;
        _victoryPoints = 0;
        _wonder = wonder;
        _cards = new List<Card>();
    }

    public override string ToString()
    {
        string output = $"Name: {Name}\nResources:\n";
        foreach (string resource in _resources)
        {
            output += $"{resource}\n";
        }
        output += $"Science Points:\n   -Stone Slab: {SciencePoints[0]}\n   -Freemasonry: {SciencePoints[1]}\n   -Bear Trap: {SciencePoints[2]}\nShields: {Shields}\n" +
                  $"Victory Points: {VictoryPoints}\nWonder: {Wonder.Name}\nCards:\n";
        foreach (Card card in _cards)
        {
            output += $"{card}\n";
        }
        return output;
    }
}