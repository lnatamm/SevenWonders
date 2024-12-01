namespace SevenWonders.Models;

public class Card
{
    private int _age;
    private string _name;
    private string _type;
    private List<(string, int)> _cost;
    private int _minimumPlayers;

    public int Age
    {
        get => _age;
    }

    public string Name
    {
        get => _name;
    }
    
    public string Type
    {
        get => _type;
    }

    public List<(string, int)> Cost
    {
        get => _cost;
    }
    
    public int MinimumPlayers
    {
        get => _minimumPlayers;
    }
    
    public Card(int age, string name, string type, List<(string, int)> cost, int minimumPlayers)
    {
        _age = age;
        _name = name;
        _type = type;
        _cost = cost;
        _minimumPlayers = minimumPlayers;
    }
    
}