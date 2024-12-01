namespace SevenWonders.Models;

public class ValueCard : Card
{
    private int _value;

    public int Value
    {
        get => _value;
    }

    public ValueCard(int age, string name, string type, List<(string, int)> cost, int minimumPlayers, int value) : base(age, name, type, cost, minimumPlayers)
    {
        _value = value;
    }

    public override string ToString()
    {
        string output = $"Age: {Age}\nName: {Name}\nType: {Type}\nCost:\n";
        foreach ((string, int) cost in Cost)
        {
            output += $"{cost.Item2} {cost.Item1}(s)\n";
        }
        output += $"Minimum players: {MinimumPlayers}\nValue: {Value}\n";
        return output;
    }
}