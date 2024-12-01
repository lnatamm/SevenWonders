namespace SevenWonders.Models;

public class ResourceCard : Card
{
    private List<string> _resources;
    
    public List<string> Resources
    {
        get => _resources;
    }
    
    public ResourceCard(int age, string name, string type, int minimumPlayers, List<string> resources) : base(age, name, type, minimumPlayers)
    {
        _resources = resources;
    }

    public override string ToString()
    {
        string output = $"Age: {Age}\nName:{Name}\nType:{Type}\nMinimum Players:{MinimumPlayers}\nResources:\n";
        foreach (string resource in _resources)
        {
            output += $"{resource}\n";
        }
        return output;
    }
}