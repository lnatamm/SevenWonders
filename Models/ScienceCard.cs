namespace SevenWonders.Models;

public class ScienceCard
{
    private string _age;
    private string _scienceType;

    public string Age
    {
        get => _age;
    }

    public string ScienceType
    {
        get => _scienceType;
    }

    public ScienceCard(string age, string scienceType)
    {
        _age = age;
        _scienceType = scienceType;
    }
}