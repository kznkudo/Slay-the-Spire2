class StateBoss
    : State
{
    public StateBoss(Stack<State> states, Charakter player)
        : base(states, player)
    {
        Name = "Boss";
    }
    public override void StateGui()
    {
    }


    public override void Update()
    {
    }
}