class EnemyMoveAttack
    : EnemyMove
{
    public string Name { get; set; }
    public int Value { get; set; }

    public EnemyMoveAttack(int value)
    {
        Name = "attack";
        Value = value;
    }
    public void Effect()
    {
        CharacterService.ChangeHp(-Value);
    }
    public void Display()
    {
        Gui.TextColor("\t" + Value + " dmg", ConsoleColor.Red);
        // Action<string> TextColor=Gui.TextColorRed;
        // Gui.EnemyIntend(TextColor, Move, Value.ToString());
    }
}