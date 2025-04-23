class StateTreasure
    : State
{
    public new string Name{get;set;}
    public StateTreasure(Stack<State> states, Charakter player) 
        : base(states, player)
    {
        Name = "Chest";
    }
    public override void StateGui()
    {
    }
        
     
    public override void Update()
    {
        
    }
}