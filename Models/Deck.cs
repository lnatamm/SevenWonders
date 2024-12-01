namespace SevenWonders.Models;

public class Deck
{
    private List<Card> _cards;
    
    public List<Card> Cards { get => _cards;}
    public int Size { get => _cards.Count;}

    public Deck()
    {
        _cards = new List<Card>();
    }

    public Card Draw()
    {
        Card card = _cards[_cards.Count - 1];
        _cards.RemoveAt(_cards.Count - 1);
        return card;
    }

    public override string ToString()
    {
        string output = "";
        foreach (Card card in _cards)
        {
            output += card.ToString() + "\n";
        }
        return output;
    }
}