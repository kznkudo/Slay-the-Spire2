class EnemyMoveBlock
    : EnemyMove
{
    public string Name{get;set;}="block";
    public int Value{get;set;}
    public EnemyMoveBlock(int value)
    {
        Value=value;
    }
    public void Effect()
    {
        EnemyService.ChangeBlock(Value);
    }
    public void Display()
    {
        Gui.TextColor("\t" + Value + " block", ConsoleColor.Cyan);
    }
}