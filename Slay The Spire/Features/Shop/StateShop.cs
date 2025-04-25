class StateShop
    : State
{
    public StateShop(Stack<State> states, Charakter player) 
        : base(states, player)
    {
        Name = "Shop";
    }
    public override void StateGui()
    {
    }
        
     
    public override void Update()
    {
    }
}