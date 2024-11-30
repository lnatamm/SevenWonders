namespace SevenWonders.Models;

public class RawMaterialsCard
{
    private string _age;
    private List<string> _rawMaterials;

    public string Age
    {
        get => _age;
    }

    public List<string> RawMaterials
    {
        get => _rawMaterials;
    }

    public RawMaterialsCard(string age, List<string> rawMaterials)
    {
        _age = age;
        _rawMaterials = rawMaterials;
    }
}