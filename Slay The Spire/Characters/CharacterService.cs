class CharacterService
{
    public static Charakter? player;
    public CharacterService(Charakter charakter)
    {
        player = charakter;
    }

    public static bool HasBlock()
    {
        if(player.Block==0)
            return false;
        return true;
    }
    public static bool HasHp()
    {
        if(player.CurrentHp==0)
            return false;
        return true;
    }
    public static void ChangeHp(int value)
    {
        if(player.Block<-value)
            player.CurrentHp += player.Block + value;
        ChangeBlock(value);
    }
    public static void ChangeBlock(int value)
    {
        player.Block+=value;
    }
    public static void ChangeMana(int manaCost)
    {
        player.Mana += manaCost;
    }
}