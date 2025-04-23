using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;    

class Thief
    : Enemy
{
    private int currentHp;
    private int block;
    public override int MaxHp {get; set;}
    public override int CurrentHp
    {
        get => currentHp; 
        set => currentHp = Math.Clamp(value, 0, MaxHp);
    } 
    public override int Block 
    {
        get => block; 
        set => block = Math.Clamp(value, 0, MaxHp);
    }
    public override int IntentName {get; set;}
    public override int IntentValue {get; set;}
    public override EnemyMove? Move{get;set;}
    public override EnemyMove? Move2{get;set;}

    public Thief()
    {
        MaxHp=43;
        CurrentHp=43;
        Block=0;
        ChooseMove();        
    }
    public override void Turn()
    {
        Block=0;
        MakeMove();
        ChooseMove();
    }
    
    public void ChooseMove()
    {
        Move=null;
        Move2=null;
        Random rand = new Random();
        switch(rand.Next(1,4))
        {
            case 1: AssignMoveSet1();  break;
            case 2: AssignMoveSet2();  break;
            case 3: AssignMoveSet3();  break;
            default:                   break;
        }
    }
    public override void MakeMove()
    {
        Move.Effect();
        Move2?.Effect();
    }
    public void AssignMoveSet1()
    {
        //Deal 6 damage
        Move=new EnemyMoveAttack(6);
        Move2=null;
    }
    public void AssignMoveSet2()
    {
        //Deal 6 damage
        Move = new EnemyMoveAttack(6);
        Move2=null;
    }
    public void AssignMoveSet3()
    {
        //Deal 6 damage
        Move = new EnemyMoveAttack(6);
        Move2 = new EnemyMoveBlock(5);
    }
    public override void Display()
    {       
        Gui.EntityHeader(this.GetType().Name, ConsoleColor.White);
        Gui.Hp(CurrentHp, Block, MaxHp);
        System.Console.WriteLine();
        System.Console.Write("\tIntent:");   Move?.Display(); Move2?.Display(); System.Console.WriteLine();
        Gui.EntityHeader("-----", ConsoleColor.White);
        System.Console.WriteLine();
    }   

}