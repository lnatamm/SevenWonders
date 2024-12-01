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
}