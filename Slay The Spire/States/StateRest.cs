class StateRest
    : State
{
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