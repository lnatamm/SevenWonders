namespace SevenWonders.Models;

public class Deck
{
    private List<Card> _cards;

    public Deck()
    {
        _cards = new List<Card>();
    }

    public void AddCard(Card card)
    {
        _cards.Add(card);
    }

    public override string ToString()
    {
        string output = "";
        foreach (Card card in _cards)
        {
            output += $"Age: {card.Age}\nName: {card.Name}\nType: {card.Type}\nMinimum of Players: {card.MinimumPlayers}\n\n";
        }
        return output;
    }
}