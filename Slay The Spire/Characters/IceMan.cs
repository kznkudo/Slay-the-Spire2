class IceMan
    : Charakter
{
    public override PlayerDeck Deck { get; set; }
    public override List<Relic> Relics { get; set; }
    public IceMan()
    {
        MaxHp = 78;
        CurrentHp = 78;
        Mana = 3;
        Block = 0;
        Gold = 99;
        Handsize = 5;
        Deck = new PlayerDeck();
        Deck.AddCard<FrostPunch>();
        Relics = new List<Relic>();
        AddCharacterRelic();
    }
    public override void Init()
    {
        Mana = 3;
        Block = 0;
    }

    public void AddCharacterRelic()
    {
        Relics.Add(new SpikeyGlaciarplate());
    }
    public override void Display()
    {
        Gui.EntityHeader(this.GetType().Name, ConsoleColor.Blue);

        Gui.Hp(CurrentHp, Block, MaxHp);

        System.Console.Write($"\tMana: ");
        Gui.TextColor(Mana.ToString(), ConsoleColor.Cyan);

        System.Console.WriteLine();

        Gui.EntityHeader("------", ConsoleColor.White);

        System.Console.WriteLine();
    }
    public override void Describtion()
    {
        Gui.Header(this.GetType().Name, ConsoleColor.Blue);
        System.Console.WriteLine("A Warrior from Skaldfrost, a village on top of the spire. To save his family he had to leave the village, but is eager to return."
                                + "\n"
                                + "He uses hard ice for defense and counterattacks.\n");
        Gui.TextColor($"Hp: {CurrentHp}/{MaxHp}", ConsoleColor.Green); Gui.TextColor($"\tGold: {Gold}\n\n", ConsoleColor.Yellow);
        System.Console.Write("Relic: "); Relics[0].Description();
    }
}