namespace SevenWonders.Models;

public class ResourceCard : Card
{
    private List<string> _resources;
    
    public List<string> Resources
    {
        get => _resources;
    }
    
    public ResourceCard(int age, string name, string type, List<(string, int)> cost, int minimumPlayers, List<string> resources) : base(age, name, type, cost, minimumPlayers)
    {
        _resources = resources;
    }

    public override string ToString()
    {
        string output = $"Age: {Age}\nName: {Name}\nType: {Type}\nCost:\n";
        foreach ((string, int) cost in Cost)
        {
            output += $"{cost.Item2} {cost.Item1}(s)\n";
        }
        output += $"Minimum Players: {MinimumPlayers}\nResources:\n";
        foreach (string resource in _resources)
        {
            output += $"{resource}\n";
        }
        return output;
    }
}