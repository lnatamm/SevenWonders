namespace SevenWonders.Models;

public static class Shuffler
{
    private static readonly Random Random = new();

    public static void Shuffle(Deck deck)
    {
        int n = deck.Size;
        for (int i = (n - 1); i > 0; i--) 
        {
            int j = Random.Next(0, i+1);
            (deck.Cards[i], deck.Cards[j]) = (deck.Cards[j], deck.Cards[i]);
        }
    }
    
    public static void Shuffle<T>(IList<T> list)
    {
        int n = list.Count;
        for (int i = (n - 1); i > 0; i--) 
        {
            int j = Random.Next(0, i+1);
            (list[i], list[j]) = (list[j], list[i]);
        }
    }
}