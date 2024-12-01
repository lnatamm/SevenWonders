namespace SevenWonders.Models;

public class Player
{
    private string _name;
    private int _coins;
    private List<string> _resources;
    private List<int> _sciencePoints; //0: Stone Slab; 1: Freemasonry 2: Bear trap
    private int _shields;
    private int _victoryPoints;
    private string _wonder; //To be replaced with class "Wonder"
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
    public string Wonder
    {
        get => _wonder;
    }
    public List<Card> Cards
    {
        get => _cards;
    }

    public Player(string name, string wonder)
    {
        _name = name;
        _resources = new List<string>();
        _sciencePoints = new List<int>();
        _shields = 0;
        _victoryPoints = 0;
        _wonder = wonder;
        _cards = new List<Card>();
    }
    
}