class StateTreasure
    : State
{
    public StateTreasure(Stack<State> states, Charakter player) 
        : base(states, player)
    {
        Name = "Chest  Room";
    }
    public override void StateGui()
    {
    }
        
     
    public override void Update()
    {
        
    }
}