abstract class Enemy
{
    private int block;
    private int currentHp;
    public int Mana { get; set; }
    public int MaxHp { get; set; }
    public int CurrentHp
    {
        get => currentHp;
        set => currentHp = Math.Clamp(value, 0, MaxHp);
    }
    public int Block
    {
        get => block;
        set => block = Math.Clamp(value, 0, int.MaxValue);
    }
    public virtual int IntentName { get; set; }
    public virtual int IntentValue { get; set; }
    public virtual EnemyMove? Move { get; set; }
    public virtual EnemyMove? Move2 { get; set; }

    public abstract void Turn();
    public abstract void MakeMove();
    public abstract void Display();
}