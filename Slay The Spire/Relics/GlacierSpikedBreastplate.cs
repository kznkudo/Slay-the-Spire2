class SpikeyGlaciarplate
    : Relic
{
    public string Name { get; set; } = "SpikeyGlaciarplate";

    public void Description()
    {
        Gui.TextColor("\t" + Name + "\n", ConsoleColor.Green);
        System.Console.WriteLine("\tFor each 5 Block gain 1 Thorns\n");
    }
    //public void Effect();
}
