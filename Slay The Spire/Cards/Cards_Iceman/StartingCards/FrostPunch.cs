class FrostPunch 
    : Card
{
    public override Type Name{get;set;}
    public int ManaCost{get;set;} 
    public int Damage {get;set;}
    public FrostPunch()
    {
        Name=typeof(FrostPunch);
        ManaCost=1;
        Damage=9;
    }
    public override void Play()
    {
        CharacterService.ChangeMana(-ManaCost);
        Effect();
    }
    public override void Effect()
    {
        CharacterService.ChangeHp(Damage);

        if(CharacterService.HasBlock())
            CharacterService.player.Deck.DrawHand(1);
    }
    public override string Description()
    {
        return $" [Deal {Damage} damage. If you have block, draw a card.]";
    }
    // public abstract void Effect();
    
}