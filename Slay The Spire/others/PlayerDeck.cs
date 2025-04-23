using System.ComponentModel.DataAnnotations;

class PlayerDeck
{
    public List<Card> Deck{get;set;}
    public List<Card> Hand{get;set;}
    public List<Card> DiscardPile{get;set;}

    public PlayerDeck()
    {
        Deck = new List<Card>();
        Hand = new List<Card>();
        AddCard<Strike>(4);  
        AddCard<Defend>(5); 
        DiscardPile = new List<Card>();       
    }

    public void AddCard<T>(int copies=1) where T:Card, new()
    {
        for (int i=0;i<copies;i++)
            Deck.Add(new T());
    }
    public void ShuffleDeck()
    {
        Random rand = new Random();
        for(int i=0;i < Deck.Count; i++)
        {
            Card temp = Deck[i];
            int j = rand.Next(0,Deck.Count);
            Deck[i]=Deck[j];
            Deck[j]=temp;
        }
    }
    public void DrawHand(int amount)
    {
        while(Hand.Count<amount)
        {
            if(Deck.Count==0)
            {
                while(DiscardPile.Count>0)
                {
                    Deck.Add(DiscardPile[0]);
                    DiscardPile.Remove(DiscardPile[0]);
                }
                ShuffleDeck();
            }
            Hand.Add(Deck[0]);
            Deck.Remove(Deck[0]);
        }
    }
    public void RemoveHand()
    {
        while(Hand.Count>0)
        {
            DiscardPile.Add(Hand[0]);
            Hand.Remove(Hand[0]);
        }
    }
    public void ShowDeck()
    {
        foreach(Card card in Deck)
            System.Console.WriteLine(card.Name);
    }
    public void ShowHand()
    {
        int i=1;
        foreach(Card card in Hand)
        {
            Gui.CombatOption(i, card.Name.ToString(), Hand[i++-1].Description());
        }
        System.Console.WriteLine();
    }
    public void ShowCardDescription(int index)
    {
        Hand[index].Description();
    }
}