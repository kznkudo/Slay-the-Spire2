using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

abstract class Charakter
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
    public virtual int Gold { get; set; }
    public int Handsize { get; set; }
    public abstract PlayerDeck Deck { get; set; }
    public abstract List<Relic> Relics { get; set; }

    public abstract void Init();
    public abstract void Display();
    public abstract void Describtion();
}