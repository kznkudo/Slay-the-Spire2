abstract class Enemy
{
    public virtual int MaxHp {get; set;}
    public virtual int CurrentHp {get; set;}
    public virtual  int Block {get; set;}
    public virtual  int IntentName {get; set;}
    public virtual  int IntentValue {get; set;}
    public virtual  EnemyMove? Move{get;set;}
    public virtual  EnemyMove? Move2{get;set;}

    public abstract void Turn();
    public abstract void MakeMove();
    public abstract void Display();
}