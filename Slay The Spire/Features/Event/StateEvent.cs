class StateEvent
    : State
{
    public StateEvent(Stack<State> states, Charakter player)
        : base(states, player)
    {
        Name = "???";
    }
    public override void StateGui()
    {
    }


    public override void Update()
    {
    }
}