class StateBoss
    : State
{
    public override string Name => "Boss";
    public StateBoss(Stack<State> states, Charakter player) 
        : base(states, player)
    {
        
    }
    public override void StateGui()
    {
    }
        
     
    public override void Update()
    {
    }
}