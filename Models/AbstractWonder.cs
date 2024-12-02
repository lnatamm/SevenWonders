namespace SevenWonders.Models;

public abstract class AbstractWonder
{
    private string _name;
    private int _numberOfStages;
    private List<List<(string, int)>> _stageCosts;

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public int NumberOfStages
    {
        get => _numberOfStages;
        set => _numberOfStages = value;
    }

    public List<List<(string, int)>> StageCosts
    {
        get => _stageCosts;
        set => _stageCosts = value;
    }
    
}