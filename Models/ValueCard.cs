namespace SevenWonders.Models;

public class ValueCard : Card
{
    private int _value;

    public int Value
    {
        get => _value;
    }

    public ValueCard(int age, string name, string type, int minimumPlayers, int value) : base(age, name, type, minimumPlayers)
    {
        _value = value;
    }
}