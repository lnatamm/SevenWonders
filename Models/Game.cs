using SevenWonders.Static;

namespace SevenWonders.Models;

public class Game
{
    private Deck _deckAgeI;
    private Deck _deckAgeII;
    private Deck _deckAgeIII;
    private List<AbstractWonder> _wonders;
    private int _numberOfPlayers;
    private List<Player> _players;
    private int _turn;
    private int _currentAge;
    private bool _GameRunning;

    public Deck DeckAgeI
    {
        get => _deckAgeI;
    }

    public Deck DeckAgeII
    {
        get => _deckAgeII;
    }

    public Deck DeckAgeIII
    {
        get => _deckAgeIII;
    }

    public int NumberOfPlayers
    {
        get => _numberOfPlayers;
    }

    public List<Player> Players
    {
        get => _players;
    }

    public int CurrentAge
    {
        get => _currentAge;
    }

    public int Turn
    {
        get => _turn;
    }

    public bool GameRunning
    {
        get => _GameRunning;
    }

    public Game(List<string> playerNames)
    {
        _deckAgeI = new Deck();
        _deckAgeII = new Deck();
        _deckAgeIII = new Deck();
        _wonders = PreDefs.Wonders;
        _numberOfPlayers = playerNames.Count;
        _turn = 0;
        PrepareGame(playerNames);
    }

    T Draw<T>(IList<T> list)
    {
        T result = list[0];
        list.RemoveAt(0);
        return result;
    }
    
    void AddCardsToDeck(Deck deck, List<Card> cards, int age, int numberOfPlayers)
    {
        foreach (Card card in cards)
        {
            if (card.Age == age && card.MinimumPlayers <= numberOfPlayers)
            {
                deck.Cards.Add(card);
            }
        }
    }
    
    public void DefinePlayers(List<String> playerNames)
    {
        _players = new List<Player>();
        foreach (string name in playerNames)
        {
            _players.Add(new Player(name, Draw(_wonders)));
        }
    }

    public void DistributeCards(List<Player> players, Deck deck)
    {
        int i = 0;
        while (deck.Cards.Count > 0)
        {
            players[i%_numberOfPlayers].AddCard(deck.Draw());
            i++;
        }
    }
    
    public void PrepareGame(List<string> playerNames)
    {
        Shuffler.Shuffle(_deckAgeI);
        Shuffler.Shuffle(_deckAgeII);
        Shuffler.Shuffle(_deckAgeIII);
        Shuffler.Shuffle(_wonders);
        DefinePlayers(playerNames);
        AddCardsToDeck(_deckAgeI, PreDefs.AgeICards, 1, _numberOfPlayers);
        DistributeCards(_players, _deckAgeI);
        _currentAge = 1;
    }

    bool CheckAgeEnd()
    {
        foreach (Player player in _players)
        {
            if (player.Cards.Count > 0)
            {
                return false;
            }
        }
        return true;
    }
    
    public void Start()
    {
        _GameRunning = true;
    }

    public void Stop()
    {
        _GameRunning = false;
    }
    
}