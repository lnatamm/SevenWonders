namespace SevenWonders.Models;

public class WarCard
{
    private string _age;
    private int _shields;

    public string Age
    {
        get => _age;
    }

    public int Shields
    {
        get => _shields;
    }

    public WarCard(string age, int shields)
    {
        _age = age;
        _shields = shields;
    }
}