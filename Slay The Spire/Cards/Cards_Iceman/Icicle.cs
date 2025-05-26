class Icicle
    : Card
{
    private int manaCost = 0;
    public override Type Name { get; set; }
    public int ManaCost
    {
        get
        {
            if (CharacterService.HasBlock())
                return 0;
            return manaCost;
        }
        set => value = manaCost;
    }
    public int Damage { get; set; }

    public Icicle()
    {
        Name = typeof(Icicle);
        Damage = 3;
        ManaCost = 1;
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
        return $" [Deal {Damage} damage. If you have Block, this card costs {ManaCost} mana.]";
    }
}