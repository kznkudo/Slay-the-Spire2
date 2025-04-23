class EnemyService
{
    private static Enemy? enemy;
    public EnemyService(Enemy Character)
    {
        enemy = Character;
    }

    public static void ChangeHp(int value)
    {
        if(enemy!.Block<(-value))
            enemy.CurrentHp += enemy.Block + value;
        ChangeBlock(value);
    }
    public static void ChangeBlock(int value)
    {
        enemy!.Block+=value;
    }
    public static bool HasHp()
    {
        if(enemy!.CurrentHp==0)
            return false;
        return true;
    }    
}