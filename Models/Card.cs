namespace SevenWonders.Models;

public class Card
{
    private int _age;
    private string _name;
    private string _type;
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

    public int MinimumPlayers
    {
        get => _minimumPlayers;
    }
    
    public Card(int age, string name, string type, int minimumPlayers)
    {
        _age = age;
        _name = name;
        _type = type;
        _minimumPlayers = minimumPlayers;
    }
    
}