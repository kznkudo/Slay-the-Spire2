class StateRest
    : State
{
    public new string Name{get;set;}
    public StateRest(Stack<State> states, Charakter player) 
        : base(states, player)
    {
        Name = "Rest Site";
    }
    public override void StateGui()
    {
    }
        
     
    public override void Update()
    {
    }
}