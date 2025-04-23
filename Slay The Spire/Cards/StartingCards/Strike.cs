class Strike 
    : Card
{
    protected Type name;
    protected int cost;
    public override Type Name{get=>name;set=>value=name;}
    public int ManaCost{get=>cost;set=>value=cost;}
    public int Damage{get;set;}
    public Strike()
    {
        name=typeof(Strike);
        cost=1;
        Damage=6;
    }
    public override void Play()
    {
        CharacterService.ChangeMana(-ManaCost);
        Effect();
    }
    public override void Effect()
    {
        EnemyService.ChangeHp(-Damage);
    }
    public override string Description()
    {
        return $" [Deal {Damage} damage.]";
    }
    // public abstract void Effect();
    // public abstract void Play();
}
