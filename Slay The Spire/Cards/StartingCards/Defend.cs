class Defend 
    : Card
{
    protected Type name;
    protected int cost;
    public override Type Name{get=>name;set=>value=name;}
    public int ManaCost{get=>cost;set=>value=cost;}
    public int Block {get;set;}
    public Defend()
    {
        name=typeof(Defend);
        cost=1;
        Block=5;
    }
    public override void Play()
    {
        CharacterService.ChangeMana(-ManaCost);
        Effect();
    }
    public override void Effect()
    {
        CharacterService.ChangeBlock(Block);
    }
    public override string Description()
    {
        return $" [Gain {Block} Block.]";
    }

    // public abstract void Effect();
    // public abstract void Play();
}
