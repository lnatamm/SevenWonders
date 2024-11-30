namespace SevenWonders.Models;

public class VictoryPointsCard
{
    private string _age;
    private int _victoryPoints;

    public string Age
    {
        get => _age;
    }

    public int VictoryPoints
    {
        get => _victoryPoints;
    }

    public VictoryPointsCard(string age, int victoryPoints)
    {
        _age = age;
        _victoryPoints = victoryPoints;
    }
}