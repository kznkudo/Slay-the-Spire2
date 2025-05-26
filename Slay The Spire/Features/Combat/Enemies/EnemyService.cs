class EnemyService
{
    private static Enemy? _enemy;
    public EnemyService(Enemy Character)
    {
        _enemy = Character;
    }

    public static void ChangeHp(int _value)
    {
        if (_enemy!.Block < (-_value))
            _enemy.CurrentHp += _enemy.Block + _value;
        ChangeBlock(_value);
    }
    public static void ChangeBlock(int _value)
    {
        _enemy!.Block += _value;
    }
    public static bool HasHp()
    {
        if (_enemy!.CurrentHp == 0)
            return false;
        return true;
    }
}