namespace SevenWonders.Models;

public class ManufacturedGoodsCard
{
    private string _age;
    private List<string> _manufacturedGoods;

    public string Age
    {
        get => _age;
    }

    public List<string> ManufacturedGoods
    {
        get => _manufacturedGoods;
    }

    public ManufacturedGoodsCard(string age, List<string> manufacturedGoods)
    {
        _age = age;
        _manufacturedGoods = manufacturedGoods;
    }
}